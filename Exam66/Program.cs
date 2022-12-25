/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

System.Console.Write("Введите значение M:");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите значение N:");
int N = int.Parse(Console.ReadLine()!);

int SumElements(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return start+SumElements(start+1,end);
}
System.Console.WriteLine(SumElements(M,N));
