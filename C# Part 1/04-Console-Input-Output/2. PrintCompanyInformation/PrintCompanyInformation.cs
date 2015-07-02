using System;

class PrintCompanyInformation
{
    /*  A company has name, address, phone number, fax number, web site and manager. 
    The manager has first name, last name, age and a phone number.
        Write a program that reads the information about a company and its manager 
    and prints it back on the console*/

    static void Main()
    {
        Console.Write("Company name: ");
        string company = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        string manager = firstName + " " + lastName;
        string checkedPhone = (phone.Length >= 10) && 
            (phone.Length <= 18) ? phone : "(no phone)";
        string checkedFax = (fax.Length >= 10) &&
            (fax.Length <= 18) ? fax : "(no fax)";
        string checkedManagerPhone = (managerPhone.Length >= 10) && 
            (managerPhone.Length <= 18) ? managerPhone : "(no phone)";

        Console.WriteLine("\n{0}\nAddress: {1}\nTel: {2}\nFax: {3}\nWeb site: {4}\n" +
        "Manager: {5} (age: {6}, tel. {7})", 
            company, address, checkedPhone, checkedFax, webSite, manager, managerAge, checkedManagerPhone);
    }
}
