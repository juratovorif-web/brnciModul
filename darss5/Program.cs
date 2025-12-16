using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace darss5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("List lengthni kritin: ");         // 1.
            //int n = int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("List array kritin: ");
            //    int num = int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //}
            //int result = ListCountThreeDigit(ints);
            //Console.WriteLine("3 xonali sonlar miqdori: " + result);





            //Console.Write("List lengthni kritin: ");    // 2.
            //int n = int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("List array kritin: ");
            //    int num = int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //}
            //int result = EvenCountInList(ints);
            //Console.WriteLine($"{result} ta juft son bor");





            //var n = int.Parse(Console.ReadLine());   // 3.

            //List<int> ints = new List<int>();

            //for (var i = 0; i < n; i++)
            //{
            //    var num = int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //}
            //int res = OddPlusInList(ints);
            //Console.WriteLine($"{res} toq son yegndisi");



            var n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(var i = 0; i < n; i++ )  
            {
               var num = int.Parse(Console.ReadLine()); 
                list.Add(num);
            }
            var res = OddNumCountInAnswer(list);
            Console.WriteLine(res);
        }



        static int ListCountThreeDigit(List<int> nums) // 1
        {
            var count = 0;

            foreach (var num in nums)
            {
                if ((num >= 100 && num <= 999 || num >= -100 && num <= -999))
                {
                    count++;
                }
            }
            return count;
        }

        static int EvenCountInList(List<int> nums) // 2
        {
            var res = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    res++;
                }
            }
            return res;
        }

        static int OddPlusInList(List<int> nums)    //  3
        {
            var res = 0;
            foreach(var num in nums)
            {
                if(num % 2 != 0)
                {
                    res += num ;
                }
            }
            return res; 
        }

        static int ThreInSevnKarra(List<int> nums) // 4
        {
            var res = 0;
            foreach(int num in nums)
            {
                if (num % 3 == 0 && num % 7 == 0)
                {
                    res++;
                }
            }
            return res;
        }

        static int OddNumCountInAnswer(List<int> nums)
        {
            var res = 0;
            foreach( int num in nums)
            {
               if(num % 2 != 0)
               {
                    var onlik = num % 10;
                    var brli = num / 10;
                    res = onlik + brli;
               }
            }
                    return res;


            
            
        }
    }
}
