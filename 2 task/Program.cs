//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите b1:");
int b1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите b2:");
int b2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите k1:");
int k1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите k2:");
int k2 = int.Parse(Console.ReadLine());

int getx(int b1,int b2, int k1,int k2)
{
    int result = 0;
    result = (b2 - b1)/(k1 - k2); 
    return result;
}

int xresult = getx(b1,b2,k1,k2);

int gety(int k1,int xresult,int b1)
{
    int result = 0;
    result = k1 + xresult + b1;
    return result;
}

int yresult = gety(k1,xresult,b1);

System.Console.WriteLine(xresult + yresult);