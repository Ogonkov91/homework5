


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int arrayLenght, arrayMaxValue, arrayMinValue, sum ;



int[] arrayInt = { };

            arrayLenght = 5;
            arrayMaxValue = 100;
            arrayMinValue = -100;
            sum = 0;

            arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

            for (int i = 1; i < arrayLenght; i += 2)
            {
                sum += arrayInt[i];
            }

            Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");
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