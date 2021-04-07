using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Configs;

namespace Contacts.Services.Abstractions
{
    public interface IConfigService
    {
        LangConfig LangConfig { get; }
    }
}
