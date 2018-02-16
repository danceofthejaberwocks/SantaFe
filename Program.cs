using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaFe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Santa Fe, home of the world's spiciest salsa!\n " +
                "Are you here for: \n A) Brekfast\n B) Lunch\n C) Dinner");
            string mealChoice = Console.ReadLine();
            string userChoice = mealChoice.ToUpper();
            Console.WriteLine($"What would you like?");
            Console.ReadLine();
            if (userChoice == "A")
            { breakfastMenuPrint(); }
            else if (userChoice == "B") { lunchMenuPrint(); }
            else { dinnerMenuPrint(); }
            string[] drinks = new string[4];

        }
        


        public static void breakfastMenuPrint()
        {
            string[] breakfast = new string[3];
            breakfast[0] = "A. Biscuits and Gravy: $5.20";
            breakfast[1] = "B. French Toast: $3.25";
            breakfast[2] = "C. Breakfast Burrito: $6.15";
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine(breakfast[i]);
               
            }
            Console.ReadLine();
        }
        public static void lunchMenuPrint()
        {   string[] lunch = new string[3];
            lunch[0] = "A. Nachos: $4.15";
           lunch[1] = "B. Chicken Street Tacos: $3.25";
            lunch[2] = "C. Tamales: $6.15";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(lunch[i]);

            }
            Console.ReadLine();
        }
        public static void dinnerMenuPrint()
        {
            string[] dinner = new string[3];
            dinner[0] = "A. Arroz con Pollo: $10.50";
            dinner[1] = "B. Mama's Mole: $3.50";
            dinner[2] = "C. Shrimp Diablo: $20.75";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dinner[i]);

            }
            Console.ReadLine();
        }

       
    }
}
//breakfast menu I want biscuits and gravy, french toast and breakfast burrito 
// lunch menu I want nachos, chicken or beef tacos, and tamales 
//dinner arroz con pollo, mole, spicy shrimp 