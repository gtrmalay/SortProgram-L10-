using System;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace SortProgramLR10Garipov
{
    public class SelectionMethod : IStrategy
    {

        private Stopwatch myStopwatch;
        private int comparisons;
        private int permutations;

        private string time = "";
        List<string> outputArr = new List<string>();

        public SelectionMethod()
        {
            myStopwatch = new Stopwatch(); // Инициализация секундомера
        }

        public void AnalSortArr(AnalInfo info)
        {
            int[] arr = new int[info.count];
            for(int i = 0; i < info.count; i++)
                arr[i] = new Random().Next(0,1000);
            arr[0] = 1;
            arr[1] = 2;
            myStopwatch.Start();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    info.comparisons++;
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                // обмен элементов
                if (arr[i] > arr[min])
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                    info.permutations++;
                }
            }

            var resultTime = myStopwatch.Elapsed;
            time = String.Format("{0:00}:{1:00}.{2:000}",
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            info.time = time;

        }

        public void SortArr(int[] arr, bool flag)
        {
            Form1.SpaceText();
            myStopwatch.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // поиск минимального числа
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    comparisons++;
                    if (arr[j] < arr[min])
                    {
                        FileOut.fileString += $"Сравнение {arr[j]} и {arr[min]}\n";
                        min = j;
                    }
                }

                if (arr[i] > arr[min])
                    Swap(arr, i, min, flag);
            }

            myStopwatch.Stop(); 
            var resultTime = myStopwatch.Elapsed;
            time = String.Format("{0:00}:{1:00}.{2:000}",
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            Form1.ReadInfo(comparisons, permutations, time);

        }

        private void Swap(int[] arr, int ind1, int ind2, bool flag)
        {

            if (flag)
            {
                FileOut.fileString += $"Перемещение {permutations}: " +
                    $"[{ind1}] - {arr[ind1]} и [{ind2}] - {arr[ind2]}\n";
            }

            string swapString = "";
            for (int i = 0; i < arr.Length; i++)
                if (i == ind1 || i == ind2)
                    swapString += $"[{arr[i]}] ";
                else
                    swapString += arr[i] + " ";

            Form1.AddSortLine(swapString);


            int temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;
            permutations++;

            FileOut.Fill();

        }

        
    }
}
