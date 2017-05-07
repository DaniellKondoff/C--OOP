using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Demo
{
    public class FileProvider : IFileProvider
    {
        public string ReadAll(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WiteAll(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
