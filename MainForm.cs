using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace N_Squared
{
    public partial class MainForm : Form
    {
        public Graphics G { get; set; }
        public Bitmap Graph { get; set; }
        public List<int> Numbers { get; set; }
        public int NumberOfElements { get; set; }
        public int SortingSpeed { get; set; }

        public MainForm()
        {
            InitializeComponent();
            SelectedAlgorithm.SelectedIndex = 0;
            GenerateBarGraph(false);
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
            for (int i = 0; i < NumberOfElements; ++i)
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

        private void DrawBarGraph(List<int> numbers)
        {
            int offsetX = (int)Math.Ceiling(((double)BlackBox.Width / numbers.Count));

            for (int i = 0; i < numbers.Count; ++i)
            {
                int x = offsetX * i;
                int y = (int)(((double)BlackBox.Height / numbers.Count) * numbers[i]);
                G.FillRectangle(Brushes.White, x, BlackBox.Height - y, offsetX, BlackBox.Height);
            }
        }

        private void GenerateBarGraph(bool shuffle)
        {
            Graph = new Bitmap(BlackBox.Width, BlackBox.Height);
            G = Graphics.FromImage(Graph);
            BlackBox.Image = Graph;

            Numbers = new List<int>();
            NumberOfElements = (int)AdjustNumberOfElements.Value;

            GenerateList(Numbers);
            if (shuffle == true)
            {
                ShuffleList(Numbers);
            }

            DrawBarGraph(Numbers);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Graph = new Bitmap(BlackBox.Width, BlackBox.Height);
            G = Graphics.FromImage(Graph);
            BlackBox.Image = Graph;
            DrawBarGraph(Numbers);
        }

        private void DisableControls()
        {
            Sort.Enabled = false;
            Shuffle.Enabled = false;
        }

        private void EnableControls()
        {
            Sort.Enabled = true;
            Shuffle.Enabled = true;
        }

        private void SelectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectedAlgorithm.Text)
            {
                case "Bubble Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(1)";
                    SpaceComplexity.ForeColor = Color.LimeGreen;
                    break;

                case "Bucket Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(n + k)";
                    SpaceComplexity.ForeColor = Color.Orange;
                    break;

                case "Cycle Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(1)";
                    SpaceComplexity.ForeColor = Color.LimeGreen;
                    break;

                case "Gnome Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(1)";
                    SpaceComplexity.ForeColor = Color.LimeGreen;
                    break;

                case "Insertion Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(1)";
                    SpaceComplexity.ForeColor = Color.LimeGreen;
                    break;

                case "Merge Sort":
                    TimeComplexity.Text = "O(n * log(n))";
                    TimeComplexity.ForeColor = Color.Orange;
                    SpaceComplexity.Text = "O(n)";
                    SpaceComplexity.ForeColor = Color.LightYellow;
                    break;

                case "Quick Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(log(n))";
                    SpaceComplexity.ForeColor = Color.Yellow;
                    break;

                case "Radix Sort":
                    TimeComplexity.Text = "O(n * k/d)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(n + 2^d)";
                    SpaceComplexity.ForeColor = Color.Red;
                    break;

                case "Selection Sort":
                    TimeComplexity.Text = "O(n²)";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(1)";
                    SpaceComplexity.ForeColor = Color.LimeGreen;
                    break;

                case "Shell Sort":
                    TimeComplexity.Text = "O(n * log²(n))";
                    TimeComplexity.ForeColor = Color.Red;
                    SpaceComplexity.Text = "O(n)";
                    SpaceComplexity.ForeColor = Color.LightYellow;
                    break;

            }
        }

        private void AdjustSortingSpeed_ValueChanged(object sender, EventArgs e)
        {
            SortingSpeed = (int)AdjustSortingSpeed.Value;
        }

        private void AdjustNumberOfElements_ValueChanged(object sender, EventArgs e)
        {
            GenerateBarGraph(false);
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            GenerateBarGraph(true);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            blackBoxBW.RunWorkerAsync();
        }

        private void BlackBoxBackgroundWorker(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BarGraph sortingAlgorithm = new BarGraph(BlackBox, SortingSpeed, NumberOfElements, Numbers);
            DisableControls();

            switch (SelectedAlgorithm.Text)
            {
                case "Bubble Sort":
                    sortingAlgorithm.BubbleSort(Numbers);
                    break;

                case "Bucket Sort":
                    sortingAlgorithm.BucketSort(Numbers);
                    break;

                case "Cycle Sort":
                    sortingAlgorithm.CycleSort(Numbers);
                    break;

                case "Gnome Sort":
                    sortingAlgorithm.GnomeSort(Numbers);
                    break;

                case "Insertion Sort":
                    sortingAlgorithm.InsertionSort(Numbers);
                    break;

                case "Merge Sort":
                    sortingAlgorithm.MergeSort(Numbers, 0, Numbers.Count - 1);
                    break;

                case "Quick Sort":
                    sortingAlgorithm.QuickSort(Numbers, 0, Numbers.Count - 1);
                    break;

                case "Radix Sort":
                    sortingAlgorithm.RadixSort(Numbers);
                    break;

                case "Selection Sort":
                    sortingAlgorithm.SelectionSort(Numbers);
                    break;

                case "Shell Sort":
                    sortingAlgorithm.ShellSort(Numbers);
                    break;
                default:
                    MessageBox.Show("This sorting algorithm does not exist or has not yet been implemented. Please try another one.", "Algorithm Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EnableControls();
                    return;
            }
            sortingAlgorithm.Glissando(Numbers);
            EnableControls();
        }
    }
}
