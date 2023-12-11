// Дан массив и число.
// Найдите три числа в массиве сумма которых равна искомому числу.
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.


class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 40, 5, 6, 7, 8, 9, 10, 11}; //50

        int target = 50;

        GetThreeNumbersSumToTarget(arr, target);
    }

    static void GetThreeNumbersSumToTarget(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length - 2; i++) // Отнимаем 2, чтобы оставить место для ещё двух чисел
        {
            HashSet<int> s = new HashSet<int>();
            int currentSum = target - arr[i];
            for (int j = i + 1; j < arr.Length; j++) // Начинаем со следующего индекса после i
            {
                int result = currentSum - arr[j];
                if (s.Contains(result))
                {
                    Console.WriteLine($"{arr[i]} + {arr[j]} + {result} = {target}");
                    return;
                }
                else
                {
                    s.Add(arr[j]);
                }
            }
        }
        Console.WriteLine("Не удалось найти три числа, сумма которых равна заданному числу.");
    }
}