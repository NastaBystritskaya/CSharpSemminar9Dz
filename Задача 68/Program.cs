/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int GetUserInput(string text) {
    System.Console.Write(text);
    int input = int.Parse(System.Console.ReadLine()!);
    return input;
}

int CalcAccerman(int n, int m) {
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return CalcAccerman(n - 1, 1);
        else
            return CalcAccerman(n - 1, CalcAccerman(n, m - 1));
}
 void Main() {
    int m = GetUserInput("Введите M: ");
    int n = GetUserInput("Введите N: ");
    int res = CalcAccerman(n, m);
    System.Console.WriteLine(res);
 }

 Main();
