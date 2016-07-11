using System;

namespace ConsoleApplication
{
    public static class CompanyInformation
    {
        public static void Start()
        {
            Console.WriteLine("Enter company information");
            Console.Write("        Name : ");
            var companyName = Console.ReadLine();
            Console.Write("     Address : ");
            var companyAddress = Console.ReadLine();
            Console.Write("Phone Number : ");
            var companyPhoneNumber = Console.ReadLine();
            Console.Write("  Fax Number : ");
            var companyFaxNumber = Console.ReadLine();
            Console.Write("     Website : ");
            var companyWebsite = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter manager information");
            Console.Write("Name : ");
            var managerName = Console.ReadLine();
            Console.Write("Surname : ");
            var managerSurname = Console.ReadLine();
            Console.Write("Phone number : ");
            var managerPhoneNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(@"Below is the company information:
{0}
{1}
Phone : {2}
Fax : {3}
Website : {4}
Manager: {5} {6} (Phone: {7})", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite, managerName, managerSurname, managerPhoneNumber);
        }
    }
}