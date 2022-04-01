namespace SoundAnalysis1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSilenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSilenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundlessSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSoundlessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSoundlessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milisecondPerFrameNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.repaintButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.soundSpeechLabel = new System.Windows.Forms.Label();
            this.soundSpeechValueLabel = new System.Windows.Forms.Label();
            this.soundlessSpeechLabel = new System.Windows.Forms.Label();
            this.soundlessSpeechValueLabel = new System.Windows.Forms.Label();
            this.amdfLabel = new System.Windows.Forms.Label();
            this.amdfValueLabel = new System.Windows.Forms.Label();
            this.autocorLabel = new System.Windows.Forms.Label();
            this.autocorValueLabel = new System.Windows.Forms.Label();
            this.silenceLabel = new System.Windows.Forms.Label();
            this.silenceValueLabel = new System.Windows.Forms.Label();
            this.zcrLabel = new System.Windows.Forms.Label();
            this.zcrValueLabel = new System.Windows.Forms.Label();
            this.steLabel = new System.Windows.Forms.Label();
            this.steValueLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            this.soundSpeechPlot = new OxyPlot.WindowsForms.PlotView();
            this.soundlessSpeechPlot = new OxyPlot.WindowsForms.PlotView();
            this.amdfPlot = new OxyPlot.WindowsForms.PlotView();
            this.autoCorrePlot = new OxyPlot.WindowsForms.PlotView();
            this.silencePlot = new OxyPlot.WindowsForms.PlotView();
            this.zcrPlot = new OxyPlot.WindowsForms.PlotView();
            this.stePlot = new OxyPlot.WindowsForms.PlotView();
            this.volumePlot = new OxyPlot.WindowsForms.PlotView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soundPlot = new OxyPlot.WindowsForms.PlotView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hzcrrValueLabel = new System.Windows.Forms.Label();
            this.zstdValueLabel = new System.Windows.Forms.Label();
            this.zstdLabel = new System.Windows.Forms.Label();
            this.hzcrrLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsterValueLabel = new System.Windows.Forms.Label();
            this.lsterLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vdrValueLabel = new System.Windows.Forms.Label();
            this.vstdValueLabel = new System.Windows.Forms.Label();
            this.vdrLabel = new System.Windows.Forms.Label();
            this.vstdLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milisecondPerFrameNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1485, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silenceToolStripMenuItem,
            this.soundlessSpeechToolStripMenuItem,
            this.soundSpeechToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // silenceToolStripMenuItem
            // 
            this.silenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSilenceToolStripMenuItem,
            this.exportSilenceToolStripMenuItem});
            this.silenceToolStripMenuItem.Name = "silenceToolStripMenuItem";
            this.silenceToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.silenceToolStripMenuItem.Text = "Silence";
            // 
            // showSilenceToolStripMenuItem
            // 
            this.showSilenceToolStripMenuItem.Name = "showSilenceToolStripMenuItem";
            this.showSilenceToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.showSilenceToolStripMenuItem.Text = "Show";
            this.showSilenceToolStripMenuItem.Click += new System.EventHandler(this.showSilenceToolStripMenuItem_Click);
            // 
            // exportSilenceToolStripMenuItem
            // 
            this.exportSilenceToolStripMenuItem.Name = "exportSilenceToolStripMenuItem";
            this.exportSilenceToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportSilenceToolStripMenuItem.Text = "Export";
            this.exportSilenceToolStripMenuItem.Click += new System.EventHandler(this.exportSilenceToolStripMenuItem_Click);
            // 
            // soundlessSpeechToolStripMenuItem
            // 
            this.soundlessSpeechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSoundlessToolStripMenuItem,
            this.exportSoundlessToolStripMenuItem});
            this.soundlessSpeechToolStripMenuItem.Name = "soundlessSpeechToolStripMenuItem";
            this.soundlessSpeechToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.soundlessSpeechToolStripMenuItem.Text = "Soundless Speech";
            // 
            // showSoundlessToolStripMenuItem
            // 
            this.showSoundlessToolStripMenuItem.Name = "showSoundlessToolStripMenuItem";
            this.showSoundlessToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.showSoundlessToolStripMenuItem.Text = "Show";
            this.showSoundlessToolStripMenuItem.Click += new System.EventHandler(this.showSoundlessToolStripMenuItem_Click);
            // 
            // exportSoundlessToolStripMenuItem
            // 
            this.exportSoundlessToolStripMenuItem.Name = "exportSoundlessToolStripMenuItem";
            this.exportSoundlessToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportSoundlessToolStripMenuItem.Text = "Export";
            this.exportSoundlessToolStripMenuItem.Click += new System.EventHandler(this.exportSoundlessToolStripMenuItem_Click);
            // 
            // soundSpeechToolStripMenuItem
            // 
            this.soundSpeechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSoundToolStripMenuItem,
            this.exportSoundToolStripMenuItem});
            this.soundSpeechToolStripMenuItem.Name = "soundSpeechToolStripMenuItem";
            this.soundSpeechToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.soundSpeechToolStripMenuItem.Text = "Sound Speech";
            // 
            // showSoundToolStripMenuItem
            // 
            this.showSoundToolStripMenuItem.Name = "showSoundToolStripMenuItem";
            this.showSoundToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.showSoundToolStripMenuItem.Text = "Show";
            this.showSoundToolStripMenuItem.Click += new System.EventHandler(this.showSoundToolStripMenuItem_Click);
            // 
            // exportSoundToolStripMenuItem
            // 
            this.exportSoundToolStripMenuItem.Name = "exportSoundToolStripMenuItem";
            this.exportSoundToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportSoundToolStripMenuItem.Text = "Export";
            this.exportSoundToolStripMenuItem.Click += new System.EventHandler(this.exportSoundToolStripMenuItem_Click);
            // 
            // milisecondPerFrameNumeric
            // 
            this.milisecondPerFrameNumeric.Location = new System.Drawing.Point(162, 11);
            this.milisecondPerFrameNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.milisecondPerFrameNumeric.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.milisecondPerFrameNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.milisecondPerFrameNumeric.Name = "milisecondPerFrameNumeric";
            this.milisecondPerFrameNumeric.Size = new System.Drawing.Size(137, 27);
            this.milisecondPerFrameNumeric.TabIndex = 1;
            this.milisecondPerFrameNumeric.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miliseconds per frame:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "L:";
            // 
            // lagNumericUpDown
            // 
            this.lagNumericUpDown.Location = new System.Drawing.Point(346, 11);
            this.lagNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lagNumericUpDown.Name = "lagNumericUpDown";
            this.lagNumericUpDown.Size = new System.Drawing.Size(137, 27);
            this.lagNumericUpDown.TabIndex = 4;
            this.lagNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // repaintButton
            // 
            this.repaintButton.Location = new System.Drawing.Point(511, 11);
            this.repaintButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repaintButton.Name = "repaintButton";
            this.repaintButton.Size = new System.Drawing.Size(80, 35);
            this.repaintButton.TabIndex = 5;
            this.repaintButton.Text = "Redraw";
            this.repaintButton.UseVisualStyleBackColor = true;
            this.repaintButton.Click += new System.EventHandler(this.repaintButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.836545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.890231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.27322F));
            this.tableLayoutPanel1.Controls.Add(this.soundSpeechLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.soundSpeechValueLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.soundlessSpeechLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.soundlessSpeechValueLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.amdfLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.amdfValueLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.autocorLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.autocorValueLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.silenceLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.silenceValueLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.zcrLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.zcrValueLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.steLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.steValueLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.volumeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.volumeValueLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.soundSpeechPlot, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.soundlessSpeechPlot, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.amdfPlot, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.autoCorrePlot, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.silencePlot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.zcrPlot, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.stePlot, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.volumePlot, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1479, 595);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // soundSpeechLabel
            // 
            this.soundSpeechLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundSpeechLabel.AutoSize = true;
            this.soundSpeechLabel.Location = new System.Drawing.Point(3, 549);
            this.soundSpeechLabel.Name = "soundSpeechLabel";
            this.soundSpeechLabel.Size = new System.Drawing.Size(106, 20);
            this.soundSpeechLabel.TabIndex = 7;
            this.soundSpeechLabel.Text = "Sound Speech:";
            this.soundSpeechLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundSpeechValueLabel
            // 
            this.soundSpeechValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundSpeechValueLabel.AutoSize = true;
            this.soundSpeechValueLabel.Location = new System.Drawing.Point(118, 549);
            this.soundSpeechValueLabel.Name = "soundSpeechValueLabel";
            this.soundSpeechValueLabel.Size = new System.Drawing.Size(17, 20);
            this.soundSpeechValueLabel.TabIndex = 34;
            this.soundSpeechValueLabel.Text = "0";
            // 
            // soundlessSpeechLabel
            // 
            this.soundlessSpeechLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundlessSpeechLabel.AutoSize = true;
            this.soundlessSpeechLabel.Location = new System.Drawing.Point(3, 470);
            this.soundlessSpeechLabel.Name = "soundlessSpeechLabel";
            this.soundlessSpeechLabel.Size = new System.Drawing.Size(75, 40);
            this.soundlessSpeechLabel.TabIndex = 6;
            this.soundlessSpeechLabel.Text = "Soundless Speech:";
            this.soundlessSpeechLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundlessSpeechValueLabel
            // 
            this.soundlessSpeechValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundlessSpeechValueLabel.AutoSize = true;
            this.soundlessSpeechValueLabel.Location = new System.Drawing.Point(118, 480);
            this.soundlessSpeechValueLabel.Name = "soundlessSpeechValueLabel";
            this.soundlessSpeechValueLabel.Size = new System.Drawing.Size(17, 20);
            this.soundlessSpeechValueLabel.TabIndex = 33;
            this.soundlessSpeechValueLabel.Text = "0";
            // 
            // amdfLabel
            // 
            this.amdfLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amdfLabel.AutoSize = true;
            this.amdfLabel.Location = new System.Drawing.Point(3, 412);
            this.amdfLabel.Name = "amdfLabel";
            this.amdfLabel.Size = new System.Drawing.Size(53, 20);
            this.amdfLabel.TabIndex = 5;
            this.amdfLabel.Text = "AMDF:";
            this.amdfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amdfValueLabel
            // 
            this.amdfValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amdfValueLabel.AutoSize = true;
            this.amdfValueLabel.Location = new System.Drawing.Point(118, 412);
            this.amdfValueLabel.Name = "amdfValueLabel";
            this.amdfValueLabel.Size = new System.Drawing.Size(17, 20);
            this.amdfValueLabel.TabIndex = 32;
            this.amdfValueLabel.Text = "0";
            // 
            // autocorLabel
            // 
            this.autocorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autocorLabel.AutoSize = true;
            this.autocorLabel.Location = new System.Drawing.Point(3, 334);
            this.autocorLabel.Name = "autocorLabel";
            this.autocorLabel.Size = new System.Drawing.Size(109, 40);
            this.autocorLabel.TabIndex = 4;
            this.autocorLabel.Text = "Autocorreation:";
            this.autocorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autocorValueLabel
            // 
            this.autocorValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autocorValueLabel.AutoSize = true;
            this.autocorValueLabel.Location = new System.Drawing.Point(118, 344);
            this.autocorValueLabel.Name = "autocorValueLabel";
            this.autocorValueLabel.Size = new System.Drawing.Size(17, 20);
            this.autocorValueLabel.TabIndex = 31;
            this.autocorValueLabel.Text = "0";
            // 
            // silenceLabel
            // 
            this.silenceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.silenceLabel.AutoSize = true;
            this.silenceLabel.Location = new System.Drawing.Point(3, 276);
            this.silenceLabel.Name = "silenceLabel";
            this.silenceLabel.Size = new System.Drawing.Size(59, 20);
            this.silenceLabel.TabIndex = 1;
            this.silenceLabel.Text = "Silence:";
            this.silenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // silenceValueLabel
            // 
            this.silenceValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.silenceValueLabel.AutoSize = true;
            this.silenceValueLabel.Location = new System.Drawing.Point(118, 276);
            this.silenceValueLabel.Name = "silenceValueLabel";
            this.silenceValueLabel.Size = new System.Drawing.Size(17, 20);
            this.silenceValueLabel.TabIndex = 30;
            this.silenceValueLabel.Text = "0";
            // 
            // zcrLabel
            // 
            this.zcrLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zcrLabel.AutoSize = true;
            this.zcrLabel.Location = new System.Drawing.Point(3, 208);
            this.zcrLabel.Name = "zcrLabel";
            this.zcrLabel.Size = new System.Drawing.Size(39, 20);
            this.zcrLabel.TabIndex = 3;
            this.zcrLabel.Text = "ZCR:";
            this.zcrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zcrValueLabel
            // 
            this.zcrValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zcrValueLabel.AutoSize = true;
            this.zcrValueLabel.Location = new System.Drawing.Point(118, 208);
            this.zcrValueLabel.Name = "zcrValueLabel";
            this.zcrValueLabel.Size = new System.Drawing.Size(17, 20);
            this.zcrValueLabel.TabIndex = 29;
            this.zcrValueLabel.Text = "0";
            // 
            // steLabel
            // 
            this.steLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.steLabel.AutoSize = true;
            this.steLabel.Location = new System.Drawing.Point(3, 140);
            this.steLabel.Name = "steLabel";
            this.steLabel.Size = new System.Drawing.Size(36, 20);
            this.steLabel.TabIndex = 2;
            this.steLabel.Text = "STE:";
            this.steLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // steValueLabel
            // 
            this.steValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.steValueLabel.AutoSize = true;
            this.steValueLabel.Location = new System.Drawing.Point(118, 140);
            this.steValueLabel.Name = "steValueLabel";
            this.steValueLabel.Size = new System.Drawing.Size(17, 20);
            this.steValueLabel.TabIndex = 28;
            this.steValueLabel.Text = "0";
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(3, 72);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(62, 20);
            this.volumeLabel.TabIndex = 0;
            this.volumeLabel.Text = "Volume:";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.Location = new System.Drawing.Point(118, 72);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(17, 20);
            this.volumeValueLabel.TabIndex = 27;
            this.volumeValueLabel.Text = "0";
            // 
            // soundSpeechPlot
            // 
            this.soundSpeechPlot.BackColor = System.Drawing.SystemColors.Window;
            this.soundSpeechPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSpeechPlot.Location = new System.Drawing.Point(205, 528);
            this.soundSpeechPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundSpeechPlot.Name = "soundSpeechPlot";
            this.soundSpeechPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.soundSpeechPlot.Size = new System.Drawing.Size(1271, 63);
            this.soundSpeechPlot.TabIndex = 25;
            this.soundSpeechPlot.Text = "plotView8";
            this.soundSpeechPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.soundSpeechPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.soundSpeechPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // soundlessSpeechPlot
            // 
            this.soundlessSpeechPlot.BackColor = System.Drawing.SystemColors.Window;
            this.soundlessSpeechPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundlessSpeechPlot.Location = new System.Drawing.Point(205, 460);
            this.soundlessSpeechPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundlessSpeechPlot.Name = "soundlessSpeechPlot";
            this.soundlessSpeechPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.soundlessSpeechPlot.Size = new System.Drawing.Size(1271, 60);
            this.soundlessSpeechPlot.TabIndex = 24;
            this.soundlessSpeechPlot.Text = "plotView7";
            this.soundlessSpeechPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.soundlessSpeechPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.soundlessSpeechPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // amdfPlot
            // 
            this.amdfPlot.BackColor = System.Drawing.SystemColors.Window;
            this.amdfPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amdfPlot.Location = new System.Drawing.Point(205, 392);
            this.amdfPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amdfPlot.Name = "amdfPlot";
            this.amdfPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.amdfPlot.Size = new System.Drawing.Size(1271, 60);
            this.amdfPlot.TabIndex = 23;
            this.amdfPlot.Text = "plotView6";
            this.amdfPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.amdfPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.amdfPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // autoCorrePlot
            // 
            this.autoCorrePlot.BackColor = System.Drawing.SystemColors.Window;
            this.autoCorrePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCorrePlot.Location = new System.Drawing.Point(205, 324);
            this.autoCorrePlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoCorrePlot.Name = "autoCorrePlot";
            this.autoCorrePlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.autoCorrePlot.Size = new System.Drawing.Size(1271, 60);
            this.autoCorrePlot.TabIndex = 22;
            this.autoCorrePlot.Text = "plotView5";
            this.autoCorrePlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.autoCorrePlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.autoCorrePlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // silencePlot
            // 
            this.silencePlot.BackColor = System.Drawing.SystemColors.Window;
            this.silencePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silencePlot.Location = new System.Drawing.Point(205, 256);
            this.silencePlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.silencePlot.Name = "silencePlot";
            this.silencePlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.silencePlot.Size = new System.Drawing.Size(1271, 60);
            this.silencePlot.TabIndex = 21;
            this.silencePlot.Text = "plotView4";
            this.silencePlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.silencePlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.silencePlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // zcrPlot
            // 
            this.zcrPlot.BackColor = System.Drawing.SystemColors.Window;
            this.zcrPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcrPlot.Location = new System.Drawing.Point(205, 188);
            this.zcrPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zcrPlot.Name = "zcrPlot";
            this.zcrPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.zcrPlot.Size = new System.Drawing.Size(1271, 60);
            this.zcrPlot.TabIndex = 20;
            this.zcrPlot.Text = "plotView3";
            this.zcrPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.zcrPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.zcrPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // stePlot
            // 
            this.stePlot.BackColor = System.Drawing.SystemColors.Window;
            this.stePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stePlot.Location = new System.Drawing.Point(205, 120);
            this.stePlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stePlot.Name = "stePlot";
            this.stePlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.stePlot.Size = new System.Drawing.Size(1271, 60);
            this.stePlot.TabIndex = 19;
            this.stePlot.Text = "plotView2";
            this.stePlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.stePlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.stePlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // volumePlot
            // 
            this.volumePlot.BackColor = System.Drawing.SystemColors.Window;
            this.volumePlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumePlot.Location = new System.Drawing.Point(205, 52);
            this.volumePlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volumePlot.Name = "volumePlot";
            this.volumePlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.volumePlot.Size = new System.Drawing.Size(1271, 60);
            this.volumePlot.TabIndex = 18;
            this.volumePlot.Text = "plotView1";
            this.volumePlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.volumePlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.volumePlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(118, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 48);
            this.label3.TabIndex = 36;
            this.label3.Text = "Wartość średnia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Wykres";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.soundPlot, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.755803F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.24302F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.32178F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.679394F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1485, 924);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.milisecondPerFrameNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lagNumericUpDown);
            this.groupBox1.Controls.Add(this.repaintButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1479, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // soundPlot
            // 
            this.soundPlot.BackColor = System.Drawing.SystemColors.Window;
            this.soundPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundPlot.Location = new System.Drawing.Point(3, 66);
            this.soundPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundPlot.Name = "soundPlot";
            this.soundPlot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.soundPlot.Size = new System.Drawing.Size(1479, 160);
            this.soundPlot.TabIndex = 9;
            this.soundPlot.Text = "plotView10";
            this.soundPlot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.soundPlot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.soundPlot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 837);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1479, 83);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hzcrrValueLabel);
            this.groupBox4.Controls.Add(this.zstdValueLabel);
            this.groupBox4.Controls.Add(this.zstdLabel);
            this.groupBox4.Controls.Add(this.hzcrrLabel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(989, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(487, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ZCR based";
            // 
            // hzcrrValueLabel
            // 
            this.hzcrrValueLabel.AutoSize = true;
            this.hzcrrValueLabel.Location = new System.Drawing.Point(386, 37);
            this.hzcrrValueLabel.Name = "hzcrrValueLabel";
            this.hzcrrValueLabel.Size = new System.Drawing.Size(17, 20);
            this.hzcrrValueLabel.TabIndex = 6;
            this.hzcrrValueLabel.Text = "0";
            // 
            // zstdValueLabel
            // 
            this.zstdValueLabel.AutoSize = true;
            this.zstdValueLabel.Location = new System.Drawing.Point(70, 39);
            this.zstdValueLabel.Name = "zstdValueLabel";
            this.zstdValueLabel.Size = new System.Drawing.Size(17, 20);
            this.zstdValueLabel.TabIndex = 5;
            this.zstdValueLabel.Text = "0";
            // 
            // zstdLabel
            // 
            this.zstdLabel.AutoSize = true;
            this.zstdLabel.Location = new System.Drawing.Point(24, 37);
            this.zstdLabel.Name = "zstdLabel";
            this.zstdLabel.Size = new System.Drawing.Size(45, 20);
            this.zstdLabel.TabIndex = 4;
            this.zstdLabel.Text = "ZSTD";
            // 
            // hzcrrLabel
            // 
            this.hzcrrLabel.AutoSize = true;
            this.hzcrrLabel.Location = new System.Drawing.Point(328, 37);
            this.hzcrrLabel.Name = "hzcrrLabel";
            this.hzcrrLabel.Size = new System.Drawing.Size(56, 20);
            this.hzcrrLabel.TabIndex = 3;
            this.hzcrrLabel.Text = "HZCRR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsterValueLabel);
            this.groupBox3.Controls.Add(this.lsterLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(496, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(487, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Energy based";
            // 
            // lsterValueLabel
            // 
            this.lsterValueLabel.AutoSize = true;
            this.lsterValueLabel.Location = new System.Drawing.Point(95, 39);
            this.lsterValueLabel.Name = "lsterValueLabel";
            this.lsterValueLabel.Size = new System.Drawing.Size(17, 20);
            this.lsterValueLabel.TabIndex = 5;
            this.lsterValueLabel.Text = "0";
            // 
            // lsterLabel
            // 
            this.lsterLabel.AutoSize = true;
            this.lsterLabel.Location = new System.Drawing.Point(45, 37);
            this.lsterLabel.Name = "lsterLabel";
            this.lsterLabel.Size = new System.Drawing.Size(49, 20);
            this.lsterLabel.TabIndex = 4;
            this.lsterLabel.Text = "LSTER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vdrValueLabel);
            this.groupBox2.Controls.Add(this.vstdValueLabel);
            this.groupBox2.Controls.Add(this.vdrLabel);
            this.groupBox2.Controls.Add(this.vstdLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(487, 75);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume based";
            // 
            // vdrValueLabel
            // 
            this.vdrValueLabel.AutoSize = true;
            this.vdrValueLabel.Location = new System.Drawing.Point(219, 37);
            this.vdrValueLabel.Name = "vdrValueLabel";
            this.vdrValueLabel.Size = new System.Drawing.Size(17, 20);
            this.vdrValueLabel.TabIndex = 4;
            this.vdrValueLabel.Text = "0";
            // 
            // vstdValueLabel
            // 
            this.vstdValueLabel.AutoSize = true;
            this.vstdValueLabel.Location = new System.Drawing.Point(62, 39);
            this.vstdValueLabel.Name = "vstdValueLabel";
            this.vstdValueLabel.Size = new System.Drawing.Size(17, 20);
            this.vstdValueLabel.TabIndex = 3;
            this.vstdValueLabel.Text = "0";
            // 
            // vdrLabel
            // 
            this.vdrLabel.AutoSize = true;
            this.vdrLabel.Location = new System.Drawing.Point(179, 37);
            this.vdrLabel.Name = "vdrLabel";
            this.vdrLabel.Size = new System.Drawing.Size(38, 20);
            this.vdrLabel.TabIndex = 1;
            this.vdrLabel.Text = "VDR";
            // 
            // vstdLabel
            // 
            this.vstdLabel.AutoSize = true;
            this.vstdLabel.Location = new System.Drawing.Point(16, 37);
            this.vstdLabel.Name = "vstdLabel";
            this.vstdLabel.Size = new System.Drawing.Size(45, 20);
            this.vstdLabel.TabIndex = 0;
            this.vstdLabel.Text = "VSTD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1485, 954);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ADP1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milisecondPerFrameNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem silenceToolStripMenuItem;
        private ToolStripMenuItem soundlessSpeechToolStripMenuItem;
        private ToolStripMenuItem soundSpeechToolStripMenuItem;
        private ToolStripMenuItem showSilenceToolStripMenuItem;
        private ToolStripMenuItem exportSilenceToolStripMenuItem;
        private ToolStripMenuItem showSoundlessToolStripMenuItem;
        private ToolStripMenuItem exportSoundlessToolStripMenuItem;
        private ToolStripMenuItem showSoundToolStripMenuItem;
        private ToolStripMenuItem exportSoundToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private NumericUpDown milisecondPerFrameNumeric;
        private Label label1;
        private Label label2;
        private NumericUpDown lagNumericUpDown;
        private Button repaintButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label volumeLabel;
        private Label steLabel;
        private Label silenceLabel;
        private Label zcrLabel;
        private Label autocorLabel;
        private Label amdfLabel;
        private Label soundlessSpeechLabel;
        private Label soundSpeechLabel;
        private OxyPlot.WindowsForms.PlotView volumePlot;
        private OxyPlot.WindowsForms.PlotView soundSpeechPlot;
        private OxyPlot.WindowsForms.PlotView soundlessSpeechPlot;
        private OxyPlot.WindowsForms.PlotView amdfPlot;
        private OxyPlot.WindowsForms.PlotView autoCorrePlot;
        private OxyPlot.WindowsForms.PlotView silencePlot;
        private OxyPlot.WindowsForms.PlotView zcrPlot;
        private OxyPlot.WindowsForms.PlotView stePlot;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private OxyPlot.WindowsForms.PlotView soundPlot;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label vstdLabel;
        private Label vdrLabel;
        private Label lsterLabel;
        private Label zstdLabel;
        private Label hzcrrLabel;
        private Label volumeValueLabel;
        private Label soundSpeechValueLabel;
        private Label soundlessSpeechValueLabel;
        private Label amdfValueLabel;
        private Label autocorValueLabel;
        private Label silenceValueLabel;
        private Label zcrValueLabel;
        private Label steValueLabel;
        private Label hzcrrValueLabel;
        private Label zstdValueLabel;
        private Label lsterValueLabel;
        private Label vdrValueLabel;
        private Label vstdValueLabel;
        private Label label3;
        private Label label4;
    }
}