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
            
