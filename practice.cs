using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //assning variables
            float aaa = 1.356f;         // 
            aaa = aaa + 21;
            int number = 14254;
            char character = 'd';
            bool boolean = false;
            string words = "fsakb";

            //printing the variables
            Console.WriteLine(aaa);
            Console.WriteLine("program is working " + boolean);
            Console.WriteLine(number);
            Console.WriteLine(character);
            Console.WriteLine(words);

            Console.WriteLine("range you can store in an int is " + "{0} to {1}", int.MinValue, int.MaxValue);

            //converting int to byte
            int Number = 12334;             //the number is larger than 255 which is the max value, so data is lost
            byte Num = (byte)Number;        
            Console.WriteLine(Num);         

            //converting string into int
            var Asd = "123";
            int s = Convert.ToInt32(Asd);
            Console.WriteLine(s);

            try
            {
                var As = "1233";
                int d = Convert.ToByte(As);
                Console.WriteLine(d);          
            }
            catch (Exception)
            {
                Console.WriteLine("hahahahaha");     //if number is higher than 255 than a messag will appear as a byte cant store numbers over 255
            }                                        //if not than it will resume 




        }
    }
}
