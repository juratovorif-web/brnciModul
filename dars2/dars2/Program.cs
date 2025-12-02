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

            Console.Write("akmalni daqiqasga newta belgi yozad :");
            var akmalEnterStringNumbers = int.Parse(Console.ReadLine());
            var belgilar = akmalEnterStringNumbers * 2.5;
            var soz = belgilar / 5;
             
           
            Console.WriteLine($"{soz} ta yozdi");
        }
    }
}
