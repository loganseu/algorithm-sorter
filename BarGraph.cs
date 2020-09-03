using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace N_Squared
{
    public class BarGraph
    {
        readonly Graphics G;
        readonly Bitmap Graph;
        readonly PictureBox BlackBox;
        public int NumberOfElements { get; set; }
        public int SortingSpeed { get; set; }

        public BarGraph(PictureBox p, int speed, int elements, List<int> numbers)
        {
            Graph = new Bitmap(p.Width, p.Height);
            G = Graphics.FromImage(Graph);
            SortingSpeed = speed;
            BlackBox = p;
            BlackBox.Image = Graph;
            NumberOfElements = elements;
            DrawBarChart(numbers);
        }

        public void DrawBarChart(List<int> numbers)
        {
            int offsetX = (int)Math.Ceiling((double)BlackBox.Width / numbers.Count);

            for (int i = 0; i < numbers.Count; ++i)
            {
                int x = offsetX * i;
                int y = (int)(((double)BlackBox.Height / numbers.Count) * numbers[i]);
                G.FillRectangle(Brushes.White, x, BlackBox.Height - y, offsetX, BlackBox.Height);
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
            RedrawBar(j, numbers, Brushes.Red);
            SwapValues(numbers, i, j);

            BlackBox.Invoke(new MethodInvoker(delegate { BlackBox.Refresh(); }));

            Thread.Sleep(SortingSpeed);
            RedrawBar(i, numbers, Brushes.White);
            RedrawBar(j, numbers, Brushes.White);
            BlackBox.Invoke(new MethodInvoker(delegate { BlackBox.Refresh(); }));
        }

        private void RedrawBar(int index, List<int> numbers, Brush color)
        {
            int x = (int)(((double)BlackBox.Width / numbers.Count) * index);
            int y = (int)(((double)BlackBox.Height / numbers.Count) * numbers[index]);
            int offsetX = (int)Math.Ceiling(((double)BlackBox.Width / numbers.Count));
            G.FillRectangle(Brushes.Black, x, 0, offsetX, BlackBox.Height);
            G.FillRectangle(color, x, BlackBox.Height - y, offsetX, BlackBox.Height);
        }

        public void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        RecolorBars(numbers, j, j + 1);
                    }
                }
            }
        }

        public void CycleSort(List<int> numbers)
        {
            int writes = 0;
            for (int cycleStart = 0; cycleStart < numbers.Count; cycleStart++)
            {
                int item = numbers[cycleStart];
                int position = cycleStart;

                do
                {
                    int next = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (i != cycleStart && numbers[i] < item)
                        {
                            next++;
                        }
                    }
                    if (position != next)
                    {
                        while (position != next && numbers[next] == item)
                        {
                            next++;
                        }

                        int temp = numbers[next];
                        numbers[next] = item;
                        RecolorBars(numbers, next, next);
                        item = temp;
                        RecolorBars(numbers, cycleStart, cycleStart);
                        writes++;
                        position = next;
                    }
                } while (cycleStart != position);
            }
        }

        public void GnomeSort(List<int> numbers)
        {
            int i = 0;

            while (i < numbers.Count)
            {
                if (i == 0)
                    i++;
                if (numbers[i] >= numbers[i - 1])
                    i++;
                else
                {
                    RecolorBars(numbers, i, i - 1);
                    i--;
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

        public void MergeSort(List<int> numbers, int left, int right)
        {
            int l = left;
            int r = right;

            if (l == r)
            {
                return;
            }

            int mid = (l + r) / 2;

            MergeSort(numbers, l, mid);
            MergeSort(numbers, mid + 1, r);

            int lastIndexLeft = mid;
            int firstIndexRight = mid + 1;
            while ((l <= lastIndexLeft) && (firstIndexRight <= r))
            {
                if ((numbers[l]) <= (numbers[firstIndexRight]))
                {
                    l++;
                }
                else
                {
                    var temp = numbers[firstIndexRight];
                    for (int k = firstIndexRight - 1; k >= l; k--)
                    {
                        numbers[k + 1] = numbers[k];
                        RecolorBars(numbers, k + 1, k + 1);
                    }
                    numbers[l] = temp;
                    RecolorBars(numbers, l, l);
                    l++;
                    lastIndexLeft++;
                    firstIndexRight++;
                }
            }
            return;
        }

        public void QuickSort(List<int> numbers, int firstIndex, int lastIndex)
        {
            int pivot = numbers[(firstIndex + (lastIndex - firstIndex) / 2)];
            int left = firstIndex;
            int right = lastIndex;
            while (left <= right)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    RecolorBars(numbers, left, right);
                    left++;
                    right--;
                }
            }
            if (firstIndex < right)
            {
                QuickSort(numbers, firstIndex, left - 1);
            }
            if (lastIndex > left)
            {
                QuickSort(numbers, right + 1, lastIndex);
            }
        }

        public void SelectionSort(List<int> numbers)
        {
            int min = 0;
            int min_index = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
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

        public void ShellSort(List<int> numbers)
        {
            for (int gap = numbers.Count / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < numbers.Count; i += 1)
                {
                    int temp = numbers[i];
                    int j;
                    for (j = i; j >= gap && numbers[j - gap] > temp; j -= gap)
                    {
                        numbers[j] = numbers[j - gap];
                        RecolorBars(numbers, j, j);
                    }
                    numbers[j] = temp;
                    RecolorBars(numbers, j, j);
                }
            }
        }

        //Named after the piano technique where you run your hand across the keyboard.
        public void Glissando(List<int> numbers)
        {
            int offsetX = (int)Math.Ceiling((double)BlackBox.Width / numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                int x = offsetX * i;
                int y = (int)(((double)BlackBox.Height / numbers.Count) * numbers[i]);
                G.FillRectangle(Brushes.LimeGreen, x, BlackBox.Height - y, offsetX, BlackBox.Height);
                BlackBox.Invoke(new MethodInvoker(delegate { BlackBox.Refresh(); }));
                switch (NumberOfElements)
                {
                    case int delay when NumberOfElements == 10:
                        Thread.Sleep(20);
                        break;
                    case int delay when NumberOfElements == 15:
                        Thread.Sleep(10);
                        break;
                    case int delay when NumberOfElements < 30:
                        Thread.Sleep(5);
                        break;
                    case int delay when NumberOfElements <= 60:
                        Thread.Sleep(2);
                        break;
                    default:
                        break;
                }
            }

            DrawBarChart(numbers);
            BlackBox.Invoke(new MethodInvoker(delegate { BlackBox.Refresh(); }));
        }
    }
}