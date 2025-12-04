namespace dars3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.1
            //for (var i = 1; i <= 20; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // 1.2
            //for (var i = 25; i <= 100; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.3
            //for (var i = 12; i <= 200; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // 1.5
            //for (var i = 12; i <= 200; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1.6
            //for (var i = 10; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1.7
            //for (var i = 120; i <= 250; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1.8
            //for (var i = 100; i >= 50; --i)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            // 1.9
            //for (var i = 80; i >= 20; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //1.10

            //Console.Write("Enter first son : " );
            //var firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter second son : " );
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if ( i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //1.11
            //Console.Write("Enter first son : ");
            //var firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter second son : ");
            //var secondNumber = int.Parse(Console.ReadLine());

            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 4 == 0 && i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1. 13
            //Console.Write("Enter first son : ");
            //var firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter second son : ");
            //var secondNumber = int.Parse(Console.ReadLine());

            //var res = 1;
            //for (var i = firstNumber; i <= secondNumber; i++)
            //{
            //    if (i % 9 == 0 && i % 5 == 0)
            //    {
            //      Console.WriteLine(i);
            //    }
            //}


            // 1. 14
            var res = 0;
            for (var i = 1; i < 100;  i++)
            {
                if ( i % 2 != 0 )
                {
                    res += i;
                }
            }
                Console.WriteLine(res);





        }
    }
}
