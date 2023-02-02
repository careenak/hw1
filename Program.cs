// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

            Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
            Console.WriteLine("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("Первое число " + x + " больше чем второе " + y);
            }
            else
            {
                Console.WriteLine("Второе число " + y + " больше чем первое " + x);
            }
 // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            Console.WriteLine("Введите первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int max = n1;

            if (n2 > max)
            {
                max = n2;
            }

            if (n3 > max)
            {
                max = n3;
            }

            Console.WriteLine("Самое большое из введённых чисел: " + max);
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("Число " + n + " нечетное");
            }
            else
            {
                Console.WriteLine("Число " + n + "четное");
            } 

