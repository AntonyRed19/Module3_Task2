using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Services.Abstractions;

namespace Contacts.Services
{
    public static class LocatorService
    {
        public static IConfigService ConfigService => new ConfigService(new FileService());
        public static ILocalizationService LocalizationService => new LocalizationService(ConfigService);
        public static Action Actions => new Action(LocalizationService);
    }
}
