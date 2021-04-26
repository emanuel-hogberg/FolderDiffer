namespace FolderDiffer
{
    partial class FileComparer
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
            this.btnOpenFolder1 = new System.Windows.Forms.Button();
            this.btnOpenFolder2 = new System.Windows.Forms.Button();
            this.txtFolder2 = new System.Windows.Forms.TextBox();
            this.txtFolder1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFile1Modified = new System.Windows.Forms.TextBox();
            this.txtFile2Modified = new System.Windows.Forms.TextBox();
            this.txtFile1Contents = new System.Windows.Forms.TextBox();
            this.txtFile2Contents = new System.Windows.Forms.TextBox();
            this.lblFile1Name = new System.Windows.Forms.Label();
            this.lblFile2Name = new System.Windows.Forms.Label();
            this.txtFile1Created = new System.Windows.Forms.TextBox();
            this.txtFile2Created = new System.Windows.Forms.TextBox();
            this.btnCompareFolders = new System.Windows.Forms.Button();
            this.lblFile1Created = new System.Windows.Forms.Label();
            this.lblFile1Modified = new System.Windows.Forms.Label();
            this.lblFile2Created = new System.Windows.Forms.Label();
            this.lblFile2Modified = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.rdoFilterExcludeExtensions = new System.Windows.Forms.RadioButton();
            this.rdoFilterOff = new System.Windows.Forms.RadioButton();
            this.btnAddFileType = new System.Windows.Forms.Button();
            this.btnRemoveFileType = new System.Windows.Forms.Button();
            this.txtAddFileType = new System.Windows.Forms.TextBox();
            this.btnNotepadPlusPlus = new System.Windows.Forms.Button();
            this.btnCompareAll = new System.Windows.Forms.Button();
            this.rdoFilterOnlyTheseExtensions = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.txtRegexFilter = new System.Windows.Forms.TextBox();
            this.lblRegexFilter = new System.Windows.Forms.Label();
            this.rdoCompareAllOn = new System.Windows.Forms.RadioButton();
            this.rdoCompareAllOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModDateFilter = new System.Windows.Forms.Label();
            this.txtModifiedAfterFilter = new System.Windows.Forms.TextBox();
            this.treeDates = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.splitHorizontal = new System.Windows.Forms.SplitContainer();
            this.splitVertical = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitHorizontal)).BeginInit();
            this.splitHorizontal.Panel1.SuspendLayout();
            this.splitHorizontal.Panel2.SuspendLayout();
            this.splitHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitVertical)).BeginInit();
            this.splitVertical.Panel1.SuspendLayout();
            this.splitVertical.Panel2.SuspendLayout();
            this.splitVertical.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFolder1
            // 
            this.btnOpenFolder1.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFolder1.Name = "btnOpenFolder1";
            this.btnOpenFolder1.Size = new System.Drawing.Size(107, 23);
            this.btnOpenFolder1.TabIndex = 0;
            this.btnOpenFolder1.Text = "Open folder 1";
            this.btnOpenFolder1.UseVisualStyleBackColor = true;
            this.btnOpenFolder1.Click += new System.EventHandler(this.btnOpenFolder1_Click);
            // 
            // btnOpenFolder2
            // 
            this.btnOpenFolder2.Location = new System.Drawing.Point(3, 32);
            this.btnOpenFolder2.Name = "btnOpenFolder2";
            this.btnOpenFolder2.Size = new System.Drawing.Size(107, 23);
            this.btnOpenFolder2.TabIndex = 1;
            this.btnOpenFolder2.Text = "Open folder 2";
            this.btnOpenFolder2.UseVisualStyleBackColor = true;
            this.btnOpenFolder2.Click += new System.EventHandler(this.btnOpenFolder2_Click);
            // 
            // txtFolder2
            // 
            this.txtFolder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder2.Location = new System.Drawing.Point(116, 32);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(1129, 20);
            this.txtFolder2.TabIndex = 2;
            this.txtFolder2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolder2_KeyPress);
            // 
            // txtFolder1
            // 
            this.txtFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder1.Location = new System.Drawing.Point(116, 5);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(1129, 20);
            this.txtFolder1.TabIndex = 3;
            this.txtFolder1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolder1_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(955, 377);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtFile1Modified
            // 
            this.txtFile1Modified.Location = new System.Drawing.Point(53, 20);
            this.txtFile1Modified.Name = "txtFile1Modified";
            this.txtFile1Modified.ReadOnly = true;
            this.txtFile1Modified.Size = new System.Drawing.Size(204, 20);
            this.txtFile1Modified.TabIndex = 7;
            // 
            // txtFile2Modified
            // 
            this.txtFile2Modified.Location = new System.Drawing.Point(53, 20);
            this.txtFile2Modified.Name = "txtFile2Modified";
            this.txtFile2Modified.ReadOnly = true;
            this.txtFile2Modified.Size = new System.Drawing.Size(191, 20);
            this.txtFile2Modified.TabIndex = 8;
            // 
            // txtFile1Contents
            // 
            this.txtFile1Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile1Contents.Location = new System.Drawing.Point(3, 113);
            this.txtFile1Contents.Multiline = true;
            this.txtFile1Contents.Name = "txtFile1Contents";
            this.txtFile1Contents.ReadOnly = true;
            this.txtFile1Contents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile1Contents.Size = new System.Drawing.Size(570, 466);
            this.txtFile1Contents.TabIndex = 9;
            // 
            // txtFile2Contents
            // 
            this.txtFile2Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile2Contents.Location = new System.Drawing.Point(0, 0);
            this.txtFile2Contents.Multiline = true;
            this.txtFile2Contents.Name = "txtFile2Contents";
            this.txtFile2Contents.ReadOnly = true;
            this.txtFile2Contents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile2Contents.Size = new System.Drawing.Size(571, 466);
            this.txtFile2Contents.TabIndex = 10;
            // 
            // lblFile1Name
            // 
            this.lblFile1Name.AutoSize = true;
            this.lblFile1Name.Location = new System.Drawing.Point(3, 4);
            this.lblFile1Name.Name = "lblFile1Name";
            this.lblFile1Name.Size = new System.Drawing.Size(35, 13);
            this.lblFile1Name.TabIndex = 4;
            this.lblFile1Name.Text = "label1";
            // 
            // lblFile2Name
            // 
            this.lblFile2Name.AutoSize = true;
            this.lblFile2Name.Location = new System.Drawing.Point(3, 4);
            this.lblFile2Name.Name = "lblFile2Name";
            this.lblFile2Name.Size = new System.Drawing.Size(35, 13);
            this.lblFile2Name.TabIndex = 5;
            this.lblFile2Name.Text = "label2";
            // 
            // txtFile1Created
            // 
            this.txtFile1Created.Location = new System.Drawing.Point(316, 20);
            this.txtFile1Created.Name = "txtFile1Created";
            this.txtFile1Created.ReadOnly = true;
            this.txtFile1Created.Size = new System.Drawing.Size(204, 20);
            this.txtFile1Created.TabIndex = 7;
            // 
            // txtFile2Created
            // 
            this.txtFile2Created.Location = new System.Drawing.Point(303, 20);
            this.txtFile2Created.Name = "txtFile2Created";
            this.txtFile2Created.ReadOnly = true;
            this.txtFile2Created.Size = new System.Drawing.Size(191, 20);
            this.txtFile2Created.TabIndex = 8;
            // 
            // btnCompareFolders
            // 
            this.btnCompareFolders.Location = new System.Drawing.Point(3, 6);
            this.btnCompareFolders.Name = "btnCompareFolders";
            this.btnCompareFolders.Size = new System.Drawing.Size(213, 23);
            this.btnCompareFolders.TabIndex = 1;
            this.btnCompareFolders.Text = "Compare folders!";
            this.btnCompareFolders.UseVisualStyleBackColor = true;
            this.btnCompareFolders.Click += new System.EventHandler(this.btnCompareFolders_Click);
            // 
            // lblFile1Created
            // 
            this.lblFile1Created.AutoSize = true;
            this.lblFile1Created.Location = new System.Drawing.Point(3, 23);
            this.lblFile1Created.Name = "lblFile1Created";
            this.lblFile1Created.Size = new System.Drawing.Size(44, 13);
            this.lblFile1Created.TabIndex = 4;
            this.lblFile1Created.Text = "Created";
            // 
            // lblFile1Modified
            // 
            this.lblFile1Modified.AutoSize = true;
            this.lblFile1Modified.Location = new System.Drawing.Point(263, 23);
            this.lblFile1Modified.Name = "lblFile1Modified";
            this.lblFile1Modified.Size = new System.Drawing.Size(47, 13);
            this.lblFile1Modified.TabIndex = 4;
            this.lblFile1Modified.Text = "Modified";
            // 
            // lblFile2Created
            // 
            this.lblFile2Created.AutoSize = true;
            this.lblFile2Created.Location = new System.Drawing.Point(3, 23);
            this.lblFile2Created.Name = "lblFile2Created";
            this.lblFile2Created.Size = new System.Drawing.Size(44, 13);
            this.lblFile2Created.TabIndex = 4;
            this.lblFile2Created.Text = "Created";
            // 
            // lblFile2Modified
            // 
            this.lblFile2Modified.AutoSize = true;
            this.lblFile2Modified.Location = new System.Drawing.Point(250, 23);
            this.lblFile2Modified.Name = "lblFile2Modified";
            this.lblFile2Modified.Size = new System.Drawing.Size(47, 13);
            this.lblFile2Modified.TabIndex = 4;
            this.lblFile2Modified.Text = "Modified";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(150, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(141, 321);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // rdoFilterExcludeExtensions
            // 
            this.rdoFilterExcludeExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoFilterExcludeExtensions.AutoSize = true;
            this.rdoFilterExcludeExtensions.Checked = true;
            this.rdoFilterExcludeExtensions.Location = new System.Drawing.Point(586, 4);
            this.rdoFilterExcludeExtensions.Name = "rdoFilterExcludeExtensions";
            this.rdoFilterExcludeExtensions.Size = new System.Drawing.Size(147, 17);
            this.rdoFilterExcludeExtensions.TabIndex = 11;
            this.rdoFilterExcludeExtensions.TabStop = true;
            this.rdoFilterExcludeExtensions.Text = "Filter out these extensions";
            this.rdoFilterExcludeExtensions.UseVisualStyleBackColor = true;
            this.rdoFilterExcludeExtensions.CheckedChanged += new System.EventHandler(this.rdoFilterOn_CheckedChanged);
            // 
            // rdoFilterOff
            // 
            this.rdoFilterOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoFilterOff.AutoSize = true;
            this.rdoFilterOff.Location = new System.Drawing.Point(739, 4);
            this.rdoFilterOff.Name = "rdoFilterOff";
            this.rdoFilterOff.Size = new System.Drawing.Size(71, 17);
            this.rdoFilterOff.TabIndex = 12;
            this.rdoFilterOff.Text = "Filter = off";
            this.rdoFilterOff.UseVisualStyleBackColor = true;
            this.rdoFilterOff.CheckedChanged += new System.EventHandler(this.rdoFilterOff_CheckedChanged);
            // 
            // btnAddFileType
            // 
            this.btnAddFileType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddFileType.Location = new System.Drawing.Point(0, 0);
            this.btnAddFileType.Name = "btnAddFileType";
            this.btnAddFileType.Size = new System.Drawing.Size(36, 44);
            this.btnAddFileType.TabIndex = 13;
            this.btnAddFileType.Text = "+";
            this.btnAddFileType.UseVisualStyleBackColor = true;
            this.btnAddFileType.Click += new System.EventHandler(this.btnAddFileType_Click);
            // 
            // btnRemoveFileType
            // 
            this.btnRemoveFileType.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveFileType.Location = new System.Drawing.Point(110, 0);
            this.btnRemoveFileType.Name = "btnRemoveFileType";
            this.btnRemoveFileType.Size = new System.Drawing.Size(31, 44);
            this.btnRemoveFileType.TabIndex = 14;
            this.btnRemoveFileType.Text = "-";
            this.btnRemoveFileType.UseVisualStyleBackColor = true;
            this.btnRemoveFileType.Click += new System.EventHandler(this.btnRemoveFileType_Click);
            // 
            // txtAddFileType
            // 
            this.txtAddFileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddFileType.Location = new System.Drawing.Point(36, 0);
            this.txtAddFileType.Name = "txtAddFileType";
            this.txtAddFileType.Size = new System.Drawing.Size(74, 20);
            this.txtAddFileType.TabIndex = 15;
            // 
            // btnNotepadPlusPlus
            // 
            this.btnNotepadPlusPlus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotepadPlusPlus.Location = new System.Drawing.Point(0, 0);
            this.btnNotepadPlusPlus.Name = "btnNotepadPlusPlus";
            this.btnNotepadPlusPlus.Size = new System.Drawing.Size(94, 36);
            this.btnNotepadPlusPlus.TabIndex = 16;
            this.btnNotepadPlusPlus.Text = "Compare in Notepad++";
            this.btnNotepadPlusPlus.UseVisualStyleBackColor = true;
            this.btnNotepadPlusPlus.Click += new System.EventHandler(this.btnNotepadPlusPlus_Click);
            // 
            // btnCompareAll
            // 
            this.btnCompareAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompareAll.Location = new System.Drawing.Point(0, 36);
            this.btnCompareAll.Name = "btnCompareAll";
            this.btnCompareAll.Size = new System.Drawing.Size(94, 50);
            this.btnCompareAll.TabIndex = 17;
            this.btnCompareAll.Text = "Compare all";
            this.btnCompareAll.UseVisualStyleBackColor = true;
            this.btnCompareAll.Click += new System.EventHandler(this.btnCompareAll_Click);
            // 
            // rdoFilterOnlyTheseExtensions
            // 
            this.rdoFilterOnlyTheseExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoFilterOnlyTheseExtensions.AutoSize = true;
            this.rdoFilterOnlyTheseExtensions.Location = new System.Drawing.Point(424, 4);
            this.rdoFilterOnlyTheseExtensions.Name = "rdoFilterOnlyTheseExtensions";
            this.rdoFilterOnlyTheseExtensions.Size = new System.Drawing.Size(156, 17);
            this.rdoFilterOnlyTheseExtensions.TabIndex = 18;
            this.rdoFilterOnlyTheseExtensions.Text = "Only show these extensions";
            this.rdoFilterOnlyTheseExtensions.UseVisualStyleBackColor = true;
            this.rdoFilterOnlyTheseExtensions.CheckedChanged += new System.EventHandler(this.rdoFilterOnlyTheseExtensions_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(94, 18);
            this.progressBar1.TabIndex = 19;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(222, 11);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(120, 13);
            this.lblFileCount.TabIndex = 20;
            this.lblFileCount.Text = "Click to compare folders";
            // 
            // txtRegexFilter
            // 
            this.txtRegexFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexFilter.Location = new System.Drawing.Point(72, 3);
            this.txtRegexFilter.Name = "txtRegexFilter";
            this.txtRegexFilter.Size = new System.Drawing.Size(346, 20);
            this.txtRegexFilter.TabIndex = 21;
            this.txtRegexFilter.TextChanged += new System.EventHandler(this.txtRegexFilter_TextChanged);
            this.txtRegexFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegexFilter_KeyPress);
            this.txtRegexFilter.Leave += new System.EventHandler(this.txtRegexFilter_Leave);
            // 
            // lblRegexFilter
            // 
            this.lblRegexFilter.AutoSize = true;
            this.lblRegexFilter.Location = new System.Drawing.Point(3, 6);
            this.lblRegexFilter.Name = "lblRegexFilter";
            this.lblRegexFilter.Size = new System.Drawing.Size(63, 13);
            this.lblRegexFilter.TabIndex = 22;
            this.lblRegexFilter.Text = "Regex filter:";
            // 
            // rdoCompareAllOn
            // 
            this.rdoCompareAllOn.AutoSize = true;
            this.rdoCompareAllOn.Checked = true;
            this.rdoCompareAllOn.Enabled = false;
            this.rdoCompareAllOn.Location = new System.Drawing.Point(5, 3);
            this.rdoCompareAllOn.Name = "rdoCompareAllOn";
            this.rdoCompareAllOn.Size = new System.Drawing.Size(39, 17);
            this.rdoCompareAllOn.TabIndex = 23;
            this.rdoCompareAllOn.TabStop = true;
            this.rdoCompareAllOn.Text = "On";
            this.rdoCompareAllOn.UseVisualStyleBackColor = true;
            this.rdoCompareAllOn.CheckedChanged += new System.EventHandler(this.rdoCompareAllOn_CheckedChanged);
            // 
            // rdoCompareAllOff
            // 
            this.rdoCompareAllOff.AutoSize = true;
            this.rdoCompareAllOff.Enabled = false;
            this.rdoCompareAllOff.Location = new System.Drawing.Point(5, 26);
            this.rdoCompareAllOff.Name = "rdoCompareAllOff";
            this.rdoCompareAllOff.Size = new System.Drawing.Size(39, 17);
            this.rdoCompareAllOff.TabIndex = 24;
            this.rdoCompareAllOff.Text = "Off";
            this.rdoCompareAllOff.UseVisualStyleBackColor = true;
            this.rdoCompareAllOff.CheckedChanged += new System.EventHandler(this.rdoCompareAllOff_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoCompareAllOn);
            this.panel1.Controls.Add(this.rdoCompareAllOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(579, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 466);
            this.panel1.TabIndex = 25;
            // 
            // lblModDateFilter
            // 
            this.lblModDateFilter.AutoSize = true;
            this.lblModDateFilter.Location = new System.Drawing.Point(3, 5);
            this.lblModDateFilter.Name = "lblModDateFilter";
            this.lblModDateFilter.Size = new System.Drawing.Size(74, 13);
            this.lblModDateFilter.TabIndex = 26;
            this.lblModDateFilter.Text = "Modified after:";
            // 
            // txtModifiedAfterFilter
            // 
            this.txtModifiedAfterFilter.Location = new System.Drawing.Point(3, 21);
            this.txtModifiedAfterFilter.Name = "txtModifiedAfterFilter";
            this.txtModifiedAfterFilter.Size = new System.Drawing.Size(138, 20);
            this.txtModifiedAfterFilter.TabIndex = 27;
            this.txtModifiedAfterFilter.Enter += new System.EventHandler(this.txtModifiedAfterFilter_Enter);
            this.txtModifiedAfterFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModifiedAfterFilter_KeyPress);
            this.txtModifiedAfterFilter.Leave += new System.EventHandler(this.txtModifiedAfterFilter_Leave);
            // 
            // treeDates
            // 
            this.treeDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDates.Location = new System.Drawing.Point(3, 53);
            this.treeDates.Name = "treeDates";
            this.treeDates.Size = new System.Drawing.Size(141, 321);
            this.treeDates.TabIndex = 28;
            this.treeDates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDates_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenFolder1);
            this.panel2.Controls.Add(this.btnOpenFolder2);
            this.panel2.Controls.Add(this.txtFolder2);
            this.panel2.Controls.Add(this.txtFolder1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 62);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 36);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCompareFolders);
            this.panel4.Controls.Add(this.lblFileCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 36);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblRegexFilter);
            this.panel5.Controls.Add(this.rdoFilterExcludeExtensions);
            this.panel5.Controls.Add(this.rdoFilterOff);
            this.panel5.Controls.Add(this.rdoFilterOnlyTheseExtensions);
            this.panel5.Controls.Add(this.txtRegexFilter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(437, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 36);
            this.panel5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFile1Contents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.92783F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1253, 582);
            this.tableLayoutPanel1.TabIndex = 32;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtFile1Created);
            this.panel7.Controls.Add(this.lblFile1Name);
            this.panel7.Controls.Add(this.lblFile1Created);
            this.panel7.Controls.Add(this.lblFile1Modified);
            this.panel7.Controls.Add(this.txtFile1Modified);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(570, 104);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCompareAll);
            this.panel8.Controls.Add(this.progressBar1);
            this.panel8.Controls.Add(this.btnNotepadPlusPlus);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(579, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(94, 104);
            this.panel8.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtFile2Contents);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(679, 113);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(571, 466);
            this.panel11.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblFile2Name);
            this.panel12.Controls.Add(this.lblFile2Created);
            this.panel12.Controls.Add(this.lblFile2Modified);
            this.panel12.Controls.Add(this.txtFile2Created);
            this.panel12.Controls.Add(this.txtFile2Modified);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(679, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(571, 104);
            this.panel12.TabIndex = 3;
            // 
            // splitHorizontal
            // 
            this.splitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHorizontal.Location = new System.Drawing.Point(0, 98);
            this.splitHorizontal.Name = "splitHorizontal";
            this.splitHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitHorizontal.Panel1
            // 
            this.splitHorizontal.Panel1.Controls.Add(this.splitVertical);
            // 
            // splitHorizontal.Panel2
            // 
            this.splitHorizontal.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitHorizontal.Size = new System.Drawing.Size(1253, 963);
            this.splitHorizontal.SplitterDistance = 377;
            this.splitHorizontal.TabIndex = 33;
            // 
            // splitVertical
            // 
            this.splitVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitVertical.Location = new System.Drawing.Point(0, 0);
            this.splitVertical.Name = "splitVertical";
            // 
            // splitVertical.Panel1
            // 
            this.splitVertical.Panel1.Controls.Add(this.listBox1);
            // 
            // splitVertical.Panel2
            // 
            this.splitVertical.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitVertical.Size = new System.Drawing.Size(1253, 377);
            this.splitVertical.SplitterDistance = 955;
            this.splitVertical.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.treeDates, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 377);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtModifiedAfterFilter);
            this.panel6.Controls.Add(this.lblModDateFilter);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 44);
            this.panel6.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtAddFileType);
            this.panel9.Controls.Add(this.btnRemoveFileType);
            this.panel9.Controls.Add(this.btnAddFileType);
            this.panel9.Location = new System.Drawing.Point(150, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 44);
            this.panel9.TabIndex = 1;
            // 
            // FileComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 1061);
            this.Controls.Add(this.splitHorizontal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FileComparer";
            this.Text = "FileComparer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.splitHorizontal.Panel1.ResumeLayout(false);
            this.splitHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHorizontal)).EndInit();
            this.splitHorizontal.ResumeLayout(false);
            this.splitVertical.Panel1.ResumeLayout(false);
            this.splitVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitVertical)).EndInit();
            this.splitVertical.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolder1;
        private System.Windows.Forms.Button btnOpenFolder2;
        private System.Windows.Forms.TextBox txtFolder2;
        private System.Windows.Forms.TextBox txtFolder1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtFile1Modified;
        private System.Windows.Forms.TextBox txtFile2Modified;
        private System.Windows.Forms.TextBox txtFile1Contents;
        private System.Windows.Forms.TextBox txtFile2Contents;
        private System.Windows.Forms.Label lblFile1Name;
        private System.Windows.Forms.Label lblFile2Name;
        private System.Windows.Forms.TextBox txtFile1Created;
        private System.Windows.Forms.TextBox txtFile2Created;
        private System.Windows.Forms.Button btnCompareFolders;
        private System.Windows.Forms.Label lblFile1Created;
        private System.Windows.Forms.Label lblFile1Modified;
        private System.Windows.Forms.Label lblFile2Created;
        private System.Windows.Forms.Label lblFile2Modified;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton rdoFilterExcludeExtensions;
        private System.Windows.Forms.RadioButton rdoFilterOff;
        private System.Windows.Forms.Button btnAddFileType;
        private System.Windows.Forms.Button btnRemoveFileType;
        private System.Windows.Forms.TextBox txtAddFileType;
        private System.Windows.Forms.Button btnNotepadPlusPlus;
        private System.Windows.Forms.Button btnCompareAll;
        private System.Windows.Forms.RadioButton rdoFilterOnlyTheseExtensions;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.TextBox txtRegexFilter;
        private System.Windows.Forms.Label lblRegexFilter;
        private System.Windows.Forms.RadioButton rdoCompareAllOn;
        private System.Windows.Forms.RadioButton rdoCompareAllOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblModDateFilter;
        private System.Windows.Forms.TextBox txtModifiedAfterFilter;
        private System.Windows.Forms.TreeView treeDates;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.SplitContainer splitHorizontal;
        private System.Windows.Forms.SplitContainer splitVertical;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
    }
}