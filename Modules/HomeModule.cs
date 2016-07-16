using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/add_new_contact"] = _ => View["add_new_contact.cshtml"];

      Get["/view_all_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml", allContacts];
      };

      Post["/contact_added"]  = _ => {
        Contact newContact = new Contact (
          Request.Form["new-name"],
          Request.Form["new-number"],
          Request.Form["new-address"]
        );
        return View["contact_added.cshtml", newContact];
      };

      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
