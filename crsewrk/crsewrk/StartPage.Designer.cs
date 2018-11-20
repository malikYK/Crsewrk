namespace crsewrk
{
    partial class StartPage
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
            this.QuizPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuizPage
            // 
            this.QuizPage.Location = new System.Drawing.Point(112, 116);
            this.QuizPage.Name = "QuizPage";
            this.QuizPage.Size = new System.Drawing.Size(186, 95);
            this.QuizPage.TabIndex = 0;
            this.QuizPage.Text = "Quiz Page";
            this.QuizPage.UseVisualStyleBackColor = true;
            this.QuizPage.Click += new System.EventHandler(this.QuizPage_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.QuizPage);
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuizPage;
    }
}

