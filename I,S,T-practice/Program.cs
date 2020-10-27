using System;
using System.IO.Pipes;

namespace I_S_T_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how old are you?");
            
            var age = Convert.ToInt32(Console.ReadLine());
            
            var answer = (age >= 21) ? $"Based on your age {age} you are permited to this site." : $"Based on your age {age} you are not permited on this site.";
           
            Console.WriteLine(answer);


            

                
            

        }
    }
}
