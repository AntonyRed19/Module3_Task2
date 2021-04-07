using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services
{
    public class FileService
    {
        public string ReadAllText(string path) => File.ReadAllText(path);
    }
}
