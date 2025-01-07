namespace MockQuiz
{
    partial class QuestionCreationForm
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
            submitQuestionInfoButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            answerOptionsLabel = new Label();
            isCorrectCheckBox1 = new CheckBox();
            firstAnswerTextBox = new TextBox();
            isCorrectCheckBox2 = new CheckBox();
            isCorrectCheckBox3 = new CheckBox();
            isCorrectCheckBox4 = new CheckBox();
            secondAnswerTextbox = new TextBox();
            thirdAnswerTextbox = new TextBox();
            fourthAnswerTextbox = new TextBox();
            questionTextBox = new TextBox();
            SuspendLayout();
            // 
            // submitQuestionInfoButton
            // 
            submitQuestionInfoButton.Location = new Point(991, 504);
            submitQuestionInfoButton.Margin = new Padding(5);
            submitQuestionInfoButton.Name = "submitQuestionInfoButton";
            submitQuestionInfoButton.Size = new Size(243, 45);
            submitQuestionInfoButton.TabIndex = 0;
            submitQuestionInfoButton.Text = "Next Question";
            submitQuestionInfoButton.UseVisualStyleBackColor = true;
            submitQuestionInfoButton.Click += submitQuestionInfoButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(562, 14);
            questionNumberLabel.Margin = new Padding(5, 0, 5, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(196, 31);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Question Number";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(562, 85);
            questionTextLabel.Margin = new Padding(5, 0, 5, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(153, 31);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Question Text";
            // 
            // answerOptionsLabel
            // 
            answerOptionsLabel.AutoSize = true;
            answerOptionsLabel.Location = new Point(562, 237);
            answerOptionsLabel.Margin = new Padding(5, 0, 5, 0);
            answerOptionsLabel.Name = "answerOptionsLabel";
            answerOptionsLabel.Size = new Size(176, 31);
            answerOptionsLabel.TabIndex = 3;
            answerOptionsLabel.Text = "Answer Options";
            // 
            // isCorrectCheckBox1
            // 
            isCorrectCheckBox1.AutoSize = true;
            isCorrectCheckBox1.Location = new Point(370, 389);
            isCorrectCheckBox1.Margin = new Padding(5);
            isCorrectCheckBox1.Name = "isCorrectCheckBox1";
            isCorrectCheckBox1.Size = new Size(191, 35);
            isCorrectCheckBox1.TabIndex = 4;
            isCorrectCheckBox1.Text = "Correct Answer";
            isCorrectCheckBox1.UseVisualStyleBackColor = true;
            // 
            // firstAnswerTextBox
            // 
            firstAnswerTextBox.Location = new Point(370, 338);
            firstAnswerTextBox.Margin = new Padding(5);
            firstAnswerTextBox.Name = "firstAnswerTextBox";
            firstAnswerTextBox.Size = new Size(201, 38);
            firstAnswerTextBox.TabIndex = 5;
            // 
            // isCorrectCheckBox2
            // 
            isCorrectCheckBox2.AutoSize = true;
            isCorrectCheckBox2.Location = new Point(714, 389);
            isCorrectCheckBox2.Margin = new Padding(5);
            isCorrectCheckBox2.Name = "isCorrectCheckBox2";
            isCorrectCheckBox2.Size = new Size(191, 35);
            isCorrectCheckBox2.TabIndex = 6;
            isCorrectCheckBox2.Text = "Correct Answer";
            isCorrectCheckBox2.UseVisualStyleBackColor = true;
            // 
            // isCorrectCheckBox3
            // 
            isCorrectCheckBox3.AutoSize = true;
            isCorrectCheckBox3.Location = new Point(370, 510);
            isCorrectCheckBox3.Margin = new Padding(5);
            isCorrectCheckBox3.Name = "isCorrectCheckBox3";
            isCorrectCheckBox3.Size = new Size(191, 35);
            isCorrectCheckBox3.TabIndex = 7;
            isCorrectCheckBox3.Text = "Correct Answer";
            isCorrectCheckBox3.UseVisualStyleBackColor = true;
            // 
            // isCorrectCheckBox4
            // 
            isCorrectCheckBox4.AutoSize = true;
            isCorrectCheckBox4.Location = new Point(714, 510);
            isCorrectCheckBox4.Margin = new Padding(5);
            isCorrectCheckBox4.Name = "isCorrectCheckBox4";
            isCorrectCheckBox4.Size = new Size(191, 35);
            isCorrectCheckBox4.TabIndex = 8;
            isCorrectCheckBox4.Text = "Correct Answer";
            isCorrectCheckBox4.UseVisualStyleBackColor = true;
            // 
            // secondAnswerTextbox
            // 
            secondAnswerTextbox.Location = new Point(714, 338);
            secondAnswerTextbox.Margin = new Padding(5);
            secondAnswerTextbox.Name = "secondAnswerTextbox";
            secondAnswerTextbox.Size = new Size(201, 38);
            secondAnswerTextbox.TabIndex = 9;
            // 
            // thirdAnswerTextbox
            // 
            thirdAnswerTextbox.Location = new Point(370, 462);
            thirdAnswerTextbox.Margin = new Padding(5);
            thirdAnswerTextbox.Name = "thirdAnswerTextbox";
            thirdAnswerTextbox.Size = new Size(201, 38);
            thirdAnswerTextbox.TabIndex = 10;
            // 
            // fourthAnswerTextbox
            // 
            fourthAnswerTextbox.Location = new Point(714, 462);
            fourthAnswerTextbox.Margin = new Padding(5);
            fourthAnswerTextbox.Name = "fourthAnswerTextbox";
            fourthAnswerTextbox.Size = new Size(201, 38);
            fourthAnswerTextbox.TabIndex = 11;
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(370, 142);
            questionTextBox.Margin = new Padding(5);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(545, 38);
            questionTextBox.TabIndex = 12;
            // 
            // QuestionCreationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 697);
            Controls.Add(questionTextBox);
            Controls.Add(fourthAnswerTextbox);
            Controls.Add(thirdAnswerTextbox);
            Controls.Add(secondAnswerTextbox);
            Controls.Add(isCorrectCheckBox4);
            Controls.Add(isCorrectCheckBox3);
            Controls.Add(isCorrectCheckBox2);
            Controls.Add(firstAnswerTextBox);
            Controls.Add(isCorrectCheckBox1);
            Controls.Add(answerOptionsLabel);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(submitQuestionInfoButton);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "QuestionCreationForm";
            Text = "QuestionCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitQuestionInfoButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private Label answerOptionsLabel;
        private CheckBox isCorrectCheckBox1;
        private TextBox firstAnswerTextBox;
        private CheckBox isCorrectCheckBox2;
        private CheckBox isCorrectCheckBox3;
        private CheckBox isCorrectCheckBox4;
        private TextBox secondAnswerTextbox;
        private TextBox thirdAnswerTextbox;
        private TextBox fourthAnswerTextbox;
        private TextBox questionTextBox;
    }
}