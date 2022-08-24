/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int n, m, s=0;
Console.Write("Введите N: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите M: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
   { if (i % 1 == 0) 
s=s+i;    
}
Console.WriteLine(s);

