namespace SpriteSheeter
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkDebugMode = new System.Windows.Forms.CheckBox();
            this.chkTransparentMask = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numTrimThreshold = new System.Windows.Forms.NumericUpDown();
            this.ddlTrimMode = new System.Windows.Forms.ComboBox();
            this.chkAllowRotation = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numPadding = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlHeuristics = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlAlgorithm = new System.Windows.Forms.ComboBox();
            this.chkForcePowerOf2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ddlScaleMode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlScale = new System.Windows.Forms.ComboBox();
            this.chkForceSquare = new System.Windows.Forms.CheckBox();
            this.chkIsMaxSize = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlHeight = new System.Windows.Forms.ComboBox();
            this.ddlWidth = new System.Windows.Forms.ComboBox();
            this.ddlColorFormat = new System.Windows.Forms.ComboBox();
            this.ddlDithering = new System.Windows.Forms.ComboBox();
            this.chkPremultiplyAlpha = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTrimFileExtension = new System.Windows.Forms.CheckBox();
            this.txtSheetPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlImageFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlDataFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.lnkSheetPath = new System.Windows.Forms.LinkLabel();
            this.dlgSheetPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.revertToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 6);
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.revertToolStripMenuItem.Text = "&Revert";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkDebugMode);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.ddlAlgorithm);
            this.splitContainer1.Panel1.Controls.Add(this.chkTransparentMask);
            this.splitContainer1.Panel1.Controls.Add(this.chkForcePowerOf2);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.ddlScaleMode);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.ddlWidth);
            this.splitContainer1.Panel1.Controls.Add(this.ddlHeuristics);
            this.splitContainer1.Panel1.Controls.Add(this.ddlScale);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.chkIsMaxSize);
            this.splitContainer1.Panel1.Controls.Add(this.numTrimThreshold);
            this.splitContainer1.Panel1.Controls.Add(this.ddlHeight);
            this.splitContainer1.Panel1.Controls.Add(this.numPadding);
            this.splitContainer1.Panel1.Controls.Add(this.chkForceSquare);
            this.splitContainer1.Panel1.Controls.Add(this.ddlTrimMode);
            this.splitContainer1.Panel1.Controls.Add(this.ddlColorFormat);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.chkAllowRotation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.chkTrimFileExtension);
            this.splitContainer1.Panel1.Controls.Add(this.ddlDithering);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.chkPremultiplyAlpha);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ddlDataFormat);
            this.splitContainer1.Panel1.Controls.Add(this.txtSheetName);
            this.splitContainer1.Panel1.Controls.Add(this.txtSheetPath);
            this.splitContainer1.Panel1.Controls.Add(this.lnkSheetPath);
            this.splitContainer1.Panel1.Controls.Add(this.ddlImageFormat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 531);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 3;
            // 
            // chkDebugMode
            // 
            this.chkDebugMode.AutoSize = true;
            this.chkDebugMode.Location = new System.Drawing.Point(83, 585);
            this.chkDebugMode.Name = "chkDebugMode";
            this.chkDebugMode.Size = new System.Drawing.Size(88, 17);
            this.chkDebugMode.TabIndex = 28;
            this.chkDebugMode.Text = "Debug Mode";
            this.chkDebugMode.UseVisualStyleBackColor = true;
            // 
            // chkTransparentMask
            // 
            this.chkTransparentMask.AutoSize = true;
            this.chkTransparentMask.Location = new System.Drawing.Point(83, 562);
            this.chkTransparentMask.Name = "chkTransparentMask";
            this.chkTransparentMask.Size = new System.Drawing.Size(112, 17);
            this.chkTransparentMask.TabIndex = 27;
            this.chkTransparentMask.Text = "Transparent Mask";
            this.chkTransparentMask.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 538);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Threshold";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 512);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Trim Mode";
            // 
            // numTrimThreshold
            // 
            this.numTrimThreshold.Location = new System.Drawing.Point(84, 536);
            this.numTrimThreshold.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numTrimThreshold.Name = "numTrimThreshold";
            this.numTrimThreshold.Size = new System.Drawing.Size(127, 20);
            this.numTrimThreshold.TabIndex = 24;
            this.numTrimThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ddlTrimMode
            // 
            this.ddlTrimMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTrimMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTrimMode.FormattingEnabled = true;
            this.ddlTrimMode.Items.AddRange(new object[] {
            "None",
            "Trim"});
            this.ddlTrimMode.Location = new System.Drawing.Point(83, 509);
            this.ddlTrimMode.Name = "ddlTrimMode";
            this.ddlTrimMode.Size = new System.Drawing.Size(145, 21);
            this.ddlTrimMode.TabIndex = 23;
            // 
            // chkAllowRotation
            // 
            this.chkAllowRotation.AutoSize = true;
            this.chkAllowRotation.Location = new System.Drawing.Point(83, 486);
            this.chkAllowRotation.Name = "chkAllowRotation";
            this.chkAllowRotation.Size = new System.Drawing.Size(94, 17);
            this.chkAllowRotation.TabIndex = 22;
            this.chkAllowRotation.Text = "Allow Rotation";
            this.chkAllowRotation.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Padding";
            // 
            // numPadding
            // 
            this.numPadding.Location = new System.Drawing.Point(84, 460);
            this.numPadding.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numPadding.Name = "numPadding";
            this.numPadding.Size = new System.Drawing.Size(127, 20);
            this.numPadding.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Heuristics";
            // 
            // ddlHeuristics
            // 
            this.ddlHeuristics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlHeuristics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlHeuristics.FormattingEnabled = true;
            this.ddlHeuristics.Items.AddRange(new object[] {
            "Best",
            "Short Side Fit",
            "Long Side Fit",
            "Area Fit",
            "Bottom Left",
            "Contact Point"});
            this.ddlHeuristics.Location = new System.Drawing.Point(83, 433);
            this.ddlHeuristics.Name = "ddlHeuristics";
            this.ddlHeuristics.Size = new System.Drawing.Size(145, 21);
            this.ddlHeuristics.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Algorithm";
            // 
            // ddlAlgorithm
            // 
            this.ddlAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAlgorithm.FormattingEnabled = true;
            this.ddlAlgorithm.Items.AddRange(new object[] {
            "MaxRects",
            "Basic"});
            this.ddlAlgorithm.Location = new System.Drawing.Point(83, 406);
            this.ddlAlgorithm.Name = "ddlAlgorithm";
            this.ddlAlgorithm.Size = new System.Drawing.Size(145, 21);
            this.ddlAlgorithm.TabIndex = 15;
            // 
            // chkForcePowerOf2
            // 
            this.chkForcePowerOf2.AutoSize = true;
            this.chkForcePowerOf2.Checked = true;
            this.chkForcePowerOf2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForcePowerOf2.Location = new System.Drawing.Point(83, 329);
            this.chkForcePowerOf2.Name = "chkForcePowerOf2";
            this.chkForcePowerOf2.Size = new System.Drawing.Size(107, 17);
            this.chkForcePowerOf2.TabIndex = 16;
            this.chkForcePowerOf2.Text = "Force Power of 2";
            this.chkForcePowerOf2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Scale Mode";
            // 
            // ddlScaleMode
            // 
            this.ddlScaleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlScaleMode.FormattingEnabled = true;
            this.ddlScaleMode.Items.AddRange(new object[] {
            "Smooth",
            "Nearest Neighbor",
            "Bileniar",
            "Bicubic"});
            this.ddlScaleMode.Location = new System.Drawing.Point(83, 379);
            this.ddlScaleMode.Name = "ddlScaleMode";
            this.ddlScaleMode.Size = new System.Drawing.Size(145, 21);
            this.ddlScaleMode.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Scale";
            // 
            // ddlScale
            // 
            this.ddlScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlScale.FormattingEnabled = true;
            this.ddlScale.Items.AddRange(new object[] {
            "1.000",
            "0.500",
            "0.250",
            "0.125"});
            this.ddlScale.Location = new System.Drawing.Point(83, 352);
            this.ddlScale.Name = "ddlScale";
            this.ddlScale.Size = new System.Drawing.Size(145, 21);
            this.ddlScale.TabIndex = 12;
            // 
            // chkForceSquare
            // 
            this.chkForceSquare.AutoSize = true;
            this.chkForceSquare.Location = new System.Drawing.Point(83, 306);
            this.chkForceSquare.Name = "chkForceSquare";
            this.chkForceSquare.Size = new System.Drawing.Size(90, 17);
            this.chkForceSquare.TabIndex = 11;
            this.chkForceSquare.Text = "Force Square";
            this.chkForceSquare.UseVisualStyleBackColor = true;
            // 
            // chkIsMaxSize
            // 
            this.chkIsMaxSize.AutoSize = true;
            this.chkIsMaxSize.Checked = true;
            this.chkIsMaxSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsMaxSize.Location = new System.Drawing.Point(83, 283);
            this.chkIsMaxSize.Name = "chkIsMaxSize";
            this.chkIsMaxSize.Size = new System.Drawing.Size(107, 17);
            this.chkIsMaxSize.TabIndex = 9;
            this.chkIsMaxSize.Text = "W&&H is Max Size";
            this.chkIsMaxSize.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Width";
            // 
            // ddlHeight
            // 
            this.ddlHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlHeight.FormattingEnabled = true;
            this.ddlHeight.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.ddlHeight.Location = new System.Drawing.Point(82, 256);
            this.ddlHeight.Name = "ddlHeight";
            this.ddlHeight.Size = new System.Drawing.Size(146, 21);
            this.ddlHeight.TabIndex = 1;
            // 
            // ddlWidth
            // 
            this.ddlWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlWidth.FormattingEnabled = true;
            this.ddlWidth.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.ddlWidth.Location = new System.Drawing.Point(82, 229);
            this.ddlWidth.Name = "ddlWidth";
            this.ddlWidth.Size = new System.Drawing.Size(146, 21);
            this.ddlWidth.TabIndex = 0;
            // 
            // ddlColorFormat
            // 
            this.ddlColorFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlColorFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlColorFormat.FormattingEnabled = true;
            this.ddlColorFormat.Items.AddRange(new object[] {
            "RGBA8888",
            "BGRA8888",
            "RGBA4444",
            "RGB888",
            "RGB565",
            "RGBA5551"});
            this.ddlColorFormat.Location = new System.Drawing.Point(83, 152);
            this.ddlColorFormat.Name = "ddlColorFormat";
            this.ddlColorFormat.Size = new System.Drawing.Size(146, 21);
            this.ddlColorFormat.TabIndex = 5;
            // 
            // ddlDithering
            // 
            this.ddlDithering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlDithering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDithering.FormattingEnabled = true;
            this.ddlDithering.Items.AddRange(new object[] {
            "Nearest Neighbor",
            "Linear",
            "Floyd-Steinberg",
            "Floyd-Steinberg Alpha",
            "Atkinson",
            "Atkinson Alpha"});
            this.ddlDithering.Location = new System.Drawing.Point(83, 179);
            this.ddlDithering.Name = "ddlDithering";
            this.ddlDithering.Size = new System.Drawing.Size(144, 21);
            this.ddlDithering.TabIndex = 7;
            // 
            // chkPremultiplyAlpha
            // 
            this.chkPremultiplyAlpha.AutoSize = true;
            this.chkPremultiplyAlpha.Location = new System.Drawing.Point(82, 206);
            this.chkPremultiplyAlpha.Name = "chkPremultiplyAlpha";
            this.chkPremultiplyAlpha.Size = new System.Drawing.Size(106, 17);
            this.chkPremultiplyAlpha.TabIndex = 8;
            this.chkPremultiplyAlpha.Text = "Premultiply Alpha";
            this.chkPremultiplyAlpha.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dithering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color Format";
            // 
            // chkTrimFileExtension
            // 
            this.chkTrimFileExtension.AutoSize = true;
            this.chkTrimFileExtension.Checked = true;
            this.chkTrimFileExtension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrimFileExtension.Location = new System.Drawing.Point(83, 102);
            this.chkTrimFileExtension.Name = "chkTrimFileExtension";
            this.chkTrimFileExtension.Size = new System.Drawing.Size(119, 17);
            this.chkTrimFileExtension.TabIndex = 30;
            this.chkTrimFileExtension.Text = "Trim File Extensions";
            this.chkTrimFileExtension.UseVisualStyleBackColor = true;
            // 
            // txtSheetPath
            // 
            this.txtSheetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSheetPath.Location = new System.Drawing.Point(82, 49);
            this.txtSheetPath.Name = "txtSheetPath";
            this.txtSheetPath.ReadOnly = true;
            this.txtSheetPath.Size = new System.Drawing.Size(144, 20);
            this.txtSheetPath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Format";
            // 
            // ddlImageFormat
            // 
            this.ddlImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlImageFormat.FormattingEnabled = true;
            this.ddlImageFormat.Items.AddRange(new object[] {
            "BMP",
            "GIF",
            "JPG",
            "PNG",
            "TIF"});
            this.ddlImageFormat.Location = new System.Drawing.Point(83, 125);
            this.ddlImageFormat.Name = "ddlImageFormat";
            this.ddlImageFormat.Size = new System.Drawing.Size(145, 21);
            this.ddlImageFormat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Format";
            // 
            // ddlDataFormat
            // 
            this.ddlDataFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataFormat.FormattingEnabled = true;
            this.ddlDataFormat.Items.AddRange(new object[] {
            "CSS",
            "XML"});
            this.ddlDataFormat.Location = new System.Drawing.Point(83, 75);
            this.ddlDataFormat.Name = "ddlDataFormat";
            this.ddlDataFormat.Size = new System.Drawing.Size(144, 21);
            this.ddlDataFormat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheet Name";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSheetName.Location = new System.Drawing.Point(83, 23);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(144, 20);
            this.txtSheetName.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(767, 531);
            this.splitContainer2.SplitterDistance = 543;
            this.splitContainer2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "PROPERTIES:";
            // 
            // lnkSheetPath
            // 
            this.lnkSheetPath.AutoSize = true;
            this.lnkSheetPath.Location = new System.Drawing.Point(12, 52);
            this.lnkSheetPath.Name = "lnkSheetPath";
            this.lnkSheetPath.Size = new System.Drawing.Size(60, 13);
            this.lnkSheetPath.TabIndex = 9;
            this.lnkSheetPath.TabStop = true;
            this.lnkSheetPath.Text = "Sheet Path";
            this.lnkSheetPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSheetPath_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SpriteSheeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTrimThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkPremultiplyAlpha;
        private System.Windows.Forms.ComboBox ddlDithering;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlColorFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlImageFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlDataFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chkIsMaxSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlHeight;
        private System.Windows.Forms.ComboBox ddlWidth;
        private System.Windows.Forms.TextBox txtSheetPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.CheckBox chkForcePowerOf2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddlScaleMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlScale;
        private System.Windows.Forms.CheckBox chkForceSquare;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numTrimThreshold;
        private System.Windows.Forms.ComboBox ddlTrimMode;
        private System.Windows.Forms.CheckBox chkAllowRotation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPadding;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlHeuristics;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlAlgorithm;
        private System.Windows.Forms.CheckBox chkDebugMode;
        private System.Windows.Forms.CheckBox chkTransparentMask;
        private System.Windows.Forms.CheckBox chkTrimFileExtension;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel lnkSheetPath;
        private System.Windows.Forms.FolderBrowserDialog dlgSheetPath;
    }
}

