﻿// ДЗ: программа, которая принимает на вход 3-х значное число, а на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите 3-х значное число от 100 до 999");          // Вывод сообщения с критериями к числу
int number = Convert.ToInt32(Console.ReadLine());                      // Ввод числа

if(number > 99 && number < 1000)                                       // Проверяется введенное число заданному критерию
  {
   int result = number%10;                                             // Рассчитывается остаток от деления на 10, что соответствует последней цифре введенного числа
   Console.WriteLine("Последняя цифра введенного числа = " + result);  // Вывод сообщения и последней цифры
  }
else Console.WriteLine("Вы ввели некорректное число");                 // Вывод сообщения, если число введено не в соответствии с критерием