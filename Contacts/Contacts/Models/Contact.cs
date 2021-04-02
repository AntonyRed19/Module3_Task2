using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => Name + Surname;
        public int PhoneNumber { get; set; }
        public string GroupBy => FullName;
    }
}
