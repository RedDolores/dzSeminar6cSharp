// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double getNum(string message)
{
    Console.WriteLine(message);
    double num = 0;
    return num = Convert.ToDouble(Console.ReadLine());
}

double k1 = getNum("Введите значение k1: ");
double b1 = getNum("Введите значение b1: ");
double k2 = getNum("Введите значение k2: ");
double b2 = getNum("Введите значение b2: ");

if (k1 != k2) 
{
    double x = (b1 + (-b2)) / (k2 + (-k1));
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых: {x}, {y}");
}
else Console.WriteLine("Прямые параллельны, точки пересечения нет.");


