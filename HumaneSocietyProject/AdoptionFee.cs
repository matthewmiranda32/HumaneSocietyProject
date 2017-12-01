using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class AdoptionFee
    {
        private double balance;
        Animals animals = new Animals(); 
        public AdoptionFee(double startingAmount = 75.00)
        {
            balance = startingAmount;
        }

        public double AddToBalance(Employee employee)
        {
            balance += employee.amount;
            return balance;
        }
    }
}
