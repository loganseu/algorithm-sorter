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
        public int numberOfElements { get; set; }
        public int sortingSpeed { get; set; }
        PictureBox BarChartBox;

    //public static SortingTime currentSortingTime { get; set; }

    public BarChart(PictureBox p, int speed, int elements)
        {
            bmp = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(bmp);
            BarChartBox = p;
            sortingSpeed = speed;
            numberOfElements = elements;
        }

        private void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; ++i)
            {
                for (int j = i + 1; j < numbers.Count; ++j)
                {
                    if (numbers[i] > numbers[j])
                    {
                        SwapValues(numbers, i, j);
                        RedrawItem(i, numbers, Brushes.Red);
                        RedrawItem(j, numbers, Brushes.Green);
                        BarChartBox.Refresh();
                        RedrawItem(i, numbers, Brushes.White);
                        RedrawItem(j, numbers, Brushes.White);
                    }
                }
            }
        }

        public static List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

            return numbers;
        }

        private void RedrawItem(int index, List<int> numbers, Brush color)
        {
            int boxWidth = BarChartBox.Width;
            int boxHeight = BarChartBox.Height;

            int x = (int)(((double)boxWidth / numbers.Count) * index);
            int y = (int)(((double)boxHeight / numbers.Count) * numbers[index]);
            int offsetX = (int)Math.Round(((double)boxWidth / numbers.Count), 0);
            g.FillRectangle(Brushes.Black, x, 0, offsetX, boxHeight);
            g.FillRectangle(color, x, boxHeight - y, offsetX, boxHeight);
        }

        public static List<int> InsertionSort(List<int> numbers)
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
                return numbers;
            }
            return numbers;
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