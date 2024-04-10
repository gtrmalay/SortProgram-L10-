using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortProgramLR10Garipov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            dataGridView.Dock = DockStyle.Fill;

            var columnSort = new DataGridViewTextBoxColumn();
            columnSort.HeaderText = "Сортировка";
            dataGridView.Columns.Add(columnSort);

            var columnCount = new DataGridViewTextBoxColumn();
            columnCount.HeaderText = "Кол-во";
            dataGridView.Columns.Add(columnCount);

            var columnComparisons = new DataGridViewTextBoxColumn();
            columnComparisons.HeaderText = "Сравнений";
            dataGridView.Columns.Add(columnComparisons);

            var columnPermutations = new DataGridViewTextBoxColumn();
            columnPermutations.HeaderText = "Перемещений";
            dataGridView.Columns.Add(columnPermutations);

            var columnTime = new DataGridViewTextBoxColumn();
            columnTime.HeaderText = "Время";
            dataGridView.Columns.Add(columnTime);

            AnalInfo[] simpleSorts =
            [
                new AnalInfo() { count = 100 },
                new AnalInfo() { count = 1000 },
                new AnalInfo() { count = 100000 },
            ];

            AnalInfo[] ShellSorts =
            [
                new AnalInfo() { count = 100 },
                new AnalInfo() { count = 1000 },
                new AnalInfo() { count = 100000 },
            ];
            foreach (var sort in simpleSorts)
            {
                new Context(new SelectionMethod()).AnalSortArr(sort);
                dataGridView.Rows.Add("Выбор", sort.count, sort.comparisons, sort.permutations, sort.time);
            }
            
            foreach (var sort in ShellSorts)
            {
                new Context(new ShellsMethod()).AnalSortArr(sort);
                dataGridView.Rows.Add("Шелла", sort.count, sort.comparisons, sort.permutations, sort.time);
            }
        }


    }
}
