using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SeeSortingAlgorithms
{
    public class BarChart
    {
        Graphics g;
        Bitmap bmp;
        public static List<int> numbers { get; set; }
        public static int numberOfElements { get; set; }
    //public static SortingTime currentSortingTime { get; set; }

    public BarChart(PictureBox p)
        {
            numbers = new List<int>();
            numberOfElements = 50;
            GenerateList();
            ShuffleList();

            bmp = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(bmp);
        }

        public static List<int> BubbleSort()
        {
            for (int i = 0; i < numbers.Count - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Count; ++j)
                {
                    if (numbers[i] > numbers[j])
                    {
                        SwapValues(numbers, i, j);
                    }
                }
            }
            return numbers;
        } 

        public static List<int> InsertionSort()
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {

                        int temp = j - 1;
                        SwapValues(numbers, temp, j);
                        return numbers;
                    }
                }
            }
            return numbers;
        }

        public static List<int> SelectionSort()
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
                return numbers;
            }
            return numbers;
        }

        public static List<int> GenerateList()
        {
            for (int i = 0; i < numberOfElements; ++i)
            {
                numbers.Add(i + 1);
            }
            return numbers;
        }

        public static List<int> ShuffleList()
        {
            Random shuffle = new Random();

            for (int i = numbers.Count - 1; i > 1; i--)
            {
                int rnd = shuffle.Next(i + 1);

                SwapValues(numbers, rnd, i);
            }
            return numbers;
        }

        public static List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

            return numbers;
        }

        public enum SortingTime
        {
            [Description("O(1)")]
            OTOTHE1,
            [Description("O(N)")]
            OTOTHEN,
            [Description("O(Nlog(N))")]
            ONLOGN,
            [Description("O(N^2)")]
            OTONSQUARED
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}