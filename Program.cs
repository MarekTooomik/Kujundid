using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. ruut");
            Console.WriteLine("2. teemant");
            Console.WriteLine("3. ristkülik");
            Console.WriteLine("4. kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    {
                        Ruut();
                        break;
                    }
                case "2":
                    {
                        Teemant();
                        break;
                    }

                case "3":
                    {
                        Ristkülik();
                        break;
                    }
                case "4":
                    {
                        Kolmnurk();
                        break;
                    }

                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;

            }

        }
        private static void Ruut()
        {
            Console.WriteLine("Sisesta Ruudu külje pikkus:");
            int sideLength = int.Parse(Console.ReadLine());

            int area = sideLength * sideLength;
            int perimeter = sideLength * 4;

            Console.WriteLine("Ruudu kuju on:");
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Ruudu ümbermõõt on: " + perimeter);
            Console.WriteLine("Ruudu pindala on: " + area);
        }
            private static void Ristkülik()
            {
                Console.WriteLine("Sisesta külje piku:");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta külje laius:");
                int width = int.Parse(Console.ReadLine());

                int area = length * width;
                int perimeter = 2 * (length + width);

                Console.WriteLine("Ristküliku kuju on:");
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine("Risküliku ümbermõõt on: " + perimeter);
            Console.WriteLine("Risküliku pindala on: " + area);
        }


        private static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga külje pikkus:");
            int sideLength = int.Parse(Console.ReadLine());

            double height = (Math.Sqrt(3) / 2) * sideLength;
            int area = (int)(0.5 * sideLength * height);
            int perimeter = sideLength * 3;

            Console.WriteLine("Kolmnurga kuju on:");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < sideLength + i; j++)
                {
                    if (j >= (sideLength - i - 1) / 2 && j <= (sideLength + i - 1) / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Kolmnurga ümbermõõt on: " + perimeter);
            Console.WriteLine("Kolmnurga pindala on: " + area);
        }

        private static void Teemant()
        {
            Console.WriteLine("Sisesta teemanti diameeter:");
            int diameter = int.Parse(Console.ReadLine());
            int radius = diameter / 2;

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            int perimeter = (int)circumference;

            Console.WriteLine("teemanti kuju on:");
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    if (Math.Sqrt(i * i + j * j) <= radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Teemanti ümbermõõt on: " + perimeter);
            Console.WriteLine("Teemati pindala on: " + area);

        }
    }
}

