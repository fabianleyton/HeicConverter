using ConvertHeic.Helpers;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHeic.Impl
{
    public class HeicConverter
    {
        public bool Convert(string type, string pathFile, string? destinationDirectory = null)
        {
            var result = true;
            try
            {
                using (MagickImage image = new MagickImage(pathFile))
                {
                    if (type.Equals("jpg"))
                        image.Format = MagickFormat.Jpg;
                    if (type.Equals("png"))
                        image.Format = MagickFormat.Png;
                    var outputFile = FileHelper.GetOutputFileName(pathFile, type, destinationDirectory);
                    image.Write(outputFile);
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine($"Error converting file '{pathFile}': {ex.Message}");
            }
            return result;
        }

        

       
    }
}
