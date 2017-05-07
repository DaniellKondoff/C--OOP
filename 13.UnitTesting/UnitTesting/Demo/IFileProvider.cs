using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface IFileProvider
    {
        string ReadAll(string filePath);

        void WiteAll(string filePath, string content);
    }
}
