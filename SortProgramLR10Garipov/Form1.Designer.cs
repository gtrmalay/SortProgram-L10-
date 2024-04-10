namespace SortProgramLR10Garipov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            TimeLabel = new Label();
            NumSwap = new Label();
            NumComp = new Label();
            groupBox2 = new GroupBox();
            buttonSort = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonOpen = new Button();
            buttonSave = new Button();
            richTextBox = new RichTextBox();
            trackBar1 = new TrackBar();
            labelTrackBar = new Label();
            ArrGenerationButton = new Button();
            OpenAnalys_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(TimeLabel);
            groupBox1.Controls.Add(NumSwap);
            groupBox1.Controls.Add(NumComp);
            groupBox1.Location = new Point(12, 379);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные о сортировке";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(17, 157);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(233, 32);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "Время сортировки: ";
            // 
            // NumSwap
            // 
            NumSwap.AutoSize = true;
            NumSwap.Location = new Point(17, 125);
            NumSwap.Name = "NumSwap";
            NumSwap.Size = new Size(265, 32);
            NumSwap.TabIndex = 1;
            NumSwap.Text = "Кол-во перестановок: ";
            // 
            // NumComp
            // 
            NumComp.AutoSize = true;
            NumComp.Location = new Point(17, 93);
            NumComp.Name = "NumComp";
            NumComp.Size = new Size(230, 32);
            NumComp.TabIndex = 0;
            NumComp.Text = "Кол-во сравнений: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveCaption;
            groupBox2.Controls.Add(buttonSort);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(12, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 251);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбор метода сортировки";
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(17, 165);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(366, 72);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Выполнить";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(198, 36);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Метод Шелла";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 58);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(208, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Метод выбора";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 632);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(400, 46);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += открытьToolStripMenuItem_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 684);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(400, 46);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(428, 21);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1356, 624);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 100;
            trackBar1.Location = new Point(12, 778);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(383, 90);
            trackBar1.TabIndex = 5;
            trackBar1.UseWaitCursor = true;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelTrackBar
            // 
            labelTrackBar.AutoSize = true;
            labelTrackBar.Location = new Point(176, 817);
            labelTrackBar.Name = "labelTrackBar";
            labelTrackBar.Size = new Size(29, 32);
            labelTrackBar.TabIndex = 6;
            labelTrackBar.Text = "...";
            // 
            // ArrGenerationButton
            // 
            ArrGenerationButton.Location = new Point(112, 865);
            ArrGenerationButton.Name = "ArrGenerationButton";
            ArrGenerationButton.Size = new Size(150, 46);
            ArrGenerationButton.TabIndex = 7;
            ArrGenerationButton.Text = "Генерация";
            ArrGenerationButton.UseVisualStyleBackColor = true;
            ArrGenerationButton.Click += buttonGeneration_Click;
            // 
            // OpenAnalys_Button
            // 
            OpenAnalys_Button.Location = new Point(12, 21);
            OpenAnalys_Button.Name = "OpenAnalys_Button";
            OpenAnalys_Button.Size = new Size(400, 46);
            OpenAnalys_Button.TabIndex = 8;
            OpenAnalys_Button.Text = "Открыть анализ";
            OpenAnalys_Button.UseVisualStyleBackColor = true;
            OpenAnalys_Button.Click += Open2Form_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1855, 1134);
            Controls.Add(OpenAnalys_Button);
            Controls.Add(ArrGenerationButton);
            Controls.Add(labelTrackBar);
            Controls.Add(trackBar1);
            Controls.Add(richTextBox);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label TimeLabel;
        private Label NumSwap;
        private Label NumComp;
        private GroupBox groupBox2;
        private Button buttonSort;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        public OpenFileDialog openFileDialog1;
        public SaveFileDialog saveFileDialog1;
        private Button buttonOpen;
        private Button buttonSave;
        private TrackBar trackBar1;
        private Label labelTrackBar;
        private Button ArrGenerationButton;
        private Button OpenAnalys_Button;
        private static RichTextBox richTextBox;
    }
}
