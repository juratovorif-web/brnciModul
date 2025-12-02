namespace dars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            var son = int.Parse(Console.ReadLine());
            var son2 = int.Parse(Console.ReadLine());   
            var res = son * son2;
            Console.WriteLine(res);
        }
    }
}
