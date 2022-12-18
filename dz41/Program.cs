// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается 
// при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


int count = 0;

Console.WriteLine("Введите число: ");

string? num = Console.ReadLine();;

while (num != "stop") 
{
    int num1 = Convert.ToInt32(num);
    if (num1 > 0) count++;
    num = Console.ReadLine();
}

Console.WriteLine(count);






