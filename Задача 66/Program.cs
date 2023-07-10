/*

Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int GetUserInput(string text) {
    System.Console.Write(text);
    int input = int.Parse(System.Console.ReadLine()!);
    return input;
}

void PrintNumbers(int start, int end, int sum) {
    if (start <= end) {
        sum = sum + start;
        start++;
        PrintNumbers(start, end, sum);
    }
    else {
        System.Console.WriteLine(sum);
    }
}
 void Main() {
    int start = GetUserInput("Введите первое число: ");
    int end = GetUserInput("Введите второе число: ");
    PrintNumbers(start, end, 0);
 }

 Main();

