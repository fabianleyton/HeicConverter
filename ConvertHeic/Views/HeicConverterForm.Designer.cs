namespace ConvertHeic.Views
{
    partial class HeicConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.convertProgressBar = new System.Windows.Forms.ProgressBar();
            this.cbDestinationFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openHeicFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.destinationfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewFilesToConvert = new System.Windows.Forms.ListView();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(747, 513);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 46);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // convertProgressBar
            // 
            this.convertProgressBar.BackColor = System.Drawing.Color.DarkGray;
            this.convertProgressBar.Location = new System.Drawing.Point(38, 462);
            this.convertProgressBar.Name = "convertProgressBar";
            this.convertProgressBar.Size = new System.Drawing.Size(859, 24);
            this.convertProgressBar.TabIndex = 1;
            // 
            // cbDestinationFormat
            // 
            this.cbDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationFormat.FormattingEnabled = true;
            this.cbDestinationFormat.Items.AddRange(new object[] {
            "Png",
            "Jpg"});
            this.cbDestinationFormat.Location = new System.Drawing.Point(390, 93);
            this.cbDestinationFormat.Name = "cbDestinationFormat";
            this.cbDestinationFormat.Size = new System.Drawing.Size(242, 40);
            this.cbDestinationFormat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chose the destination format";
            // 
            // openHeicFileDialog
            // 
            this.openHeicFileDialog.Filter = "\"HEIC|*.heic|All files|*.*\"";
            this.openHeicFileDialog.Multiselect = true;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(38, 34);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(150, 46);
            this.btnSelectFiles.TabIndex = 4;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // listViewFilesToConvert
            // 
            this.listViewFilesToConvert.BackColor = System.Drawing.Color.White;
            this.listViewFilesToConvert.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewFilesToConvert.GridLines = true;
            this.listViewFilesToConvert.Location = new System.Drawing.Point(38, 158);
            this.listViewFilesToConvert.Name = "listViewFilesToConvert";
            this.listViewFilesToConvert.Size = new System.Drawing.Size(859, 290);
            this.listViewFilesToConvert.TabIndex = 5;
            this.listViewFilesToConvert.UseCompatibleStateImageBehavior = false;
            this.listViewFilesToConvert.View = System.Windows.Forms.View.Details;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(12, 562);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(108, 30);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "V. 1.0 (FL)";
            // 
            // HeicConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(930, 603);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.listViewFilesToConvert);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDestinationFormat);
            this.Controls.Add(this.convertProgressBar);
            this.Controls.Add(this.btnConvert);
            this.Name = "HeicConverter";
            this.Text = "HeicConverter FL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConvert;
        private ProgressBar convertProgressBar;
        private ComboBox cbDestinationFormat;
        private Label label1;
        private OpenFileDialog openHeicFileDialog;
        private Button btnSelectFiles;
        private FolderBrowserDialog destinationfolderBrowserDialog;
        private ListView listViewFilesToConvert;
        private Label lblVersion;
    }
}