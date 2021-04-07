using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Abstractions
{
    public interface IFileService
    {
        string ReadAllText(string path);
    }
}
