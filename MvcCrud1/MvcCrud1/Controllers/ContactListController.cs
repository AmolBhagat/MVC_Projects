using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud1.Models;

namespace MvcCrud1.Controllers
{
    public class ContactListController : Controller
    {
        
        public ActionResult Index()
        {
            ContactListEntities1 context = new ContactListEntities1();

            return View(context.Contacts.ToList());
        }

        public ActionResult Details(int id)
        {
            ContactListEntities1 context = new ContactListEntities1();

            return View(context.Contacts.Where(x=>x.ContactID==id).FirstOrDefault());

        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            ContactListEntities1 context = new ContactListEntities1();
            if (contact.ContactName==null)
            {
                ModelState.AddModelError("ContactName", "Enter ContactName");
            }
            if (contact.PhoneNumber1 == null)
            {
                ModelState.AddModelError("PhoneNumber1", "Enter valid PhoneNumber");
            }
            if (contact.Address1 == null)
            {
                ModelState.AddModelError("Address1", "Enter Address");
            }
            if (contact.Birthdate == null)
            {
                ModelState.AddModelError("Birthdate", "Enter Birthdate");
            }
            if (contact.EmailID == null)
            {
                ModelState.AddModelError("EmailID", "Enter EmailID");
            }


            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            { 
                return View(context.Contacts.Add(contact));    
            }
           
                           
        }

        public ActionResult Edit(int id)
        {
            ContactListEntities1 context = new ContactListEntities1();

            return View(context.Contacts.Where(x=>x.ContactID==id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id,Contact contact)
        {
            ContactListEntities1 context = new ContactListEntities1();
            if (contact.ContactName == null)
            {
                ModelState.AddModelError("ContactName", "Enter ContactName");
            }
            if (contact.PhoneNumber1 == null)
            {
                ModelState.AddModelError("PhoneNumber1", "Enter valid PhoneNumber");
            }
            if (contact.Address1 == null)
            {
                ModelState.AddModelError("Address1", "Enter Address");
            }
            if (contact.Birthdate == null)
            {
                ModelState.AddModelError("Birthdate", "Enter Birthdate");
            }
            if (contact.EmailID == null)
            {
                ModelState.AddModelError("EmailID", "Enter EmailID");
            }
            if(ModelState.IsValid)
            {
                
                context.Entry(contact).State = System.Data.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           else
            {
                return View("Edit");
            }
        }

        public ActionResult Delete(int id)
        {
            ContactListEntities1 context = new ContactListEntities1();
            return View(context.Contacts.Where(x=>x.ContactID==id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id,Contact contact)
        {
            try
            {
                ContactListEntities1 context = new ContactListEntities1();
                contact = context.Contacts.Where(x => x.ContactID == id).FirstOrDefault();
                context.Contacts.Remove(contact);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           

        }
    }
}