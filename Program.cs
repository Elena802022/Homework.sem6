//Задача 41. Пользователь вводит N чисел с клавиатуры. Сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Enter the numbers: ");
int[] numbers=GetArrayFromString(Console.ReadLine()!);
Console.WriteLine($"The number of numbers greater then zero {GetCountPositiveElements(numbers)}");
Console.WriteLine();

int[] GetArrayFromString(string StringArray)
{
    string[]nums=StringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int [nums.Length];
    for(int i=0; i <result.Length; i++)
    {
        result[i]=int.Parse(nums[i]);
    }
    return result;
}
int GetCountPositiveElements(int[]array)
{
    int count=0;
    foreach(var item in array)
    {
        if (item>0) count++;
    }
      return count;  
    }

//Задача 43
//Написать программу, которая принимает массив из любого количества элементов (не менее 6). В проимежутке от 0-100, а на выходе выводит этот же массив, но отсортированный по возрастанию (от меньшего числа к большему).

int[]array=GetArray(10, 0, 100);
Console.WriteLine($"{String.Join(",",array)}");
Console.WriteLine();
ReverseArr(array);
Console.WriteLine($"{String.Join(",", array)}");

int []GetArray(int size, int minValue, int maxValue)
{
    int[] result=new int [size];
    for(int i=0; i<size; i++)
    {
        result[i]=new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int[] ReverseArr(int[] arr)
{
    for(int i=0; i<arr.Length-1; i++)
    {
        for(int j=i+1; j<arr.Length; j++)
        {
         if(arr[j]<arr[i])
        {
        int temp=arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
        }
        } 
       
    }
    return arr;
}
    