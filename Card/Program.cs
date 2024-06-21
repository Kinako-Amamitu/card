using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int number1, number2, number3, number4;

            Console.Write("１つ目のカードの数字を入力してください");
        
            number1=int.Parse(Console.ReadLine());
            
            Console.Write("２つ目のカードの数字を入力してください");
        
            number2=int.Parse(Console.ReadLine());
            
            Console.Write("３つ目のカードの数字を入力してください");
        
            number3=int.Parse(Console.ReadLine());
            
            Console.Write("４つ目のカードの数字を入力してください");
        
            number4=int.Parse(Console.ReadLine());

            Console.WriteLine("{0},{1},{2},{3}",number1,number2,number3,number4);

            if(number1 == number2 && number1==number3 && number1==number4)
            {
                Console.WriteLine("フォーカード!!!!");
            }
            else if((number1==number2&&number1==number3)||(number1==number2&&number1==number4)||(number1==number3&&number1==number4)||(number2==number3&&number3==number4))
            {
                Console.WriteLine("スリーカード!!!");
            }
            else if((number1==number2&& number3 == number4)||(number2==number3&&number1==number4)||(number1==number3&&number2==number4))
            {
                Console.WriteLine("ツーペア!!");
            }
            else if((number1 == number2) ||( number2 == number3) || (number3 == number4) || (number1 == number3) ||number1==number4||(number2 == number4))
            {
                Console.WriteLine("ワンペア!");
            }
            else 
            {
                Console.WriteLine("ノーペア...");
            }

            Console.ReadLine();
        }
    }
}
