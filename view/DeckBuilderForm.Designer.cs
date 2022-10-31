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
            this.panelPage = new System.Windows.Forms.Panel();
            this.labelCardsInSearchResult = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelPageSeparator = new System.Windows.Forms.Label();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.panelSpecificSearch = new System.Windows.Forms.Panel();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.radioButtonLevelEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelAll = new System.Windows.Forms.RadioButton();
            this.panelDef = new System.Windows.Forms.Panel();
            this.radioButtonDefEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefAll = new System.Windows.Forms.RadioButton();
            this.labelType = new System.Windows.Forms.Label();
            this.panelAtk = new System.Windows.Forms.Panel();
            this.radioButtonAtkEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkAll = new System.Windows.Forms.RadioButton();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.textBoxAtk = new System.Windows.Forms.TextBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.labelAtk = new System.Windows.Forms.Label();
            this.comboBoxAttribute = new System.Windows.Forms.ComboBox();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.buttonRemoveCard = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.flowLayoutPanelDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelYugioh.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.panelSpecificSearch.SuspendLayout();
            this.panelLevel.SuspendLayout();
            this.panelDef.SuspendLayout();
            this.panelAtk.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYugioh
            // 
            this.panelYugioh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelYugioh.Controls.Add(this.panelPage);
            this.panelYugioh.Controls.Add(this.panelSpecificSearch);
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
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Controls.Add(this.labelCardsInSearchResult);
            this.panelPage.Controls.Add(this.buttonPrevious);
            this.panelPage.Controls.Add(this.labelPageSeparator);
            this.panelPage.Controls.Add(this.labelTotalPages);
            this.panelPage.Controls.Add(this.buttonNext);
            this.panelPage.Controls.Add(this.labelCurrentPage);
            this.panelPage.Location = new System.Drawing.Point(1091, 584);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(146, 64);
            this.panelPage.TabIndex = 41;
            // 
            // labelCardsInSearchResult
            // 
            this.labelCardsInSearchResult.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardsInSearchResult.Location = new System.Drawing.Point(41, 35);
            this.labelCardsInSearchResult.Name = "labelCardsInSearchResult";
            this.labelCardsInSearchResult.Size = new System.Drawing.Size(64, 21);
            this.labelCardsInSearchResult.TabIndex = 39;
            this.labelCardsInSearchResult.Text = "1";
            this.labelCardsInSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(3, 29);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(32, 32);
            this.buttonPrevious.TabIndex = 36;
            this.buttonPrevious.Text = "←";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelPageSeparator
            // 
            this.labelPageSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageSeparator.AutoSize = true;
            this.labelPageSeparator.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPageSeparator.Location = new System.Drawing.Point(65, 6);
            this.labelPageSeparator.Name = "labelPageSeparator";
            this.labelPageSeparator.Size = new System.Drawing.Size(16, 20);
            this.labelPageSeparator.TabIndex = 0;
            this.labelPageSeparator.Text = "/";
            this.labelPageSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPages.Location = new System.Drawing.Point(87, 6);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(56, 20);
            this.labelTotalPages.TabIndex = 38;
            this.labelTotalPages.Text = "1";
            this.labelTotalPages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(111, 29);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(32, 32);
            this.buttonNext.TabIndex = 37;
            this.buttonNext.Text = "→";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPage.Location = new System.Drawing.Point(3, 6);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(56, 20);
            this.labelCurrentPage.TabIndex = 0;
            this.labelCurrentPage.Text = "1";
            this.labelCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSpecificSearch
            // 
            this.panelSpecificSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelSpecificSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpecificSearch.Controls.Add(this.panelLevel);
            this.panelSpecificSearch.Controls.Add(this.panelDef);
            this.panelSpecificSearch.Controls.Add(this.labelType);
            this.panelSpecificSearch.Controls.Add(this.panelAtk);
            this.panelSpecificSearch.Controls.Add(this.labelAttribute);
            this.panelSpecificSearch.Controls.Add(this.textBoxAtk);
            this.panelSpecificSearch.Controls.Add(this.labelRace);
            this.panelSpecificSearch.Controls.Add(this.comboBoxType);
            this.panelSpecificSearch.Controls.Add(this.labelLevel);
            this.panelSpecificSearch.Controls.Add(this.labelDef);
            this.panelSpecificSearch.Controls.Add(this.comboBoxRace);
            this.panelSpecificSearch.Controls.Add(this.labelAtk);
            this.panelSpecificSearch.Controls.Add(this.comboBoxAttribute);
            this.panelSpecificSearch.Controls.Add(this.textBoxDef);
            this.panelSpecificSearch.Controls.Add(this.textBoxLevel);
            this.panelSpecificSearch.Location = new System.Drawing.Point(929, 82);
            this.panelSpecificSearch.Name = "panelSpecificSearch";
            this.panelSpecificSearch.Size = new System.Drawing.Size(220, 487);
            this.panelSpecificSearch.TabIndex = 35;
            // 
            // panelLevel
            // 
            this.panelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLevel.Controls.Add(this.radioButtonLevelEqual);
            this.panelLevel.Controls.Add(this.radioButtonLevelGreaterOrEqual);
            this.panelLevel.Controls.Add(this.radioButtonLevelLesserOrEqual);
            this.panelLevel.Controls.Add(this.radioButtonLevelAll);
            this.panelLevel.Location = new System.Drawing.Point(47, 326);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(124, 31);
            this.panelLevel.TabIndex = 51;
            // 
            // radioButtonLevelEqual
            // 
            this.radioButtonLevelEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelEqual.Location = new System.Drawing.Point(96, 3);
            this.radioButtonLevelEqual.Name = "radioButtonLevelEqual";
            this.radioButtonLevelEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonLevelEqual.TabIndex = 54;
            this.radioButtonLevelEqual.Text = "=";
            this.radioButtonLevelEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelEqual.CheckedChanged += new System.EventHandler(this.radioButtonLevelEqual_CheckedChanged);
            // 
            // radioButtonLevelGreaterOrEqual
            // 
            this.radioButtonLevelGreaterOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelGreaterOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelGreaterOrEqual.Location = new System.Drawing.Point(65, 3);
            this.radioButtonLevelGreaterOrEqual.Name = "radioButtonLevelGreaterOrEqual";
            this.radioButtonLevelGreaterOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonLevelGreaterOrEqual.TabIndex = 53;
            this.radioButtonLevelGreaterOrEqual.Text = "≥";
            this.radioButtonLevelGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelGreaterOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelGreaterOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonLevelGreaterOrEqual_CheckedChanged);
            // 
            // radioButtonLevelLesserOrEqual
            // 
            this.radioButtonLevelLesserOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelLesserOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelLesserOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelLesserOrEqual.Location = new System.Drawing.Point(34, 3);
            this.radioButtonLevelLesserOrEqual.Name = "radioButtonLevelLesserOrEqual";
            this.radioButtonLevelLesserOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonLevelLesserOrEqual.TabIndex = 52;
            this.radioButtonLevelLesserOrEqual.Text = "≤";
            this.radioButtonLevelLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonLevelLesserOrEqual_CheckedChanged);
            // 
            // radioButtonLevelAll
            // 
            this.radioButtonLevelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelAll.Checked = true;
            this.radioButtonLevelAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLevelAll.Name = "radioButtonLevelAll";
            this.radioButtonLevelAll.Size = new System.Drawing.Size(25, 25);
            this.radioButtonLevelAll.TabIndex = 51;
            this.radioButtonLevelAll.TabStop = true;
            this.radioButtonLevelAll.Text = "*";
            this.radioButtonLevelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelAll.UseVisualStyleBackColor = true;
            this.radioButtonLevelAll.CheckedChanged += new System.EventHandler(this.radioButtonLevelAll_CheckedChanged);
            // 
            // panelDef
            // 
            this.panelDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDef.Controls.Add(this.radioButtonDefEqual);
            this.panelDef.Controls.Add(this.radioButtonDefGreaterOrEqual);
            this.panelDef.Controls.Add(this.radioButtonDefLesserOrEqual);
            this.panelDef.Controls.Add(this.radioButtonDefAll);
            this.panelDef.Location = new System.Drawing.Point(48, 241);
            this.panelDef.Name = "panelDef";
            this.panelDef.Size = new System.Drawing.Size(124, 31);
            this.panelDef.TabIndex = 47;
            // 
            // radioButtonDefEqual
            // 
            this.radioButtonDefEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefEqual.Location = new System.Drawing.Point(96, 3);
            this.radioButtonDefEqual.Name = "radioButtonDefEqual";
            this.radioButtonDefEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonDefEqual.TabIndex = 50;
            this.radioButtonDefEqual.Text = "=";
            this.radioButtonDefEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefEqual.UseVisualStyleBackColor = true;
            this.radioButtonDefEqual.CheckedChanged += new System.EventHandler(this.radioButtonDefEqual_CheckedChanged);
            // 
            // radioButtonDefGreaterOrEqual
            // 
            this.radioButtonDefGreaterOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefGreaterOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefGreaterOrEqual.Location = new System.Drawing.Point(65, 3);
            this.radioButtonDefGreaterOrEqual.Name = "radioButtonDefGreaterOrEqual";
            this.radioButtonDefGreaterOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonDefGreaterOrEqual.TabIndex = 49;
            this.radioButtonDefGreaterOrEqual.Text = "≥";
            this.radioButtonDefGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefGreaterOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonDefGreaterOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonDefGreaterOrEqual_CheckedChanged);
            // 
            // radioButtonDefLesserOrEqual
            // 
            this.radioButtonDefLesserOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefLesserOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefLesserOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefLesserOrEqual.Location = new System.Drawing.Point(34, 3);
            this.radioButtonDefLesserOrEqual.Name = "radioButtonDefLesserOrEqual";
            this.radioButtonDefLesserOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonDefLesserOrEqual.TabIndex = 48;
            this.radioButtonDefLesserOrEqual.Text = "≤";
            this.radioButtonDefLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonDefLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonDefLesserOrEqual_CheckedChanged);
            // 
            // radioButtonDefAll
            // 
            this.radioButtonDefAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefAll.Checked = true;
            this.radioButtonDefAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDefAll.Name = "radioButtonDefAll";
            this.radioButtonDefAll.Size = new System.Drawing.Size(25, 25);
            this.radioButtonDefAll.TabIndex = 47;
            this.radioButtonDefAll.TabStop = true;
            this.radioButtonDefAll.Text = "*";
            this.radioButtonDefAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefAll.UseVisualStyleBackColor = true;
            this.radioButtonDefAll.CheckedChanged += new System.EventHandler(this.radioButtonDefAll_CheckedChanged);
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(88, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(42, 20);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Type";
            // 
            // panelAtk
            // 
            this.panelAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAtk.Controls.Add(this.radioButtonAtkEqual);
            this.panelAtk.Controls.Add(this.radioButtonAtkGreaterOrEqual);
            this.panelAtk.Controls.Add(this.radioButtonAtkLesserOrEqual);
            this.panelAtk.Controls.Add(this.radioButtonAtkAll);
            this.panelAtk.Location = new System.Drawing.Point(50, 156);
            this.panelAtk.Name = "panelAtk";
            this.panelAtk.Size = new System.Drawing.Size(124, 31);
            this.panelAtk.TabIndex = 42;
            // 
            // radioButtonAtkEqual
            // 
            this.radioButtonAtkEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkEqual.Location = new System.Drawing.Point(96, 3);
            this.radioButtonAtkEqual.Name = "radioButtonAtkEqual";
            this.radioButtonAtkEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonAtkEqual.TabIndex = 46;
            this.radioButtonAtkEqual.Text = "=";
            this.radioButtonAtkEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkEqual.UseVisualStyleBackColor = true;
            this.radioButtonAtkEqual.CheckedChanged += new System.EventHandler(this.radioButtonAtkEqual_CheckedChanged);
            // 
            // radioButtonAtkGreaterOrEqual
            // 
            this.radioButtonAtkGreaterOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkGreaterOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkGreaterOrEqual.Location = new System.Drawing.Point(65, 3);
            this.radioButtonAtkGreaterOrEqual.Name = "radioButtonAtkGreaterOrEqual";
            this.radioButtonAtkGreaterOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonAtkGreaterOrEqual.TabIndex = 45;
            this.radioButtonAtkGreaterOrEqual.Text = "≥";
            this.radioButtonAtkGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkGreaterOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonAtkGreaterOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonAtkGreaterOrEqual_CheckedChanged);
            // 
            // radioButtonAtkLesserOrEqual
            // 
            this.radioButtonAtkLesserOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkLesserOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkLesserOrEqual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkLesserOrEqual.Location = new System.Drawing.Point(34, 3);
            this.radioButtonAtkLesserOrEqual.Name = "radioButtonAtkLesserOrEqual";
            this.radioButtonAtkLesserOrEqual.Size = new System.Drawing.Size(25, 25);
            this.radioButtonAtkLesserOrEqual.TabIndex = 44;
            this.radioButtonAtkLesserOrEqual.Text = "≤";
            this.radioButtonAtkLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonAtkLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonAtkLesserOrEqual_CheckedChanged);
            // 
            // radioButtonAtkAll
            // 
            this.radioButtonAtkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkAll.Checked = true;
            this.radioButtonAtkAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAtkAll.Name = "radioButtonAtkAll";
            this.radioButtonAtkAll.Size = new System.Drawing.Size(25, 25);
            this.radioButtonAtkAll.TabIndex = 43;
            this.radioButtonAtkAll.TabStop = true;
            this.radioButtonAtkAll.Text = "*";
            this.radioButtonAtkAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkAll.UseVisualStyleBackColor = true;
            this.radioButtonAtkAll.CheckedChanged += new System.EventHandler(this.radioButtonAtkAll_CheckedChanged);
            // 
            // labelAttribute
            // 
            this.labelAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAttribute.Location = new System.Drawing.Point(73, 102);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(72, 20);
            this.labelAttribute.TabIndex = 34;
            this.labelAttribute.Text = "Attribute";
            // 
            // textBoxAtk
            // 
            this.textBoxAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAtk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAtk.Location = new System.Drawing.Point(3, 213);
            this.textBoxAtk.Name = "textBoxAtk";
            this.textBoxAtk.Size = new System.Drawing.Size(212, 22);
            this.textBoxAtk.TabIndex = 20;
            this.textBoxAtk.Text = "0";
            // 
            // labelRace
            // 
            this.labelRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRace.AutoSize = true;
            this.labelRace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRace.Location = new System.Drawing.Point(85, 51);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(48, 20);
            this.labelRace.TabIndex = 33;
            this.labelRace.Text = "Race";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(3, 23);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 25);
            this.comboBoxType.TabIndex = 21;
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLevel.Location = new System.Drawing.Point(85, 360);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(49, 20);
            this.labelLevel.TabIndex = 32;
            this.labelLevel.Text = "Level";
            // 
            // labelDef
            // 
            this.labelDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDef.AutoSize = true;
            this.labelDef.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDef.Location = new System.Drawing.Point(75, 275);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(70, 20);
            this.labelDef.TabIndex = 31;
            this.labelDef.Text = "Defense";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRace.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(3, 74);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(212, 25);
            this.comboBoxRace.TabIndex = 26;
            // 
            // labelAtk
            // 
            this.labelAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAtk.AutoSize = true;
            this.labelAtk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAtk.Location = new System.Drawing.Point(80, 190);
            this.labelAtk.Name = "labelAtk";
            this.labelAtk.Size = new System.Drawing.Size(58, 20);
            this.labelAtk.TabIndex = 29;
            this.labelAtk.Text = "Attack";
            // 
            // comboBoxAttribute
            // 
            this.comboBoxAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAttribute.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAttribute.FormattingEnabled = true;
            this.comboBoxAttribute.Location = new System.Drawing.Point(3, 125);
            this.comboBoxAttribute.Name = "comboBoxAttribute";
            this.comboBoxAttribute.Size = new System.Drawing.Size(212, 25);
            this.comboBoxAttribute.TabIndex = 27;
            // 
            // textBoxDef
            // 
            this.textBoxDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDef.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDef.Location = new System.Drawing.Point(4, 298);
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(212, 22);
            this.textBoxDef.TabIndex = 23;
            this.textBoxDef.Text = "0";
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLevel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLevel.Location = new System.Drawing.Point(3, 383);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(212, 22);
            this.textBoxLevel.TabIndex = 23;
            this.textBoxLevel.Text = "0";
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCard.Location = new System.Drawing.Point(980, 36);
            this.buttonRemoveCard.Name = "buttonRemoveCard";
            this.buttonRemoveCard.Size = new System.Drawing.Size(71, 40);
            this.buttonRemoveCard.TabIndex = 14;
            this.buttonRemoveCard.Text = "Remove";
            this.buttonRemoveCard.UseVisualStyleBackColor = true;
            this.buttonRemoveCard.Click += new System.EventHandler(this.buttonRemoveCard_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCard.Location = new System.Drawing.Point(1057, 36);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(43, 40);
            this.buttonAddCard.TabIndex = 13;
            this.buttonAddCard.Text = "Add";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // flowLayoutPanelDeck
            // 
            this.flowLayoutPanelDeck.AllowDrop = true;
            this.flowLayoutPanelDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelDeck.AutoScroll = true;
            this.flowLayoutPanelDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelDeck.Location = new System.Drawing.Point(236, 82);
            this.flowLayoutPanelDeck.Name = "flowLayoutPanelDeck";
            this.flowLayoutPanelDeck.Size = new System.Drawing.Size(687, 569);
            this.flowLayoutPanelDeck.TabIndex = 12;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point(3, 82);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(227, 569);
            this.panelCard.TabIndex = 10;
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(1155, 82);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(82, 487);
            this.flowLayoutPanelCards.TabIndex = 9;
            this.flowLayoutPanelCards.WrapContents = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(1106, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(131, 27);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(1106, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 40);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YugiohForm";
            this.Load += new System.EventHandler(this.YugiohForm_Load);
            this.panelYugioh.ResumeLayout(false);
            this.panelYugioh.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.panelSpecificSearch.ResumeLayout(false);
            this.panelSpecificSearch.PerformLayout();
            this.panelLevel.ResumeLayout(false);
            this.panelDef.ResumeLayout(false);
            this.panelAtk.ResumeLayout(false);
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
        private ComboBox comboBoxType;
        private TextBox textBoxAtk;
        private ComboBox comboBoxAttribute;
        private ComboBox comboBoxRace;
        private Label labelType;
        private TextBox textBoxLevel;
        private TextBox textBoxDef;
        private Label labelAtk;
        private Label labelDef;
        private Label labelLevel;
        private Label labelAttribute;
        private Label labelRace;
        private Panel panelSpecificSearch;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelTotalPages;
        private Label labelCurrentPage;
        private Label labelCardsInSearchResult;
        private Panel panelPage;
        private Label labelPageSeparator;
        private Panel panelAtk;
        private RadioButton radioButtonAtkAll;
        private RadioButton radioButtonAtkEqual;
        private RadioButton radioButtonAtkGreaterOrEqual;
        private RadioButton radioButtonAtkLesserOrEqual;
        private Panel panelDef;
        private RadioButton radioButtonDefEqual;
        private RadioButton radioButtonDefGreaterOrEqual;
        private RadioButton radioButtonDefLesserOrEqual;
        private RadioButton radioButtonDefAll;
        private Panel panelLevel;
        private RadioButton radioButtonLevelEqual;
        private RadioButton radioButtonLevelGreaterOrEqual;
        private RadioButton radioButtonLevelLesserOrEqual;
        private RadioButton radioButtonLevelAll;
    }
}