using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using PhoneContacts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Controllers
{   
    [Area("Admin")]
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(contacts);
        }

        public IActionResult DefaultRouting()
        {
            return Content("Dummy page with DEFAULT ROUTING from Chapter 6.");
        }

        public IActionResult CustomRouting()
        {
            return Content("Dummy page with CUSTOM ROUTING from Chapter 6.");
        }

        [Route("CustomAttributeRouting")]
        public IActionResult CustomAttributeRouting()
        {
            return Content("Dummy page with CUSTOM ATTRIBUTE ROUTING from Chapter 6.");
        }

    }
}
