using System;

namespace Friday_activity_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Universe!");

            //Q1 - Swap two numbers using temporary variable
            Console.WriteLine();//Print a blank line for clarity

            Console.WriteLine("Enter number 1");//Prompt to enter a number
            int number_1 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value
            Console.WriteLine("You entered " + Convert.ToString(number_1) + " as number_1");

            Console.WriteLine("Enter number 2");//Prompt to enter a number
            int number_2 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value
            Console.WriteLine("You entered " + Convert.ToString(number_2) + " as number_2");

            int temp_number = number_1;//Set temp_number to equal number_1
            number_1 = number_2;//Set number_1 to equal number_2 now that number_1 is saved in the temp_number variable
            number_2 = temp_number;//Set number_2 to be equal to number_1s original value that is stored in the temp_number variable

            Console.WriteLine("number_1 = " + Convert.ToString(number_1) + " and number_2 = " + Convert.ToString(number_2));

            //Q2 - Swap two numbers without using temporary variable
            Console.WriteLine();//Print a blank line for clarity

            Console.WriteLine("Enter number 1");//Prompt to enter a number
            number_1 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value
            Console.WriteLine("Enter number 2");//Prompt to enter a number
            number_2 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value

            number_1 = number_1 + number_2;// number_1 is equal to sum of both numbers
            number_2 = number_1 - number_2;// This will make number_2 equal to number_1s original value
            number_1 = number_1 - number_2;// This will make number_1 equal to number_2s original value

            Console.WriteLine("number_1 = " + Convert.ToString(number_1) + " and number_2 = " + Convert.ToString(number_2));

            //Q3 - Input a number from user. Check if the number is odd or even.
            Console.WriteLine();//Print a blank line for clarity

            Console.WriteLine("Enter your number to see if it is even or odd");//Prompt to enter a number
            number_1 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value

            if (number_1 % 2 == 0)//Check if number is even 
            {
                Console.WriteLine("Your number is even.");//If number is even print this
            }
            else
            {
                Console.WriteLine("Your number is odd.");//If number is odd print this
            }

            //Q4 - Input a year from user. Check if the year is a leap year or a common year. 
            Console.WriteLine();//Print a blank line for clarity

            Console.WriteLine("Enter a year");//Prompt to enter a year
            int year = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the value to the variable year

            if (year % 4 != 0)//Check if year is divisable by 4
            {
                Console.WriteLine("This year is a common year");//Outputs to show that year is not a leap year
            }

            else if (year % 400 == 0)
            {
                Console.WriteLine("This year is a leap year");//Outputs to show that year is a leap year
            }

            else if (year % 100 == 0)
            {
                Console.WriteLine("This year is a common year");//Outputs to show that year is not a leap year
            }

            else
            {
                Console.WriteLine("This year is a leap year");//Outputs to show that year is a leap year
            }

            //Q5 - Input 3 numbers from user and find the greater number 
            Console.WriteLine();//Print a blank line for clarity

            Console.WriteLine("You will be asked for three numbers and shown which is the greatest");//Displays what is going to happen
            Console.WriteLine("Enter number 1");//Prompt to enter a number
            number_1 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value

            Console.WriteLine("Enter number 2");//Prompt to enter a number
            number_2 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value

            Console.WriteLine("Enter number 3");//Prompt to enter a number
            int number_3 = Convert.ToInt32(Console.ReadLine());//Reads the line and assigns the variable that value

            Console.WriteLine("You entered " + Convert.ToString(number_1) + ", " + Convert.ToString(number_2) + " and " + Convert.ToString(number_3));

            if (number_1 > number_2 && number_1 > number_3)//Check to see if number_1 is the largest number
            {
                Console.WriteLine("Number one, " + Convert.ToString(number_1) + " is the largest number");//Output to show that number 1 is the largest number
            }

            else if (number_2 > number_1 && number_2 > number_3)//Check to see if number_2 is the largest number)
            {
                Console.WriteLine("Number two, " + Convert.ToString(number_2) + " is the largest number");//Output to show that number 2 is the largest number
            }

            else if (number_3 > number_1 && number_3 > number_2)//Check to see if number_3 is the largest number)
            {
                Console.WriteLine("Number three, " + Convert.ToString(number_3) + " is the largest number");//Output to show that number 3 is the largest number
            }
        }
    }
}
