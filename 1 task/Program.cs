//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.Write("Сколько чисел?:");
int numbersize = int.Parse(Console.ReadLine());

int[]array = new int [numbersize];

int[] getarray(int [] array)
{
    int index = 0;
    for(int i=1;i<array.Length+1;i++)
    {
        System.Console.Write($"Введите число "+ i + ":");
        int result = int.Parse(Console.ReadLine());
        array[index] = result;
        index = index + 1;
    }
   return array;
}

int[] result = getarray(array);

//System.Console.WriteLine(string.Join(",",result));

int getresult(int [] result)
{
    int answer = 0;
    int index = 0;
    for(int i=0;i<numbersize;i++)
    {
        if(result[index]>0)
        {
            answer = answer +1;
        }
        index = index+1;
    }


    return answer;
}

int finallyresult = getresult(result);

System.Console.WriteLine($"Колличество чисел больше 0: "+ finallyresult);