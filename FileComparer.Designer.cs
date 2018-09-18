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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFolder1
            // 
            this.btnOpenFolder1.Location = new System.Drawing.Point(8, 6);
            this.btnOpenFolder1.Name = "btnOpenFolder1";
            this.btnOpenFolder1.Size = new System.Drawing.Size(107, 23);
            this.btnOpenFolder1.TabIndex = 0;
            this.btnOpenFolder1.Text = "Open folder 1";
            this.btnOpenFolder1.UseVisualStyleBackColor = true;
            this.btnOpenFolder1.Click += new System.EventHandler(this.btnOpenFolder1_Click);
            // 
            // btnOpenFolder2
            // 
            this.btnOpenFolder2.Location = new System.Drawing.Point(8, 35);
            this.btnOpenFolder2.Name = "btnOpenFolder2";
            this.btnOpenFolder2.Size = new System.Drawing.Size(107, 23);
            this.btnOpenFolder2.TabIndex = 1;
            this.btnOpenFolder2.Text = "Open folder 2";
            this.btnOpenFolder2.UseVisualStyleBackColor = true;
            this.btnOpenFolder2.Click += new System.EventHandler(this.btnOpenFolder2_Click);
            // 
            // txtFolder2
            // 
            this.txtFolder2.Location = new System.Drawing.Point(121, 37);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(1750, 20);
            this.txtFolder2.TabIndex = 2;
            this.txtFolder2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolder2_KeyPress);
            // 
            // txtFolder1
            // 
            this.txtFolder1.Location = new System.Drawing.Point(121, 8);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(1750, 20);
            this.txtFolder1.TabIndex = 3;
            this.txtFolder1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolder1_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1607, 290);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtFile1Modified
            // 
            this.txtFile1Modified.Location = new System.Drawing.Point(55, 410);
            this.txtFile1Modified.Name = "txtFile1Modified";
            this.txtFile1Modified.ReadOnly = true;
            this.txtFile1Modified.Size = new System.Drawing.Size(204, 20);
            this.txtFile1Modified.TabIndex = 7;
            // 
            // txtFile2Modified
            // 
            this.txtFile2Modified.Location = new System.Drawing.Point(1029, 410);
            this.txtFile2Modified.Name = "txtFile2Modified";
            this.txtFile2Modified.ReadOnly = true;
            this.txtFile2Modified.Size = new System.Drawing.Size(191, 20);
            this.txtFile2Modified.TabIndex = 8;
            // 
            // txtFile1Contents
            // 
            this.txtFile1Contents.Location = new System.Drawing.Point(8, 436);
            this.txtFile1Contents.Multiline = true;
            this.txtFile1Contents.Name = "txtFile1Contents";
            this.txtFile1Contents.ReadOnly = true;
            this.txtFile1Contents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile1Contents.Size = new System.Drawing.Size(915, 685);
            this.txtFile1Contents.TabIndex = 9;
            // 
            // txtFile2Contents
            // 
            this.txtFile2Contents.Location = new System.Drawing.Point(982, 436);
            this.txtFile2Contents.Multiline = true;
            this.txtFile2Contents.Name = "txtFile2Contents";
            this.txtFile2Contents.ReadOnly = true;
            this.txtFile2Contents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile2Contents.Size = new System.Drawing.Size(889, 685);
            this.txtFile2Contents.TabIndex = 10;
            // 
            // lblFile1Name
            // 
            this.lblFile1Name.AutoSize = true;
            this.lblFile1Name.Location = new System.Drawing.Point(5, 394);
            this.lblFile1Name.Name = "lblFile1Name";
            this.lblFile1Name.Size = new System.Drawing.Size(35, 13);
            this.lblFile1Name.TabIndex = 4;
            this.lblFile1Name.Text = "label1";
            // 
            // lblFile2Name
            // 
            this.lblFile2Name.AutoSize = true;
            this.lblFile2Name.Location = new System.Drawing.Point(979, 394);
            this.lblFile2Name.Name = "lblFile2Name";
            this.lblFile2Name.Size = new System.Drawing.Size(35, 13);
            this.lblFile2Name.TabIndex = 5;
            this.lblFile2Name.Text = "label2";
            // 
            // txtFile1Created
            // 
            this.txtFile1Created.Location = new System.Drawing.Point(318, 410);
            this.txtFile1Created.Name = "txtFile1Created";
            this.txtFile1Created.ReadOnly = true;
            this.txtFile1Created.Size = new System.Drawing.Size(204, 20);
            this.txtFile1Created.TabIndex = 7;
            // 
            // txtFile2Created
            // 
            this.txtFile2Created.Location = new System.Drawing.Point(1279, 410);
            this.txtFile2Created.Name = "txtFile2Created";
            this.txtFile2Created.ReadOnly = true;
            this.txtFile2Created.Size = new System.Drawing.Size(191, 20);
            this.txtFile2Created.TabIndex = 8;
            // 
            // btnCompareFolders
            // 
            this.btnCompareFolders.Location = new System.Drawing.Point(8, 64);
            this.btnCompareFolders.Name = "btnCompareFolders";
            this.btnCompareFolders.Size = new System.Drawing.Size(393, 23);
            this.btnCompareFolders.TabIndex = 1;
            this.btnCompareFolders.Text = "Compare folders!";
            this.btnCompareFolders.UseVisualStyleBackColor = true;
            this.btnCompareFolders.Click += new System.EventHandler(this.btnCompareFolders_Click);
            // 
            // lblFile1Created
            // 
            this.lblFile1Created.AutoSize = true;
            this.lblFile1Created.Location = new System.Drawing.Point(5, 413);
            this.lblFile1Created.Name = "lblFile1Created";
            this.lblFile1Created.Size = new System.Drawing.Size(44, 13);
            this.lblFile1Created.TabIndex = 4;
            this.lblFile1Created.Text = "Created";
            // 
            // lblFile1Modified
            // 
            this.lblFile1Modified.AutoSize = true;
            this.lblFile1Modified.Location = new System.Drawing.Point(265, 413);
            this.lblFile1Modified.Name = "lblFile1Modified";
            this.lblFile1Modified.Size = new System.Drawing.Size(47, 13);
            this.lblFile1Modified.TabIndex = 4;
            this.lblFile1Modified.Text = "Modified";
            // 
            // lblFile2Created
            // 
            this.lblFile2Created.AutoSize = true;
            this.lblFile2Created.Location = new System.Drawing.Point(979, 413);
            this.lblFile2Created.Name = "lblFile2Created";
            this.lblFile2Created.Size = new System.Drawing.Size(44, 13);
            this.lblFile2Created.TabIndex = 4;
            this.lblFile2Created.Text = "Created";
            // 
            // lblFile2Modified
            // 
            this.lblFile2Modified.AutoSize = true;
            this.lblFile2Modified.Location = new System.Drawing.Point(1226, 413);
            this.lblFile2Modified.Name = "lblFile2Modified";
            this.lblFile2Modified.Size = new System.Drawing.Size(47, 13);
            this.lblFile2Modified.TabIndex = 4;
            this.lblFile2Modified.Text = "Modified";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1639, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 290);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // rdoFilterExcludeExtensions
            // 
            this.rdoFilterExcludeExtensions.AutoSize = true;
            this.rdoFilterExcludeExtensions.Checked = true;
            this.rdoFilterExcludeExtensions.Location = new System.Drawing.Point(1647, 67);
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
            this.rdoFilterOff.AutoSize = true;
            this.rdoFilterOff.Location = new System.Drawing.Point(1800, 67);
            this.rdoFilterOff.Name = "rdoFilterOff";
            this.rdoFilterOff.Size = new System.Drawing.Size(71, 17);
            this.rdoFilterOff.TabIndex = 12;
            this.rdoFilterOff.Text = "Filter = off";
            this.rdoFilterOff.UseVisualStyleBackColor = true;
            this.rdoFilterOff.CheckedChanged += new System.EventHandler(this.rdoFilterOff_CheckedChanged);
            // 
            // btnAddFileType
            // 
            this.btnAddFileType.Location = new System.Drawing.Point(1639, 389);
            this.btnAddFileType.Name = "btnAddFileType";
            this.btnAddFileType.Size = new System.Drawing.Size(45, 23);
            this.btnAddFileType.TabIndex = 13;
            this.btnAddFileType.Text = "+";
            this.btnAddFileType.UseVisualStyleBackColor = true;
            this.btnAddFileType.Click += new System.EventHandler(this.btnAddFileType_Click);
            // 
            // btnRemoveFileType
            // 
            this.btnRemoveFileType.Location = new System.Drawing.Point(1828, 389);
            this.btnRemoveFileType.Name = "btnRemoveFileType";
            this.btnRemoveFileType.Size = new System.Drawing.Size(43, 23);
            this.btnRemoveFileType.TabIndex = 14;
            this.btnRemoveFileType.Text = "-";
            this.btnRemoveFileType.UseVisualStyleBackColor = true;
            this.btnRemoveFileType.Click += new System.EventHandler(this.btnRemoveFileType_Click);
            // 
            // txtAddFileType
            // 
            this.txtAddFileType.Location = new System.Drawing.Point(1690, 391);
            this.txtAddFileType.Name = "txtAddFileType";
            this.txtAddFileType.Size = new System.Drawing.Size(132, 20);
            this.txtAddFileType.TabIndex = 15;
            // 
            // btnNotepadPlusPlus
            // 
            this.btnNotepadPlusPlus.Location = new System.Drawing.Point(528, 408);
            this.btnNotepadPlusPlus.Name = "btnNotepadPlusPlus";
            this.btnNotepadPlusPlus.Size = new System.Drawing.Size(323, 22);
            this.btnNotepadPlusPlus.TabIndex = 16;
            this.btnNotepadPlusPlus.Text = "Compare in Notepad++";
            this.btnNotepadPlusPlus.UseVisualStyleBackColor = true;
            this.btnNotepadPlusPlus.Click += new System.EventHandler(this.btnNotepadPlusPlus_Click);
            // 
            // btnCompareAll
            // 
            this.btnCompareAll.Location = new System.Drawing.Point(857, 389);
            this.btnCompareAll.Name = "btnCompareAll";
            this.btnCompareAll.Size = new System.Drawing.Size(116, 32);
            this.btnCompareAll.TabIndex = 17;
            this.btnCompareAll.Text = "Compare all";
            this.btnCompareAll.UseVisualStyleBackColor = true;
            this.btnCompareAll.Click += new System.EventHandler(this.btnCompareAll_Click);
            // 
            // rdoFilterOnlyTheseExtensions
            // 
            this.rdoFilterOnlyTheseExtensions.AutoSize = true;
            this.rdoFilterOnlyTheseExtensions.Location = new System.Drawing.Point(1485, 67);
            this.rdoFilterOnlyTheseExtensions.Name = "rdoFilterOnlyTheseExtensions";
            this.rdoFilterOnlyTheseExtensions.Size = new System.Drawing.Size(156, 17);
            this.rdoFilterOnlyTheseExtensions.TabIndex = 18;
            this.rdoFilterOnlyTheseExtensions.Text = "Only show these extensions";
            this.rdoFilterOnlyTheseExtensions.UseVisualStyleBackColor = true;
            this.rdoFilterOnlyTheseExtensions.CheckedChanged += new System.EventHandler(this.rdoFilterOnlyTheseExtensions_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(857, 413);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(116, 18);
            this.progressBar1.TabIndex = 19;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(407, 69);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(120, 13);
            this.lblFileCount.TabIndex = 20;
            this.lblFileCount.Text = "Click to compare folders";
            // 
            // txtRegexFilter
            // 
            this.txtRegexFilter.Location = new System.Drawing.Point(1151, 66);
            this.txtRegexFilter.Name = "txtRegexFilter";
            this.txtRegexFilter.Size = new System.Drawing.Size(319, 20);
            this.txtRegexFilter.TabIndex = 21;
            this.txtRegexFilter.TextChanged += new System.EventHandler(this.txtRegexFilter_TextChanged);
            this.txtRegexFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegexFilter_KeyPress);
            this.txtRegexFilter.Leave += new System.EventHandler(this.txtRegexFilter_Leave);
            // 
            // lblRegexFilter
            // 
            this.lblRegexFilter.AutoSize = true;
            this.lblRegexFilter.Location = new System.Drawing.Point(1082, 69);
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
            this.panel1.Location = new System.Drawing.Point(929, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 51);
            this.panel1.TabIndex = 25;
            // 
            // lblModDateFilter
            // 
            this.lblModDateFilter.AutoSize = true;
            this.lblModDateFilter.Location = new System.Drawing.Point(854, 69);
            this.lblModDateFilter.Name = "lblModDateFilter";
            this.lblModDateFilter.Size = new System.Drawing.Size(74, 13);
            this.lblModDateFilter.TabIndex = 26;
            this.lblModDateFilter.Text = "Modified after:";
            // 
            // txtModifiedAfterFilter
            // 
            this.txtModifiedAfterFilter.Location = new System.Drawing.Point(934, 66);
            this.txtModifiedAfterFilter.Name = "txtModifiedAfterFilter";
            this.txtModifiedAfterFilter.Size = new System.Drawing.Size(142, 20);
            this.txtModifiedAfterFilter.TabIndex = 27;
            this.txtModifiedAfterFilter.Enter += new System.EventHandler(this.txtModifiedAfterFilter_Enter);
            this.txtModifiedAfterFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModifiedAfterFilter_KeyPress);
            this.txtModifiedAfterFilter.Leave += new System.EventHandler(this.txtModifiedAfterFilter_Leave);
            // 
            // FileComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 1133);
            this.Controls.Add(this.txtModifiedAfterFilter);
            this.Controls.Add(this.lblModDateFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegexFilter);
            this.Controls.Add(this.txtRegexFilter);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rdoFilterOnlyTheseExtensions);
            this.Controls.Add(this.btnCompareAll);
            this.Controls.Add(this.btnNotepadPlusPlus);
            this.Controls.Add(this.txtAddFileType);
            this.Controls.Add(this.btnRemoveFileType);
            this.Controls.Add(this.btnAddFileType);
            this.Controls.Add(this.rdoFilterOff);
            this.Controls.Add(this.rdoFilterExcludeExtensions);
            this.Controls.Add(this.txtFile2Contents);
            this.Controls.Add(this.txtFile1Contents);
            this.Controls.Add(this.txtFile2Created);
            this.Controls.Add(this.txtFile2Modified);
            this.Controls.Add(this.txtFile1Created);
            this.Controls.Add(this.txtFile1Modified);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblFile2Name);
            this.Controls.Add(this.lblFile2Modified);
            this.Controls.Add(this.lblFile2Created);
            this.Controls.Add(this.lblFile1Modified);
            this.Controls.Add(this.lblFile1Created);
            this.Controls.Add(this.lblFile1Name);
            this.Controls.Add(this.txtFolder1);
            this.Controls.Add(this.txtFolder2);
            this.Controls.Add(this.btnCompareFolders);
            this.Controls.Add(this.btnOpenFolder2);
            this.Controls.Add(this.btnOpenFolder1);
            this.Name = "FileComparer";
            this.Text = "FileComparer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}