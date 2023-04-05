namespace Interface;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces");
        person myPerson = new person();
        myPerson.FirstName = "Tyler";
        myPerson.LastName = "Johnson";
        myPerson.PhoneNumber = "705-619-4114";
        myPerson.EmailAddress = "tvjj10@gmail.com";
        Console.WriteLine(myPerson.SendEmail());
        Console.WriteLine(myPerson.ShowContatcInfo());

        Company myCompany = new Company();
        myCompany.CompanyName = "tyler inc.";
        myCompany.DirectorName = "Tyler Johnson";
        myCompany.DirectorEmailAddress = "Tjohnson@tyler.inc.com";
        myCompany.PhoneNumber = "705-619-4114";
        myCompany.EmailAddress = "tyler.inc@tyler.inc.com";
    }
}
