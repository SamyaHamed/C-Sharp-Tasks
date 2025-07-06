// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Samya !");
Console.WriteLine(4+5);
Console.WriteLine("4+5");
Console.Write("i love you\n");
Console.Write("HI Everyone\n");
String var1 = "Eman" ;
Console.WriteLine(var1);

Console.WriteLine("Enter Your age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("User Name is :"+ age);
int v1 = 9;
int v2 = 10;
Console.WriteLine(v1<v2);
string name1 = "samya";
string name2 = "Eman";
string university = "AL-Najah";
string all = $"hi {name1} ,{name2} all of them study at {university}";
Console.WriteLine(all);
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
