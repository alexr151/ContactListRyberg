using ContactListRyberg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListRyberg.Controllers
{
    public class HomeController : Controller
    {
       
        private ContactContext context { get; set; }
        
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }

    }
}
