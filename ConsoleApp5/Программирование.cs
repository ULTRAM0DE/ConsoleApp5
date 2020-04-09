using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] digits = new byte[5];

            digits[0] = 34;
            digits[4] = 255;

            Console.WriteLine(digits[3]);

            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };

            Console.WriteLine(students[1]);

            short[,] nums = new short[5, 2];

            int[,] numbers = {
              { 5, 7, 2},
              { 9, 200, 8 },
              { 7, 0, 12 }
            };
            int len = students.Length;
            Console.WriteLine(students.Length);

            Array.Clear(students, 0, len);
           
            Console.WriteLine(students[1]);

            string[] copyStudents = new string[len];
            students.CopyTo(copyStudents, 0);

            Console.WriteLine(copyStudents[1]);



            int[,,] numbers_2 = {
                {
                     { 5, 7, 2},
                     { 9, 200, 8 },
                     { 7, 0, 12 }
                },
                {
                     { 5, 7, 2},
                     { 9, 200, 8 },
                     { 7, 0, 12 }
                },
            };    

            
        }
    }
}


     



        
    

