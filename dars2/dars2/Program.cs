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


            var firstNumber = int.Parse(Console.ReadLine());    
            var secondNumber = int.Parse(Console.ReadLine());    
            var theriNumber = int.Parse(Console.ReadLine());

            var temp = firstNumber;
            if (temp > secondNumber && theriNumber < temp)
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
