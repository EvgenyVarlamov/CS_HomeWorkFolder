//  ДЗ: программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число больше 1");
int numberN = Convert.ToInt32(Console.ReadLine());   // Ввод числа
int numberCount = 0;                                 // Переменная для работы цикла

if(numberN > 1)                                      // Проверка введенного числа
  {
   Console.Write("Чётные числа: ");
   while(numberCount < numberN)                      // Перебор от нуля до введенного числа
   {
      numberCount++;
      if(numberCount%2 == 0)
         {
          Console.Write(numberCount + ", ");         // Вывод чётных чисел
         }
   }
  }
else Console.Write("Вы ввели некорректное число");   // Вывод сообщения о некорректно введенном числе