//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов в массиве");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[sizeArray];
myArrayRandom(myArray);
Console.WriteLine("Случайный массив: ");
ShowArray(myArray);
int result = 0;

void myArrayRandom(int[] myArray)
{
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(-100,100);
}
}

void ShowArray(int[] myArray)
{
    Console.Write("[");
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ",");
    }
    Console.Write("]");
}
for(int i = 0; i < myArray.Length; i++)
if (myArray[i] % 2 != 0)
{
    result = result + myArray[i];
}
System.Console.WriteLine($" -> {result}"); //сумма элементов, стоящих на нечётных позициях



