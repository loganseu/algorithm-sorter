using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace SeeSortingAlgorithms
{
    public class BarChart
    {
        Graphics g;
        Bitmap bmp;
        public int numberOfElements { get; set; }
        public int sortingSpeed { get; set; }
        PictureBox BarChartBox;

        public BarChart(PictureBox p, int speed, int elements, List<int> numbers)
        {
            bmp = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(bmp);
            BarChartBox = p;
            BarChartBox.Image = bmp;
            sortingSpeed = speed;
            numberOfElements = elements;
            DrawBarChart(numbers);
        }

        public void DrawBarChart(List<int> numbers)
        {
            int boxWidth = BarChartBox.Width;
            int boxHeight = BarChartBox.Height;
            int offsetX = (int)Math.Ceiling((double)boxWidth / numbers.Count);

            for (int i = 0; i < numbers.Count; ++i)
            {
                int x = offsetX * i;
                int y = (int)(((double)boxHeight / numbers.Count) * numbers[i]);
                g.FillRectangle(Brushes.White, x, boxHeight - y, offsetX, boxHeight);
            }
        }

        public List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

            return numbers;
        }

        public void RecolorBars(List<int> numbers, int i, int j)
        {
            RedrawBar(i, numbers, Brushes.Red);
            RedrawBar(j, numbers, Brushes.LimeGreen);
            SwapValues(numbers, i, j);
            BarChartBox.Refresh();
            Thread.Sleep(sortingSpeed);
            RedrawBar(i, numbers, Brushes.White);
            RedrawBar(j, numbers, Brushes.White);
            BarChartBox.Refresh();
        }

        private void RedrawBar(int index, List<int> numbers, Brush color)
        {
            int boxWidth = BarChartBox.Width;
            int boxHeight = BarChartBox.Height;

            int x = (int)(((double)boxWidth / numbers.Count) * index);
            int y = (int)(((double)boxHeight / numbers.Count) * numbers[index]);
            int offsetX = (int)Math.Ceiling(((double)boxWidth / numbers.Count));
            g.FillRectangle(Brushes.Black, x, 0, offsetX, boxHeight);
            g.FillRectangle(color, x, boxHeight - y, offsetX, boxHeight);
        }

        public void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; ++i)
            {
                for (int j = 0; j < numbers.Count - 1; ++j)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        RecolorBars(numbers, j, j + 1);
                    }
                }
            }
        }

        public void InsertionSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        RecolorBars(numbers, j - 1, j);
                    }
                }
            }
        }

        public void SelectionSort(List<int> numbers)
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
                if (i != min_index)
                {
                    RecolorBars(numbers, i, min_index);
                }
            }
        }

        //Named after the piano technique where you run your hand across the keyboard.
        public void Glissando(List<int> numbers)
        {
            int boxWidth = BarChartBox.Width;
            int boxHeight = BarChartBox.Height;
            int offsetX = (int)Math.Ceiling((double)boxWidth / numbers.Count);

            for (int i = 0; i < numbers.Count; ++i)
            {
                int x = offsetX * i;
                int y = (int)(((double)boxHeight / numbers.Count) * numbers[i]);
                g.FillRectangle(Brushes.LimeGreen, x, boxHeight - y, offsetX, boxHeight);
                BarChartBox.Refresh();
                Thread.Sleep(20);
            }

            DrawBarChart(numbers);
            BarChartBox.Refresh();
        }
    }
}