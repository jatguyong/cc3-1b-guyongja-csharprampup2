using System;

namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1
            const double POUNDS_TO_KG = 0.45359237;
            Console.Write("Weight in Pounds (lbs): ");
            double pounds = double.Parse(Console.ReadLine());
            double converted_pounds = pounds * POUNDS_TO_KG;
            Console.WriteLine("Weight converted to Kilograms (kg): " + Math.Round(converted_pounds, 2) + "kg");

            Console.WriteLine("=============================================================");

            const double MILES_TO_KM = 1.609344;
            Console.Write("Length in Miles (mi): ");
            double length = double.Parse(Console.ReadLine());
            double converted_length = length * MILES_TO_KM;
            Console.WriteLine("Length in Kilometers (km): " + Math.Round(converted_length, 2) + "km");

            Console.WriteLine("=============================================================");

            Console.Write("Temperature in Fahrenheit (F): ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double converted_fahrenheit = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine("Temperature in Celsius (C): " + Math.Round(converted_fahrenheit, 2) + " Celsius");

            Console.WriteLine("=============================================================");

            int average_of_students = 0;

            for (int i = 1; i < 11; i++) {
                Console.Write("Age of Student " + i + ": ");
                int student = int.Parse(Console.ReadLine());
                average_of_students += student;
            }

            Console.WriteLine("The average age of the students is: " + average_of_students / 10);

            Console.WriteLine("=============================================================");

            string[] characters = { "Xie Lian", "Hanguang-Jun", "Yiling Patriarch", "Hua Cheng", "Luo Binghe" };

            string ability = "spiritual blast";
            string equipment = "Chenqing";
            string item = "Yin Tiger Tally";

            string story = $@"
{characters[0]}, the exiled heaven official and former prince of XianLe, encountered {characters[1]}, 
a peculiar cultivator searching for someone dear to him. That person turned out to be the now-villain, {characters[2]}, 
whose arrival had disrupted the celestial balance as he soared with his spirit-calling flute, {equipment}. 
Together, they aimed to uncover the truth behind the Patriarch's change in attitude.

In a climactic battle, {characters[0]} was forced to use his hidden power, the {ability}, 
but was gravely wounded by malevolent spirits. {characters[3]}, the Ghost King, joined to avenge his beloved friend 
and revealed that the {characters[2]} was controlled by the {item}. 

After vindicating the {characters[2]}, they destroyed the tally…or so they thought. 
As the battle ended, {characters[4]}, a disciple from Cang Qiong Mountain, collected the item 
and soon realized it wasn't wholly destroyed. Pondering its fate, he chose to keep it for now.";

            Console.WriteLine(story);

            Console.WriteLine("=============================================================");
            // PART 2
            // Number 1:

            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int num1) && num1 > 0) {
                for (int i = 1; i <= num1; i++) {
                    for (int j = 1; j <= i; j++) {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

            } else {
                Console.WriteLine("Invalid Input!");
            }


            Console.WriteLine("=============================================================");
            // Number 2:

            Console.Write("Enter a number: ");
            int sum = 0;

            if (int.TryParse(Console.ReadLine(), out int num2) && num2 > 0) {
                for (int i = 1; i < num2 + 1; i++) {
                    sum += i;
                }

                Console.WriteLine("Output: " + sum);
            } else {
                Console.WriteLine("Invalid Input!");
            }



            Console.WriteLine("=============================================================");
            //Number 3:

            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int num3) && num3 > 0) {
                for (int i = num3; i >= 1; i--) {
                    for (int j = 1; j <= i; j++) {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            } else {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
