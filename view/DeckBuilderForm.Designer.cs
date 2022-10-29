namespace YugiohApp.view {
    partial class DeckBuilderForm {
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
            this.panelYugioh = new System.Windows.Forms.Panel();
            this.labelSQLTime = new System.Windows.Forms.Label();
            this.labelJsonTime = new System.Windows.Forms.Label();
            this.labelSQLResult = new System.Windows.Forms.Label();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.buttonRemoveCard = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.flowLayoutPanelDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelYugioh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYugioh
            // 
            this.panelYugioh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYugioh.Controls.Add(this.labelSQLTime);
            this.panelYugioh.Controls.Add(this.labelJsonTime);
            this.panelYugioh.Controls.Add(this.labelSQLResult);
            this.panelYugioh.Controls.Add(this.buttonSQL);
            this.panelYugioh.Controls.Add(this.buttonRemoveCard);
            this.panelYugioh.Controls.Add(this.buttonAddCard);
            this.panelYugioh.Controls.Add(this.flowLayoutPanelDeck);
            this.panelYugioh.Controls.Add(this.panelCard);
            this.panelYugioh.Controls.Add(this.flowLayoutPanelCards);
            this.panelYugioh.Controls.Add(this.textBoxSearch);
            this.panelYugioh.Controls.Add(this.buttonSearch);
            this.panelYugioh.Location = new System.Drawing.Point(12, 12);
            this.panelYugioh.Margin = new System.Windows.Forms.Padding(0);
            this.panelYugioh.Name = "panelYugioh";
            this.panelYugioh.Size = new System.Drawing.Size(1240, 657);
            this.panelYugioh.TabIndex = 0;
            // 
            // labelSQLTime
            // 
            this.labelSQLTime.AutoSize = true;
            this.labelSQLTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSQLTime.Location = new System.Drawing.Point(819, 48);
            this.labelSQLTime.Name = "labelSQLTime";
            this.labelSQLTime.Size = new System.Drawing.Size(64, 17);
            this.labelSQLTime.TabIndex = 18;
            this.labelSQLTime.Text = "SQL Time";
            // 
            // labelJsonTime
            // 
            this.labelJsonTime.AutoSize = true;
            this.labelJsonTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJsonTime.Location = new System.Drawing.Point(672, 48);
            this.labelJsonTime.Name = "labelJsonTime";
            this.labelJsonTime.Size = new System.Drawing.Size(69, 17);
            this.labelJsonTime.TabIndex = 17;
            this.labelJsonTime.Text = "Json Time";
            // 
            // labelSQLResult
            // 
            this.labelSQLResult.AutoSize = true;
            this.labelSQLResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSQLResult.Location = new System.Drawing.Point(1018, 137);
            this.labelSQLResult.Name = "labelSQLResult";
            this.labelSQLResult.Size = new System.Drawing.Size(45, 17);
            this.labelSQLResult.TabIndex = 16;
            this.labelSQLResult.Text = "Result";
            // 
            // buttonSQL
            // 
            this.buttonSQL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSQL.Location = new System.Drawing.Point(981, 83);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(119, 41);
            this.buttonSQL.TabIndex = 15;
            this.buttonSQL.Text = "SQL";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCard.Location = new System.Drawing.Point(981, 36);
            this.buttonRemoveCard.Name = "buttonRemoveCard";
            this.buttonRemoveCard.Size = new System.Drawing.Size(70, 41);
            this.buttonRemoveCard.TabIndex = 14;
            this.buttonRemoveCard.Text = "Remove";
            this.buttonRemoveCard.UseVisualStyleBackColor = true;
            this.buttonRemoveCard.Click += new System.EventHandler(this.buttonRemoveCard_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCard.Location = new System.Drawing.Point(1057, 36);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(43, 41);
            this.buttonAddCard.TabIndex = 13;
            this.buttonAddCard.Text = "Add";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // flowLayoutPanelDeck
            // 
            this.flowLayoutPanelDeck.AllowDrop = true;
            this.flowLayoutPanelDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDeck.AutoScroll = true;
            this.flowLayoutPanelDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelDeck.Location = new System.Drawing.Point(284, 82);
            this.flowLayoutPanelDeck.Name = "flowLayoutPanelDeck";
            this.flowLayoutPanelDeck.Size = new System.Drawing.Size(687, 572);
            this.flowLayoutPanelDeck.TabIndex = 12;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point(3, 82);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(275, 572);
            this.panelCard.TabIndex = 10;
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(1106, 82);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(131, 570);
            this.flowLayoutPanelCards.TabIndex = 9;
            this.flowLayoutPanelCards.WrapContents = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(1106, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(131, 27);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(1106, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 41);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // DeckBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelYugioh);
            this.Name = "DeckBuilderForm";
            this.Text = "YugiohForm";
            this.Load += new System.EventHandler(this.YugiohForm_Load);
            this.panelYugioh.ResumeLayout(false);
            this.panelYugioh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelYugioh;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private FlowLayoutPanel flowLayoutPanelCards;
        private Panel panelCard;
        private FlowLayoutPanel flowLayoutPanelDeck;
        private Button buttonAddCard;
        private Button buttonRemoveCard;
        private Button buttonSQL;
        private Label labelSQLResult;
        private Label labelSQLTime;
        private Label labelJsonTime;
    }
}