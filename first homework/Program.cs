using System;
namespace AnastasiaStepanovaDZ { 
    class program {
        static void Main(string[] args)
        {
            Console.WriteLine("1 номер");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");

            Console.WriteLine("2 номер");
            Console.WriteLine("Введите первое число");
            string first = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string second = Console.ReadLine();
            bool result = int.TryParse(first, out var f) & int.TryParse(second, out var o);
            if (result = true)
            {
                Console.WriteLine($"{o}");
                Console.WriteLine($"{f}");
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }

            Console.WriteLine("3 номер");
            Console.WriteLine("Введите радиус окружности");
            int radius = Convert.ToInt32(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Длина окружности равна {circumference}");

            Console.WriteLine("4 номер");
            Console.WriteLine("y = cos(x)");
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Cos(x));

            Console.WriteLine("5 номер");
            Console.WriteLine("Введите коэффициенты квадратного уравнения:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {root1}, x2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {root}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }

            Console.WriteLine("6 номер");
            Console.WriteLine("Введите значение a");
            int aw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int bw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            int cw = Convert.ToInt32(Console.ReadLine());
            int bo = cw;
            int ao = bw;
            int co = aw;
            Console.WriteLine($"a) a={ao} b={bo} c={co}");
            int be = aw;
            int ce = bw;
            int ae = cw;
            Console.WriteLine($"b) a={ae} b={be} c={ce}");


            Console.WriteLine("7 номер");
            Random random = new Random();
            Console.WriteLine("Случайные числа:");
            for (int i = 0; i < 4; i++)
            {
                int randomnumber = random.Next();
                Console.WriteLine(randomnumber);
            }
       

            Console.WriteLine("8 номер");
            Console.WriteLine("Введите трёхзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int last = number % 10;
            int numb = last * 100 + number / 10;
            Console.WriteLine(numb);

            Console.WriteLine("9 номер");
            Console.WriteLine("Введите стоимость конфет за кг");
            int sweets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость печенья за кг");
            int cookies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость яблок за кг");
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество купленных конфет в кг");
            int numberofsweets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество купленного печенья в кг");
            int numberofcookies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество купленных яблок в кг");
            int numberofapples = Convert.ToInt32(Console.ReadLine());
            int cost = sweets * numberofsweets + cookies * numberofcookies + apples * numberofapples;
            Console.WriteLine($"Стоимость всей покупки = {cost}");



        } 
     }
}
        
    
