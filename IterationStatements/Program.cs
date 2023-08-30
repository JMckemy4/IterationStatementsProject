using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var num = 0;
            // Create a do-while loop and use the template below:
                // Increment num by 1
                var y = 1;
                do
                {
                    num++;
                    numbers.Add(num);
                    Console.WriteLine(y);
                    y++;
                } while (num < 100);
                 num++;
                 Console.WriteLine(num);
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                // <---- While your variable is less than 100
                // Create a while loop
                // <--- While num is less than 200
                while (num < 200)
                {
                num++;
                    // Increment num by 1
                    // Then add num to the collection numbers
                    //HINT: copy how this was done in the do while loop
                    Console.WriteLine(num);
                } // This is to show the user that the numbers will start increasing on the console
                foreach (var x in numbers)
                {
                    Console.WriteLine(numbers);
                }
                // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
                // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

                //start for loop here
                for (int counter = 199; counter <= numbers.Count && counter >= 0; counter--)
                {
                    Console.WriteLine(numbers[counter]);

                    // place numbers[i] inside of the Console.WriteLine() method

                }
            }
        }
    }

                    
             
           

            //------------End of exercise
           

           





