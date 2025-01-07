namespace MockQuiz
{
    partial class QuestionForm
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
            nextQuestionButton = new Button();
            questionText = new Label();
            checkBoxListOfAnswers = new CheckedListBox();
            SuspendLayout();
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new Point(994, 606);
            nextQuestionButton.Margin = new Padding(5);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new Size(212, 45);
            nextQuestionButton.TabIndex = 1;
            nextQuestionButton.Text = "Continue";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += NextQuestionButton_Click;
            // 
            // questionText
            // 
            questionText.AutoSize = true;
            questionText.Location = new Point(332, 139);
            questionText.Name = "questionText";
            questionText.Size = new Size(262, 31);
            questionText.TabIndex = 3;
            questionText.Text = "Text supplied at runtime";
            // 
            // checkBoxListOfAnswers
            // 
            checkBoxListOfAnswers.CheckOnClick = true;
            checkBoxListOfAnswers.FormattingEnabled = true;
            checkBoxListOfAnswers.Location = new Point(332, 288);
            checkBoxListOfAnswers.Name = "checkBoxListOfAnswers";
            checkBoxListOfAnswers.Size = new Size(562, 268);
            checkBoxListOfAnswers.TabIndex = 4;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 697);
            Controls.Add(checkBoxListOfAnswers);
            Controls.Add(questionText);
            Controls.Add(nextQuestionButton);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "QuestionForm";
            Text = "Quiz App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button nextQuestionButton;
        private Label questionText;
        private CheckedListBox checkBoxListOfAnswers;
    }
}
