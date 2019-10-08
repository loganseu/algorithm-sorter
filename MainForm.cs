using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SeeSortingAlgorithms
{
    public partial class MainForm : Form
    {
        Graphics g;
        Bitmap bmp;
        public MainForm()
        {
            InitializeComponent();
            SelectAlgorithm.SelectedIndex = 0;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ChooseNumberofElements_TextChanged(object sender, EventArgs e)
        {
            string NumberofElements = ChooseNumberofElements.Text;
        }

        private void SortingSpeed_Click(object sender, EventArgs e)
        {

        }
        public static List<int> SwapValues(List<int> numbers, int a, int b)
        {
            int temp = numbers[b];
            numbers[b] = numbers[a];
            numbers[a] = temp;

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



        private void SelectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(BarChartBox.Width, BarChartBox.Height);
            g = Graphics.FromImage(bmp);

            BarChartBox.Image = bmp;

            List<int> numbers = new List<int>();
            int numberOfElements = 20;
            for (int i = 0; i < numberOfElements; ++i)
            {
                numbers.Add(i + 1);
            }
            Random shuffle = new Random();
            for (int i = numbers.Count - 1; i > 1; i--)
            {
                int rnd = shuffle.Next(i + 1);

                SwapValues(numbers, rnd, i);
            }
            DrawBarChart(numbers);
        }

        private void NumberofElements_Click(object sender, EventArgs e)
        {

        }

        private void EnterSortingSpeed_TextChanged(object sender, EventArgs e)
        {
            var SortingSpeed = EnterSortingSpeed.Text;
        }
    }
}
