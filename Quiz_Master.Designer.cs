namespace Quiz_Master
{
    partial class Quiz_Master
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz_Master));
            this.btnStartRound = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperatorType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmaddition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsubtraction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmultiplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmdividion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMix = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGameLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEsey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNoneLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMixLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmamountQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbReadAmount = new System.Windows.Forms.ToolStripTextBox();
            this.gbQuiz = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panelRadioButton = new System.Windows.Forms.Panel();
            this.rbChoice2 = new System.Windows.Forms.RadioButton();
            this.rbChoice3 = new System.Windows.Forms.RadioButton();
            this.rbChoice1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnResetRound = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTypeOperator = new System.Windows.Forms.Label();
            this.lblDifficultyLevel = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnChangeGame = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lvQuestion = new System.Windows.Forms.ListView();
            this.imgStatus = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.gbQuiz.SuspendLayout();
            this.panelRadioButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartRound
            // 
            this.btnStartRound.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStartRound.ForeColor = System.Drawing.Color.White;
            this.btnStartRound.Location = new System.Drawing.Point(843, 501);
            this.btnStartRound.Name = "btnStartRound";
            this.btnStartRound.Size = new System.Drawing.Size(135, 32);
            this.btnStartRound.TabIndex = 0;
            this.btnStartRound.Text = "Start Round";
            this.btnStartRound.UseCompatibleTextRendering = true;
            this.btnStartRound.UseVisualStyleBackColor = false;
            this.btnStartRound.Click += new System.EventHandler(this.StartRound_Click);
            this.btnStartRound.MouseEnter += new System.EventHandler(this.ChangeFormButton);
            this.btnStartRound.MouseLeave += new System.EventHandler(this.ResetFormButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOperatorType,
            this.tsmGameLevel,
            this.tsmamountQuestion});
            this.toolStripMenuItemSettings.Image = global::Quiz_Master.Properties.Resources.SettingsIcon;
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(123, 32);
            this.toolStripMenuItemSettings.Text = "&Settings";
            // 
            // tsmOperatorType
            // 
            this.tsmOperatorType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmaddition,
            this.tsmsubtraction,
            this.tsmmultiplication,
            this.tsmdividion,
            this.tsmNone,
            this.tsmMix});
            this.tsmOperatorType.Name = "tsmOperatorType";
            this.tsmOperatorType.Size = new System.Drawing.Size(293, 36);
            this.tsmOperatorType.Text = "&Operator Type";
            // 
            // tsmaddition
            // 
            this.tsmaddition.Image = global::Quiz_Master.Properties.Resources.AdditionIcon;
            this.tsmaddition.Name = "tsmaddition";
            this.tsmaddition.Size = new System.Drawing.Size(236, 36);
            this.tsmaddition.Tag = "1";
            this.tsmaddition.Text = "&Addition";
            this.tsmaddition.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmaddition.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmsubtraction
            // 
            this.tsmsubtraction.Image = global::Quiz_Master.Properties.Resources.SubtractionIcon;
            this.tsmsubtraction.Name = "tsmsubtraction";
            this.tsmsubtraction.Size = new System.Drawing.Size(236, 36);
            this.tsmsubtraction.Tag = "2";
            this.tsmsubtraction.Text = "&Subtraction";
            this.tsmsubtraction.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmsubtraction.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmmultiplication
            // 
            this.tsmmultiplication.Image = global::Quiz_Master.Properties.Resources.MultiplicationIcon;
            this.tsmmultiplication.Name = "tsmmultiplication";
            this.tsmmultiplication.Size = new System.Drawing.Size(236, 36);
            this.tsmmultiplication.Tag = "3";
            this.tsmmultiplication.Text = "&Multiplication";
            this.tsmmultiplication.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmmultiplication.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmdividion
            // 
            this.tsmdividion.Image = global::Quiz_Master.Properties.Resources.DividionIcon;
            this.tsmdividion.Name = "tsmdividion";
            this.tsmdividion.Size = new System.Drawing.Size(236, 36);
            this.tsmdividion.Tag = "4";
            this.tsmdividion.Text = "Dividion";
            this.tsmdividion.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmdividion.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmNone
            // 
            this.tsmNone.Checked = true;
            this.tsmNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmNone.Name = "tsmNone";
            this.tsmNone.Size = new System.Drawing.Size(236, 36);
            this.tsmNone.Tag = "5";
            this.tsmNone.Text = "None";
            this.tsmNone.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmNone.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmMix
            // 
            this.tsmMix.Name = "tsmMix";
            this.tsmMix.Size = new System.Drawing.Size(236, 36);
            this.tsmMix.Tag = "0";
            this.tsmMix.Text = "Mix";
            this.tsmMix.CheckedChanged += new System.EventHandler(this.ChangeOperatorTypeInGame);
            this.tsmMix.Click += new System.EventHandler(this.ChecKChoice_Type);
            // 
            // tsmGameLevel
            // 
            this.tsmGameLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEsey,
            this.tsmMedium,
            this.tsmHard,
            this.tsmNoneLevel,
            this.tsmMixLevel});
            this.tsmGameLevel.Name = "tsmGameLevel";
            this.tsmGameLevel.Size = new System.Drawing.Size(293, 36);
            this.tsmGameLevel.Text = "&Difficulty Level";
            // 
            // tsmEsey
            // 
            this.tsmEsey.Name = "tsmEsey";
            this.tsmEsey.Size = new System.Drawing.Size(187, 36);
            this.tsmEsey.Tag = "1";
            this.tsmEsey.Text = "&Esey";
            this.tsmEsey.CheckedChanged += new System.EventHandler(this.ChangeLevelInGame);
            this.tsmEsey.Click += new System.EventHandler(this.CheckChoice_Level);
            // 
            // tsmMedium
            // 
            this.tsmMedium.Name = "tsmMedium";
            this.tsmMedium.Size = new System.Drawing.Size(187, 36);
            this.tsmMedium.Tag = "2";
            this.tsmMedium.Text = "&Medium";
            this.tsmMedium.CheckedChanged += new System.EventHandler(this.ChangeLevelInGame);
            this.tsmMedium.Click += new System.EventHandler(this.CheckChoice_Level);
            // 
            // tsmHard
            // 
            this.tsmHard.Name = "tsmHard";
            this.tsmHard.Size = new System.Drawing.Size(187, 36);
            this.tsmHard.Tag = "3";
            this.tsmHard.Text = "&Hard";
            this.tsmHard.CheckedChanged += new System.EventHandler(this.ChangeLevelInGame);
            this.tsmHard.Click += new System.EventHandler(this.CheckChoice_Level);
            // 
            // tsmNoneLevel
            // 
            this.tsmNoneLevel.Checked = true;
            this.tsmNoneLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmNoneLevel.Name = "tsmNoneLevel";
            this.tsmNoneLevel.Size = new System.Drawing.Size(187, 36);
            this.tsmNoneLevel.Tag = "4";
            this.tsmNoneLevel.Text = "None";
            this.tsmNoneLevel.CheckedChanged += new System.EventHandler(this.ChangeLevelInGame);
            this.tsmNoneLevel.Click += new System.EventHandler(this.CheckChoice_Level);
            // 
            // tsmMixLevel
            // 
            this.tsmMixLevel.Name = "tsmMixLevel";
            this.tsmMixLevel.Size = new System.Drawing.Size(187, 36);
            this.tsmMixLevel.Tag = "0";
            this.tsmMixLevel.Text = "Mix";
            this.tsmMixLevel.CheckedChanged += new System.EventHandler(this.ChangeLevelInGame);
            this.tsmMixLevel.Click += new System.EventHandler(this.CheckChoice_Level);
            // 
            // tsmamountQuestion
            // 
            this.tsmamountQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbReadAmount});
            this.tsmamountQuestion.Name = "tsmamountQuestion";
            this.tsmamountQuestion.Size = new System.Drawing.Size(293, 36);
            this.tsmamountQuestion.Text = "&Number of Question";
            // 
            // tstbReadAmount
            // 
            this.tstbReadAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbReadAmount.MaxLength = 3;
            this.tstbReadAmount.Name = "tstbReadAmount";
            this.tstbReadAmount.Size = new System.Drawing.Size(100, 31);
            this.tstbReadAmount.Text = "0";
            this.tstbReadAmount.TextChanged += new System.EventHandler(this.AmountRoundWillPlay);
            // 
            // gbQuiz
            // 
            this.gbQuiz.BackgroundImage = global::Quiz_Master.Properties.Resources.backgroundMath;
            this.gbQuiz.Controls.Add(this.lblQuestion);
            this.gbQuiz.Controls.Add(this.btnCheck);
            this.gbQuiz.Controls.Add(this.panelRadioButton);
            this.gbQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbQuiz.Location = new System.Drawing.Point(129, 93);
            this.gbQuiz.Name = "gbQuiz";
            this.gbQuiz.Size = new System.Drawing.Size(447, 311);
            this.gbQuiz.TabIndex = 2;
            this.gbQuiz.TabStop = false;
            this.gbQuiz.Text = "Quiz";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Location = new System.Drawing.Point(151, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(106, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(328, 273);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 32);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseCompatibleTextRendering = true;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.ChangeFormButton);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ResetFormButton);
            // 
            // panelRadioButton
            // 
            this.panelRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.panelRadioButton.Controls.Add(this.rbChoice2);
            this.panelRadioButton.Controls.Add(this.rbChoice3);
            this.panelRadioButton.Controls.Add(this.rbChoice1);
            this.panelRadioButton.Location = new System.Drawing.Point(109, 105);
            this.panelRadioButton.Name = "panelRadioButton";
            this.panelRadioButton.Size = new System.Drawing.Size(264, 131);
            this.panelRadioButton.TabIndex = 4;
            this.panelRadioButton.Visible = false;
            // 
            // rbChoice2
            // 
            this.rbChoice2.AutoSize = true;
            this.rbChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbChoice2.Location = new System.Drawing.Point(88, 94);
            this.rbChoice2.Name = "rbChoice2";
            this.rbChoice2.Size = new System.Drawing.Size(19, 18);
            this.rbChoice2.TabIndex = 3;
            this.rbChoice2.Tag = "2";
            this.rbChoice2.UseVisualStyleBackColor = true;
            // 
            // rbChoice3
            // 
            this.rbChoice3.AutoSize = true;
            this.rbChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbChoice3.Location = new System.Drawing.Point(9, 94);
            this.rbChoice3.Name = "rbChoice3";
            this.rbChoice3.Size = new System.Drawing.Size(19, 18);
            this.rbChoice3.TabIndex = 2;
            this.rbChoice3.Tag = "3";
            this.rbChoice3.UseVisualStyleBackColor = true;
            // 
            // rbChoice1
            // 
            this.rbChoice1.AutoSize = true;
            this.rbChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbChoice1.Location = new System.Drawing.Point(167, 94);
            this.rbChoice1.Name = "rbChoice1";
            this.rbChoice1.Size = new System.Drawing.Size(19, 18);
            this.rbChoice1.TabIndex = 1;
            this.rbChoice1.Tag = "1";
            this.rbChoice1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Turquoise;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(457, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseCompatibleTextRendering = true;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.ChangeFormButton);
            this.btnNext.MouseLeave += new System.EventHandler(this.ResetFormButton);
            // 
            // btnResetRound
            // 
            this.btnResetRound.BackColor = System.Drawing.Color.Brown;
            this.btnResetRound.Enabled = false;
            this.btnResetRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetRound.ForeColor = System.Drawing.Color.White;
            this.btnResetRound.Location = new System.Drawing.Point(843, 450);
            this.btnResetRound.Name = "btnResetRound";
            this.btnResetRound.Size = new System.Drawing.Size(135, 32);
            this.btnResetRound.TabIndex = 4;
            this.btnResetRound.Text = "Reset Round";
            this.btnResetRound.UseCompatibleTextRendering = true;
            this.btnResetRound.UseVisualStyleBackColor = false;
            this.btnResetRound.Click += new System.EventHandler(this.btnResetGame_Click);
            this.btnResetRound.MouseEnter += new System.EventHandler(this.ChangeFormButton);
            this.btnResetRound.MouseLeave += new System.EventHandler(this.ResetFormButton);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(144, 28);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(185, 29);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Question  0 of 0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvQuestion);
            this.groupBox1.Controls.Add(this.lblTypeOperator);
            this.groupBox1.Controls.Add(this.lblDifficultyLevel);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.lblFail);
            this.groupBox1.Controls.Add(this.lblWin);
            this.groupBox1.Controls.Add(this.lblRound);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(594, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Details";
            // 
            // lblTypeOperator
            // 
            this.lblTypeOperator.AutoSize = true;
            this.lblTypeOperator.Location = new System.Drawing.Point(144, 227);
            this.lblTypeOperator.Name = "lblTypeOperator";
            this.lblTypeOperator.Size = new System.Drawing.Size(155, 29);
            this.lblTypeOperator.TabIndex = 8;
            this.lblTypeOperator.Text = "T/Operator : ";
            // 
            // lblDifficultyLevel
            // 
            this.lblDifficultyLevel.AutoSize = true;
            this.lblDifficultyLevel.Location = new System.Drawing.Point(144, 193);
            this.lblDifficultyLevel.Name = "lblDifficultyLevel";
            this.lblDifficultyLevel.Size = new System.Drawing.Size(117, 29);
            this.lblDifficultyLevel.TabIndex = 7;
            this.lblDifficultyLevel.Text = "D/Level : ";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPercent.Location = new System.Drawing.Point(335, 60);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(41, 24);
            this.lblPercent.TabIndex = 6;
            this.lblPercent.Text = "0%";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(144, 154);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(115, 29);
            this.lblFail.TabIndex = 4;
            this.lblFail.Text = "Fail(s) : 0";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Location = new System.Drawing.Point(144, 116);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(119, 29);
            this.lblWin.TabIndex = 3;
            this.lblWin.Text = "Win(s) : 0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(144, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 24);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // btnChangeGame
            // 
            this.btnChangeGame.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeGame.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnChangeGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeGame.Location = new System.Drawing.Point(0, 495);
            this.btnChangeGame.Name = "btnChangeGame";
            this.btnChangeGame.Size = new System.Drawing.Size(192, 38);
            this.btnChangeGame.TabIndex = 6;
            this.btnChangeGame.Text = "Change Game";
            this.btnChangeGame.UseCompatibleTextRendering = true;
            this.btnChangeGame.UseVisualStyleBackColor = true;
            this.btnChangeGame.Click += new System.EventHandler(this.btnChangeGame_Click);
            this.btnChangeGame.MouseEnter += new System.EventHandler(this.ChangeFormButton);
            this.btnChangeGame.MouseLeave += new System.EventHandler(this.ResetFormButton);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lvQuestion
            // 
            this.lvQuestion.BackColor = System.Drawing.Color.SkyBlue;
            this.lvQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvQuestion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvQuestion.HideSelection = false;
            this.lvQuestion.LargeImageList = this.imgStatus;
            this.lvQuestion.Location = new System.Drawing.Point(13, 41);
            this.lvQuestion.Name = "lvQuestion";
            this.lvQuestion.Size = new System.Drawing.Size(120, 214);
            this.lvQuestion.SmallImageList = this.imgStatus;
            this.lvQuestion.TabIndex = 9;
            this.lvQuestion.UseCompatibleStateImageBehavior = false;
            this.lvQuestion.View = System.Windows.Forms.View.Details;
            // 
            // imgStatus
            // 
            this.imgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStatus.ImageStream")));
            this.imgStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStatus.Images.SetKeyName(0, "falseIcon.jpg");
            this.imgStatus.Images.SetKeyName(1, "qustionIcon.jpg");
            this.imgStatus.Images.SetKeyName(2, "trurIcon.jpg");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // Quiz_Master
            // 
            this.AcceptButton = this.btnNext;
            this.BackgroundImage = global::Quiz_Master.Properties.Resources.backgroundMath2;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.btnChangeGame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetRound);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbQuiz);
            this.Controls.Add(this.btnStartRound);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quiz_Master";
            this.Load += new System.EventHandler(this.Quiz_Master_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbQuiz.ResumeLayout(false);
            this.gbQuiz.PerformLayout();
            this.panelRadioButton.ResumeLayout(false);
            this.panelRadioButton.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnStartRound;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmOperatorType;
        private System.Windows.Forms.ToolStripMenuItem tsmaddition;
        private System.Windows.Forms.ToolStripMenuItem tsmsubtraction;
        private System.Windows.Forms.ToolStripMenuItem tsmmultiplication;
        private System.Windows.Forms.ToolStripMenuItem tsmdividion;
        private System.Windows.Forms.ToolStripMenuItem tsmGameLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmEsey;
        private System.Windows.Forms.ToolStripMenuItem tsmMedium;
        private System.Windows.Forms.ToolStripMenuItem tsmHard;
        private System.Windows.Forms.ToolStripMenuItem tsmNone;
        private System.Windows.Forms.ToolStripMenuItem tsmMix;
        private System.Windows.Forms.ToolStripMenuItem tsmNoneLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmMixLevel;
        private System.Windows.Forms.GroupBox gbQuiz;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnResetRound;
        private System.Windows.Forms.ToolStripMenuItem tsmamountQuestion;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ToolStripTextBox tstbReadAmount;
        private System.Windows.Forms.RadioButton rbChoice1;
        private System.Windows.Forms.Panel panelRadioButton;
        private System.Windows.Forms.RadioButton rbChoice2;
        private System.Windows.Forms.RadioButton rbChoice3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblDifficultyLevel;
        private System.Windows.Forms.Label lblTypeOperator;
        private System.Windows.Forms.Button btnChangeGame;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListView lvQuestion;
        private System.Windows.Forms.ImageList imgStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}