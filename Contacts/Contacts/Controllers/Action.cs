using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Helpers;
using Contacts.Models;
using Contacts.Services.Abstractions;

namespace Contacts.Controllers
{
    public class Action
    {
        private readonly ILocalizationService _localizationService;

        public Action(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        public void ActionWork()
        {
            var alphabet = _localizationService.GetAlphabetForCurrentCulture();

            var willBeRemove1 = new Contact() { Name = "Dfg" };
            var willBeRemove2 = new Contact() { Name = "46fg" };

            var groupedList = new GroupByList<Contact>(alphabet)
            {
                new Contact() { Name = "acg" },
                new Contact() { Name = "36fg" },
                willBeRemove1,
                willBeRemove2,
                new Contact() { Name = "afg" },
                new Contact() { Name = "гоу" },
                new Contact() { Name = "авгоу" },
                new Contact() { Name = "tfy" },
                new Contact() { Name = "_tfy" },
                new Contact() { Name = "_afy" },
                new Contact() { Name = "abg" },
            };

            Console.WriteLine("--------------En----------------");

            foreach (var items in groupedList)
            {
                foreach (var item in items.Value)
                {
                    Console.WriteLine($"Key = {items.Key} Value = {item.FullName}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("--------------RU----------------");

            var lang = _localizationService.GetAlhpabetByCulture("ru_RU");
            groupedList.ChangeAlhabet(lang);

            foreach (var items in groupedList)
            {
                foreach (var item in items.Value)
                {
                    Console.WriteLine($"Key = {items.Key} Value = {item.FullName}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("--------------After remove----------------");

            groupedList.Remove(willBeRemove1);
            groupedList.Remove(willBeRemove2);

            foreach (var items in groupedList)
            {
                foreach (var item in items.Value)
                {
                    Console.WriteLine($"Key = {items.Key} Value = {item.FullName}");
                }

                Console.WriteLine();
            }
        }
    }
}
