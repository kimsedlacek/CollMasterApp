using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] arrayOne = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(arrayOne);            
                       
            //TODO: Print the first number of the array

            Console.WriteLine($"{arrayOne[0]} is the number at index 0 right now.");

            //TODO: Print the last number of the array

            Console.WriteLine($"{arrayOne.Length - 1} is the last number in the index right now.");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(arrayOne);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(arrayOne);
            NumberPrinter(arrayOne);


            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(arrayOne);
            Console.WriteLine();

            Console.WriteLine("-------------------");

           
            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayOne);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayOne);
            NumberPrinter(arrayOne);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numberList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity of list");
            Console.WriteLine(numberList.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);


            //TODO: Print the new capacity
            Console.WriteLine("The new capacity of the list: ");
            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            bool canParse;
            int userInput;
            do
            {
                Console.WriteLine("What number do you want to search for in the list?"); 
                canParse = int.TryParse(Console.ReadLine(), out userInput);
                
            } while (canParse == false);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("All numbers in the list:");
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int [] convertedArray = numberList.ToArray();

            //TODO: Clear the list
            Console.WriteLine("Should see nothing below this line, the list is cleared:");
            numberList.Clear();
            NumberPrinter(numberList);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0; 
                }

            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0; i--)
            {
                if (numberList[i] %2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            foreach (var item in numberList)
            {
                if(searchNumber == item)
                {
                    Console.WriteLine("Your number is in the list.");
                    foundNumber = true;
                    break;
                }
                
                    {
                    Console.WriteLine("Your number is NOT in the list.");
                    }
                
            if (foundNumber == false);
                
                Console.WriteLine($"{searchNumber} is not in the list");
            }
        }

        

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = rng.Next(0, 51);
                numberList.Add(randomNumber);
            }

        }

        private static void Populater(int[] numbers)
        {
                   
            Random rng = new Random();

            for(int i = 0; i < numbers.Length ; i++)
            {
                int randomNumber = rng.Next(0, 51);
                numbers[i] = randomNumber;  
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }
            NumberPrinter(newArray);
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
