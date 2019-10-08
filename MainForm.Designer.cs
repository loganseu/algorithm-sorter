namespace SeeSortingAlgorithms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SelectedAlgorithm = new System.Windows.Forms.Label();
            this.NumberofElements = new System.Windows.Forms.Label();
            this.SortingSpeed = new System.Windows.Forms.Label();
            this.EnterSortingSpeed = new System.Windows.Forms.TextBox();
            this.EnterNumberofElements = new System.Windows.Forms.TextBox();
            this.SortingTime = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BarChartBox = new System.Windows.Forms.PictureBox();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedAlgorithm
            // 
            this.SelectedAlgorithm.AutoSize = true;
            this.SelectedAlgorithm.Location = new System.Drawing.Point(40, 135);
            this.SelectedAlgorithm.Name = "SelectedAlgorithm";
            this.SelectedAlgorithm.Size = new System.Drawing.Size(130, 17);
            this.SelectedAlgorithm.TabIndex = 0;
            this.SelectedAlgorithm.Text = "Selected Algorithm:";
            // 
            // NumberofElements
            // 
            this.NumberofElements.AutoSize = true;
            this.NumberofElements.Location = new System.Drawing.Point(30, 56);
            this.NumberofElements.Name = "NumberofElements";
            this.NumberofElements.Size = new System.Drawing.Size(140, 17);
            this.NumberofElements.TabIndex = 1;
            this.NumberofElements.Text = "Number of Elements:";
            // 
            // SortingSpeed
            // 
            this.SortingSpeed.AutoSize = true;
            this.SortingSpeed.Location = new System.Drawing.Point(68, 96);
            this.SortingSpeed.Name = "SortingSpeed";
            this.SortingSpeed.Size = new System.Drawing.Size(102, 17);
            this.SortingSpeed.TabIndex = 2;
            this.SortingSpeed.Text = "Sorting Speed:";
            this.SortingSpeed.Click += new System.EventHandler(this.SortingSpeed_Click);
            // 
            // EnterSortingSpeed
            // 
            this.EnterSortingSpeed.Location = new System.Drawing.Point(176, 96);
            this.EnterSortingSpeed.Name = "EnterSortingSpeed";
            this.EnterSortingSpeed.Size = new System.Drawing.Size(50, 22);
            this.EnterSortingSpeed.TabIndex = 3;
            // 
            // EnterNumberofElements
            // 
            this.EnterNumberofElements.Location = new System.Drawing.Point(176, 56);
            this.EnterNumberofElements.Name = "EnterNumberofElements";
            this.EnterNumberofElements.Size = new System.Drawing.Size(50, 22);
            this.EnterNumberofElements.TabIndex = 4;
            this.EnterNumberofElements.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // SortingTime
            // 
            this.SortingTime.AutoSize = true;
            this.SortingTime.Location = new System.Drawing.Point(102, 27);
            this.SortingTime.Name = "SortingTime";
            this.SortingTime.Size = new System.Drawing.Size(68, 17);
            this.SortingTime.TabIndex = 0;
            this.SortingTime.Text = "Time (O):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Insertion Sort"});
            this.comboBox1.Location = new System.Drawing.Point(176, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // BarChartBox
            // 
            this.BarChartBox.BackColor = System.Drawing.Color.Black;
            this.BarChartBox.Location = new System.Drawing.Point(350, 0);
            this.BarChartBox.Name = "BarChartBox";
            this.BarChartBox.Size = new System.Drawing.Size(1030, 650);
            this.BarChartBox.TabIndex = 6;
            this.BarChartBox.TabStop = false;
            // 
            // chartTimer
            // 
            this.chartTimer.Enabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BarChartBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EnterNumberofElements);
            this.Controls.Add(this.EnterSortingSpeed);
            this.Controls.Add(this.SortingSpeed);
            this.Controls.Add(this.NumberofElements);
            this.Controls.Add(this.SortingTime);
            this.Controls.Add(this.SelectedAlgorithm);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "MainForm";
            this.Text = "Visualize Sorting Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedAlgorithm;
        private System.Windows.Forms.Label NumberofElements;
        private System.Windows.Forms.Label SortingSpeed;
        private System.Windows.Forms.TextBox EnterSortingSpeed;
        private System.Windows.Forms.TextBox EnterNumberofElements;
        private System.Windows.Forms.Label SortingTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox BarChartBox;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

