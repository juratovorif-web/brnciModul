namespace darss4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.4.1 
            //Console.WriteLine(MakeAbba("<<>>", "Orif"));    

            // 1.4.0 - 1
            //var firstNumber = int.Parse(Console.ReadLine());
            //var secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(QowbCqarw(firstNumber, secondNumber));

            //  - 2
            //var stringValue = Console.ReadLine();
            //Console.WriteLine(ReplaceLetters(stringValue));

            // - 3 
            //var text = Console.ReadLine();
            //Console.WriteLine(CountLowerLetters(text));

            // - 4 orasidi toq sonlani sanaw
            //var firstNumber = int.Parse(Console.ReadLine());
            //var secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountOddNumbers(firstNumber, secondNumber));

            // - 5   neci xonaligni topw
            //var son = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountNumberOfDigits(son));

            // - 9  space sanaw
            //var  s = Console.ReadLine();
            //Console.WriteLine(CountSpace(s));

            // - 10 palindrommi dvoti
            //var str =Console.ReadLine();
            //Console.WriteLine(PalindromText(str));

            // - 13    son sanaaw stringi icidan
            //var str = Console.ReadLine();
            //Console.WriteLine(DigitCount(str)); 

            // - 14
            //var str = Console.ReadLine();
            //Console.WriteLine(BigLetters(str));

            // 15
            //var str = Console.ReadLine();
            //Console.WriteLine(IslowerLetters(str));

            ////16
            //var str = Console.ReadLine();
            //Console.WriteLine(BigLettersSmolLetters(str));

            // 17
            //var s = Console.ReadLine();
            //Console.WriteLine(OkCounter(s));

            // 18
            //var str = Console.ReadLine();
            //Console.WriteLine(StarLetterString(str));

           







        }



        static int QowbCqarw(int a, int b)// 1
        {
            return a + b;
        }

        static string ReplaceLetters(string str)// 2
        {
            var res = string.Empty;
            foreach (char i in str)
            {
                if (i == 'x')
                {
                    res += 'y';
                }
                else if (i == 'y')
                {
                    res += 'z';
                }
                else
                {
                    res += i;
                }
            }

            return res;
        }

        static int CountLowerLetters(string str) // 3
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

        static int CountOddNumbers(int firstNumber, int secondNumber) // 4
        {
            var res = 0;
            for (var i = firstNumber; i < secondNumber; i++)
            {
                if (i % 2 != 0)
                {
                    res++;
                }
            }
            return res;
        }

        static int CountNumberOfDigits(int number) // 12
        {
            var res = 0;
            while (number > 0)
            {
                number /= 10;
                res++;
            }

            return res;
        }

        static bool AllDigit(string str) // 11
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


        static int CountSpace(string str) // 9
        {
            var res = 0;
            foreach (var i in str)
            {
                if (i == ' ')
                {
                    res++;
                }
            }
            return res;
        }

        static bool PalindromText(string str)  // 10 palindrommi
        {
            str = str.Replace(" ", "").ToLower();
            return str.SequenceEqual(str.Reverse());
        }

        static int DigitCount(string str) // 13
        {
            var res = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    res++;
                }
            }
            return res;


        }

        static bool BigLetters(string str) // 14
        {

            if (str.Length == 0)
            {
                return false;
            }

            return char.IsUpper(str[0]);
        }

        static bool IslowerLetters(string str) // 15
        {

            if (str.Length == 0)
            {
                return false;
            }

            return char.IsLower(str[0]);
        }

        static string BigLettersSmolLetters(string str) // 16
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    res += char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    res += char.ToUpper(str[i]);
                }
                else
                {
                    res += str[i];
                }

            }
            return res;
        }

        static int OkCounter(string str)  // 17
        {
            var res = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == "ok")
                {
                    res++;
                }
            }
            return res;
        }

        static string StarLetterString(string str) // 18
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    res += '*';
                }
                else
                {
                    res += str[i];
                }
            }
            return res;
        }

        static string LowerAll(string str) // 19
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    res += char.ToUpper(str[i]);
                }
                else
                {
                    res += str[i];
                }
            }
            return res;
        }

        static string UpperLeter(string str) // 20
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    res += char.ToLower(str[i]);
                }
                else
                {
                    res += str[i];
                }
            }
            return res;
        }

        static int AmailCount(string str) // 21
        {
            var count = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '@')
                {
                    count++;
                }
            }
            return count;
        }

        static string HelloName(string str)    //   1.4.1 txt
        {
            var res = string.Empty;

            return res += $"Hello {str}!";
        }

        static string MakeAbba(string a, string b) // 2
        {
            var res = string.Empty;
            return res = $"{a}{b}{b}{a}";
        }

        static string MakeOutWord(string a, string b) // 3
        {
            var res = string.Empty;
            a.Substring(2, a.Length - 2);
            return res = $"{a}{b}";
        }

        static string ExtraEnd(string str)// 4
        {
            var res = string.Empty;
            foreach (char v in str)
            {
                if (str.Length < 2)
                {
                    return str;
                }
                var qow = str.Substring(str.Length - 2, 2);

                return $"{qow}{qow}{qow}";
            }
            return res;




        }

        static string FirstTwo(string str)// 5
        {
            var res = string.Empty;
            foreach (char v in str)
            {
                if (str.Length > 2)
                {
                    return str;
                }
                var qow = str.Substring(str.Length - 2, 2);

                return $"{qow}{qow}{qow}";
            }
            return res;





        }

        static string FirstHarf(string str)// 6
        {
            var harf = str.Length / 2;             
            return str.Substring(0, harf);
        }

        static string WithOutEnd(string str , string secondText) // 7
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (str.Length < 2)
            {
                return string.Empty;
            }
            return str.Substring(1, str.Length - 2);

            if (secondText == null)
            {
                throw new ArgumentNullException(nameof(secondText));
            }
            else if (secondText.Length < 2)
            {
                return string.Empty;
            }
            return str.Substring(1, secondText.Length - 2);
        }
    }
}
