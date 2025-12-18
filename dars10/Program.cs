using Microsoft.Win32.SafeHandles;

namespace dars10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afu student = new Afu();

            //student.Studet = " 4 kurs ";
            //student.Name = "Ibrohm";
            //student.Surname = "Gulomov";
            //student.Age = 22;
            //student.Email = "gulomovibrohim@gmail.com";
            //student.PhoneNum = "+998900642244";

            //Console.WriteLine(student.Studet);
            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.Surname);
            //Console.WriteLine(student.Age);
            //Console.WriteLine(student.Email);
            //Console.WriteLine(student.PhoneNum);
            //Console.WriteLine();

            //Afu studentka = new Afu();

            //studentka.Studet = "3 kurs";
            //studentka.Name = "Xafiza";
            //studentka.Surname = "Bohodirova";
            //studentka.Age = 22;
            //studentka.Email = "bohodirovaxafiza@gmail.com";
            //studentka.PhoneNum = "+998987654321";

            //Console.WriteLine(studentka.Studet);
            //Console.WriteLine(studentka.Name);
            //Console.WriteLine(studentka.Surname);
            //Console.WriteLine(studentka.Age);
            //Console.WriteLine(studentka.Email);
            //Console.WriteLine(studentka.PhoneNum);
            // ------------------------------------------------------------------------------------------------------------


            //PhoneModel modelApple = new PhoneModel();

            //modelApple.ModelPhone = "17 pro ";
            //modelApple.Sistem = "Ios";
            //modelApple.Ram = 12 ;
            //modelApple.Memory = 512;
            //modelApple.YearOfManufacture = 2025;
            //modelApple.CameraQuality = "48 mp";
            //modelApple.BatteryCapacity = "4252 A";

            //Console.WriteLine(modelApple.ModelPhone);
            //Console.WriteLine(modelApple.Sistem);
            //Console.WriteLine($"{modelApple.Ram}/{modelApple.Memory}");
            //Console.WriteLine(modelApple.YearOfManufacture);
            //Console.WriteLine(modelApple.CameraQuality);
            //Console.WriteLine(modelApple.BatteryCapacity);

            PhoneModel modelSamsung = new PhoneModel();

            modelSamsung.ModelPhone = "Samsung A55 ";
            modelSamsung.Sistem = "Android";
            modelSamsung.Ram = 8;
            modelSamsung.Memory = 256;
            modelSamsung.YearOfManufacture = 2024;
            modelSamsung.CameraQuality = "50 mp";
            modelSamsung.BatteryCapacity = "5000 A";

            Console.WriteLine(modelSamsung.ModelPhone);
            Console.WriteLine(modelSamsung.Sistem);
            Console.WriteLine($"{modelSamsung.Ram}/{modelSamsung.Memory}");
            Console.WriteLine(modelSamsung.YearOfManufacture);
            Console.WriteLine(modelSamsung.CameraQuality);
            Console.WriteLine(modelSamsung.BatteryCapacity);









        }
    }
}
