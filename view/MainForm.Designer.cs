namespace YugiohApp.view {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonQuiz = new System.Windows.Forms.Button();
            this.buttonDeckBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuiz.Location = new System.Drawing.Point(94, 141);
            this.buttonQuiz.Name = "buttonQuiz";
            this.buttonQuiz.Size = new System.Drawing.Size(200, 100);
            this.buttonQuiz.TabIndex = 0;
            this.buttonQuiz.Text = "Quiz";
            this.buttonQuiz.UseVisualStyleBackColor = true;
            this.buttonQuiz.Click += new System.EventHandler(this.buttonQuiz_Click);
            // 
            // buttonDeckBuilder
            // 
            this.buttonDeckBuilder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeckBuilder.Location = new System.Drawing.Point(411, 141);
            this.buttonDeckBuilder.Name = "buttonDeckBuilder";
            this.buttonDeckBuilder.Size = new System.Drawing.Size(200, 100);
            this.buttonDeckBuilder.TabIndex = 1;
            this.buttonDeckBuilder.Text = "Deck Builder";
            this.buttonDeckBuilder.UseVisualStyleBackColor = true;
            this.buttonDeckBuilder.Click += new System.EventHandler(this.buttonDeckBuilder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 382);
            this.Controls.Add(this.buttonDeckBuilder);
            this.Controls.Add(this.buttonQuiz);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonQuiz;
        private Button buttonDeckBuilder;
    }
}