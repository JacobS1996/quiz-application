namespace MockQuiz
{
	partial class Dashboard
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
            selectQuizButton = new Button();
            quizListBox = new ListBox();
            quizAppLabel = new Label();
            createQuizButton = new Button();
            SuspendLayout();
            // 
            // selectQuizButton
            // 
            selectQuizButton.Location = new Point(742, 506);
            selectQuizButton.Margin = new Padding(5);
            selectQuizButton.Name = "selectQuizButton";
            selectQuizButton.Size = new Size(153, 45);
            selectQuizButton.TabIndex = 0;
            selectQuizButton.Text = "Take Quiz";
            selectQuizButton.UseVisualStyleBackColor = true;
            selectQuizButton.Click += selectQuizButton_Click;
            // 
            // quizListBox
            // 
            quizListBox.FormattingEnabled = true;
            quizListBox.ItemHeight = 31;
            quizListBox.Location = new Point(54, 206);
            quizListBox.Margin = new Padding(5);
            quizListBox.Name = "quizListBox";
            quizListBox.Size = new Size(678, 345);
            quizListBox.TabIndex = 1;
            // 
            // quizAppLabel
            // 
            quizAppLabel.AutoSize = true;
            quizAppLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quizAppLabel.Location = new Point(548, 44);
            quizAppLabel.Margin = new Padding(5, 0, 5, 0);
            quizAppLabel.Name = "quizAppLabel";
            quizAppLabel.Size = new Size(267, 46);
            quizAppLabel.TabIndex = 2;
            quizAppLabel.Text = "Quiz Application";
            // 
            // createQuizButton
            // 
            createQuizButton.Location = new Point(1067, 48);
            createQuizButton.Margin = new Padding(5);
            createQuizButton.Name = "createQuizButton";
            createQuizButton.Size = new Size(219, 45);
            createQuizButton.TabIndex = 3;
            createQuizButton.Text = "Create New Quiz";
            createQuizButton.UseVisualStyleBackColor = true;
            createQuizButton.Click += createQuizButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 697);
            Controls.Add(createQuizButton);
            Controls.Add(quizAppLabel);
            Controls.Add(quizListBox);
            Controls.Add(selectQuizButton);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Dashboard";
            Text = "Home Page";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectQuizButton;
        private ListBox quizListBox;
        private Label quizAppLabel;
        private Button createQuizButton;
    }
}