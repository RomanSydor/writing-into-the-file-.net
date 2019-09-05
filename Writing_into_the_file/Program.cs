using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
     
    class Program
    {

        static void Main(string[] args)
        {

            double a, b, step;
            double i;
            int j = 0;

            Console.Write("Input a: ");
            string a_str = Console.ReadLine();
            a = Convert.ToInt64(a_str);
            
            Console.Write("Input b: ");
            string b_str = Console.ReadLine();
            b = Convert.ToInt64(b_str);
            
            Console.Write("Input step: ");
            string step_str = Console.ReadLine();
            step = Convert.ToInt64(step_str);

            StreamWriter result_out = new StreamWriter(@"C:\С#\Writing_into_the_file\Writing_into_the_file\result.txt");


            for (i = a; i <= b; i+=step) 
            {
                j++;
                result_out.WriteLine( j + ") Result (x = " + i + ") : " + function(i));
            }

            result_out.Close();

            StreamReader result_in = new StreamReader(@"C:\С#\Writing_into_the_file\Writing_into_the_file\result.txt");

            Console.WriteLine(File.ReadAllText(@"C:\С#\Writing_into_the_file\Writing_into_the_file\result.txt"));

            Console.ReadLine();
        }

        public static double function(double x)
        {
            return x * x;
        }

    }
}
