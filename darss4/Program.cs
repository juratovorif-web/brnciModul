namespace darss4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Foundation";

            ///
            Console.WriteLine(MakeAbba("<<>>", "Orif"));
        }


        static int QowbCqarw(int a, int b)
        {
            return a + b;
        }

        static string ReplaceLetters(string str)
        {
            var res = string.Empty;
            foreach (char i in str)
            {
                if (i == 'x') res += 'y';
                else if (i == 'y') res += 'z';
                else res += i;
            }

            return res;
        }

        static int CountLowerLetters(string str)
        {
            var res = 0;
            foreach (char i in str)
            {
                if (char.IsLower(i))
                {
                    res++;
                }
            }
            return res;
        }

        static int CountOddNumbers (int firstNumber, int secondNumber )
        {
            var res = 0;
            for (var i = firstNumber; i < secondNumber; i++)
            {
                if ( i % 2 != 0 )
                {
                    res++;
                }
            }
            return res;
        }

        static int CountNumberOfDigits(int number)
        {
            var res = 0;
            while(number > 0)
            {
                number /= 10;
                res++;
            }

            return res;
        }

        static bool AllDigit(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        static string MakeAbba(string a, string b)
        {
            var res = string.Empty;
            res += a.Substring(0, 2);
            res += b;
            res += a.Substring(2);
            return res;
        }
    }
}
