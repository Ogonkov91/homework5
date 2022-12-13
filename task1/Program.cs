 // *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            // Напишите программу, которая покажет количество чётных чисел в массиве.
    int arrayLenght, arrayMaxValue, arrayMinValue, count;   
    int[] arrayInt = { };    
            arrayLenght = 6;
            arrayMaxValue = 1000;
            arrayMinValue = 100;
            count = 0;

            arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

            // Console.WriteLine($"[{String.Join("; ", arrayInt)}]");

            for (int i = 0; i < arrayLenght; i++)
            {
                if (arrayInt[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество чётных чисел = {count}");
            WaitingToAnyKey();
            
    


void WaitingToAnyKey() // пауза до нажатия клавиши
{
    Console.Write("Press any key: ");
    Console.ReadKey();
    Console.WriteLine();
}

int[] ArrayIntGenerator(int lenght, int maxValue, int minValue) // рандом генератор для одномерного массива
{
    int[] arrayInt = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        arrayInt[i] = new Random().Next(minValue, maxValue);
        Console.Write(arrayInt[i] + "; ");
    }
    Console.WriteLine();
    return arrayInt;
    }