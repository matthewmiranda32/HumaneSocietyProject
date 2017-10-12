using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public partial class Adopter
    {
        List<string> adopter = new List<string>();
        Employee employee = new Employee();
        Database database = new Database();
        public void GetInformation()
        {
            Console.WriteLine("Before you choose your animal, I'd like to learn a little about you.");
            Console.ReadLine();
            Console.WriteLine("Please enter your name: ");
            string adopterName = Console.ReadLine();
            adopter.Add(adopterName);
            Console.WriteLine("Please enter your address: ");
            string address = Console.ReadLine();
            adopter.Add(address);
            Console.WriteLine("What type of home do you have: ");
            string typeOfHome = Console.ReadLine();
            adopter.Add(typeOfHome);
            Console.WriteLine("Do you own any other pets? ");
            string otherPets = Console.ReadLine();
            adopter.Add(otherPets);
            Console.WriteLine("Who is your primary veteranarian? ");
            string vet = Console.ReadLine();
            adopter.Add(vet);
            Console.WriteLine("Do you have any children? ");
            string kids = Console.ReadLine();
            adopter.Add(kids);
            Console.WriteLine("What is your level of activity? ");
            string activityLevel = Console.ReadLine();
            adopter.Add(activityLevel);
            Console.WriteLine("Have you had any previous experience with pets? ");
            string petExperience = Console.ReadLine();
            adopter.Add(petExperience);
        }
        public void ChooseAnimal()
        {
            Console.WriteLine("Is this the animal you'd like?");
            string response = Console.ReadLine();
            if(response == "yes")
            {
                Console.WriteLine("Great! Let's get you checked out! Follow me to Room 6.");
            }
            else if(response == "no")
            {
                Console.WriteLine("Okay! Let's keep looking...");
            }  
        }
    }
}
