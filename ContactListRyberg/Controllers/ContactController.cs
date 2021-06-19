using ContactListRyberg.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListRyberg.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var Contact = context.Contacts.Find(id);
            return View(Contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact Contact)
        {
            if (ModelState.IsValid)
            {
                if (Contact.ContactId == 0)
                    context.Contacts.Add(Contact);
                else
                {
                    context.Contacts.Update(Contact);

                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.Action = (Contact.ContactId == 0) ? "Add" : "Edit";
                return View(Contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Contact = context.Contacts.Find(id);
            return View(Contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact Contact)
        {
            context.Contacts.Remove(Contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}