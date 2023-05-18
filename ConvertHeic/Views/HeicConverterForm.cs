using ConvertHeic.Helpers;
using ConvertHeic.Impl;
using ConvertHeic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertHeic.Views
{
    public partial class HeicConverter : Form
    {
        private List<FilesToConvert> _filesToConvert = new List<FilesToConvert>();
        public HeicConverter()
        {
            InitializeComponent();
        }


        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            if (openHeicFileDialog.ShowDialog() == DialogResult.OK){
                try
                {
                    var heicConverter = new Impl.HeicConverter();
                    var filesToConvert = openHeicFileDialog.FileNames.ToList();
                    _filesToConvert = GetFilesToConvert(filesToConvert);
                    PopulateDataListView();
                    convertProgressBar.Value = 0; 
                    convertProgressBar.Maximum = _filesToConvert.Count;
                }
                catch ( Exception ex)
                {

                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(_filesToConvert.Any())
            {
                convertProgressBar.Minimum= 0;
                convertProgressBar.Maximum = _filesToConvert.Count;
                convertProgressBar.Value = 0;
                var heicConverter = new Impl.HeicConverter();
                var count = 0;
                var destinationFormat = !string.IsNullOrEmpty(cbDestinationFormat.Text) ? cbDestinationFormat.Text : "jpg";
                foreach (var file in _filesToConvert)
                {
                    var result = heicConverter.Convert(destinationFormat, file.FileNameAndPath);
                    if (result)
                    {
                        file.Processed = FilesToConvertStatus.Success;
                    }else
                    {
                        file.Processed = FilesToConvertStatus.Failure;
                    }
                    convertProgressBar.Value = ++count;
                    PopulateDataListView();
                }
                //heicConverter.Convert("png", _filesToConvert.ToList());
            }
        }

        private List<FilesToConvert> GetFilesToConvert(List<string> items)
        {
            var result = new List<FilesToConvert>();
            if (items.Any())
            {
                var count = 0;
                foreach(var file in items)
                {
                    result.Add(new FilesToConvert()
                    {
                        Id = ++count,
                        FileNameAndPath= file,
                        FileNameDestination = FileHelper.GetOutputFileName(Path.GetFileName(file), "png"),
                        Processed = FilesToConvertStatus.Pending
                    });
                }
            }
            return result;
        }

        private void PopulateDataListView()
        {
            listViewFilesToConvert.Items.Clear();
            listViewFilesToConvert.Columns.Clear();
            listViewFilesToConvert.Columns.Add("FileName", 200);
            listViewFilesToConvert.Columns.Add("Destination", 300);
            listViewFilesToConvert.Columns.Add("Status", 100);

            if (_filesToConvert.Any())
            {
                var conta = 0;
                foreach (var file in _filesToConvert)
                {
                    ListViewItem item = new ListViewItem(file.FileName);
                    item.SubItems.Add(file.FileNameDestination);
                    item.SubItems.Add(file.Processed.ToString());
                    listViewFilesToConvert.Items.Add(item);
                }
            }
        }
    }
}
