using System.Transactions;

namespace dars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * var dayValue = int.Parse(Console.ReadLine());
            var timeValue = int.Parse(Console.ReadLine());
            var res = $"{ dayValue * 24 + timeValue}  >>> soat ";
            Console.WriteLine(res); 
            */

            /*
            Console.Write("patriki puli enter : ");
            var patrikCash = int.Parse(Console.ReadLine());
            Console.Write("juliyani puli enter : ");
            var juliyaCash = int.Parse(Console.ReadLine());

            var res = $"patrik {patrikCash -  juliyaCash} som pul bersa julyani puli tenglawadi";
            Console.WriteLine(res);
            */

            /*
            Console.Write("akmalni daqiqasga newta belgi yozad :");
            var akmalEnterStringNumbers = int.Parse(Console.ReadLine());
            var belgilar = akmalEnterStringNumbers * 2.5;
            var soz = belgilar / 5;
             
           
            Console.WriteLine($"{soz} ta yozdi");
            */
            /**
            Console.Write("Enter bino: ");
            var binoVAlue = int.Parse(Console.ReadLine());  
            Console.Write("Enter qavat: ");
            var qavatValue = int.Parse(Console.ReadLine());
            Console.Write("Enter xona: ");
            var xonaValue = int.Parse(Console.ReadLine());
            Console.Write("Enter stul: ");
            var stulValue = int.Parse(Console.ReadLine());


            var parta = (binoVAlue * xonaValue) + (qavatValue * stulValue);
            var res = parta / 2;
            Console.WriteLine($"{res} ta parta bor!");
            **/


            /**
            Console.Write("Enter number : ");
            var n = int.Parse(Console.ReadLine());

            var onlik = n % 10;
            var brlik = n / 10;
           
            if (onlik + brlik > 10)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            */


            var kopaytmaYgrmadanOwsa = int.Parse(Console.ReadLine());

            var onlik = kopaytmaYgrmadanOwsa % 10;
            var brlik = kopaytmaYgrmadanOwsa / 10;
            if (onlik * brlik > 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
        }
    }
}
