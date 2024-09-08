﻿namespace FEBuilderGBA
{
    partial class ImageBGForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.DragTargetPanel = new System.Windows.Forms.Panel();
            this.DetailErrorMessageBox = new FEBuilderGBA.TextBoxEx();
            this.X_REF = new FEBuilderGBA.ListBoxEx();
            this.X_BG_PIC = new FEBuilderGBA.InterpolatedPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Comment = new FEBuilderGBA.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.P0 = new System.Windows.Forms.NumericUpDown();
            this.P4 = new System.Windows.Forms.NumericUpDown();
            this.P8 = new System.Windows.Forms.NumericUpDown();
            this.J_8 = new System.Windows.Forms.Label();
            this.J_4 = new System.Windows.Forms.Label();
            this.J_0 = new System.Windows.Forms.Label();
            this.BlockSize = new FEBuilderGBA.TextBoxEx();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.SelectAddress = new FEBuilderGBA.TextBoxEx();
            this.label22 = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.DragTargetPanel2 = new System.Windows.Forms.Panel();
            this.GraphicsToolButton = new System.Windows.Forms.Button();
            this.DecreaseColorTSAToolButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ReloadListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadCount = new System.Windows.Forms.NumericUpDown();
            this.ReadStartAddress = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AddressListExpandsButton = new System.Windows.Forms.Button();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.AddressList = new FEBuilderGBA.ListBoxEx();
            this.OpenSourceButton = new System.Windows.Forms.Button();
            this.SelectSourceButton = new System.Windows.Forms.Button();
            this.DragTargetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_BG_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8)).BeginInit();
            this.AddressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            this.DragTargetPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadStartAddress)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(150, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragTargetPanel
            // 
            this.DragTargetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragTargetPanel.Controls.Add(this.SelectSourceButton);
            this.DragTargetPanel.Controls.Add(this.OpenSourceButton);
            this.DragTargetPanel.Controls.Add(this.DetailErrorMessageBox);
            this.DragTargetPanel.Controls.Add(this.X_REF);
            this.DragTargetPanel.Controls.Add(this.X_BG_PIC);
            this.DragTargetPanel.Controls.Add(this.label8);
            this.DragTargetPanel.Controls.Add(this.Comment);
            this.DragTargetPanel.Controls.Add(this.label4);
            this.DragTargetPanel.Controls.Add(this.P0);
            this.DragTargetPanel.Controls.Add(this.P4);
            this.DragTargetPanel.Controls.Add(this.P8);
            this.DragTargetPanel.Controls.Add(this.J_8);
            this.DragTargetPanel.Controls.Add(this.J_4);
            this.DragTargetPanel.Controls.Add(this.J_0);
            this.DragTargetPanel.Location = new System.Drawing.Point(183, 51);
            this.DragTargetPanel.Name = "DragTargetPanel";
            this.DragTargetPanel.Size = new System.Drawing.Size(701, 374);
            this.DragTargetPanel.TabIndex = 1;
            // 
            // DetailErrorMessageBox
            // 
            this.DetailErrorMessageBox.ErrorMessage = "";
            this.DetailErrorMessageBox.Location = new System.Drawing.Point(2, 299);
            this.DetailErrorMessageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DetailErrorMessageBox.Multiline = true;
            this.DetailErrorMessageBox.Name = "DetailErrorMessageBox";
            this.DetailErrorMessageBox.Placeholder = "";
            this.DetailErrorMessageBox.ReadOnly = true;
            this.DetailErrorMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DetailErrorMessageBox.Size = new System.Drawing.Size(510, 70);
            this.DetailErrorMessageBox.TabIndex = 204;
            this.DetailErrorMessageBox.Visible = false;
            // 
            // X_REF
            // 
            this.X_REF.FormattingEnabled = true;
            this.X_REF.IntegralHeight = false;
            this.X_REF.Location = new System.Drawing.Point(529, 19);
            this.X_REF.Name = "X_REF";
            this.X_REF.Size = new System.Drawing.Size(172, 349);
            this.X_REF.TabIndex = 197;
            this.X_REF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.X_REF_KeyDown);
            this.X_REF.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.X_REF_MouseDoubleClick);
            // 
            // X_BG_PIC
            // 
            this.X_BG_PIC.Interpolation = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            this.X_BG_PIC.Location = new System.Drawing.Point(260, 5);
            this.X_BG_PIC.Name = "X_BG_PIC";
            this.X_BG_PIC.Size = new System.Drawing.Size(269, 211);
            this.X_BG_PIC.TabIndex = 67;
            this.X_BG_PIC.TabStop = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(529, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 18);
            this.label8.TabIndex = 201;
            this.label8.Text = "参照箇所";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comment
            // 
            this.Comment.ErrorMessage = "";
            this.Comment.Location = new System.Drawing.Point(88, 89);
            this.Comment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Comment.Name = "Comment";
            this.Comment.Placeholder = "";
            this.Comment.Size = new System.Drawing.Size(170, 20);
            this.Comment.TabIndex = 196;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "@COMMENT";
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(2, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 195;
            this.label4.Text = "コメント";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P0
            // 
            this.P0.Hexadecimal = true;
            this.P0.Location = new System.Drawing.Point(165, 7);
            this.P0.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.P0.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.P0.Name = "P0";
            this.P0.Size = new System.Drawing.Size(91, 20);
            this.P0.TabIndex = 0;
            // 
            // P4
            // 
            this.P4.Hexadecimal = true;
            this.P4.Location = new System.Drawing.Point(165, 33);
            this.P4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.P4.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(91, 20);
            this.P4.TabIndex = 1;
            // 
            // P8
            // 
            this.P8.Hexadecimal = true;
            this.P8.Location = new System.Drawing.Point(165, 60);
            this.P8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.P8.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.P8.Name = "P8";
            this.P8.Size = new System.Drawing.Size(91, 20);
            this.P8.TabIndex = 2;
            // 
            // J_8
            // 
            this.J_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J_8.Location = new System.Drawing.Point(2, 60);
            this.J_8.Name = "J_8";
            this.J_8.Size = new System.Drawing.Size(161, 21);
            this.J_8.TabIndex = 70;
            this.J_8.Text = "パレット";
            this.J_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J_4
            // 
            this.J_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J_4.Location = new System.Drawing.Point(2, 33);
            this.J_4.Name = "J_4";
            this.J_4.Size = new System.Drawing.Size(161, 21);
            this.J_4.TabIndex = 69;
            this.J_4.Text = "ヘッダ付きTSA";
            this.J_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J_0
            // 
            this.J_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J_0.Location = new System.Drawing.Point(2, 7);
            this.J_0.Name = "J_0";
            this.J_0.Size = new System.Drawing.Size(161, 21);
            this.J_0.TabIndex = 68;
            this.J_0.Text = "画像";
            this.J_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockSize
            // 
            this.BlockSize.ErrorMessage = "";
            this.BlockSize.Location = new System.Drawing.Point(199, -1);
            this.BlockSize.Name = "BlockSize";
            this.BlockSize.Placeholder = "";
            this.BlockSize.ReadOnly = true;
            this.BlockSize.Size = new System.Drawing.Size(55, 20);
            this.BlockSize.TabIndex = 52;
            // 
            // AddressPanel
            // 
            this.AddressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressPanel.Controls.Add(this.BlockSize);
            this.AddressPanel.Controls.Add(this.label3);
            this.AddressPanel.Controls.Add(this.SelectAddress);
            this.AddressPanel.Controls.Add(this.label22);
            this.AddressPanel.Controls.Add(this.WriteButton);
            this.AddressPanel.Controls.Add(this.Address);
            this.AddressPanel.Controls.Add(this.label23);
            this.AddressPanel.Location = new System.Drawing.Point(183, 31);
            this.AddressPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(701, 21);
            this.AddressPanel.TabIndex = 70;
            // 
            // SelectAddress
            // 
            this.SelectAddress.ErrorMessage = "";
            this.SelectAddress.Location = new System.Drawing.Point(340, -1);
            this.SelectAddress.Name = "SelectAddress";
            this.SelectAddress.Placeholder = "";
            this.SelectAddress.ReadOnly = true;
            this.SelectAddress.Size = new System.Drawing.Size(89, 20);
            this.SelectAddress.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.AccessibleDescription = "@SELECTION_ADDRESS";
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(261, -1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 21);
            this.label22.TabIndex = 39;
            this.label22.Text = "選択アドレス:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(529, -1);
            this.WriteButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(165, 20);
            this.WriteButton.TabIndex = 9;
            this.WriteButton.Text = "書き込み";
            this.WriteButton.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.Hexadecimal = true;
            this.Address.Location = new System.Drawing.Point(59, 3);
            this.Address.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Address.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(83, 20);
            this.Address.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(-1, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 22);
            this.label23.TabIndex = 1;
            this.label23.Text = "アドレス";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragTargetPanel2
            // 
            this.DragTargetPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragTargetPanel2.Controls.Add(this.GraphicsToolButton);
            this.DragTargetPanel2.Controls.Add(this.DecreaseColorTSAToolButton);
            this.DragTargetPanel2.Controls.Add(this.ImportButton);
            this.DragTargetPanel2.Controls.Add(this.ExportButton);
            this.DragTargetPanel2.Location = new System.Drawing.Point(183, 431);
            this.DragTargetPanel2.Name = "DragTargetPanel2";
            this.DragTargetPanel2.Size = new System.Drawing.Size(701, 29);
            this.DragTargetPanel2.TabIndex = 73;
            // 
            // GraphicsToolButton
            // 
            this.GraphicsToolButton.Location = new System.Drawing.Point(529, 6);
            this.GraphicsToolButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GraphicsToolButton.Name = "GraphicsToolButton";
            this.GraphicsToolButton.Size = new System.Drawing.Size(141, 20);
            this.GraphicsToolButton.TabIndex = 204;
            this.GraphicsToolButton.Text = "グラフィックツール";
            this.GraphicsToolButton.UseVisualStyleBackColor = true;
            this.GraphicsToolButton.Click += new System.EventHandler(this.GraphicsToolButton_Click);
            // 
            // DecreaseColorTSAToolButton
            // 
            this.DecreaseColorTSAToolButton.Location = new System.Drawing.Point(387, 6);
            this.DecreaseColorTSAToolButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DecreaseColorTSAToolButton.Name = "DecreaseColorTSAToolButton";
            this.DecreaseColorTSAToolButton.Size = new System.Drawing.Size(137, 20);
            this.DecreaseColorTSAToolButton.TabIndex = 69;
            this.DecreaseColorTSAToolButton.Text = "減色ツール";
            this.DecreaseColorTSAToolButton.UseVisualStyleBackColor = true;
            this.DecreaseColorTSAToolButton.Click += new System.EventHandler(this.DecreaseColorTSAToolButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(19, 6);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(107, 20);
            this.ImportButton.TabIndex = 65;
            this.ImportButton.Text = "画像読込";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(146, 6);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(107, 20);
            this.ExportButton.TabIndex = 64;
            this.ExportButton.Text = "画像取出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ReloadListButton
            // 
            this.ReloadListButton.Location = new System.Drawing.Point(299, -1);
            this.ReloadListButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ReloadListButton.Name = "ReloadListButton";
            this.ReloadListButton.Size = new System.Drawing.Size(71, 21);
            this.ReloadListButton.TabIndex = 25;
            this.ReloadListButton.Text = "再取得";
            this.ReloadListButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "先頭アドレス";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(173, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "読込数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReloadListButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ReadCount);
            this.panel1.Controls.Add(this.ReadStartAddress);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 21);
            this.panel1.TabIndex = 71;
            // 
            // ReadCount
            // 
            this.ReadCount.Location = new System.Drawing.Point(232, 1);
            this.ReadCount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ReadCount.Name = "ReadCount";
            this.ReadCount.Size = new System.Drawing.Size(51, 20);
            this.ReadCount.TabIndex = 28;
            // 
            // ReadStartAddress
            // 
            this.ReadStartAddress.Hexadecimal = true;
            this.ReadStartAddress.Location = new System.Drawing.Point(79, 1);
            this.ReadStartAddress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ReadStartAddress.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.ReadStartAddress.Name = "ReadStartAddress";
            this.ReadStartAddress.Size = new System.Drawing.Size(83, 20);
            this.ReadStartAddress.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.AddressListExpandsButton);
            this.panel6.Controls.Add(this.LabelFilter);
            this.panel6.Controls.Add(this.AddressList);
            this.panel6.Location = new System.Drawing.Point(9, 31);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 429);
            this.panel6.TabIndex = 71;
            // 
            // AddressListExpandsButton
            // 
            this.AddressListExpandsButton.Location = new System.Drawing.Point(0, 405);
            this.AddressListExpandsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressListExpandsButton.Name = "AddressListExpandsButton";
            this.AddressListExpandsButton.Size = new System.Drawing.Size(165, 20);
            this.AddressListExpandsButton.TabIndex = 114;
            this.AddressListExpandsButton.Text = "リストの拡張";
            this.AddressListExpandsButton.UseVisualStyleBackColor = true;
            // 
            // LabelFilter
            // 
            this.LabelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFilter.Location = new System.Drawing.Point(-1, -1);
            this.LabelFilter.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(173, 21);
            this.LabelFilter.TabIndex = 55;
            this.LabelFilter.Text = "名前";
            this.LabelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressList
            // 
            this.AddressList.FormattingEnabled = true;
            this.AddressList.IntegralHeight = false;
            this.AddressList.Location = new System.Drawing.Point(-1, 19);
            this.AddressList.Name = "AddressList";
            this.AddressList.Size = new System.Drawing.Size(173, 383);
            this.AddressList.TabIndex = 0;
            this.AddressList.SelectedIndexChanged += new System.EventHandler(this.AddressList_SelectedIndexChanged);
            // 
            // OpenSourceButton
            // 
            this.OpenSourceButton.Location = new System.Drawing.Point(261, 222);
            this.OpenSourceButton.Name = "OpenSourceButton";
            this.OpenSourceButton.Size = new System.Drawing.Size(126, 22);
            this.OpenSourceButton.TabIndex = 205;
            this.OpenSourceButton.Text = "ソースファイルを開く";
            this.OpenSourceButton.UseVisualStyleBackColor = true;
            this.OpenSourceButton.Click += new System.EventHandler(this.OpenSourceButton_Click);
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Location = new System.Drawing.Point(393, 222);
            this.SelectSourceButton.Name = "SelectSourceButton";
            this.SelectSourceButton.Size = new System.Drawing.Size(130, 22);
            this.SelectSourceButton.TabIndex = 206;
            this.SelectSourceButton.Text = "ソースフォルダーを開く";
            this.SelectSourceButton.UseVisualStyleBackColor = true;
            this.SelectSourceButton.Click += new System.EventHandler(this.SelectSourceButton_Click);
            // 
            // ImageBGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(888, 462);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.DragTargetPanel);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.DragTargetPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "ImageBGForm";
            this.Text = "背景画像";
            this.Load += new System.EventHandler(this.ImageBGForm_Load);
            this.DragTargetPanel.ResumeLayout(false);
            this.DragTargetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_BG_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P8)).EndInit();
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            this.DragTargetPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadStartAddress)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DragTargetPanel;
        private System.Windows.Forms.NumericUpDown P0;
        private System.Windows.Forms.NumericUpDown P4;
        private System.Windows.Forms.NumericUpDown P8;
        private System.Windows.Forms.Label J_8;
        private System.Windows.Forms.Label J_4;
        private System.Windows.Forms.Label J_0;
        private FEBuilderGBA.TextBoxEx BlockSize;
        private System.Windows.Forms.Panel AddressPanel;
        private FEBuilderGBA.TextBoxEx SelectAddress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.NumericUpDown Address;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel DragTargetPanel2;
        private System.Windows.Forms.Button ReloadListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ReadCount;
        private System.Windows.Forms.NumericUpDown ReadStartAddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelFilter;
        private ListBoxEx AddressList;
        private System.Windows.Forms.Button AddressListExpandsButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private InterpolatedPictureBox X_BG_PIC;
        private System.Windows.Forms.Button DecreaseColorTSAToolButton;
        private TextBoxEx Comment;
        private System.Windows.Forms.Label label4;
        private ListBoxEx X_REF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GraphicsToolButton;
        private TextBoxEx DetailErrorMessageBox;
        private System.Windows.Forms.Button SelectSourceButton;
        private System.Windows.Forms.Button OpenSourceButton;
    }
}