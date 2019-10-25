namespace N_Squared
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
            this.SelectedAlgorithmLabel = new System.Windows.Forms.Label();
            this.NumberOfElementsLabel = new System.Windows.Forms.Label();
            this.SortingSpeedLabel = new System.Windows.Forms.Label();
            this.TimeComplexityLabel = new System.Windows.Forms.Label();
            this.SelectedAlgorithm = new System.Windows.Forms.ComboBox();
            this.BlackBox = new System.Windows.Forms.PictureBox();
            this.Shuffle = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.AdjustNumberOfElements = new System.Windows.Forms.NumericUpDown();
            this.AdjustSortingSpeed = new System.Windows.Forms.NumericUpDown();
            this.InfoBox = new System.Windows.Forms.PictureBox();
            this.TimeComplexity = new System.Windows.Forms.TextBox();
            this.SpaceComplexity = new System.Windows.Forms.TextBox();
            this.SpaceComplexityLabel = new System.Windows.Forms.Label();
            this.blackBoxBW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BlackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustNumberOfElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustSortingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedAlgorithmLabel
            // 
            this.SelectedAlgorithmLabel.AutoSize = true;
            this.SelectedAlgorithmLabel.Location = new System.Drawing.Point(60, 95);
            this.SelectedAlgorithmLabel.Name = "SelectedAlgorithmLabel";
            this.SelectedAlgorithmLabel.Size = new System.Drawing.Size(130, 17);
            this.SelectedAlgorithmLabel.TabIndex = 0;
            this.SelectedAlgorithmLabel.Text = "Selected Algorithm:";
            // 
            // NumberOfElementsLabel
            // 
            this.NumberOfElementsLabel.AutoSize = true;
            this.NumberOfElementsLabel.Location = new System.Drawing.Point(50, 25);
            this.NumberOfElementsLabel.Name = "NumberOfElementsLabel";
            this.NumberOfElementsLabel.Size = new System.Drawing.Size(140, 17);
            this.NumberOfElementsLabel.TabIndex = 1;
            this.NumberOfElementsLabel.Text = "Number of Elements:";
            // 
            // SortingSpeedLabel
            // 
            this.SortingSpeedLabel.AutoSize = true;
            this.SortingSpeedLabel.Location = new System.Drawing.Point(56, 60);
            this.SortingSpeedLabel.Name = "SortingSpeedLabel";
            this.SortingSpeedLabel.Size = new System.Drawing.Size(134, 17);
            this.SortingSpeedLabel.TabIndex = 2;
            this.SortingSpeedLabel.Text = "Sorting Speed (ms):";
            // 
            // TimeComplexityLabel
            // 
            this.TimeComplexityLabel.AutoSize = true;
            this.TimeComplexityLabel.Location = new System.Drawing.Point(76, 130);
            this.TimeComplexityLabel.Name = "TimeComplexityLabel";
            this.TimeComplexityLabel.Size = new System.Drawing.Size(114, 17);
            this.TimeComplexityLabel.TabIndex = 0;
            this.TimeComplexityLabel.Text = "Time Complexity:";
            // 
            // SelectedAlgorithm
            // 
            this.SelectedAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedAlgorithm.FormattingEnabled = true;
            this.SelectedAlgorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Bucket Sort",
            "Cycle Sort",
            "Gnome Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Radix Sort",
            "Selection Sort",
            "Shell Sort"});
            this.SelectedAlgorithm.Location = new System.Drawing.Point(210, 95);
            this.SelectedAlgorithm.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedAlgorithm.Name = "SelectedAlgorithm";
            this.SelectedAlgorithm.Size = new System.Drawing.Size(140, 24);
            this.SelectedAlgorithm.Sorted = true;
            this.SelectedAlgorithm.TabIndex = 5;
            this.SelectedAlgorithm.SelectedIndexChanged += new System.EventHandler(this.SelectAlgorithm_SelectedIndexChanged);
            // 
            // BlackBox
            // 
            this.BlackBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackBox.BackColor = System.Drawing.Color.Black;
            this.BlackBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BlackBox.Location = new System.Drawing.Point(382, 0);
            this.BlackBox.Margin = new System.Windows.Forms.Padding(0);
            this.BlackBox.Name = "BlackBox";
            this.BlackBox.Size = new System.Drawing.Size(1200, 853);
            this.BlackBox.TabIndex = 6;
            this.BlackBox.TabStop = false;
            // 
            // Shuffle
            // 
            this.Shuffle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Shuffle.Location = new System.Drawing.Point(252, 204);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(100, 40);
            this.Shuffle.TabIndex = 8;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Sort
            // 
            this.Sort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sort.Location = new System.Drawing.Point(30, 204);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(100, 40);
            this.Sort.TabIndex = 9;
            this.Sort.Text = "Sort!";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // AdjustNumberOfElements
            // 
            this.AdjustNumberOfElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdjustNumberOfElements.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AdjustNumberOfElements.Location = new System.Drawing.Point(210, 25);
            this.AdjustNumberOfElements.Margin = new System.Windows.Forms.Padding(0);
            this.AdjustNumberOfElements.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.AdjustNumberOfElements.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustNumberOfElements.Name = "AdjustNumberOfElements";
            this.AdjustNumberOfElements.ReadOnly = true;
            this.AdjustNumberOfElements.Size = new System.Drawing.Size(60, 22);
            this.AdjustNumberOfElements.TabIndex = 10;
            this.AdjustNumberOfElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdjustNumberOfElements.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustNumberOfElements.ValueChanged += new System.EventHandler(this.AdjustNumberOfElements_ValueChanged);
            // 
            // AdjustSortingSpeed
            // 
            this.AdjustSortingSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdjustSortingSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustSortingSpeed.Location = new System.Drawing.Point(210, 60);
            this.AdjustSortingSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.AdjustSortingSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AdjustSortingSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustSortingSpeed.Name = "AdjustSortingSpeed";
            this.AdjustSortingSpeed.ReadOnly = true;
            this.AdjustSortingSpeed.Size = new System.Drawing.Size(60, 22);
            this.AdjustSortingSpeed.TabIndex = 10;
            this.AdjustSortingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdjustSortingSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AdjustSortingSpeed.ValueChanged += new System.EventHandler(this.AdjustSortingSpeed_ValueChanged);
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoBox.BackColor = System.Drawing.Color.White;
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoBox.Location = new System.Drawing.Point(30, 250);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(322, 578);
            this.InfoBox.TabIndex = 11;
            this.InfoBox.TabStop = false;
            // 
            // TimeComplexity
            // 
            this.TimeComplexity.BackColor = System.Drawing.Color.LightGray;
            this.TimeComplexity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeComplexity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeComplexity.Location = new System.Drawing.Point(210, 130);
            this.TimeComplexity.Margin = new System.Windows.Forms.Padding(0);
            this.TimeComplexity.Name = "TimeComplexity";
            this.TimeComplexity.ReadOnly = true;
            this.TimeComplexity.Size = new System.Drawing.Size(140, 23);
            this.TimeComplexity.TabIndex = 12;
            // 
            // SpaceComplexity
            // 
            this.SpaceComplexity.BackColor = System.Drawing.Color.LightGray;
            this.SpaceComplexity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpaceComplexity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceComplexity.Location = new System.Drawing.Point(210, 165);
            this.SpaceComplexity.Margin = new System.Windows.Forms.Padding(0);
            this.SpaceComplexity.Name = "SpaceComplexity";
            this.SpaceComplexity.ReadOnly = true;
            this.SpaceComplexity.Size = new System.Drawing.Size(140, 23);
            this.SpaceComplexity.TabIndex = 13;
            // 
            // SpaceComplexityLabel
            // 
            this.SpaceComplexityLabel.AutoSize = true;
            this.SpaceComplexityLabel.Location = new System.Drawing.Point(67, 165);
            this.SpaceComplexityLabel.Name = "SpaceComplexityLabel";
            this.SpaceComplexityLabel.Size = new System.Drawing.Size(123, 17);
            this.SpaceComplexityLabel.TabIndex = 14;
            this.SpaceComplexityLabel.Text = "Space Complexity:";
            // 
            // blackBoxBW
            // 
            this.blackBoxBW.WorkerSupportsCancellation = true;
            this.blackBoxBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BlackBoxBackgroundWorker);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.SpaceComplexityLabel);
            this.Controls.Add(this.SpaceComplexity);
            this.Controls.Add(this.TimeComplexity);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.AdjustSortingSpeed);
            this.Controls.Add(this.AdjustNumberOfElements);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.BlackBox);
            this.Controls.Add(this.SelectedAlgorithm);
            this.Controls.Add(this.SortingSpeedLabel);
            this.Controls.Add(this.NumberOfElementsLabel);
            this.Controls.Add(this.TimeComplexityLabel);
            this.Controls.Add(this.SelectedAlgorithmLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "n²";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BlackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustNumberOfElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustSortingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedAlgorithmLabel;
        private System.Windows.Forms.Label NumberOfElementsLabel;
        private System.Windows.Forms.Label SortingSpeedLabel;
        private System.Windows.Forms.Label TimeComplexityLabel;
        private System.Windows.Forms.ComboBox SelectedAlgorithm;
        private System.Windows.Forms.PictureBox BlackBox;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.NumericUpDown AdjustNumberOfElements;
        private System.Windows.Forms.NumericUpDown AdjustSortingSpeed;
        private System.Windows.Forms.PictureBox InfoBox;
        private System.Windows.Forms.TextBox TimeComplexity;
        private System.Windows.Forms.TextBox SpaceComplexity;
        private System.Windows.Forms.Label SpaceComplexityLabel;
        private System.ComponentModel.BackgroundWorker blackBoxBW;
    }
}

