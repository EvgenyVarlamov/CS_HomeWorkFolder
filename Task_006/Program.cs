// ДЗ: программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");                                                             // Вывод информационногосообщения
int firstNumber = Convert.ToInt32(Console.ReadLine());                                                 // Ввод первого числа
Console.WriteLine("Введите второе число");                                                             // Вывод информационногосообщения
int secondNumber = Convert.ToInt32(Console.ReadLine());                                                // Ввод второго числа 

if(firstNumber == secondNumber)                                                                        // Сравнение чисел
  {
    Console.WriteLine("Первое число " + firstNumber  + " и второое число " + secondNumber + " равны"); // Вывод сообщения и чисел по результатам сравнения
  }
if(firstNumber > secondNumber)
  {
    Console.WriteLine("Первое число " + firstNumber  + " больше второго числа " + secondNumber);
  }   
if(firstNumber < secondNumber)
  {
   Console.WriteLine("Первое число " + firstNumber  + " меньше второго числа " + secondNumber);
  }