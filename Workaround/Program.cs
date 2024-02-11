using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Hüseyin";
        person.LastName = "Kan";
        person.BirthYear = 1999;
        person.NationalId = 1234;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }

}