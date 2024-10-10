namespace SortAgloritums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            Random generator = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = generator.Next(200);
            }

            int[] result = new int[numbers.Length];

            result = BubbleSort(numbers);
            Console.WriteLine("Bubble Sort Result:");
            PrintArray(result);

            result = SelectionSort(numbers);
            Console.WriteLine("Selection Sort Result:");
            PrintArray(result);

            result = InsertionSort(numbers);
            Console.WriteLine("Insertion Sort Result:");
            PrintArray(result);
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        private static void Swap(int[] array, in int k, in int i)
        {
            int temp = array[k];
            array[k] = array[i];
            array[i] = temp;
        }

        static int[] BubbleSort(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i];
            }

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        Swap(result, j, j + 1);
                    }
                }
            }
            return result;
        }

        static int[] SelectionSort(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i];
            }

            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(result, minIndex, i);
            }
            return result;
        }

        static int[] InsertionSort(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i];
            }

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;
                while (j >= 0 && result[j] > key)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = key;
            }
            return result;
        }
    }
}
