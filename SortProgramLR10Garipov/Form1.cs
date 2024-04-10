using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SortProgramLR10Garipov 
{
    
    public partial class Form1 : Form
    {

        Random random = new Random();

        public static int comparisons;
        public static int permutations;

        private static string time = "MM:SS:MS";
        public Form1()
        {
            InitializeComponent();
        }

        private Context context;
        public static void ReadInfo(int comp, int perm, string ti)
        {
            comparisons = comp;
            permutations = perm;
            time = ti;

        }

        public static void SpaceText()
        {
            richTextBox.Text += "\n\n";
        }

        public static void AddSortLine(string str)
        {
            richTextBox.Text += str + '\n';
        }

        public static void FillFirstLine()
        {
            richTextBox.Text = "Исходный массив:\n";
            foreach (var i in Context.array)
            richTextBox.Text += i + " ";
            richTextBox.Text += "\n\n";
        }

        private void PrintInfo()
        {
            NumComp.Text = "Кол-во сравнений: " + Convert.ToString(comparisons);
            NumSwap.Text = "Кол-во перестановок: " + Convert.ToString(permutations);
            TimeLabel.Text = "Время сортировки: " + time;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrackBar.Text = trackBar1.Value.ToString();
        }

        private void buttonGeneration_Click(object sender, EventArgs e)
        {
            string generatedArr = "";
            var newArr = new int[trackBar1.Value];

            //генерируем числа
            for (int i = 0; i < newArr.Length; i++) 
            {
                newArr[i] = random.Next(0, 100);
                generatedArr += newArr[i] + " ";
            }
            
            Context.array = newArr;
            //выводим сгенерированные числа
            richTextBox.Text = generatedArr;

        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            var mboxResult = MessageBox.Show("Подготовить файл для сохранения?", "Внимание", MessageBoxButtons.YesNo);

            var flag = mboxResult == DialogResult.Yes;

            Context context;
            if (radioButton1.Checked)
                context = new(new SelectionMethod());
            else
                context = new(new ShellsMethod());

            context.SortArr(flag);
            FileOut.sorted = true;
            PrintInfo();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text;
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
                using (var reader = new StreamReader(ofd.FileName))
                    text = reader.ReadToEnd();
            else
                return;

            var stringArr = text.Split(' ');
            var intArr = new int[stringArr.Length];
            for (int i = 0; i < intArr.Length; i++)
                int.TryParse(stringArr[i], out intArr[i]);

            Context.array = intArr;
            FillFirstLine(); 
}

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text files(*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
                FileOut.SavaFile(sfd.FileName);
        }

        private void открытьОкноАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ваш код
        }

        private void Open2Form_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        
    }
}
