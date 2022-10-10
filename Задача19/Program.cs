// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.Clear();
Console.WriteLine("Программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. ");

//Объявление массива
int[] arr = new int [5];
int bigNumber;
int del = 10000;
int index = 0;


Console.WriteLine("Введите пятизначное число: ");
bigNumber = int.Parse(Console.ReadLine()!);

for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = bigNumber / del % 10;
        del /= 10;
    }

if ((arr[index] == arr[arr.Length-1]) && (arr[index+1] == arr[arr.Length-2]))
    {Console.WriteLine($"Число является палиндромом "); }
else
    {Console.WriteLine($"Число не является палиндромом "); }
