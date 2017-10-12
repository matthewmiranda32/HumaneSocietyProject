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
            Animals animals = new Animals();
            Employee employee = new Employee();
            Adopter adopter = new Adopter();
            adopter.GetInformation();
            DataTable res = employee.GetAnimals();
            employee.GuideToRoom(res);
        }
    }
}
