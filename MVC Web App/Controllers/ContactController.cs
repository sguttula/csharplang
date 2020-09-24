using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using static Lab5.Views.Contact.ContactService;
using Lab5.Models;

namespace Lab5.Controllers
{
    public class ContactController : Controller
    {
        
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public IActionResult List()
        {
            var contact = contactService.GetContacts();
            return View(contact);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }        
        [HttpPost]
        public IActionResult Add(Contacts contact)
        {
            contact.ContactName = contact.ContactName;
            contact.ContactPhoneNumber = contact.ContactPhoneNumber;
            contactService.AddContact(contact);
            return RedirectToAction(nameof(List));
        }       
    }
}
