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
                int number1 = 0, number2 = 0, number3 = 0, number4 = 0;


                while (number1 <= 0 || number1 > 13)
                {
                    Console.Write("１つ目のカードの数字を入力してください");
                    number1 = int.Parse(Console.ReadLine());
                    if (number1 <= 0 || number1 > 13)
                    {
                        Console.WriteLine("もう一度入力してください。");
                    }
                }



                while (number2 <= 0 || number2 > 13)
                {
                    Console.Write("２つ目のカードの数字を入力してください");
                    number2 = int.Parse(Console.ReadLine());
                    if (number2 <= 0 || number2 > 13)
                    {
                        Console.WriteLine("もう一度入力してください。");
                    }
                }

                while (number3 <= 0 || number3 > 13)
                {
                    Console.Write("３つ目のカードの数字を入力してください");
                    number3 = int.Parse(Console.ReadLine());
                    if (number3 <= 0 || number3 > 13)
                    {
                        Console.WriteLine("もう一度入力してください。");
                    }
                }

                while (number4 <= 0 || number4 > 13)
                {
                    Console.Write("４つ目のカードの数字を入力してください");
                    number4 = int.Parse(Console.ReadLine());
                    if (number4 <= 0 || number4 > 13)
                    {
                        Console.WriteLine("もう一度入力してください。");
                    }
                }

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
