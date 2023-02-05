//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов в массиве");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[sizeArray];
myArrayRandom(myArray);
Console.WriteLine("Случайный массив: ");
ShowArray(myArray);

void myArrayRandom(int[] myArray)
{
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(100,1000);
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

int count = 0; 

for (int j = 0; j < myArray.Length; j++)
if (myArray[j] % 2 == 0)

count++;

Console.Write($" -> {count}"); //количество чётных чисел в массиве

    
