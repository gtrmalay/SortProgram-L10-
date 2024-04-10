using System;
using System.Diagnostics;

namespace SortProgramLR10Garipov
{
    internal class ShellsMethod : IStrategy
    {
        private Stopwatch myStopwatch;
        private int comparisons = 0;
        private int permutations = 0;
        private string time = ""; // Объявление переменной для хранения времени выполнения

        public ShellsMethod()
        {
            myStopwatch = new Stopwatch(); // Инициализация секундомера
        }

        public void AnalSortArr(AnalInfo info)
        {
            int[] arr = new int[info.count];
            for (int i = 0; i < info.count; i++)
                arr[i] = new Random().Next(0, 1000);

            myStopwatch.Start(); // Запуск секундомера

            // Расстояние между элементами, которые сравниваются
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while (Comp()&&(j >= d) && (arr[j - d] > arr[j]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - d];
                        arr[j - d] = temp;
                        j = j - d;
                        permutations++;
                    }
                }
                d = d / 2;
            }

            info.permutations = permutations;
            info.comparisons = comparisons;

            myStopwatch.Stop(); // Остановка секундомера
            var resultTime = myStopwatch.Elapsed;
            time = String.Format("{0:00}:{1:00}.{2:000}",
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
            info.time = time;
        }

        bool Comp()
        {
            comparisons++;
            return true;
        }

        public void SortArr(int[] arr, bool flag)
        {
            Form1.SpaceText();
            myStopwatch.Start(); // Запуск секундомера

            // Расстояние между элементами, которые сравниваются
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    Comparisons(arr, i, d, flag);
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        Swap(arr, j, j - d, flag);
                        j = j - d;
                    }
                }
                d = d / 2;
            }

            myStopwatch.Stop(); // Остановка секундомера
            var resultTime = myStopwatch.Elapsed;
            time = String.Format("{0:00}:{1:00}.{2:000}",
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            Form1.ReadInfo(comparisons, permutations, time);
        }

        private void Swap(int[] arr, int ind1, int ind2, bool flag)
        {
            permutations++;

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

            FileOut.Fill();

        }

        private bool Comparisons(int[] arr, int ind1, int ind2, bool flag)
        {
            comparisons++; // Увеличение счетчика сравнений

            if (flag && FileOut.fileString == null)
            {
                FileOut.fileString = "Исходный массив: ";
                FileOut.Fill();
            }

            if (flag)
                FileOut.fileString += $"Сравнение {comparisons}: {arr[ind1]} и {arr[ind2]}\n";

            // Здесь может потребоваться возвращаемое значение в зависимости от ваших нужд
            return true;
        }

        
    }
}
