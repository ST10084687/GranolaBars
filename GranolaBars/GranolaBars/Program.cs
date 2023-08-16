using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranolaBars
{
    public class Program
    {
        static void Main(string[] args)
        {
            double granolaEach = 1.50;
            double granolaCase = 100;
            double granolaCaseCost = 100;
            double associationRequirement = 0.10;
            double casesNeeded = 29;
            double governmentEarnings = 0;
            double clubEarnings = 0;
            

            Console.WriteLine("Each granola bar costs >>> R" + granolaEach);
            Console.WriteLine("Granola bars are sold in a case of " + granolaCase + " bars");
            Console.WriteLine("Each case costs >>> R" + granolaCaseCost);

            finalClubEarnings(100, 0.10, 29, out governmentEarnings, out clubEarnings);
            Console.WriteLine("Amount given to the student association >>> R" + governmentEarnings);
            Console.WriteLine("The total amout the computer club will recieve after selling 29 cases >>> R" + clubEarnings);

            Console.ReadLine();



        
        }
        public static void finalClubEarnings(double granolaCase, double associationRequirement,double casesNeeded, out double governmentEarnings, out double clubEarnings)
        {
            governmentEarnings = (granolaCase * casesNeeded) * associationRequirement;
            clubEarnings = (granolaCase * casesNeeded) - governmentEarnings;
           

        }
       

    }
}
