/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в массиве");
        int length = Convert.ToInt32(Console.ReadLine());
        if(length<=0) length=3;
        string[] inputArr = setArray(length);
        string[] outputArr = FilterArray(inputArr);
        Console.WriteLine("[ "+ string.Join(", ", outputArr)+" ]");
    }
    static string[] setArray(int length)
    {
        string[] array = new string[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = getConsoleString("Введите строку #"+(i+1)+": ");
        }
        return array;
    }
    static string getConsoleString(string message){
        string str = "";
        while (true)
        {
            Console.Write(message);
            str = Console.ReadLine();
            if (str?.Length > 0)
            {
                break;
            }
            Console.WriteLine("Неверный ввод, повторите попытку");
        }
        return str;
    }
    static string[] FilterArray(string[] inputArr)
    {
        int count = 0;
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] outputArr = new string[count];
        int index = 0;
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i].Length <= 3)
            {
                outputArr[index] = inputArr[i];
                index++;
            }
        }

        return outputArr;
    }
}