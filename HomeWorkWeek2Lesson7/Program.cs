using System;

namespace HomeWorkWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree();
            ExerciseFour();
        }

        public static void ExerciseOne()
        {
            // Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
            // one równe czy nie.
            //     Dane testowe:
            // a : 5
            // b : 5
            // Rezultat w terminalu :
            // 5 i 5 są równe 
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine($"{a} i {b}  są równe.");
            }
        }

        public static void ExerciseTwo()
        {
            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            // jest parzysta czy nieparzysta.
            //     Dane testowe : 15
            // Rezultat w terminalu :
            // 15 jest liczbą nieparzystą
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            if (a % 2 == 0)
            {
                Console.WriteLine($"liczba: {a} - jest parzysta.");
            }
            else
            {
                Console.WriteLine($"liczba: {a} - jest nieparzysta.");
            }
        }

        public static void ExerciseThree()
        {
            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            // jest dodatnia czy ujemna.
            //     Dane testowe : 14
            // Rezultat w terminalu :
            // 14 jest liczbą dodatnią
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            if (a > 0)
            {
                Console.WriteLine($"Liczba {a} jest dodatnia.");
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest ujemna.");
            }

        }

        public static void ExerciseFour()
        {
            int year;
            Int32.TryParse(Console.ReadLine(), out year);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"Rok: {year} jest przestępny");
            }
            else
            {
                Console.WriteLine($"Rok: {year} jest nieprzestępny");
            }
        }
    }
}