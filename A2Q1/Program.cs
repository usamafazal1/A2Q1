using System;
using System.Linq;

namespace A2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for how long the array has to be 
            Console.WriteLine("How many numbers do you want to enter in the array?");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            //determine the size of the array
            int[] myArray = new int[Quantity];

            Console.WriteLine("Enter values for your array\n");

            //take input of values for the array
            for (int i = 0; i < Quantity; i++)
            {

                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //print the array
            Console.WriteLine("\nYour array has the following elements: ");
            for (int i = 0; i < Quantity; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            //adding all elements of the array using sum function from using System.Linq

            Console.WriteLine("\n\nThe sum of the elements of the array is: " + myArray.Sum());

            //multiplication of elements of the array
            int product = 1;

            Console.Write("\n\nThe product of elements of the array is: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                product = product * myArray[i];
            }
            Console.Write(product + "\n\n\n\n");

        }
    }
}