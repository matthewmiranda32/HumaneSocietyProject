using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public partial class Adopter
    {
        public string adopterName;
        public string address;
        public string typeOfHome;
        public string otherPets;
        public string vet;
        public string kids;
        public string kidsAges;
        public string activityLevel;
        public string petExperience;
        public void GetAdopterName()
        {
            Console.WriteLine("Before you choose your animal, I'd like to learn a little about you.");
            Console.WriteLine("Please enter your name: ");
            adopterName = Console.ReadLine();
        }
        public void RetrieveAdopterHomeInfo()
        {
            Console.WriteLine("Please enter your address: ");
            address = Console.ReadLine();
            Console.WriteLine("What type of home do you have? ");
            typeOfHome = Console.ReadLine();
            while (typeOfHome != "Apartment" && typeOfHome != "House" && typeOfHome != "Mobile Home")
            {
                Console.WriteLine("Please enter either Mobile Home, Apartment or House.");
                Console.ReadLine();
            }
        }

        public void AskAboutOtherPets()
        {
            Console.WriteLine("Do you own any other pets? ");
            otherPets = Console.ReadLine();
            while (otherPets != "Yes" && otherPets != "No")
            {
                Console.WriteLine("Please Answer Yes or No.");
                Console.ReadLine();
            }
        }

        public void AskAboutVet()
        {
            Console.WriteLine("Who is your primary veteranarian? ");
            vet = Console.ReadLine();
        }

        public void AskAboutTheKids()
        {
            Console.WriteLine("Do you have any children? ");
            kids = Console.ReadLine();
            if (kids == "Yes")
            {
                Console.WriteLine("Are they young children?");
                kidsAges = Console.ReadLine();
                while (kidsAges != "Yes" && kidsAges != "No")
                {
                    Console.WriteLine("Please answer Yes or No.");
                    Console.ReadLine();
                }
            }
            while (kids != "Yes" && kids != "No")
            {
                Console.WriteLine("Please answer Yes or No.");
                Console.ReadLine();
            }
        }

        public void AskAboutActivity()
        {
            Console.WriteLine("What is your level of activity? ");
            activityLevel = Console.ReadLine();
            while (activityLevel != "Low" && activityLevel != "Medium" && activityLevel != "High")
            {
                Console.WriteLine("Please answer with Low, Medium or High.");
                Console.ReadLine();
            }
        }

        public void AskAboutPetExperience()
        {
            Console.WriteLine("Have you had any previous experience with pets? ");
            petExperience = Console.ReadLine();
            while (petExperience != "Yes" && petExperience != "No")
            {
                Console.WriteLine("Please Answer Yes or No.");
                Console.ReadLine();
            }
        }

        public void ChooseAnimal(Employee employee, DataTable res)
        {
            Console.WriteLine("Is this the animal you'd like?");
            string response = Console.ReadLine();
            if(response == "Yes")
            {
                Console.WriteLine("Great! Let's get you checked out! Follow me to Room 6.");
                Console.ReadLine();
            }
            else if(response == "No")
            {
                Console.WriteLine("Okay! Let's keep looking...");
                employee.GuideToRoom(res);
            }
            
            while (response != "Yes" && response != "No")
            {
                Console.WriteLine("Please type Yes or No");
                Console.ReadLine();
            } 
        }
    }
}
