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
            this.ChooseNumberofElements = new System.Windows.Forms.TextBox();
            this.SortingTime = new System.Windows.Forms.Label();
            this.SelectAlgorithm = new System.Windows.Forms.ComboBox();
            this.BarChartBox = new System.Windows.Forms.PictureBox();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.Shuffle = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
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
            this.NumberofElements.Click += new System.EventHandler(this.NumberofElements_Click);
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
            this.EnterSortingSpeed.TextChanged += new System.EventHandler(this.EnterSortingSpeed_TextChanged);
            // 
            // ChooseNumberofElements
            // 
            this.ChooseNumberofElements.Location = new System.Drawing.Point(176, 56);
            this.ChooseNumberofElements.Name = "ChooseNumberofElements";
            this.ChooseNumberofElements.Size = new System.Drawing.Size(50, 22);
            this.ChooseNumberofElements.TabIndex = 4;
            this.ChooseNumberofElements.TextChanged += new System.EventHandler(this.ChooseNumberofElements_TextChanged);
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
            // SelectAlgorithm
            // 
            this.SelectAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAlgorithm.FormattingEnabled = true;
            this.SelectAlgorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Selection Sort"});
            this.SelectAlgorithm.Location = new System.Drawing.Point(176, 132);
            this.SelectAlgorithm.Name = "SelectAlgorithm";
            this.SelectAlgorithm.Size = new System.Drawing.Size(140, 24);
            this.SelectAlgorithm.TabIndex = 5;
            this.SelectAlgorithm.SelectedIndexChanged += new System.EventHandler(this.SelectAlgorithm_SelectedIndexChanged);
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
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(176, 186);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(100, 40);
            this.Shuffle.TabIndex = 8;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(70, 186);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(100, 40);
            this.Sort.TabIndex = 9;
            this.Sort.Text = "Sort!";
            this.Sort.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.BarChartBox);
            this.Controls.Add(this.SelectAlgorithm);
            this.Controls.Add(this.ChooseNumberofElements);
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
        private System.Windows.Forms.TextBox ChooseNumberofElements;
        private System.Windows.Forms.Label SortingTime;
        private System.Windows.Forms.ComboBox SelectAlgorithm;
        private System.Windows.Forms.PictureBox BarChartBox;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button Sort;
    }
}

