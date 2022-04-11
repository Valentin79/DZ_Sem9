// Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int x = Prompt("Введите число 1: ");
int y = Prompt("Введите число 2: ");
while (y == x)
{
    y = Prompt("Не-не-не, другое число: ");  // Немножко улыбки
}

if(x > y) (x, y) = (y, x);  // что бы было не важно, какое число больше. В теле метода вызывает лишний вывод.
NatureEvenRow(x , y);
void NatureEvenRow(int x, int y)
{
    if(x >= y) return;
    if(x%2 != 0)  x++;
    Console.Write(x +", ");
    NatureEvenRow(x+1 , y);
}