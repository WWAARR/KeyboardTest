using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTest
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            var rand = new Random();
            int a = 1;
            for (int i = 0; i < a; i++)
            {
            Console.Write((char)rand.Next(65, 90));//97,122
            }
            string S = Console.ReadLine();
            Console.Write("\n");
            var F = Convert.ToString(S);
            */
            Random rand = new Random();
            int[] arr = new int[20];
            //int[] arr1 = new int[20];

            for (int i = 0; i < 15; i++)
            {
                if (i % 3 == 0 && i > 0)
                {
                    arr[i] = '_';
                    i++;
                }
                arr[i] = rand.Next(97, 122);//Little
                //arr1[i] = rand.Next(65, 90);//Large
            }
            for (int i = 0; i < 1; i++)
            {
               Console.Write((char)arr[i]);
            }
            int S = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
            if (S == Convert.ToChar(arr[0]))
            {
                Console.WriteLine("Вы быстры!");
            }
            else
            {
                Console.WriteLine($"\aВы не правы. :C");
            }
        }
    }
}
