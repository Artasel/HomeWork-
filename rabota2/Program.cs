// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*в общем, приравниваем правые части данных равенств:
k1*x+b1=k2*x+b2
выразим отсюда x:
x=(b2-b1)/(k1-k2)
затем подставим полученное значение х в выражение для у (для любого, например первого) :
y=k1(b2-b1)/(k1-k2)+b1
ответ: x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1
*/

Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

double y = 5 * (4 - 2) / (5 - 9) + 2;          //выполняются по разному и имеют разный результат. странно, ведь это одно и тоже
double y2 = k1 * (b2 - b1) / (k1 - k2) + b1;   //выполняются по разному и имеют разный результат. странно, ведь это одно и тоже

Console.WriteLine($"y равен = {y}");
Console.WriteLine($"({x}; {y2})");