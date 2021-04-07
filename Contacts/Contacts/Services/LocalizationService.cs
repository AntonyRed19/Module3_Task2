using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Services.Abstractions;
using Contacts.Configs;

namespace Contacts.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly IConfigService _configService;

        public LocalizationService(IConfigService configService)
        {
            _configService = configService;
        }

        public string GetAlphabetForCurrentCulture()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            return GetAlhpabetByCulture(culture);
        }

        public string GetAlhpabetByCulture(string cultureName)
        {
            var lang = _configService.LangConfig;
            return lang.Alphabet.ContainsKey(cultureName) ? lang.Alphabet[cultureName] : lang.Alphabet[lang.DefaultCulture];
        }
    }
}
