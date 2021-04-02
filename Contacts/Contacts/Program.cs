using System;
using System.Collections.Generic;
using System.Linq;
using Contacts.Models;

namespace Contacts
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var dictionary = new Dictionary<string, Contact>();
           dictionary.Add("d", new Contact() { FullName = "ddf", PhoneNumber = 2434545 });
           dictionary.Add("a", new Contact() { FullName = "adsds", PhoneNumber = 243325 });
           dictionary.Add("b", new Contact() { FullName = "bddssds", PhoneNumber = 2433224 });
           dictionary.Add("c", new Contact() { FullName = "cccwcwwfdfdfdf", PhoneNumber = 2322343 });
           var list = dictionary.Keys.ToList();
           list.Sort();
           foreach (var key in list)
            {
                var keys = dictionary[key];
                Console.WriteLine(keys);
            }
        }
    }
}
