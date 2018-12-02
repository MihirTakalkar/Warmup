using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihirWarmup12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = new string[10];
            // fill an array witth 10 words
            // ask the user for a word
            // tell me how many words in the array start with the same first letter as the users word

            int count = 0;
            string match = "";
            Console.WriteLine("Type a word");
            string user = Console.ReadLine();

            numbers[0] = "cars";
            numbers[1] = "hi";
            numbers[2] = "my";
            numbers[3] = "name";
            numbers[4] = "is";
            numbers[5] = "tim";
            numbers[6] = "tom";
            numbers[7] = "tam";
            numbers[8] = "and";
            numbers[9] = "cool";

            for(int i = 0; i < numbers.Length; i++)
            {
                if(user[0] == numbers[i][0])
                {
                    match += numbers[i] += ",";
                    //Console.WriteLine("The first letter is equal.");
                    count++;
                }
            }
            Console.WriteLine("{0}", count);
            Console.WriteLine("{0}", match);
            Console.ReadKey();
        }
    }
}
