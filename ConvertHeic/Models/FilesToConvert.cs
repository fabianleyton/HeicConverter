using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConvertHeic.Models
{
    public class FilesToConvert
    {
        public int Id { get; set; }
        public string FileName => Path.GetFileName(this.FileNameAndPath);
        public string FileNameAndPath { get; set; }
        public string PathFile => Path.GetDirectoryName(FileNameAndPath);
        public string FileNameDestination { get; set; }
        public FilesToConvertStatus Processed { get; set; }
    }

    public enum FilesToConvertStatus
    {
        Success, Failure, Pending
    }
}
