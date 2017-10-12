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
        Adopter adopter = new Adopter();

        public DataTable GetAnimals()
        {
            Console.WriteLine("How would you like to see our animals?");
            
            DataTable res = animals.ConvertCSVtoDataTable();
            foreach(DataRow dataRow in res.Rows)
            {
                    Console.WriteLine("Animal: " +dataRow[1]);
                    Console.WriteLine("Name: " +dataRow[2]);
                    Console.WriteLine("Room Location: " +dataRow[4]);
            } 
            return res;
        }

        public void LookUpAdopteeInfo(DataTable res)
        {
            if (adopter.LifeStyle_and_Activity_Levels == "Low")
            {
                for (int i = 5; i <= 34; i++)
                {
                    Console.WriteLine("I recommend these animals: " + res.Rows[i]["Name"] + res.Rows[i]["Type of Animal"]);
                }
            }

            if (adopter.Experience_With_Previous_Pets == "Yes")
            {
                for(int i = 0; i <= 34; i++)
                {
                    Console.WriteLine("I recommend these animals: " + res.Rows[i]["Name"] + res.Rows[i]["Type of Animal"]);
                }

            }
        }
        public void GuideToRoom(DataTable res)
        {
            Console.WriteLine("Based on the list of choices, which room would you like to visit?");
            string roomChoice = Console.ReadLine();
            int room = Convert.ToInt32(roomChoice);
            if(room == 1)
            {
                Console.WriteLine("Alright, let's go look at the dogs!");
                Console.ReadLine();
                for (int i = 0; i <= 4; i++)
                {
                        Console.WriteLine(res.Rows[i]["Name"]);
                        Console.WriteLine(res.Rows[i]["Type of Animal"]);
                        Console.ReadLine();
                }
                //retrieves data regarding the animals located in room 1, i.e. the dogs
            }
            if(room == 2)
            {
                Console.WriteLine("Alright, let's go look at the birds!");
                Console.ReadLine();
                for(int i = 10; i <= 14; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                    Console.ReadLine();
                }
                
                //retrieves data regarding the animals in room 2, i.e. the birds
            }
            if(room == 3)
            {
                Console.WriteLine("Alright, let's go look at the cats!");
                Console.ReadLine();
                for(int i = 5; i <= 9; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                    Console.ReadLine();
                }
                //retrieves the data regarding the animals in room 3, i.e the cats
            }
            if(room == 4)
            {
                Console.WriteLine("Alright, let's go look at the rabbits!");
                Console.ReadLine();
                for(int i = 15; i <= 19; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                    Console.ReadLine();
                }
                //retrieves the data regarding the animals in room 4, i.e. the bunnies
            }
            if(room == 5)
            {
                Console.WriteLine("Alright, let's go look at the fish!");
                Console.ReadLine();
                for(int i = 20; i <= 24; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                    Console.ReadLine();
                }
                //retrieves the data regarding the animals in room 5, i.e. the fish
            }
            if(room == 7)
            {
                Console.WriteLine("Alright, let's go look at the lizards and turtles!");
                Console.ReadLine();
                for(int i = 25; i <= 34; i++)
                {
                    Console.WriteLine(res.Rows[i]["Name"]);
                    Console.WriteLine(res.Rows[i]["Type of Animal"]);
                    Console.ReadLine();
                }
                //retrieves the data regarding the animals in room 7, i.e. the lizards and turtles
            }
        }

        public void AcceptPayment(DataTable res)
        {
            for (int i = 0; i <= 34; i++)
            {
                Console.WriteLine("That'll be $" + res.Rows[i]["Price($)"]);
            }
        }
    }
}
