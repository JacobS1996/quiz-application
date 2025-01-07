namespace MockQuiz
{
    partial class QuizCreatorForm
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
            quizTitleLabel = new Label();
            numberOfQuestionsLabel = new Label();
            passingPercentageLabel = new Label();
            quizTitleTextbox = new TextBox();
            questionCountTextbox = new TextBox();
            passingPercentageTextbox = new TextBox();
            initiateQuizSetupButton = new Button();
            SuspendLayout();
            // 
            // quizTitleLabel
            // 
            quizTitleLabel.AutoSize = true;
            quizTitleLabel.Location = new Point(472, 112);
            quizTitleLabel.Name = "quizTitleLabel";
            quizTitleLabel.Size = new Size(110, 31);
            quizTitleLabel.TabIndex = 0;
            quizTitleLabel.Text = "Quiz Title";
            // 
            // numberOfQuestionsLabel
            // 
            numberOfQuestionsLabel.AutoSize = true;
            numberOfQuestionsLabel.Location = new Point(350, 235);
            numberOfQuestionsLabel.Name = "numberOfQuestionsLabel";
            numberOfQuestionsLabel.Size = new Size(232, 31);
            numberOfQuestionsLabel.TabIndex = 1;
            numberOfQuestionsLabel.Text = "Number of Questions";
            // 
            // passingPercentageLabel
            // 
            passingPercentageLabel.AutoSize = true;
            passingPercentageLabel.Location = new Point(279, 378);
            passingPercentageLabel.Name = "passingPercentageLabel";
            passingPercentageLabel.Size = new Size(303, 31);
            passingPercentageLabel.TabIndex = 2;
            passingPercentageLabel.Text = "Required Percentage to Pass";
            // 
            // quizTitleTextbox
            // 
            quizTitleTextbox.Location = new Point(723, 109);
            quizTitleTextbox.Name = "quizTitleTextbox";
            quizTitleTextbox.Size = new Size(125, 38);
            quizTitleTextbox.TabIndex = 3;
            // 
            // questionCountTextbox
            // 
            questionCountTextbox.Location = new Point(723, 232);
            questionCountTextbox.Name = "questionCountTextbox";
            questionCountTextbox.Size = new Size(125, 38);
            questionCountTextbox.TabIndex = 4;
            // 
            // passingPercentageTextbox
            // 
            passingPercentageTextbox.Location = new Point(723, 375);
            passingPercentageTextbox.Name = "passingPercentageTextbox";
            passingPercentageTextbox.Size = new Size(125, 38);
            passingPercentageTextbox.TabIndex = 5;
            // 
            // initiateQuizSetupButton
            // 
            initiateQuizSetupButton.Location = new Point(723, 508);
            initiateQuizSetupButton.Name = "initiateQuizSetupButton";
            initiateQuizSetupButton.Size = new Size(125, 44);
            initiateQuizSetupButton.TabIndex = 6;
            initiateQuizSetupButton.Text = "Continue";
            initiateQuizSetupButton.UseVisualStyleBackColor = true;
            initiateQuizSetupButton.Click += initiateQuizSetupButton_Click;
            // 
            // QuizCreatorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(initiateQuizSetupButton);
            Controls.Add(passingPercentageTextbox);
            Controls.Add(questionCountTextbox);
            Controls.Add(quizTitleTextbox);
            Controls.Add(passingPercentageLabel);
            Controls.Add(numberOfQuestionsLabel);
            Controls.Add(quizTitleLabel);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "QuizCreatorForm";
            Text = "QuizCreatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quizTitleLabel;
        private Label numberOfQuestionsLabel;
        private Label passingPercentageLabel;
        private TextBox quizTitleTextbox;
        private TextBox questionCountTextbox;
        private TextBox passingPercentageTextbox;
        private Button initiateQuizSetupButton;
    }
}