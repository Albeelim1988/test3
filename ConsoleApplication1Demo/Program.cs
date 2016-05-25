using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1Demo
{

    class Program
    {

        int x = 4, y = 1;

        static void Main(string[] args)
        {

            double angle;
            //List<int> mylist = new List<int> { 4, 7, 2, 5, 0, 6 };

            //angle = Math.PI * 15 / 180;

            angle = mathvalue(15);
            FileStream fileO = File.OpenRead("text.txt"); //demo 123
            //sum = x - y;

            /*test test1 = new test(1);
            test test2 = new test(2);
            test test3 = new test(3);*/
            //int test1 = 1; //comment
            /*switch (test1)
            {
                case (test1 <9):
                    Console.WriteLine("Same as Case 2");
                    break;
                case test3:
                    Console.WriteLine("Same as Case 3");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }*/
        }
        public static double mathvalue(int x)
        {
            return Math.PI *x / 180;
        }
        public class test
        {
            public int value { get; set; }
            public test(int x) { value = x; }
        }
    }
}
