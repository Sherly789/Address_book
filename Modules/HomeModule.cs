using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_new_contact.cshtml"];
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
