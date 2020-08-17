using System;
using System.Configuration;
using System.Linq.Expressions;

namespace ConsoleApplication2
{
    class Program
    {
      
        static void Main()
        { 
            // ExerciseOne();
            // ExerciseTwo();
            // ExerciseThree();
            // ExerciseFour();
            // ExerciseFive();
            // ExerciseSix();
            // ExerciseSeven();
            // ExerciseEight();
            // ExerciseNine();
            // ExerciseTen();
            // ExerciseEleven();
            // ExerciseTwelve();
            ExerciseThirteen();

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
            /* Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
            jest rokiem przestępnym.
                Dane testowe : 2016 */

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

        public static void ExerciseFive()
        {
            /*Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
            uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
            prezydenta.
            Dane testowe : 21
            Rezultat w terminalu :
            Możesz zostać posłem*/

            int age;
            Int32.TryParse(Console.ReadLine(), out age);
            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać tylko posłem.");
            }
            else if(age > 30)
            {
                Console.WriteLine("Możesz zostać Posłem i Senatorem natomiast nie możesz prezydentem.");
            }
            else if (age > 35)
            {
                Console.WriteLine("Możesz zostać posłem,santorem i prezydentem");
            }
        }

        public static void ExerciseSix()
        {
            /*Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
            wymyśloną kategorię wzrostu.
            Dane testowe : 140
            Rezultat w terminalu :
            Jesteś krasnoludem*/
            int height;
            Int32.TryParse(Console.ReadLine(), out height);
            if (height <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height > 140 && height < 170) 

            {
                Console.WriteLine("Jesteś niskim"); 
            }
            else if (height >= 170 && height < 190)
            {
                Console.WriteLine("Jesteś średniego wzrostu");
            }
            else
            {
                Console.WriteLine("Jesteś wysoki");
            }
        }
        public static void ExerciseSeven()
        {
            int a, b, c;
            
            Console.WriteLine("Podaj trzy liczby");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Int32.TryParse(Console.ReadLine(), out c);
            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(max);
        }

        public static void ExerciseEight()
        {
            int math, physic, chemistry;
            Console.WriteLine("Podaj swoje wyniki z matury w kolejności: Matma,Fizyka,Chemia");
            Int32.TryParse(Console.ReadLine(), out math);
            Int32.TryParse(Console.ReadLine(), out physic);
            Int32.TryParse(Console.ReadLine(), out chemistry);
            if (math > 70 && physic > 55 && chemistry > 45 && math + chemistry + physic > 180
            || math + chemistry > 150 || math + physic > 150) 
            {
                Console.WriteLine("Kandyat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Niestety masz za słaby wyniki spróbuj ponownie za rok.");
            }

        }

        public static void ExerciseNine()
        {
            int temp;
            Console.WriteLine("Podaj temperature: ");
            Int32.TryParse(Console.ReadLine(), out temp);
            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp > 0 && temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("zaczyna być słabo,bo gorąco");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            } 
        }

        public static void ExerciseTen()
        {
            int a, b, c;
            Console.WriteLine("Podaj boki trójkąta w kolejności - A, B, C");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Int32.TryParse(Console.ReadLine(), out c);
            if (a > b + c || b > a + c || c > a + b)
            {
                Console.WriteLine("Możesz stworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("Nie możesz stworzyć trójkąta.");
            }
        }

        public static void ExerciseEleven()
        {
            int grade;
            Console.WriteLine("Podaj ocene od 1 do 6:");
            Int32.TryParse(Console.ReadLine(), out grade);
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2: 
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
                default:
                    Console.WriteLine("Podałeś liczbę spoza zakresu ocen");
                    break;
            }
        }

        public static void ExerciseTwelve()
        {
            Console.WriteLine("Podaj dzień tygodnia od 1 do 7");
            int weekDay;
            Int32.TryParse(Console.ReadLine(), out weekDay);

            var output = weekDay switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thrusday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
            };
            Console.WriteLine(output);

        }

        public static void ExerciseThirteen()
        {
            int choose;
            
            int firstNumber, secondNumber;
            Console.WriteLine("Enter first number :");
            Int32.TryParse(Console.ReadLine(), out firstNumber);
            
            Console.WriteLine("Enter Second Number:");
            Int32.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Enter the number of the operation to be performed");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Dividing");
            
            Int32.TryParse(Console.ReadLine(), out choose);
            var output = choose switch
            {
                1 => firstNumber + secondNumber,
                2 => firstNumber - secondNumber,
                3 => firstNumber * secondNumber,
                4 when secondNumber == 0 =>  throw new Exception("you can't divide by 0.. duh"),
                4 => firstNumber / secondNumber,
            };
            Console.Write($"result: {output}");

        }
    }
}