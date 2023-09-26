using System;
using System.IO;
namespace testeUnitario
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if(string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return FileExists(fileName);
        }
    }
}
