using System;

namespace AddressBook
{
  public class Contact
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
      return $"Name: {Name}, Lastname: {LastName}, Phone: {Phone}, Email: {Email}.";
    }
  }
}
