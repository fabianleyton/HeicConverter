using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHeic.Helpers
{
    public static class FileHelper
    {
        public static string GetOutputFileName(string originalFileName, string extension, string? destination = null)
        {
            string directory = destination ?? Path.GetDirectoryName(originalFileName);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);
            return Path.Combine(directory, $"{fileNameWithoutExtension}.{extension}");
        }
    }
}
