//Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number1;
int number2;
int number3;
number1 = Prompt("Введите первое число ");
number2 = Prompt("Введите второе число ");
number3 = Prompt("Введите третье число ");

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

System.Console.WriteLine(max);