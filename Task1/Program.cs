//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number1;
int number2;
number1 = Prompt("Введите первое число ");
number2 = Prompt("Введите второе число ");
if (number1 > number2){
    System.Console.WriteLine(number1);
}
else{
System.Console.WriteLine(number2);
}



