namespace YugiohApp.view {
    partial class QuizForm {
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonRevealMore = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonGuessD = new System.Windows.Forms.RadioButton();
            this.radioButtonGuessC = new System.Windows.Forms.RadioButton();
            this.radioButtonGuessB = new System.Windows.Forms.RadioButton();
            this.radioButtonGuessA = new System.Windows.Forms.RadioButton();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.panelQuiz.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(857, 532);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(139, 62);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelQuiz
            // 
            this.panelQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuiz.Controls.Add(this.labelResult);
            this.panelQuiz.Controls.Add(this.buttonRevealMore);
            this.panelQuiz.Controls.Add(this.buttonConfirm);
            this.panelQuiz.Controls.Add(this.panel1);
            this.panelQuiz.Controls.Add(this.pictureBoxCard);
            this.panelQuiz.Controls.Add(this.buttonPlay);
            this.panelQuiz.Location = new System.Drawing.Point(12, 12);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(999, 597);
            this.panelQuiz.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(680, 94);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(113, 39);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result:";
            // 
            // buttonRevealMore
            // 
            this.buttonRevealMore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRevealMore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRevealMore.Location = new System.Drawing.Point(259, 257);
            this.buttonRevealMore.Name = "buttonRevealMore";
            this.buttonRevealMore.Size = new System.Drawing.Size(139, 62);
            this.buttonRevealMore.TabIndex = 5;
            this.buttonRevealMore.Text = "Reveal More";
            this.buttonRevealMore.UseVisualStyleBackColor = true;
            this.buttonRevealMore.Click += new System.EventHandler(this.buttonRevealMore_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(625, 257);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(139, 62);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioButtonGuessD);
            this.panel1.Controls.Add(this.radioButtonGuessC);
            this.panel1.Controls.Add(this.radioButtonGuessB);
            this.panel1.Controls.Add(this.radioButtonGuessA);
            this.panel1.Location = new System.Drawing.Point(202, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 269);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonGuessD
            // 
            this.radioButtonGuessD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonGuessD.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGuessD.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGuessD.Location = new System.Drawing.Point(334, 158);
            this.radioButtonGuessD.Name = "radioButtonGuessD";
            this.radioButtonGuessD.Size = new System.Drawing.Size(257, 84);
            this.radioButtonGuessD.TabIndex = 3;
            this.radioButtonGuessD.TabStop = true;
            this.radioButtonGuessD.Text = "D:";
            this.radioButtonGuessD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGuessD.UseVisualStyleBackColor = true;
            this.radioButtonGuessD.CheckedChanged += new System.EventHandler(this.radioButtonGuessD_CheckedChanged);
            // 
            // radioButtonGuessC
            // 
            this.radioButtonGuessC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonGuessC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGuessC.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGuessC.Location = new System.Drawing.Point(24, 158);
            this.radioButtonGuessC.Name = "radioButtonGuessC";
            this.radioButtonGuessC.Size = new System.Drawing.Size(257, 84);
            this.radioButtonGuessC.TabIndex = 2;
            this.radioButtonGuessC.TabStop = true;
            this.radioButtonGuessC.Text = "C:";
            this.radioButtonGuessC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGuessC.UseVisualStyleBackColor = true;
            this.radioButtonGuessC.CheckedChanged += new System.EventHandler(this.radioButtonGuessC_CheckedChanged);
            // 
            // radioButtonGuessB
            // 
            this.radioButtonGuessB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonGuessB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGuessB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGuessB.Location = new System.Drawing.Point(334, 24);
            this.radioButtonGuessB.Name = "radioButtonGuessB";
            this.radioButtonGuessB.Size = new System.Drawing.Size(257, 84);
            this.radioButtonGuessB.TabIndex = 1;
            this.radioButtonGuessB.TabStop = true;
            this.radioButtonGuessB.Text = "B:";
            this.radioButtonGuessB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGuessB.UseVisualStyleBackColor = true;
            this.radioButtonGuessB.CheckedChanged += new System.EventHandler(this.radioButtonGuessB_CheckedChanged);
            // 
            // radioButtonGuessA
            // 
            this.radioButtonGuessA.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGuessA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGuessA.Location = new System.Drawing.Point(24, 24);
            this.radioButtonGuessA.Name = "radioButtonGuessA";
            this.radioButtonGuessA.Size = new System.Drawing.Size(257, 84);
            this.radioButtonGuessA.TabIndex = 0;
            this.radioButtonGuessA.TabStop = true;
            this.radioButtonGuessA.Text = "A:";
            this.radioButtonGuessA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGuessA.UseVisualStyleBackColor = true;
            this.radioButtonGuessA.CheckedChanged += new System.EventHandler(this.radioButtonGuessA_CheckedChanged);
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCard.Location = new System.Drawing.Point(404, 3);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(215, 316);
            this.pictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard.TabIndex = 2;
            this.pictureBoxCard.TabStop = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 621);
            this.Controls.Add(this.panelQuiz);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.panelQuiz.ResumeLayout(false);
            this.panelQuiz.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPlay;
        private Panel panelQuiz;
        private PictureBox pictureBoxCard;
        private Panel panel1;
        private RadioButton radioButtonGuessA;
        private RadioButton radioButtonGuessD;
        private RadioButton radioButtonGuessC;
        private RadioButton radioButtonGuessB;
        private Button buttonConfirm;
        private Button buttonRevealMore;
        private Label labelResult;
    }
}