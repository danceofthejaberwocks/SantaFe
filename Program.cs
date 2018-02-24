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
            {
                Console.WriteLine("Welcome to Santa Fe, home of the world's spiciest salsa!");
                Console.WriteLine("Great, and would you like\n A) a booth\n B) a table?");
                Console.ReadLine();
                ChoiceScript();
                WelcomeMenu();
            }
        }
        //METHODS LIVE BELOW THIS LINE 

        public static bool WelcomeMenu()
            //this method is just a simple loop so you can keep ordering 
        {
            bool welcomeMenu = true;
           
            while (welcomeMenu == true)
            {
               
                Console.WriteLine("Will that be all today?\nY or N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                {
                    welcomeMenu = true;
                    ChoiceScript();
                }
                else
                {
                    welcomeMenu = false;
                }
            }

            return welcomeMenu;
        }
        public static void ChoiceScript()
            //this method has you pick the meal and calls on the method to card you
        {
            Console.WriteLine($"What would you like?\nA)Breakfast\nB)Lunch\nC)Dinner");
            string mealChoice = Console.ReadLine().ToUpper();
            //that line makes it upper case so there are no input issues
            if (mealChoice == "A")
                //print meals, then print drinks
            { BreakfastMenuPrint(); DrinkMenu(); DrinkChoice(); }
            else if (mealChoice == "B") { LunchMenuPrint(); DrinkMenu(); DrinkChoice(); }
            else if (mealChoice=="C") { DinnerMenuPrint(); DrinkMenu(); DrinkChoice(); }
            // I want it to give you an error and force you pick the right thing for incorrect values
            else {
                Console.Write("That was not a choice. Try again\n");
                ChoiceScript();
            }

        }
        public static void BreakfastMenuPrint()
            //this stores and prints breaksfast menu. 
            //I did not store all arrays in one method because I want to be able
            //to easily edit contents
            //all the menus work essentially the same. I make an array with the choices 
            //and then a loop prints them
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
        public static void LunchMenuPrint()
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
        public static void DinnerMenuPrint()
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

        public static void DrinkMenu()
        {
            string[] drinks = new string[5];
            drinks[0] = "A) Bloody Mary";
            drinks[1] = "B) Iced Tea";
            drinks[2] = "C) Beer";
            drinks[3] = "D) Soda";
            drinks[4] = "E) Water";

            Console.WriteLine($"And what do you want to drink?\n");
            for (int i = 0; i < 5; i++)
            { Console.WriteLine( drinks[i]); }
        }

            public static TimeSpan ageCheck()
            {

            Console.WriteLine("When is your birthday?");
            string input = Console.ReadLine();
            var birthday = DateTime.Parse(input);
            var startDate = DateTime.Today;
            TimeSpan Age = startDate.Subtract(birthday);
            

            return Age;
            }
        public static void Alcohol()
        {
            var Age= ageCheck();
            int x1 = (int)Age.TotalDays / 365;
            //that line turns my age TimeSpan into an int
            //I choose int because I want it to be a round #
            if (x1 < 21)
            {
                Console.WriteLine("You are too young to drink, pick something else");
                DrinkMenu();
                string userInput = Console.ReadLine();
                if (userInput.ToUpper() == "A")
                    Alcohol();
                else if (userInput.ToUpper() == "C")
                    Alcohol();
                Console.ReadLine();
            }
        }
        public static void DrinkChoice()
        {
            //Console.WriteLine($"And what do you want to drink?\n");

            string drinkChoice = Console.ReadLine().ToUpper();
            if (drinkChoice == "A")
            {
                Alcohol();

            }
            else if (drinkChoice == "B")
            {
                Console.WriteLine("One iced tea, coming up!");
            }
            else if (drinkChoice == "C")
            { Alcohol(); }
            else if (drinkChoice == "D")
            {
                Console.WriteLine("One soda, coming up!");
            }
            else if (drinkChoice == "E")
            {
                Console.WriteLine("One water coming up!");
            }
            else
            {
                Console.Write("That was not a choice. Try again");
                DrinkMenu();
                DrinkChoice();
            }
            }
        }
    }