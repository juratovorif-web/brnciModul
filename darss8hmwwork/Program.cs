using System.Reflection.Metadata;

namespace darss8hmwwork
{
    internal class Program
    {
        static List<string> Person = new List<string>();
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("------ MENU ------");
                Console.WriteLine("1 - Create person");
                Console.WriteLine("2 - Read persons");
                Console.WriteLine("3 - Update person");
                Console.WriteLine("4 - Delete person");
                Console.WriteLine("0 - Exit");
                Console.Write("Tanlovingiz: ");

                int choice;
                bool ok = int.TryParse(Console.ReadLine(), out choice);


                if (choice == 1)
                {
                    Console.Write("Ism kiriting: ");
                    string name = Console.ReadLine();

                    Console.Write("Passport kiriting: ");
                    string passport = Console.ReadLine();

                    CreatePerson(name, passport);
                }
                else if (choice == 2)
                {
                    ReadPerson();
                }
                else if (choice == 3)
                {
                    Console.Write("Passport kiriting: ");
                    string passport = Console.ReadLine();

                    Console.Write("Yangi ism kiriting: ");
                    string newName = Console.ReadLine();

                    UpdatePerson(passport, newName);
                }
                else if (choice == 4)
                {
                    Console.Write("Passport kiriting: ");
                    string passport = Console.ReadLine();

                    DeletePerson(passport);
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Dastur tugadi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Noto‘g‘ri tanlov!");
                }

                Console.ReadKey();
                Console.Clear();
               


            }

        }

        static void CreatePerson(string name, string passport)
        {
            Person.Add(name + "|" + passport);
        }
        static void ReadPerson()
        {
            foreach (var p in Person)
            {
                var parts = p.Split('|');
                Console.WriteLine($"Ism: {parts[0]}, Passport: {parts[1]}");
            }
        }
        static void UpdatePerson(string passport, string newName)
        {
            for (int i = 0; i < Person.Count; i++)
            {
                var parts = Person[i].Split('|');
                var passportFromList = parts[1];

                if (passportFromList == passport)
                {
                    Person[i] = newName + "|" + passportFromList;
                    break;
                }
            }
        }

        static void DeletePerson(string passport)
        {
            for (int i = 0; i < Person.Count; i++)
            {
                var parts = Person[i].Split('|');
                var passportFromList = parts[1];

                if (passportFromList == passport)
                {
                    Person.RemoveAt(i);
                    break;
                }
            }
        }



    }
}
