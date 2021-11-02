// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые:

// нарушают порядок возрастания
// больше среднего арифметического элементов A
// чётные


//int GetRandom(int minValue, int maxValue)

//Задать массив

int index = 0;

int[] array = new int[10];

// Заполняет массив
while (index <10)
{
    array[index] = new Random().Next(10, 100); // [10, 99)
    index++;
}
index = 0;

// Печатает массив
while (index <= 9) 
{
    int val = array[index]; 
    Console.WriteLine(val);
    index++;
}
Console.WriteLine();
index = 1;

// Исключение элеменотов нарушения возрастания
int currentElement = array[0];
Console.WriteLine("Элементы нарушающие порядок возрастание:");
Console.WriteLine(currentElement);
while (index <= 9)

{
    if (array[index]>currentElement)
    {

        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    
    index++;
}
Console.WriteLine();

//нахождение среднего арифметического элементов A
int sum = array[0];
for (int i = 1; i < index; i++)
{
    sum += array[i];
}
int result = sum / index;

//Печатаем сумму в консоль

Console.WriteLine("Сумма массива: {0}" , sum);
Console.WriteLine();

//Печатаем среднее арифметическое 
Console.WriteLine("Среднее арифметическое: {0}", result);
Console.WriteLine();

// Находим количество эелементов больше среднего арифметического А
var count = 0;
        var sum2 = 0;

        foreach (var current in array)
        {
            if (current > result)
            {
                count++;
                sum2 += current;
            }
        }
        Console.WriteLine("Количество элементов больше среднего арифметического: {0}",count);
        Console.WriteLine();

// Сумма элементов больше среднеего аримфметического
        Console.WriteLine("Сумма элементов больше среднеего аримфметического: {0}" , sum2);
        Console.WriteLine();

// определяем чётные числа, если число делится на два с остатком 0, то оно чётное
        var sum3 = 0;
        Console.Write("Чётные элементы массива:");
        Console.WriteLine("");
        for (int i = 0; i < array.Length; i++) 
        
        {
            if (array[i] % 2 == 0) 
            {
           
                Console.WriteLine(array[i]);
            }
            sum3 += array[i];
        }
                Console.WriteLine();
                Console.WriteLine("Сумма четных элементов массива равна: {0}", sum3);
                Console.WriteLine();

        //Нечётные числа массива
        var sum4 = 0;
        Console.Write("Нечётные элементы массива:");
        Console.WriteLine("");
        for (int i = 0; i < array.Length; i++) 
        
        {
            if (array[i] % 2 != 0) 
            {
            
                Console.WriteLine(array[i]);
            }
            sum4 += array[i];
        }
                Console.WriteLine();
                Console.WriteLine("Сумма нечетных элементов массива равна: {0}", sum4);
                Console.WriteLine();

