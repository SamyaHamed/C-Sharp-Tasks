// See https://aka.ms/new-console-template for more information
/*
Write C# code that reads the following from a file 
N : represents int number
N Values : represents a list of integer numbers

this will represent Unsorted array
find two numbers where their summation = 9


Example
- Input:
7
5 7 10 3 6 1 0


Output:
3  6
*/


using System;
using System.IO;  // include the System.IO namespace

namespace MyApp
{
    class Program
    {
        private  static int[] Numbers;
        private static int[] ReadFile( string nameOfFile)
        {
            string[] Lines = File.ReadAllLines(nameOfFile);
            int Size= int.Parse(Lines[0]);
            int [] array = new int[Size];
            array = Lines[1].Split(' ').Select(int.Parse).ToArray();
            return array;
        }
        private static void ReturnPair(int[] array)
        { 
            int Result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++) // j starts from i+1 to avoid duplicates and self-pairs
                {    Result = array[i] + array[j];
                    if (Result == 9)
                    {
                        Console.WriteLine($"Pair found: {array[i]} + {array[j]} = 9");
                    }
                }
            }   
            
        }
        static void Main(string[] args)
        {
             Numbers = ReadFile("File1.txt");
             ReturnPair(Numbers);
        }
    }
    
}
