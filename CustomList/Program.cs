using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Generator(5000));
            //Console.ReadLine();

            CustomList<string> myList = new CustomList<string>() { };
            //Console.WriteLine((myList.SelectionSort()).ToString());
            myList.InsertionSort();
            Console.WriteLine(myList.ToString());
        }
        public static string Generator(int length)
        {
            Random rand = new Random();
            string output = "";
            while (length > 0)
            {
                int letterInt = rand.Next(97,123);
                char letterChar = Convert.ToChar(letterInt);
                output+= "\""+ letterChar + "\",";
                length--;
            }
            return output;
        }
    }
}
