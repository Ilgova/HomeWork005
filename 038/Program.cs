// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Write("Введите количество элементов в массиве : ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[sizeArray];
myArrayRandom(myArray);
ShowArray(myArray);
int min = myArray.Min();
int max = myArray.Max();
Console.WriteLine($" разница между максимальным и минимальным элементов массива = {max - min}");

void myArrayRandom(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
    myArray[i] = new Random().Next(0,100);
    //Console.Write(myArray[i]);
    }
}

void ShowArray(int[] myArray)
{
    Console.Write("[");
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.Write("]");
}
