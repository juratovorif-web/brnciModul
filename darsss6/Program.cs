using System.Text;

namespace darsss6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  - 1
            //Console.WriteLine(Add("a", "s", "s"));     
            //Console.WriteLine(Add(15,4));
            //Console.WriteLine(Add(2.3,4.3,5.3));


            //Console.WriteLine(GetAmountDigit(5));

            // --------------------------------------
            // - 2      bu a ni b  marta cqaradi  gan funksiya
            //var a = int.Parse(Console.ReadLine()); 
            //var b = int.Parse(Console.ReadLine());
            //repeat(a,b);
            // --------------------------------------

            // --------------------------------------      - 6
            //var a = int.Parse(Console.ReadLine());
            //var b = int.Parse(Console.ReadLine());
            //var c = int.Parse(Console.ReadLine());
            //Console.WriteLine(Multiplication(a,b,c));
            // --------------------------------------

            // ------------------------------------------------             - 4
            //Console.WriteLine(NumRoomsCountInTextLenLeters(55555));
            //Console.WriteLine(NumRoomsCountInTextLenLeters("nmagaporif"));
            // -------------------------------------------------

            // ---------------------------------------
            //var a = int.Parse(Console.ReadLine());
            //var b = int.Parse(Console.ReadLine());
            //var c = int.Parse(Console.ReadLine());
            //Console.WriteLine(FindMax(a, b, c ));
            // ---------------------------------------     - 5


            // Console.WriteLine(MyAbs(-9));          //  - 11


            //Console.WriteLine(MyIsUpper('a'));
            //Console.WriteLine(MyIsUpper('Z'));               //  - 12
            //Console.WriteLine(MyIsUpper('%'));

            //Console.WriteLine(MyToUpper('a'));              // -  13

            //Console.WriteLine(MyIsDigik('5'));           // - 14
            //Console.WriteLine(MyIsDigik('d'));

            //Console.WriteLine(MyIsLower('s'));          // - 15
            //Console.WriteLine(MyIsLower('A'));

            //Console.WriteLine(MyToLower('D'));     // - 16

            //Console.WriteLine(MyPow(3,4));     // - 17



            // 1.4.2  # - 1
            //var firstText = Console.ReadLine();
            //var numOne = int.Parse(Console.ReadLine());
            //var secondText = Console.ReadLine();
            //var numTwo = int.Parse(Console.ReadLine());

            //var partOne = firstText.Substring(0, numOne);
            //var partTwo = secondText.Substring(secondText.Length - numTwo, numTwo);

            //var res = partOne + partTwo;
            //Console.WriteLine(res);
            // ---------------------------------------------------------------------------------
            //  1.4.1    # - 2
            //var str = Console.ReadLine();
            //var charr = 'c';

            //StringBuilder stringBuilder = new StringBuilder();

            //for (var i = 0; i < str.Length; i++)
            //{
            //    stringBuilder.Append(str[i]);
            //    if (str[i] == charr)
            //    {
            //        stringBuilder.Append(charr);
            //    }
            //}
            //Console.WriteLine(stringBuilder.ToString());
            // --------------------------------------------------------------


            Console.WriteLine(FirstTexCharSecTex("nmagap" , "ukam", 'p'));    // 1.4.1    # - 3

        }


        static string FirstTexCharSecTex(string s1, string s2, char bel)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in s1)
            {
                sb.Append(ch);     

                if (ch == bel)
                {
                    sb.Append(s2);  
                }
            }

            return sb.ToString();
        }


        static void repeat(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(a);
            }
        } // - 2
        static void repeat(int a, int b)
        {
            for (int i = 1; i <= b; i++)
            {
                Console.WriteLine(a);
            }


        } // -2


        static int Add(int x, int y)
        {
            return x + y;
        }
        static string Add(string a, string b, string c)
        {
            return a + b + c;
        }  // - 1
        static double Add(double o, double r, double f)
        {
            return o + r + f;

        }



        static int Multiplication(int m)
        {
            var res = 1;
            for (int i = 1; i <= m; i++)
            {
                res = res * i;
            }
            return res;

        }
        static int Multiplication(int a, int b)     //    - 6
        {
            var res = 1;
            for (var i = a; i <= b; i++)
            {
                res *= i;
            }
            return res;

        }
        static int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }


        static int NumRoomsCountInTextLenLeters(int n) // - 4
        {
            var res = 0;
            while (n > 0)
            {
                n /= 10;
                res++;
            }
            return res;

        }
        static int NumRoomsCountInTextLenLeters(string str) // - 4
        {
            var count = 0;
            foreach (var i in str)
            {
                char.IsLetter(i);
                count++;
            }
            return count;
        }


        static int FindMax(int a, int b, int c) //  - 5
        {
            var max = 0;
            if (a > b)
            {
                max = a;
            }
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                c = max;
            }
            return max;
        }

        static int FindMax(int o, int r, int i, int f)  // - 5
        {
            var max = o;
            if (r > max)
            {
                max = r;
            }
            if (i > max)
            {
                max = i;
            }
            if (f > max)
            {
                max = f;
            }
            return max;

        }

        static int MyAbs(int num) // - 11
        {
            if (num < 0)
            {
                num = -num;
            }
            return num;
        }

        static bool MyIsUpper(char ch) // - 12
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                return true;
            }
            return false;
        }

        static char MyToUpper(char ch) // - 13
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                return ch;
            }
            return (char)(ch - 32);
        }

        static bool MyIsDigik(char ch) // - 14
        {
            if (ch >= '0' && ch <= '9')
            {
                return true;
            }
            return false;


        }

        static bool MyIsLower(char ch) // - 15
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }
            if (ch >= 'a' && ch <= 'z')
            {
                return true;
            }
            return false;
        }

        static char MyToLower(char ch)   // - 16
        {

            if (ch >= 'a' && ch <= 'z')
            {
                return (char)(ch - 32);
            }
            return ch;
        }

        static int MyPow(int a, int b) // - 17 
        {
            var res = 1;
            for (var i = 0; i < b; i++)
            {
                res *= a;
            }
            return res;

        }


    }

}
