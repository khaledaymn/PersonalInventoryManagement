using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PersonalInventoryManagement.BL.Helper
{
    public class FileManager
    {
        public string SaveImage(string selectedFilePath, string saveDirectory)
        {
            try
            {
                if (!Directory.Exists(saveDirectory))
                    Directory.CreateDirectory(saveDirectory);

                string fileName = Path.GetFileName(selectedFilePath);
                string uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
                string targetFilePath = Path.Combine(saveDirectory, uniqueFileName);

                File.Copy(selectedFilePath, targetFilePath, true);

                return targetFilePath;
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving image: " + ex.Message);
            }
        }

        public bool DeleteImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting image: " + ex.Message);
            }
        }
    }
}
