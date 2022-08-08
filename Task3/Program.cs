//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number;
number = Prompt("Введите число ");
int evennumber = number % 2;
if (evennumber == 0){
    System.Console.WriteLine("Число четное");
}
else{
    System.Console.WriteLine("Число нечетное");
}