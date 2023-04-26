using Convert_Temperature.Classes;
using System;
using System.Collections.Generic;

namespace Convert_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var head = "Calculation of degrees Celsius and Fahrenheit";
                Console.WriteLine($"\n\t{head.ToUpper()}");
                Console.WriteLine("\t---------------------------------------------");
                Console.Write(" Enter numb: ");
                var numb = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    Convert_Class convert_Class = new Convert_Class(Convert.ToInt32(numb));
                    List<string> list = convert_Class.Convert_Temperature();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                Console.Write(" Do you want continue Yes/No - ");
                var answer = Console.ReadLine();
                Console.WriteLine();

                if (answer.ToLower() == "no")
                {
                    Console.WriteLine(" Good bye");
                    break;
                }
            }
        }
    }
}
