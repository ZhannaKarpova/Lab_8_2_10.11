using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab_8_2_10._11

{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText("F1.txt"); 
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100)); 
                }
            }
            sw.Close(); 

            using (StreamReader sr = new StreamReader("F1.txt"))
            {
                string numbers = sr.ReadLine();
                foreach (var number in numbers.Split())
                {
                    Console.WriteLine(number);
                    int x = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int i = 10; i >= 0; i--)
                    {
                        sum += i;

                    }
                    Console.WriteLine(sum);
                    Console.ReadKey();
                }
            }
        }
    }
}  

