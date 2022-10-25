namespace YugiohApp.view {
    partial class YugiohForm {
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
            this.flowLayoutPanelDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.labelId = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.buttonRemoveCard = new System.Windows.Forms.Button();
            this.panelYugioh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYugioh
            // 
            this.panelYugioh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYugioh.Controls.Add(this.buttonRemoveCard);
            this.panelYugioh.Controls.Add(this.buttonAddCard);
            this.panelYugioh.Controls.Add(this.flowLayoutPanelDeck);
            this.panelYugioh.Controls.Add(this.labelId);
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
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(915, 4);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 24);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "Id";
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
            this.flowLayoutPanelCards.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(1106, 83);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(131, 569);
            this.flowLayoutPanelCards.TabIndex = 9;
            this.flowLayoutPanelCards.WrapContents = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(1106, 1);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(131, 27);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(1106, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 43);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCard.Location = new System.Drawing.Point(1057, 34);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(43, 43);
            this.buttonAddCard.TabIndex = 13;
            this.buttonAddCard.Text = "Add";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCard.Location = new System.Drawing.Point(981, 34);
            this.buttonRemoveCard.Name = "buttonRemoveCard";
            this.buttonRemoveCard.Size = new System.Drawing.Size(70, 43);
            this.buttonRemoveCard.TabIndex = 14;
            this.buttonRemoveCard.Text = "Remove";
            this.buttonRemoveCard.UseVisualStyleBackColor = true;
            this.buttonRemoveCard.Click += new System.EventHandler(this.buttonRemoveCard_Click);
            // 
            // YugiohForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelYugioh);
            this.Name = "YugiohForm";
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
        private Label labelId;
        private FlowLayoutPanel flowLayoutPanelDeck;
        private Button buttonAddCard;
        private Button buttonRemoveCard;
    }
}