using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Configs;
using Contacts.Services.Abstractions;
using Newtonsoft.Json;

namespace Contacts.Services
{
    public class ConfigService : IConfigService
    {
        private readonly string _filePath = "config.json";
        private readonly IFileService _fileService;
        private readonly LangConfig _langConfig;
        private FileService _fileServices;

        public ConfigService(IFileService fileService)
        {
            _fileService = fileService;

            var config = GetConfig();
            _langConfig = config.Lang;
        }

        public ConfigService(FileService fileService)
        {
            _fileServices = fileService;
        }

        public LangConfig LangConfig => _langConfig;

        private Configs.Config GetConfig()
        {
            var json = _fileService.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Configs.Config>(json);
        }
    }
}
