using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Services;

namespace Contacts
{
    public class Starter
    {
        public void Run()
        {
            var controller = LocatorService.Actions;
            controller.ActionWork();
        }
    }
}
