using System.Xml;

namespace PW1
{
    internal class Program
    {
        static void Main()
        {
            Car first = new Car();
            Console.WriteLine("Введите название машины 1");
            string checkName = Console.ReadLine();
            if (checkName != "")
            {
                first.carName = checkName;
            }
            Console.WriteLine("Введите максимальную скорость машины 1");
            // System.FormatException
            try
            {
                double checkSpeed = Convert.ToDouble(Console.ReadLine());
                if (checkSpeed != 0 || checkSpeed > 50)
                {
                    first.maxSpeed = checkSpeed;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Некорректно введенное значение, присваиваем стандартное");
                Console.WriteLine("");
            }

            first.output();

            Car second = new Car();
            Console.WriteLine("Введите название машины 2");
            checkName = Console.ReadLine();
            if (checkName != "")
            {
                second.carName = checkName;
            }
            Console.WriteLine("Введите максимальную скорость машины 2");
            try
            {
                double checkSpeed = Convert.ToDouble(Console.ReadLine());
                if (checkSpeed != 0 || checkSpeed > 50)
                {
                    second.maxSpeed = checkSpeed;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Некорректно введенное значение, присваиваем стандартное");
                Console.WriteLine("");
            }

            second.output();

            Car third = new Car();
            Console.WriteLine("Введите название машины 3");
            checkName = Console.ReadLine();
            if (checkName != "")
            {
                third.carName = checkName;
            }
            Console.WriteLine("Введите максимальную скорость машины 3");
            try
            {
                double checkSpeed = Convert.ToDouble(Console.ReadLine());
                if (checkSpeed != 0 || checkSpeed > 50)
                {
                    third.maxSpeed = checkSpeed;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Некорректно введенное значение, присваиваем стандартное");
                Console.WriteLine("");
            }
            third.output();

            Car four = new Car();
            Console.WriteLine("Введите название машины 4");
            checkName = Console.ReadLine();
            if (checkName != "")
            {
                four.carName = checkName;
            }
            Console.WriteLine("Введите максимальную скорость машины 4");
            try
            {
                double checkSpeed = Convert.ToDouble(Console.ReadLine());
                if (checkSpeed != 0 || checkSpeed > 50)
                {
                    four.maxSpeed = checkSpeed;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Некорректно введенное значение, присваиваем стандартное");
                Console.WriteLine("");
            }
            four.output();

            double gonkiMaxSpeed = Math.Max(Math.Max(first.maxSpeed, second.maxSpeed), Math.Max(third.maxSpeed, four.maxSpeed));
            
            if (gonkiMaxSpeed == first.maxSpeed)
            {
                Console.WriteLine($"Первым пришел на гоночном треке: {first.carName}");
            }
            if (gonkiMaxSpeed == second.maxSpeed)
            {
                Console.WriteLine($"Первым пришел на гоночном треке {second.carName}");
            }
            if (gonkiMaxSpeed == third.maxSpeed)
            {
                Console.WriteLine($"Первым пришел на гоночном треке {third.carName}");
            }
            if (gonkiMaxSpeed == four.maxSpeed)
            {
                Console.WriteLine($"Первым пришел на гоночном треке {four.carName}");
            }

        }
        class Car
        {
            public double maxSpeed;
            public string carName;
            public Car()
            {
                this.maxSpeed = 120;
                this.carName = "ИЖ Планета 5";
            }
            public Car(double carSpeed, string carName)
            {
                this.maxSpeed = carSpeed;
                this.carName = carName;
            }
            public void output()
            {
                Console.WriteLine($"Название машины: {this.carName}");
                Console.WriteLine($"Максимальная скорость: {this.maxSpeed}");
            }
        }
    }
}