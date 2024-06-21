using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int mode = 1;
            while (mode==1) {
                Random rnd = new Random();
                int number1=rnd.Next(1,13),
                    number2=rnd.Next(1,13),
                    number3=rnd.Next(1,13),
                    number4=rnd.Next(1,13);

                    
                
                Console.WriteLine("１つ目のカードの数字{0}", number1);

                Console.WriteLine("２つ目のカードの数字{0}", number2);

                Console.WriteLine("３つ目のカードの数字{0}", number3);

                Console.WriteLine("４つ目のカードの数字{0}", number4);

                Console.WriteLine("{0},{1},{2},{3}", number1, number2, number3, number4);

                if (number1 == number2 && number1 == number3 && number1 == number4)
                {
                    Console.WriteLine("フォーカード!!!!");
                }
                else if ((number1 == number2 && number1 == number3) || (number1 == number2 && number1 == number4) || (number1 == number3 && number1 == number4) || (number2 == number3 && number3 == number4))
                {
                    Console.WriteLine("スリーカード!!!");
                }
                else if ((number1 == number2 && number3 == number4) || (number2 == number3 && number1 == number4) || (number1 == number3 && number2 == number4))
                {
                    Console.WriteLine("ツーペア!!");
                }
                else if ((number1 == number2) || (number2 == number3) || (number3 == number4) || (number1 == number3) || number1 == number4 || (number2 == number4))
                {
                    Console.WriteLine("ワンペア!");
                }
                else
                {
                    Console.WriteLine("ノーペア...");
                }

                Console.WriteLine("もう一度やりますか<Y＝1：N＝0>");
                mode=int.Parse(Console.ReadLine());

                Console.ReadLine();
            }
        }
    }
}
