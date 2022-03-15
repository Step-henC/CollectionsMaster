using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            int[] rando = new int[50];
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(rando);

            //Print the first number of the array
            Console.WriteLine(rando[0]);

            //Print the last number of the array            
            Console.WriteLine($"{rando.Length - 1}");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(rando);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(rando);


            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(rando);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers

            ThreeKiller(rando);
            NumberPrinter(rando);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(rando);
            NumberPrinter(rando);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion


            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"{ intList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            
            Populater(intList);

            //Print the new capacity
            Console.WriteLine($"{intList.Capacity}");



            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            bool numCheck;
            int userNum;
            do
            {
                numCheck = int.TryParse(Console.ReadLine(), out userNum);

            } while (numCheck == false);
            NumberChecker(intList, userNum);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var makeArray = intList.ToArray();

            //Clear the list
            intList.Clear();

            #endregion
              
            
            

        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("Multiple of 3 = 0: ");
           
          
            
        }

        private static void OddKiller(List<int> numberList)
        {

            
            
               
                
                
                numberList.RemoveAll(i => i % 2 != 0);
                
            
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {



            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("We have your number");
            }
            else
            { Console.WriteLine("Not here"); }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {

                

               
                 numberList.Add(rng.Next(0, 50)); 
            }
        
            

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
                

            }
        }
        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
         
           
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
