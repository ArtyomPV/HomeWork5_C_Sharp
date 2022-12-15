//================ Task 1 ==========================
/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, 
 которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
//======= время выполнения 20 минут == (No use copy/paste) ==============
/*
1. Создать метод FillArray()
2. создать методб которы определит четные чиcла в массиве и посчитает их
и выведет в консоль.
*/
// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().NextDouble(100, 1000);
//     }
//     return arr;
//  }

//  void CountQuantityPosElement(int[] arr)
//  {
//     int countQuantityPosElement = 0;
//     int sizeOfArray = arr.Length;
//     for (int i = 0; i < sizeOfArray; i++)
//     {
//         if(arr[i]%2 == 0) countQuantityPosElement++;
//     }
//     Console.WriteLine($"Quantity  of positive elements within array equal {countQuantityPosElement}.");
//  }
// Console.Write("Enter array's size: ");
//  int size = Convert.ToInt32(Console.ReadLine());
//  int[] array =  FillArray(size);
//  CountQuantityPosElement(array);


//================ Task 2 ==========================
/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/* 
1.Создать массив от 0 до 1000
2.Определить количество отрезков элементов от 10 до 99, и посчитать количество элементов
внутри этих отрезков
*/
//======= время выполнения 54 минуты == (No use copy/paste) ==============
// int[] FillArray(int size)
// {
//     int[] array = new int[size]; 
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble(0, 200);
//     }
//     return array; 
// }

// int CountElementsBetweenSomeValue(int[] arr, int num1, int num2) 
// {
//     int length = arr.Length;
//     int count = 0;
//     bool flagStartCount = false;
    
//     for(int i = 0; i < length; i++)
//     {
//         if(arr[i] >= num1 && arr[i] <= num2)              //ищем начало отрезка num1
//         {
//            flagStartCount = true;       //разрешаем подсчет элементов
//         }
        
//         if(arr[i] > num2 || arr[i] < num1)              //ищем конец отрезка num2
//         {
//             flagStartCount = false;     //запрещаем отсчет элементов
//         }
        
//         if(flagStartCount) count ++;    //если разрешен подсчет элемнтов, то считаем количество
//     }
//     return count;
//     Console.Write($"Quantity of array`s elements is {count}");
// }

// void ShowArray(int[] arr)
// {
//     int size = arr.Length;
//     for(int i = 0; i < size; i++)
//     {
//         if (i == size-1) Console.WriteLine($"{arr[i]} ");
//         else Console.Write($"{arr[i]}, ");
//     }
// }

// void ShowCountElements(int number)
// {
//     Console.Write($"Quantity of array`s elements is {number}");
// }
// int size = 123;
// int startNumber = 10;
// int endNumber = 99;

// int[] array = FillArray(size);
// //int[] array = {};
// int count = CountElementsBetweenSomeValue(array, startNumber, endNumber);
// ShowArray(array);
// ShowCountElements(count);


//================ Task 3 =========================

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
1. Метод заполнить массив
2. Метод сумма нечетных чисел
     Определить нечетные позиции массива  и сложить их
*/
//======= время выполнения 19 минут == (used copy/paste method showarray) ==============
// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-100, 100);    
//     }
//     return arr;
// }

// int SumOddElementsArray(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i%2 != 0) sum += arr[i];
//     }
//     return sum;
// }

// void ShowArray(int[] arr)
// {
//     int size = arr.Length;
//     Console.Write("{");
//     for(int i = 0; i < size; i++)
//     {
//         if (i == size-1) Console.Write($"{arr[i]} ");
//         else Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine("}");
// }

// void ShowSumOddElementsArray(int num)
// {
//     Console.Write($"Sum of odd elements of array is {num}");
// }

// int sizeArray = 10;
// int[] array = FillArray(sizeArray);
// int sum =  SumOddElementsArray(array);
// ShowArray(array);
// ShowSumOddElementsArray(sum);

//================ Task 4 ==========================
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
//======= время выполнения 40 минут == (used copy/paste method showarray) ==============
double[] FillArray(int size)
{
    double[] arr = new double[size];
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().NextDouble() +  new Random().Next(-100, 100);
    }
    return arr;
}

double FindMinValue(double[] arr)
{
    double minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]<minValue) minValue = arr[i];
    }
    return minValue;
}

double FindMaxValue(double[] arr)
{
    double maxValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]>maxValue) maxValue = arr[i];
    }
    return maxValue;
}

void ShowArray(double[] arr)
{
    int size = arr.Length;
    Console.Write("{");
    for(int i = 0; i < size; i++)
    {
        if (i == size-1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("}");
}

void ShowDifferenceNumber(double minValue, double maxValue)
{
    double difference = maxValue - minValue;
    Console.WriteLine($" -> {difference:0.00}");
}

int sizeArray = 10;
double[] array = FillArray(sizeArray);
double min = FindMinValue(array);
double max = FindMaxValue(array);
ShowArray(array);
ShowDifferenceNumber(min, max);


//================ Task 5 ==========================
/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/