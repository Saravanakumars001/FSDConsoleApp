using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FSDConsoleApp
{
    class ConditionalConstructsExamples
    {

        static void Main(string[] args)
        {
            //bool IsEmail = true;
            //bool IsGoogle = false;
            //bool IsFacebook = false;

            //if (IsEmail || IsGoogle || IsFacebook)
            //{
            //    Console.WriteLine("Login is successful and can access course");
            //}
            //else
            //{
            //    Console.WriteLine("Login is failed and cannot access course");

            //}

            //Console.ReadLine();

            /*
            bool authdone = false;

            string res;

            res = authdone ? "Login is success" : "Login is failed";
            Console.WriteLine(res);

            Console.ReadLine();*/


            /*string irole = "Saravana";

            switch (irole)
            {
                case "Admin":
                    Console.WriteLine("You have full access");
                    break;
                case "SubAdmin":
                    Console.WriteLine("You have acccess to create and delete course ");
                    break;
                case "Testprep":
                    Console.WriteLine("You have access to create or delete tests");
                    break;
                case "User":
                    Console.WriteLine("You have access to view the course");
                    break;
             default:
                 Console.WriteLine("You have trial access");
                 break;


            }

            Console.ReadLine();*/

            bool NeedCandles = true;
            int noOfcandles = 0;
            while (NeedCandles)
            {
                Console.WriteLine("Do u need candle? Yes / No");
                string conf = Console.ReadLine();
                if(conf=="Yes")
                {
                    noOfcandles++;
                }
                else
                {

                    NeedCandles = false;
                }
            }

            Console.WriteLine("No of candles needed {0}",noOfcandles);
            Console.ReadLine();
        }


        }
    
}
