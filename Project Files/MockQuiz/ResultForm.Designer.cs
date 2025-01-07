namespace MockQuiz
{
    partial class ResultForm
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
            yourScoreLabel = new Label();
            userScore = new Label();
            returnHomeButton = new Button();
            passFailLabel = new Label();
            SuspendLayout();
            // 
            // yourScoreLabel
            // 
            yourScoreLabel.AutoSize = true;
            yourScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yourScoreLabel.Location = new Point(627, 234);
            yourScoreLabel.Name = "yourScoreLabel";
            yourScoreLabel.Size = new Size(174, 41);
            yourScoreLabel.TabIndex = 0;
            yourScoreLabel.Text = "Your Score: ";
            // 
            // userScore
            // 
            userScore.AutoSize = true;
            userScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userScore.Location = new Point(627, 301);
            userScore.Name = "userScore";
            userScore.Size = new Size(409, 41);
            userScore.TabIndex = 1;
            userScore.Text = "Score Will Display At Runtime";
            userScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(637, 413);
            returnHomeButton.Margin = new Padding(3, 4, 3, 4);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(224, 67);
            returnHomeButton.TabIndex = 2;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += returnHomeButton_Click;
            // 
            // passFailLabel
            // 
            passFailLabel.AutoSize = true;
            passFailLabel.Location = new Point(562, 105);
            passFailLabel.Name = "passFailLabel";
            passFailLabel.Size = new Size(239, 38);
            passFailLabel.TabIndex = 3;
            passFailLabel.Text = "Pass/Fail Message";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 833);
            Controls.Add(passFailLabel);
            Controls.Add(returnHomeButton);
            Controls.Add(userScore);
            Controls.Add(yourScoreLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ResultForm";
            Text = "ResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yourScoreLabel;
        private Label userScore;
        private Button returnHomeButton;
        private Label passFailLabel;
    }
}