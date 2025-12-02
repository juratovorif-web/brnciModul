namespace dars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dayValue = int.Parse(Console.ReadLine());
            var timeValue = int.Parse(Console.ReadLine());
            var res = $"{ dayValue * 24 + timeValue}  >>> soat ";
            Console.WriteLine(res);
        }
    }
}
