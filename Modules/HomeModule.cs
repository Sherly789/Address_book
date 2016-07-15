using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_contact.cshtml"];
      Get["/view_all_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml", allContacts];
      };


      Post["/contact_added"]  = _ => {
        Contact newContact = new Contact (
          Request.Form["new-name"],
          Request.Form["new-number"]
        );
        // newContact.Save();
        return View["contact_added.cshtml", newContact];
      };


    }
  }
}
