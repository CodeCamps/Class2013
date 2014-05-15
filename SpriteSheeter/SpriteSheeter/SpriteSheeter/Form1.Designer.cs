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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlDataFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlImageFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlColorFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlDithering = new System.Windows.Forms.ComboBox();
            this.chkPremultiplyAlpha = new System.Windows.Forms.CheckBox();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupColors = new System.Windows.Forms.GroupBox();
            this.groupDimensions = new System.Windows.Forms.GroupBox();
            this.ddlWidth = new System.Windows.Forms.ComboBox();
            this.ddlHeight = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIsMaxSize = new System.Windows.Forms.CheckBox();
            this.chkForceSquare = new System.Windows.Forms.CheckBox();
            this.ddlScale = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlScaleMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkForcePowerOf2 = new System.Windows.Forms.CheckBox();
            this.groupLayout = new System.Windows.Forms.GroupBox();
            this.ddlAlgorithm = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlHeuristics = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numPadding = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAllowRotation = new System.Windows.Forms.CheckBox();
            this.ddlTrimMode = new System.Windows.Forms.ComboBox();
            this.numTrimThreshold = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chkTransparentMask = new System.Windows.Forms.CheckBox();
            this.chkDebugMode = new System.Windows.Forms.CheckBox();
            this.chkTrimFileExtension = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.groupColors.SuspendLayout();
            this.groupDimensions.SuspendLayout();
            this.groupLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimThreshold)).BeginInit();
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.revertToolStripMenuItem.Text = "&Revert";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupLayout);
            this.splitContainer1.Panel1.Controls.Add(this.groupDimensions);
            this.splitContainer1.Panel1.Controls.Add(this.groupColors);
            this.splitContainer1.Panel1.Controls.Add(this.groupOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 531);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 3;
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
            // groupOutput
            // 
            this.groupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutput.Controls.Add(this.chkTrimFileExtension);
            this.groupOutput.Controls.Add(this.label6);
            this.groupOutput.Controls.Add(this.txtImagePath);
            this.groupOutput.Controls.Add(this.label5);
            this.groupOutput.Controls.Add(this.ddlImageFormat);
            this.groupOutput.Controls.Add(this.label2);
            this.groupOutput.Controls.Add(this.ddlDataFormat);
            this.groupOutput.Controls.Add(this.label1);
            this.groupOutput.Controls.Add(this.txtDataPath);
            this.groupOutput.Location = new System.Drawing.Point(3, 0);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(214, 146);
            this.groupOutput.TabIndex = 0;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "OUTPUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Format";
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
            this.ddlDataFormat.Location = new System.Drawing.Point(80, 16);
            this.ddlDataFormat.Name = "ddlDataFormat";
            this.ddlDataFormat.Size = new System.Drawing.Size(128, 21);
            this.ddlDataFormat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Format";
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
            this.ddlImageFormat.Location = new System.Drawing.Point(80, 69);
            this.ddlImageFormat.Name = "ddlImageFormat";
            this.ddlImageFormat.Size = new System.Drawing.Size(128, 21);
            this.ddlImageFormat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color Format";
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
            this.ddlColorFormat.Location = new System.Drawing.Point(79, 19);
            this.ddlColorFormat.Name = "ddlColorFormat";
            this.ddlColorFormat.Size = new System.Drawing.Size(128, 21);
            this.ddlColorFormat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dithering";
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
            this.ddlDithering.Location = new System.Drawing.Point(80, 46);
            this.ddlDithering.Name = "ddlDithering";
            this.ddlDithering.Size = new System.Drawing.Size(128, 21);
            this.ddlDithering.TabIndex = 7;
            // 
            // chkPremultiplyAlpha
            // 
            this.chkPremultiplyAlpha.AutoSize = true;
            this.chkPremultiplyAlpha.Location = new System.Drawing.Point(79, 73);
            this.chkPremultiplyAlpha.Name = "chkPremultiplyAlpha";
            this.chkPremultiplyAlpha.Size = new System.Drawing.Size(106, 17);
            this.chkPremultiplyAlpha.TabIndex = 8;
            this.chkPremultiplyAlpha.Text = "Premultiply Alpha";
            this.chkPremultiplyAlpha.UseVisualStyleBackColor = true;
            // 
            // txtDataPath
            // 
            this.txtDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataPath.Location = new System.Drawing.Point(80, 43);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(128, 20);
            this.txtDataPath.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Path";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagePath.Location = new System.Drawing.Point(80, 96);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(128, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Image Path";
            // 
            // groupColors
            // 
            this.groupColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupColors.Controls.Add(this.ddlColorFormat);
            this.groupColors.Controls.Add(this.ddlDithering);
            this.groupColors.Controls.Add(this.chkPremultiplyAlpha);
            this.groupColors.Controls.Add(this.label4);
            this.groupColors.Controls.Add(this.label3);
            this.groupColors.Location = new System.Drawing.Point(3, 151);
            this.groupColors.Name = "groupColors";
            this.groupColors.Size = new System.Drawing.Size(214, 99);
            this.groupColors.TabIndex = 1;
            this.groupColors.TabStop = false;
            this.groupColors.Text = "COLORS";
            // 
            // groupDimensions
            // 
            this.groupDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDimensions.Controls.Add(this.chkForcePowerOf2);
            this.groupDimensions.Controls.Add(this.label10);
            this.groupDimensions.Controls.Add(this.ddlScaleMode);
            this.groupDimensions.Controls.Add(this.label9);
            this.groupDimensions.Controls.Add(this.ddlScale);
            this.groupDimensions.Controls.Add(this.chkForceSquare);
            this.groupDimensions.Controls.Add(this.chkIsMaxSize);
            this.groupDimensions.Controls.Add(this.label8);
            this.groupDimensions.Controls.Add(this.label7);
            this.groupDimensions.Controls.Add(this.ddlHeight);
            this.groupDimensions.Controls.Add(this.ddlWidth);
            this.groupDimensions.Location = new System.Drawing.Point(3, 256);
            this.groupDimensions.Name = "groupDimensions";
            this.groupDimensions.Size = new System.Drawing.Size(214, 201);
            this.groupDimensions.TabIndex = 2;
            this.groupDimensions.TabStop = false;
            this.groupDimensions.Text = "DIMENSIONS";
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
            this.ddlWidth.Location = new System.Drawing.Point(79, 20);
            this.ddlWidth.Name = "ddlWidth";
            this.ddlWidth.Size = new System.Drawing.Size(128, 21);
            this.ddlWidth.TabIndex = 0;
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
            this.ddlHeight.Location = new System.Drawing.Point(79, 47);
            this.ddlHeight.Name = "ddlHeight";
            this.ddlHeight.Size = new System.Drawing.Size(128, 21);
            this.ddlHeight.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Height";
            // 
            // chkIsMaxSize
            // 
            this.chkIsMaxSize.AutoSize = true;
            this.chkIsMaxSize.Checked = true;
            this.chkIsMaxSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsMaxSize.Location = new System.Drawing.Point(80, 74);
            this.chkIsMaxSize.Name = "chkIsMaxSize";
            this.chkIsMaxSize.Size = new System.Drawing.Size(107, 17);
            this.chkIsMaxSize.TabIndex = 9;
            this.chkIsMaxSize.Text = "W&&H is Max Size";
            this.chkIsMaxSize.UseVisualStyleBackColor = true;
            // 
            // chkForceSquare
            // 
            this.chkForceSquare.AutoSize = true;
            this.chkForceSquare.Location = new System.Drawing.Point(80, 97);
            this.chkForceSquare.Name = "chkForceSquare";
            this.chkForceSquare.Size = new System.Drawing.Size(90, 17);
            this.chkForceSquare.TabIndex = 11;
            this.chkForceSquare.Text = "Force Square";
            this.chkForceSquare.UseVisualStyleBackColor = true;
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
            this.ddlScale.Location = new System.Drawing.Point(80, 143);
            this.ddlScale.Name = "ddlScale";
            this.ddlScale.Size = new System.Drawing.Size(128, 21);
            this.ddlScale.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Scale";
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
            this.ddlScaleMode.Location = new System.Drawing.Point(80, 170);
            this.ddlScaleMode.Name = "ddlScaleMode";
            this.ddlScaleMode.Size = new System.Drawing.Size(128, 21);
            this.ddlScaleMode.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Scale Mode";
            // 
            // chkForcePowerOf2
            // 
            this.chkForcePowerOf2.AutoSize = true;
            this.chkForcePowerOf2.Checked = true;
            this.chkForcePowerOf2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForcePowerOf2.Location = new System.Drawing.Point(80, 120);
            this.chkForcePowerOf2.Name = "chkForcePowerOf2";
            this.chkForcePowerOf2.Size = new System.Drawing.Size(107, 17);
            this.chkForcePowerOf2.TabIndex = 16;
            this.chkForcePowerOf2.Text = "Force Power of 2";
            this.chkForcePowerOf2.UseVisualStyleBackColor = true;
            // 
            // groupLayout
            // 
            this.groupLayout.Controls.Add(this.chkDebugMode);
            this.groupLayout.Controls.Add(this.chkTransparentMask);
            this.groupLayout.Controls.Add(this.label15);
            this.groupLayout.Controls.Add(this.label14);
            this.groupLayout.Controls.Add(this.numTrimThreshold);
            this.groupLayout.Controls.Add(this.ddlTrimMode);
            this.groupLayout.Controls.Add(this.chkAllowRotation);
            this.groupLayout.Controls.Add(this.label13);
            this.groupLayout.Controls.Add(this.numPadding);
            this.groupLayout.Controls.Add(this.label12);
            this.groupLayout.Controls.Add(this.ddlHeuristics);
            this.groupLayout.Controls.Add(this.label11);
            this.groupLayout.Controls.Add(this.ddlAlgorithm);
            this.groupLayout.Location = new System.Drawing.Point(3, 463);
            this.groupLayout.Name = "groupLayout";
            this.groupLayout.Size = new System.Drawing.Size(214, 220);
            this.groupLayout.TabIndex = 3;
            this.groupLayout.TabStop = false;
            this.groupLayout.Text = "LAYOUT";
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
            this.ddlAlgorithm.Location = new System.Drawing.Point(79, 19);
            this.ddlAlgorithm.Name = "ddlAlgorithm";
            this.ddlAlgorithm.Size = new System.Drawing.Size(128, 21);
            this.ddlAlgorithm.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Algorithm";
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
            this.ddlHeuristics.Location = new System.Drawing.Point(79, 46);
            this.ddlHeuristics.Name = "ddlHeuristics";
            this.ddlHeuristics.Size = new System.Drawing.Size(128, 21);
            this.ddlHeuristics.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Heuristics";
            // 
            // numPadding
            // 
            this.numPadding.Location = new System.Drawing.Point(80, 73);
            this.numPadding.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numPadding.Name = "numPadding";
            this.numPadding.Size = new System.Drawing.Size(127, 20);
            this.numPadding.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Padding";
            // 
            // chkAllowRotation
            // 
            this.chkAllowRotation.AutoSize = true;
            this.chkAllowRotation.Location = new System.Drawing.Point(79, 99);
            this.chkAllowRotation.Name = "chkAllowRotation";
            this.chkAllowRotation.Size = new System.Drawing.Size(94, 17);
            this.chkAllowRotation.TabIndex = 22;
            this.chkAllowRotation.Text = "Allow Rotation";
            this.chkAllowRotation.UseVisualStyleBackColor = true;
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
            this.ddlTrimMode.Location = new System.Drawing.Point(79, 122);
            this.ddlTrimMode.Name = "ddlTrimMode";
            this.ddlTrimMode.Size = new System.Drawing.Size(128, 21);
            this.ddlTrimMode.TabIndex = 23;
            // 
            // numTrimThreshold
            // 
            this.numTrimThreshold.Location = new System.Drawing.Point(80, 149);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Trim Mode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Threshold";
            // 
            // chkTransparentMask
            // 
            this.chkTransparentMask.AutoSize = true;
            this.chkTransparentMask.Location = new System.Drawing.Point(79, 175);
            this.chkTransparentMask.Name = "chkTransparentMask";
            this.chkTransparentMask.Size = new System.Drawing.Size(112, 17);
            this.chkTransparentMask.TabIndex = 27;
            this.chkTransparentMask.Text = "Transparent Mask";
            this.chkTransparentMask.UseVisualStyleBackColor = true;
            // 
            // chkDebugMode
            // 
            this.chkDebugMode.AutoSize = true;
            this.chkDebugMode.Location = new System.Drawing.Point(79, 198);
            this.chkDebugMode.Name = "chkDebugMode";
            this.chkDebugMode.Size = new System.Drawing.Size(88, 17);
            this.chkDebugMode.TabIndex = 28;
            this.chkDebugMode.Text = "Debug Mode";
            this.chkDebugMode.UseVisualStyleBackColor = true;
            // 
            // chkTrimFileExtension
            // 
            this.chkTrimFileExtension.AutoSize = true;
            this.chkTrimFileExtension.Checked = true;
            this.chkTrimFileExtension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrimFileExtension.Location = new System.Drawing.Point(80, 122);
            this.chkTrimFileExtension.Name = "chkTrimFileExtension";
            this.chkTrimFileExtension.Size = new System.Drawing.Size(114, 17);
            this.chkTrimFileExtension.TabIndex = 30;
            this.chkTrimFileExtension.Text = "Trim File Extension";
            this.chkTrimFileExtension.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.groupColors.ResumeLayout(false);
            this.groupColors.PerformLayout();
            this.groupDimensions.ResumeLayout(false);
            this.groupDimensions.PerformLayout();
            this.groupLayout.ResumeLayout(false);
            this.groupLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimThreshold)).EndInit();
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
        private System.Windows.Forms.GroupBox groupOutput;
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
        private System.Windows.Forms.GroupBox groupDimensions;
        private System.Windows.Forms.CheckBox chkIsMaxSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlHeight;
        private System.Windows.Forms.ComboBox ddlWidth;
        private System.Windows.Forms.GroupBox groupColors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.CheckBox chkForcePowerOf2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddlScaleMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlScale;
        private System.Windows.Forms.CheckBox chkForceSquare;
        private System.Windows.Forms.GroupBox groupLayout;
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
    }
}

