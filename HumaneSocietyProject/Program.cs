using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Aberdeen Humane Society!");
            Console.ReadLine();
            Animals animals = new Animals();
            Employee employee = new Employee();
            Adopter adopter = new Adopter();
            Database database = new Database();
            AdoptionFee adoptionFee = new AdoptionFee();
            adopter.GetAdopterName();
            adopter.RetrieveAdopterHomeInfo();
            adopter.AskAboutOtherPets();
            adopter.AskAboutPetExperience();
            adopter.AskAboutVet();
            adopter.AskAboutTheKids();
            adopter.AskAboutActivity();
            database.CreateTableForAdopters();
            database.AddValuestoAdopters(adopter);
            DataTable res = employee.GetAnimals();
            employee.GuideToRoom(res);
            adopter.ChooseAnimal(employee, res);
            employee.FeedAnimals(res);
            employee.AskForVaccination(res);
            employee.AskForPayment(res);
            adoptionFee.AddToBalance(employee);
            Console.WriteLine("Thank you! We hope you enjoy your new pet!");
            Console.ReadLine();
        }
    }
}
