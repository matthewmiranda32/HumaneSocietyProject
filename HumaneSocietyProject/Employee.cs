using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public partial class Employee
    {
        Animals animals = new Animals();
        public string animalName;
        public double amount;

        public DataTable GetAnimals()
        {
            Console.WriteLine("How would you like to see our animals?");
            Console.ReadLine();
            DataTable res = animals.ConvertCSVtoDataTable();
            foreach (DataRow dataRow in res.Rows)
            {
                Console.WriteLine("Animal: " + dataRow[1]);
                Console.WriteLine("Name: " + dataRow[2]);
                Console.WriteLine("Room Location: " + dataRow[4]);
            }
            return res;
        }

        public void GuideToRoom(DataTable res)
        {
            Console.WriteLine("Do you know what kind of pet you want?");
            Console.WriteLine("Dogs are in Room 1, Birds are in Room 2, Cats are in Room 3, Rabbits are in Room 4, Fish are in Room 5 and Turtles and Lizards are in Room 7.");
            Console.WriteLine("Type the number of the room you wish to visit.");
            string roomChoice = Console.ReadLine();
            int room = Convert.ToInt32(roomChoice);
            if (room == 1)
            {
                Console.WriteLine("Alright, let's go look at the dogs!");
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]); 
                }
                //retrieves data regarding the animals located in room 1, i.e. the dogs
            }
            if (room == 2)
            {
                Console.WriteLine("Alright, let's go look at the birds!");
                for (int i = 10; i <= 14; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                }

                //retrieves data regarding the animals in room 2, i.e. the birds
            }
            if (room == 3)
            {
                Console.WriteLine("Alright, let's go look at the cats!");
                for (int i = 5; i <= 9; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                }
                //retrieves the data regarding the animals in room 3, i.e the cats
            }
            if (room == 4)
            {
                Console.WriteLine("Alright, let's go look at the rabbits!");
                for (int i = 15; i <= 19; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                }
                //retrieves the data regarding the animals in room 4, i.e. the bunnies
            }
            if (room == 5)
            {
                Console.WriteLine("Alright, let's go look at the fish!");
                for (int i = 20; i <= 24; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                }
                //retrieves the data regarding the animals in room 5, i.e. the fish
            }
            if (room == 7)
            {
                Console.WriteLine("Alright, let's go look at the lizards and turtles!");
                for (int i = 25; i <= 34; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                }
                //retrieves the data regarding the animals in room 7, i.e. the lizards and turtles
            }

            else if (room != 1 && room != 2 && room != 3 && room != 4 && room != 5 && room != 7)
            {
                Console.WriteLine("Please enter a valid room number.");
                Console.ReadLine();
            }

            Console.WriteLine("Do you know which animal you'd like? Please type their name.");
            animalName = Console.ReadLine();
        }

        public void AskForPayment(DataTable res)
        {
            for (int i = 0; i <= 34; i++)
            {
                if (res.Rows[i]["Name"].ToString() == animalName)
                {
                    Console.WriteLine("That'll be $" + res.Rows[i]["Price($)"].ToString());
                    Console.ReadLine();
                }
            }
        }

        public void CollectMoney(DataTable res)
        {
            for (int i = 0; i <= 34; i++)
            {
                if (res.Rows[i]["Price($)"].ToString() == animalName)
                {
                    string price = res.Rows[i]["Price($)"].ToString();
                    amount = Convert.ToDouble(price);
                }
            }
        }

        public void FeedAnimals(DataTable res)
        {
            for (int i = 0; i <= 34; i++)
            {
                if (res.Rows[i]["Name"].ToString() == animalName)
                { 
                Console.WriteLine( res.Rows[i]["Name"] + " needs " + res.Rows[i]["Food Amount (in cups)"] + " cups of " + res.Rows[i]["Food Type"] + " each day.");
                Console.ReadLine();
                }
            }
        }

        public void AskForVaccination(DataTable res)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (res.Rows[i]["Name"].ToString() == animalName)
                {
                    if (res.Rows[i]["Room Location"].ToString() == "1" && res.Rows[i]["Room Location"].ToString() == "3" && res.Rows[i]["Room Location"].ToString() == "4")
                    {
                        if (res.Rows[i]["Been Vaccinated?"].ToString() == "No")
                        {
                            Console.WriteLine(res.Rows[i]["Name"] + " has not yet been vaccinated. Would you like to do that now?");
                            string response = Console.ReadLine();
                            if (response == "Yes")
                            {
                                Console.WriteLine("All right. Let's take care of that right now!");
                            }
                            else if (response == "No")
                            {
                                Console.WriteLine("All right. Let's get you checked out!");
                            }
                            else
                            {
                                Console.WriteLine("Please answer Yes or No.");
                            }
                        }
                    }
                }
            }
        }
    }
}
