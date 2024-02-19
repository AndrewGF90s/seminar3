// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.

// Начальные условия:

// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
// Выводится: 5.15

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double max = 0;
double min = array[0];
    for(int  i = 0;i < array.Length;i++) {
        if(array[i] > max) {
            max = array[i];
        }
        else if (array[i] < min) {
            min = array[i];
        }
    }
double averege = max - min;
 Console.WriteLine($"Разнизница  между числами  {max} и {min} ровна {averege}");