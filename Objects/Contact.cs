using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private int _number;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string contactName, int contactNumber)
    {
      _name = contactName;
      _number = contactNumber;
      _instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetNumber()
    {
      return _number;
    }

    public void SetNumber(int newNumber)
    {
      _number = newNumber;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    // public void Save()
    // {
    //   _instances.Add(this);
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }


  }
}
