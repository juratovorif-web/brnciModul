using System.Reflection.Metadata;

namespace darss8hmwwork
{
    internal class Program
    {
        static List<string> Names = new List<string>();
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("1. Create ");
                Console.WriteLine("2. Delete ");
                Console.WriteLine("3. Upadate ");
                Console.WriteLine("4. Read ");

                Console.WriteLine("Tanlang : ");
                string choise = Console.ReadLine();

                if(choise == "1")
                {
                    Console.WriteLine("Enter text : ");
                    string text = Console.ReadLine();
                    CreateNam(text);
                }
                else if(choise == "2")
                {
                    Console.WriteLine("Deleted text : ");
                    string text = Console.ReadLine();
                    DeleteNam(text);
                }
                else if(choise == "3")
                {
                    Console.WriteLine("Old text : ");
                    string oldText = Console.ReadLine();

                    Console.WriteLine("New text");
                    string newText = Console.ReadLine();

                    UpdeteNam(oldText, newText);
                }
                else if (choise == "4")
                {
                    ReadNam();
                }
                Console.ReadKey();
                Console.Clear();
            }


        }

        static void CreateNam(string name)
        {
           Names.Add(name); 
        }
        static void DeleteNam(string name)
        {
            Names.Remove(name);
        }
        static void UpdeteNam(string oldName, string newName)
        {
            var index = Names.IndexOf(oldName);
            if (index != -1)
            {
                Names[index] = newName;
            }
        }
        static void ReadNam()
        {
            foreach (var n in Names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }

    }
}
