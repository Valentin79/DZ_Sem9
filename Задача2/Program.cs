// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");
if(M > N) (M, N) = (N, M); // меняем большее и меньшее

int SumNumbers(int M, int N)
{
    if(M > N) return 0;
    return SumNumbers(M+1, N) + M;
}

Console.WriteLine($"Сумма всех элементов = {SumNumbers(M, N)}");