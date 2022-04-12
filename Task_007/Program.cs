//  ДЗ программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");                 // Вывод информационного сообщения
int numberFirst = Convert.ToInt32(Console.ReadLine());     // Ввод первого числа
Console.WriteLine("Введите второе число");                 // Вывод информационного сообщения
int numberSecond = Convert.ToInt32(Console.ReadLine());    // Ввод второго числа 
Console.WriteLine("Введите третье число");                 // Вывод информационного сообщения
int numberThird = Convert.ToInt32(Console.ReadLine());     // Ввод третьего числа

int max = numberFirst;                                     // Присвоение переменной мах значания первого числа
if(numberSecond > max) max = numberSecond;                 // Сравнение переменной мах значания и второго числа
if(numberThird > max) max = numberThird;                   // Сравнение переменной мах значания и третьего числа

Console.WriteLine("Наибольшее число =  " + max);           // Вывод сообщения и наибольшего значения