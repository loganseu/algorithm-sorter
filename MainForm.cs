﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SeeSortingAlgorithms
{
    public partial class MainForm : Form
    {
        Graphics g;
        Bitmap bmp;
        List<int> numbers;
        public int numberOfElements { get; set; }
        public int speed { get; set; }
        public string sortingTime { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CreateNewBarChart();
            SelectTheAlgorithm.SelectedIndex = 0;
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

        public List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

            return numbers;
        }

        public List<int> GenerateList(List<int> numbers)
        {
            for (int i = 0; i < numberOfElements; ++i)
            {
                numbers.Add(i + 1);
            }
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

        private void DrawBarChart(List<int> numbers)
        {
            int boxWidth = BarChartBox.Width;
            int boxHeight = BarChartBox.Height;

            for (int i = 0; i < numbers.Count; ++i)
            {
                int offsetX = (int)Math.Round(((double)boxWidth / numbers.Count), 0);
                int x = (int)(((double)boxWidth / numbers.Count) * i);
                int y = (int)(((double)boxHeight / numbers.Count) * numbers[i]);
                g.FillRectangle(Brushes.White, x, boxHeight - y, offsetX, boxHeight);
            }
        }

        private void CreateNewBarChart()
        {
            bmp = new Bitmap(BarChartBox.Width, BarChartBox.Height);
            g = Graphics.FromImage(bmp);
            BarChartBox.Image = bmp;

            numbers = new List<int>();
            numberOfElements = (int)AdjustElements.Value;

            GenerateList(numbers);
            ShuffleList(numbers);
            DrawBarChart(numbers);
        }

        private void SelectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            CreateNewBarChart();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            BarChart sortingAlgorithm = new BarChart(BarChartBox, speed, numberOfElements, numbers);

            ThreadStart ts = delegate ()
            {
                try
                {
                    switch (SelectTheAlgorithm.Text)
                    {
                        case "Bubble Sort":
                            sortingAlgorithm.BubbleSort(numbers);
                            break;
                        case "Insertion Sort":
                            sortingAlgorithm.InsertionSort(numbers);
                            break;
                        case "Selection Sort":
                            sortingAlgorithm.SelectionSort(numbers);
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            };
            Thread t = new Thread(ts);
            t.Start();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            bmp = new Bitmap(BarChartBox.Width, BarChartBox.Height);
            g = Graphics.FromImage(bmp);
            BarChartBox.Image = bmp;
            DrawBarChart(numbers);
        }
    }
}
