using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace SeeSortingAlgorithms
{
    public class Algorithms
    {
        Graphics barChart;
        public List<int> numbers { get; set; }

        public List<int> GenerateList()
        {
            int defaultValue = 10;
            for (int i = 0; i < defaultValue; ++i)
            {
                numbers.Add(i + 1);
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

            return numbers;
        }

        public List<int> ShuffleList(List<int> numbers)
        {
            Random shuffle = new Random();

            for (int i = numbers.Count - 1; i > 1; i--)
            {
                int rnd = shuffle.Next(i + 1);

                SwapValues(numbers, rnd, i);
            }
            return numbers;
        }

        public List<int> DrawLines(List<int> numbers)
        {
            return numbers;
        }

        public List<int> BubbleSort(List<int> numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Count - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Count; ++j)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        public List<int> InsertionSort(List<int> numbers)
        {
            int temp = 0;
            for (int i = 1; i < numbers.Count; ++i)
            {
                int j = i;

                while (numbers[j] < numbers[j - 1] && j > 1)
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                    j = j - 1;
                }
                if (numbers[j] < numbers[j - 1] && j == 1)
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                }
            }
            return numbers;
        }

        public static List<int> SelectionSort(List<int> numbers)
        {
            int min = 0;
            int min_index = 0;
            for (int i = 0; i < numbers.Count; ++i)
            {
                for (int j = i; j < numbers.Count; ++j)
                {
                    if (j == i || numbers[j] < min)
                    {
                        min = numbers[j];
                        min_index = j;
                    }
                }
                numbers[min_index] = numbers[i];
                numbers[i] = min;
            }
            return numbers;
        }
    }
}
