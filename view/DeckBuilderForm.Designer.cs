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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.textBoxAtk = new System.Windows.Forms.TextBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.panelAtk = new System.Windows.Forms.Panel();
            this.radioButtonAtkAll = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonAtkLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.labelDef = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.labelAtk = new System.Windows.Forms.Label();
            this.comboBoxAttribute = new System.Windows.Forms.ComboBox();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.radioButtonLevelAll = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLevelLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.panelDef = new System.Windows.Forms.Panel();
            this.radioButtonDefAll = new System.Windows.Forms.RadioButton();
            this.radioButtonDefEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefGreaterOrEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonDefLesserOrEqual = new System.Windows.Forms.RadioButton();
            this.buttonRemoveCard = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.flowLayoutPanelDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.panelYugioh.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAtk.SuspendLayout();
            this.panelLevel.SuspendLayout();
            this.panelDef.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYugioh
            // 
            this.panelYugioh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYugioh.Controls.Add(this.labelPage);
            this.panelYugioh.Controls.Add(this.buttonNext);
            this.panelYugioh.Controls.Add(this.buttonPrevious);
            this.panelYugioh.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.labelAttribute);
            this.panel1.Controls.Add(this.textBoxAtk);
            this.panel1.Controls.Add(this.labelRace);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.panelAtk);
            this.panel1.Controls.Add(this.labelDef);
            this.panel1.Controls.Add(this.comboBoxRace);
            this.panel1.Controls.Add(this.labelAtk);
            this.panel1.Controls.Add(this.comboBoxAttribute);
            this.panel1.Controls.Add(this.panelLevel);
            this.panel1.Controls.Add(this.textBoxDef);
            this.panel1.Controls.Add(this.textBoxLevel);
            this.panel1.Controls.Add(this.panelDef);
            this.panel1.Location = new System.Drawing.Point(929, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 569);
            this.panel1.TabIndex = 35;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(57, 2);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(54, 22);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Type";
            // 
            // labelAttribute
            // 
            this.labelAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAttribute.Location = new System.Drawing.Point(38, 408);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(92, 22);
            this.labelAttribute.TabIndex = 34;
            this.labelAttribute.Text = "Attribute";
            // 
            // textBoxAtk
            // 
            this.textBoxAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAtk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAtk.Location = new System.Drawing.Point(3, 130);
            this.textBoxAtk.Name = "textBoxAtk";
            this.textBoxAtk.Size = new System.Drawing.Size(163, 23);
            this.textBoxAtk.TabIndex = 20;
            // 
            // labelRace
            // 
            this.labelRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRace.AutoSize = true;
            this.labelRace.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRace.Location = new System.Drawing.Point(55, 352);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(59, 22);
            this.labelRace.TabIndex = 33;
            this.labelRace.Text = "Race";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(3, 30);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(163, 25);
            this.comboBoxType.TabIndex = 21;
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLevel.Location = new System.Drawing.Point(55, 254);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(59, 22);
            this.labelLevel.TabIndex = 32;
            this.labelLevel.Text = "Level";
            // 
            // panelAtk
            // 
            this.panelAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAtk.Controls.Add(this.radioButtonAtkAll);
            this.panelAtk.Controls.Add(this.radioButtonAtkEqual);
            this.panelAtk.Controls.Add(this.radioButtonAtkGreaterOrEqual);
            this.panelAtk.Controls.Add(this.radioButtonAtkLesserOrEqual);
            this.panelAtk.Location = new System.Drawing.Point(11, 86);
            this.panelAtk.Name = "panelAtk";
            this.panelAtk.Size = new System.Drawing.Size(145, 38);
            this.panelAtk.TabIndex = 22;
            // 
            // radioButtonAtkAll
            // 
            this.radioButtonAtkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkAll.AutoSize = true;
            this.radioButtonAtkAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAtkAll.Name = "radioButtonAtkAll";
            this.radioButtonAtkAll.Size = new System.Drawing.Size(29, 32);
            this.radioButtonAtkAll.TabIndex = 4;
            this.radioButtonAtkAll.TabStop = true;
            this.radioButtonAtkAll.Text = "*";
            this.radioButtonAtkAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkAll.UseVisualStyleBackColor = true;
            this.radioButtonAtkAll.CheckedChanged += new System.EventHandler(this.radioButtonAtkAll_CheckedChanged);
            // 
            // radioButtonAtkEqual
            // 
            this.radioButtonAtkEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtkEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAtkEqual.AutoSize = true;
            this.radioButtonAtkEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkEqual.Location = new System.Drawing.Point(110, 3);
            this.radioButtonAtkEqual.Name = "radioButtonAtkEqual";
            this.radioButtonAtkEqual.Size = new System.Drawing.Size(32, 32);
            this.radioButtonAtkEqual.TabIndex = 2;
            this.radioButtonAtkEqual.TabStop = true;
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
            this.radioButtonAtkGreaterOrEqual.AutoSize = true;
            this.radioButtonAtkGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkGreaterOrEqual.Location = new System.Drawing.Point(74, 3);
            this.radioButtonAtkGreaterOrEqual.Name = "radioButtonAtkGreaterOrEqual";
            this.radioButtonAtkGreaterOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonAtkGreaterOrEqual.TabIndex = 1;
            this.radioButtonAtkGreaterOrEqual.TabStop = true;
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
            this.radioButtonAtkLesserOrEqual.AutoSize = true;
            this.radioButtonAtkLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAtkLesserOrEqual.Location = new System.Drawing.Point(38, 3);
            this.radioButtonAtkLesserOrEqual.Name = "radioButtonAtkLesserOrEqual";
            this.radioButtonAtkLesserOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonAtkLesserOrEqual.TabIndex = 0;
            this.radioButtonAtkLesserOrEqual.TabStop = true;
            this.radioButtonAtkLesserOrEqual.Text = "≤";
            this.radioButtonAtkLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAtkLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonAtkLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonAtkLesserOrEqual_CheckedChanged);
            // 
            // labelDef
            // 
            this.labelDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDef.AutoSize = true;
            this.labelDef.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDef.Location = new System.Drawing.Point(42, 156);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(85, 22);
            this.labelDef.TabIndex = 31;
            this.labelDef.Text = "Defense";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRace.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(3, 380);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(163, 25);
            this.comboBoxRace.TabIndex = 26;
            // 
            // labelAtk
            // 
            this.labelAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAtk.AutoSize = true;
            this.labelAtk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAtk.Location = new System.Drawing.Point(47, 58);
            this.labelAtk.Name = "labelAtk";
            this.labelAtk.Size = new System.Drawing.Size(74, 22);
            this.labelAtk.TabIndex = 29;
            this.labelAtk.Text = "Attack";
            // 
            // comboBoxAttribute
            // 
            this.comboBoxAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAttribute.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAttribute.FormattingEnabled = true;
            this.comboBoxAttribute.Location = new System.Drawing.Point(3, 436);
            this.comboBoxAttribute.Name = "comboBoxAttribute";
            this.comboBoxAttribute.Size = new System.Drawing.Size(163, 25);
            this.comboBoxAttribute.TabIndex = 27;
            // 
            // panelLevel
            // 
            this.panelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLevel.Controls.Add(this.radioButtonLevelAll);
            this.panelLevel.Controls.Add(this.radioButtonLevelEqual);
            this.panelLevel.Controls.Add(this.radioButtonLevelGreaterOrEqual);
            this.panelLevel.Controls.Add(this.radioButtonLevelLesserOrEqual);
            this.panelLevel.Location = new System.Drawing.Point(11, 282);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(145, 38);
            this.panelLevel.TabIndex = 24;
            // 
            // radioButtonLevelAll
            // 
            this.radioButtonLevelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelAll.AutoSize = true;
            this.radioButtonLevelAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLevelAll.Name = "radioButtonLevelAll";
            this.radioButtonLevelAll.Size = new System.Drawing.Size(29, 32);
            this.radioButtonLevelAll.TabIndex = 35;
            this.radioButtonLevelAll.TabStop = true;
            this.radioButtonLevelAll.Text = "*";
            this.radioButtonLevelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelAll.UseVisualStyleBackColor = true;
            this.radioButtonLevelAll.CheckedChanged += new System.EventHandler(this.radioButtonLevelAll_CheckedChanged);
            // 
            // radioButtonLevelEqual
            // 
            this.radioButtonLevelEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelEqual.AutoSize = true;
            this.radioButtonLevelEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelEqual.Location = new System.Drawing.Point(110, 3);
            this.radioButtonLevelEqual.Name = "radioButtonLevelEqual";
            this.radioButtonLevelEqual.Size = new System.Drawing.Size(32, 32);
            this.radioButtonLevelEqual.TabIndex = 2;
            this.radioButtonLevelEqual.TabStop = true;
            this.radioButtonLevelEqual.Text = "=";
            this.radioButtonLevelEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelEqual.CheckedChanged += new System.EventHandler(this.radioButtonEqual_CheckedChanged);
            // 
            // radioButtonLevelGreaterOrEqual
            // 
            this.radioButtonLevelGreaterOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelGreaterOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelGreaterOrEqual.AutoSize = true;
            this.radioButtonLevelGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelGreaterOrEqual.Location = new System.Drawing.Point(74, 3);
            this.radioButtonLevelGreaterOrEqual.Name = "radioButtonLevelGreaterOrEqual";
            this.radioButtonLevelGreaterOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonLevelGreaterOrEqual.TabIndex = 1;
            this.radioButtonLevelGreaterOrEqual.TabStop = true;
            this.radioButtonLevelGreaterOrEqual.Text = "≥";
            this.radioButtonLevelGreaterOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelGreaterOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelGreaterOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonGreaterOrEqual_CheckedChanged);
            // 
            // radioButtonLevelLesserOrEqual
            // 
            this.radioButtonLevelLesserOrEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLevelLesserOrEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLevelLesserOrEqual.AutoSize = true;
            this.radioButtonLevelLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLevelLesserOrEqual.Location = new System.Drawing.Point(38, 3);
            this.radioButtonLevelLesserOrEqual.Name = "radioButtonLevelLesserOrEqual";
            this.radioButtonLevelLesserOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonLevelLesserOrEqual.TabIndex = 0;
            this.radioButtonLevelLesserOrEqual.TabStop = true;
            this.radioButtonLevelLesserOrEqual.Text = "≤";
            this.radioButtonLevelLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLevelLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonLevelLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonLevelLesserOrEqual_CheckedChanged);
            // 
            // textBoxDef
            // 
            this.textBoxDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDef.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDef.Location = new System.Drawing.Point(3, 228);
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(163, 23);
            this.textBoxDef.TabIndex = 23;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLevel.Location = new System.Drawing.Point(3, 326);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(163, 23);
            this.textBoxLevel.TabIndex = 23;
            // 
            // panelDef
            // 
            this.panelDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDef.Controls.Add(this.radioButtonDefAll);
            this.panelDef.Controls.Add(this.radioButtonDefEqual);
            this.panelDef.Controls.Add(this.radioButtonDefGreaterOrEqual);
            this.panelDef.Controls.Add(this.radioButtonDefLesserOrEqual);
            this.panelDef.Location = new System.Drawing.Point(11, 184);
            this.panelDef.Name = "panelDef";
            this.panelDef.Size = new System.Drawing.Size(145, 38);
            this.panelDef.TabIndex = 24;
            // 
            // radioButtonDefAll
            // 
            this.radioButtonDefAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefAll.AutoSize = true;
            this.radioButtonDefAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonDefAll.Name = "radioButtonDefAll";
            this.radioButtonDefAll.Size = new System.Drawing.Size(29, 32);
            this.radioButtonDefAll.TabIndex = 3;
            this.radioButtonDefAll.TabStop = true;
            this.radioButtonDefAll.Text = "*";
            this.radioButtonDefAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefAll.UseVisualStyleBackColor = true;
            this.radioButtonDefAll.CheckedChanged += new System.EventHandler(this.radioButtonDefAll_CheckedChanged);
            // 
            // radioButtonDefEqual
            // 
            this.radioButtonDefEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefEqual.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDefEqual.AutoSize = true;
            this.radioButtonDefEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefEqual.Location = new System.Drawing.Point(110, 3);
            this.radioButtonDefEqual.Name = "radioButtonDefEqual";
            this.radioButtonDefEqual.Size = new System.Drawing.Size(32, 32);
            this.radioButtonDefEqual.TabIndex = 2;
            this.radioButtonDefEqual.TabStop = true;
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
            this.radioButtonDefGreaterOrEqual.AutoSize = true;
            this.radioButtonDefGreaterOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefGreaterOrEqual.Location = new System.Drawing.Point(74, 3);
            this.radioButtonDefGreaterOrEqual.Name = "radioButtonDefGreaterOrEqual";
            this.radioButtonDefGreaterOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonDefGreaterOrEqual.TabIndex = 1;
            this.radioButtonDefGreaterOrEqual.TabStop = true;
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
            this.radioButtonDefLesserOrEqual.AutoSize = true;
            this.radioButtonDefLesserOrEqual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDefLesserOrEqual.Location = new System.Drawing.Point(38, 3);
            this.radioButtonDefLesserOrEqual.Name = "radioButtonDefLesserOrEqual";
            this.radioButtonDefLesserOrEqual.Size = new System.Drawing.Size(30, 32);
            this.radioButtonDefLesserOrEqual.TabIndex = 0;
            this.radioButtonDefLesserOrEqual.TabStop = true;
            this.radioButtonDefLesserOrEqual.Text = "≤";
            this.radioButtonDefLesserOrEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDefLesserOrEqual.UseVisualStyleBackColor = true;
            this.radioButtonDefLesserOrEqual.CheckedChanged += new System.EventHandler(this.radioButtonDefLesserOrEqual_CheckedChanged);
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCard.Location = new System.Drawing.Point(980, 36);
            this.buttonRemoveCard.Name = "buttonRemoveCard";
            this.buttonRemoveCard.Size = new System.Drawing.Size(71, 41);
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
            this.flowLayoutPanelDeck.Location = new System.Drawing.Point(236, 82);
            this.flowLayoutPanelDeck.Name = "flowLayoutPanelDeck";
            this.flowLayoutPanelDeck.Size = new System.Drawing.Size(687, 569);
            this.flowLayoutPanelDeck.TabIndex = 12;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(1106, 82);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(131, 531);
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
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(1106, 619);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(32, 32);
            this.buttonPrevious.TabIndex = 36;
            this.buttonPrevious.Text = "←";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(1205, 619);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(32, 32);
            this.buttonNext.TabIndex = 37;
            this.buttonNext.Text = "→";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // labelPage
            // 
            this.labelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPage.Location = new System.Drawing.Point(1151, 624);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(40, 22);
            this.labelPage.TabIndex = 38;
            this.labelPage.Text = "1/1";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAtk.ResumeLayout(false);
            this.panelAtk.PerformLayout();
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            this.panelDef.ResumeLayout(false);
            this.panelDef.PerformLayout();
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
        private Panel panelAtk;
        private ComboBox comboBoxType;
        private TextBox textBoxAtk;
        private ComboBox comboBoxAttribute;
        private ComboBox comboBoxRace;
        private Label labelType;
        private RadioButton radioButtonAtkLesserOrEqual;
        private RadioButton radioButtonAtkEqual;
        private RadioButton radioButtonAtkGreaterOrEqual;
        private Panel panelLevel;
        private RadioButton radioButtonLevelEqual;
        private RadioButton radioButtonLevelGreaterOrEqual;
        private RadioButton radioButtonLevelLesserOrEqual;
        private TextBox textBoxLevel;
        private Panel panelDef;
        private RadioButton radioButtonDefEqual;
        private RadioButton radioButtonDefGreaterOrEqual;
        private RadioButton radioButtonDefLesserOrEqual;
        private TextBox textBoxDef;
        private Label labelAtk;
        private Label labelDef;
        private Label labelLevel;
        private Label labelAttribute;
        private Label labelRace;
        private Panel panel1;
        private RadioButton radioButtonDefAll;
        private RadioButton radioButtonAtkAll;
        private RadioButton radioButtonLevelAll;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelPage;
    }
}