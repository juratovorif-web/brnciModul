namespace darss4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Foundation";

            var res = str.Substring(1, str.Length - 3);
            Console.WriteLine(res);
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
    }

}
