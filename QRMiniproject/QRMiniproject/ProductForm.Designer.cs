﻿namespace QRMiniproject
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductSprtContainer1 = new System.Windows.Forms.SplitContainer();
            this.PrdGridBox = new MetroFramework.Controls.MetroGrid();
            this.pIdxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qR_ProjectDBDataSet = new QRMiniproject.QR_ProjectDBDataSet();
            this.ProductSprtContainer2 = new System.Windows.Forms.SplitContainer();
            this.PrdpictureBox = new System.Windows.Forms.PictureBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblUnit = new MetroFramework.Controls.MetroLabel();
            this.lblStandard = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.TxtpdtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtpdtUnit = new MetroFramework.Controls.MetroTextBox();
            this.TxtpdtStandard = new MetroFramework.Controls.MetroTextBox();
            this.TxtpdtName = new MetroFramework.Controls.MetroTextBox();
            this.TxtpdtID = new MetroFramework.Controls.MetroTextBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.productTblTableAdapter = new QRMiniproject.QR_ProjectDBDataSetTableAdapters.ProductTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSprtContainer1)).BeginInit();
            this.ProductSprtContainer1.Panel1.SuspendLayout();
            this.ProductSprtContainer1.Panel2.SuspendLayout();
            this.ProductSprtContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrdGridBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qR_ProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSprtContainer2)).BeginInit();
            this.ProductSprtContainer2.Panel1.SuspendLayout();
            this.ProductSprtContainer2.Panel2.SuspendLayout();
            this.ProductSprtContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrdpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductSprtContainer1
            // 
            this.ProductSprtContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductSprtContainer1.Location = new System.Drawing.Point(0, 0);
            this.ProductSprtContainer1.Name = "ProductSprtContainer1";
            // 
            // ProductSprtContainer1.Panel1
            // 
            this.ProductSprtContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.ProductSprtContainer1.Panel1.Controls.Add(this.PrdGridBox);
            // 
            // ProductSprtContainer1.Panel2
            // 
            this.ProductSprtContainer1.Panel2.Controls.Add(this.ProductSprtContainer2);
            this.ProductSprtContainer1.Size = new System.Drawing.Size(1071, 626);
            this.ProductSprtContainer1.SplitterDistance = 735;
            this.ProductSprtContainer1.TabIndex = 0;
            // 
            // PrdGridBox
            // 
            this.PrdGridBox.AllowUserToAddRows = false;
            this.PrdGridBox.AllowUserToDeleteRows = false;
            this.PrdGridBox.AllowUserToResizeRows = false;
            this.PrdGridBox.AutoGenerateColumns = false;
            this.PrdGridBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrdGridBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrdGridBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PrdGridBox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrdGridBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PrdGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrdGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdxDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.standardDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.PrdGridBox.DataSource = this.productTblBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrdGridBox.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrdGridBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrdGridBox.EnableHeadersVisualStyles = false;
            this.PrdGridBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PrdGridBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrdGridBox.Location = new System.Drawing.Point(0, 0);
            this.PrdGridBox.MultiSelect = false;
            this.PrdGridBox.Name = "PrdGridBox";
            this.PrdGridBox.ReadOnly = true;
            this.PrdGridBox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrdGridBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PrdGridBox.RowHeadersWidth = 50;
            this.PrdGridBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PrdGridBox.RowTemplate.Height = 27;
            this.PrdGridBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrdGridBox.Size = new System.Drawing.Size(735, 626);
            this.PrdGridBox.TabIndex = 0;
            this.PrdGridBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrdGridBox_CellClick);
            // 
            // pIdxDataGridViewTextBoxColumn
            // 
            this.pIdxDataGridViewTextBoxColumn.DataPropertyName = "P_Idx";
            this.pIdxDataGridViewTextBoxColumn.HeaderText = "P_Idx";
            this.pIdxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIdxDataGridViewTextBoxColumn.Name = "pIdxDataGridViewTextBoxColumn";
            this.pIdxDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdxDataGridViewTextBoxColumn.Visible = false;
            this.pIdxDataGridViewTextBoxColumn.Width = 61;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "제품코드";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 114;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "제품이름";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 113;
            // 
            // standardDataGridViewTextBoxColumn
            // 
            this.standardDataGridViewTextBoxColumn.DataPropertyName = "Standard";
            this.standardDataGridViewTextBoxColumn.HeaderText = "규격";
            this.standardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.standardDataGridViewTextBoxColumn.Name = "standardDataGridViewTextBoxColumn";
            this.standardDataGridViewTextBoxColumn.ReadOnly = true;
            this.standardDataGridViewTextBoxColumn.Width = 114;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "단위";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 114;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "가격";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 113;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "이미지";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Visible = false;
            this.pictureDataGridViewImageColumn.Width = 114;
            // 
            // productTblBindingSource
            // 
            this.productTblBindingSource.DataMember = "ProductTbl";
            this.productTblBindingSource.DataSource = this.qR_ProjectDBDataSet;
            // 
            // qR_ProjectDBDataSet
            // 
            this.qR_ProjectDBDataSet.DataSetName = "QR_ProjectDBDataSet";
            this.qR_ProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductSprtContainer2
            // 
            this.ProductSprtContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductSprtContainer2.Location = new System.Drawing.Point(0, 0);
            this.ProductSprtContainer2.Name = "ProductSprtContainer2";
            this.ProductSprtContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ProductSprtContainer2.Panel1
            // 
            this.ProductSprtContainer2.Panel1.Controls.Add(this.PrdpictureBox);
            // 
            // ProductSprtContainer2.Panel2
            // 
            this.ProductSprtContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.ProductSprtContainer2.Panel2.Controls.Add(this.lblPrice);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.lblUnit);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.lblStandard);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.lblName);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.lblID);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.TxtpdtPrice);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.TxtpdtUnit);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.TxtpdtStandard);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.TxtpdtName);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.TxtpdtID);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.BtnSave);
            this.ProductSprtContainer2.Panel2.Controls.Add(this.BtnNew);
            this.ProductSprtContainer2.Size = new System.Drawing.Size(332, 626);
            this.ProductSprtContainer2.SplitterDistance = 277;
            this.ProductSprtContainer2.TabIndex = 0;
            // 
            // PrdpictureBox
            // 
            this.PrdpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrdpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrdpictureBox.Location = new System.Drawing.Point(0, 0);
            this.PrdpictureBox.Name = "PrdpictureBox";
            this.PrdpictureBox.Size = new System.Drawing.Size(332, 277);
            this.PrdpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrdpictureBox.TabIndex = 0;
            this.PrdpictureBox.TabStop = false;
            this.PrdpictureBox.Click += new System.EventHandler(this.PrdpictureBox_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(11, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 26);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "가격";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(11, 124);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(81, 26);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "단위";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStandard
            // 
            this.lblStandard.Location = new System.Drawing.Point(11, 90);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(81, 26);
            this.lblStandard.TabIndex = 10;
            this.lblStandard.Text = "규격";
            this.lblStandard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(11, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 26);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "제품이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Gainsboro;
            this.lblID.Location = new System.Drawing.Point(11, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 26);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "제품코드";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtpdtPrice
            // 
            // 
            // 
            // 
            this.TxtpdtPrice.CustomButton.Image = null;
            this.TxtpdtPrice.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.TxtpdtPrice.CustomButton.Name = "";
            this.TxtpdtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtpdtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtpdtPrice.CustomButton.TabIndex = 1;
            this.TxtpdtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtpdtPrice.CustomButton.UseSelectable = true;
            this.TxtpdtPrice.CustomButton.Visible = false;
            this.TxtpdtPrice.Lines = new string[0];
            this.TxtpdtPrice.Location = new System.Drawing.Point(98, 158);
            this.TxtpdtPrice.MaxLength = 32767;
            this.TxtpdtPrice.Name = "TxtpdtPrice";
            this.TxtpdtPrice.PasswordChar = '\0';
            this.TxtpdtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtpdtPrice.SelectedText = "";
            this.TxtpdtPrice.SelectionLength = 0;
            this.TxtpdtPrice.SelectionStart = 0;
            this.TxtpdtPrice.ShortcutsEnabled = true;
            this.TxtpdtPrice.Size = new System.Drawing.Size(197, 26);
            this.TxtpdtPrice.TabIndex = 7;
            this.TxtpdtPrice.UseSelectable = true;
            this.TxtpdtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtpdtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtpdtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtpdtPrice_KeyDown);
            // 
            // TxtpdtUnit
            // 
            // 
            // 
            // 
            this.TxtpdtUnit.CustomButton.Image = null;
            this.TxtpdtUnit.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.TxtpdtUnit.CustomButton.Name = "";
            this.TxtpdtUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtpdtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtpdtUnit.CustomButton.TabIndex = 1;
            this.TxtpdtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtpdtUnit.CustomButton.UseSelectable = true;
            this.TxtpdtUnit.CustomButton.Visible = false;
            this.TxtpdtUnit.Lines = new string[0];
            this.TxtpdtUnit.Location = new System.Drawing.Point(98, 124);
            this.TxtpdtUnit.MaxLength = 32767;
            this.TxtpdtUnit.Name = "TxtpdtUnit";
            this.TxtpdtUnit.PasswordChar = '\0';
            this.TxtpdtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtpdtUnit.SelectedText = "";
            this.TxtpdtUnit.SelectionLength = 0;
            this.TxtpdtUnit.SelectionStart = 0;
            this.TxtpdtUnit.ShortcutsEnabled = true;
            this.TxtpdtUnit.Size = new System.Drawing.Size(197, 26);
            this.TxtpdtUnit.TabIndex = 6;
            this.TxtpdtUnit.UseSelectable = true;
            this.TxtpdtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtpdtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtpdtStandard
            // 
            // 
            // 
            // 
            this.TxtpdtStandard.CustomButton.Image = null;
            this.TxtpdtStandard.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.TxtpdtStandard.CustomButton.Name = "";
            this.TxtpdtStandard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtpdtStandard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtpdtStandard.CustomButton.TabIndex = 1;
            this.TxtpdtStandard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtpdtStandard.CustomButton.UseSelectable = true;
            this.TxtpdtStandard.CustomButton.Visible = false;
            this.TxtpdtStandard.Lines = new string[0];
            this.TxtpdtStandard.Location = new System.Drawing.Point(98, 90);
            this.TxtpdtStandard.MaxLength = 32767;
            this.TxtpdtStandard.Name = "TxtpdtStandard";
            this.TxtpdtStandard.PasswordChar = '\0';
            this.TxtpdtStandard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtpdtStandard.SelectedText = "";
            this.TxtpdtStandard.SelectionLength = 0;
            this.TxtpdtStandard.SelectionStart = 0;
            this.TxtpdtStandard.ShortcutsEnabled = true;
            this.TxtpdtStandard.Size = new System.Drawing.Size(197, 26);
            this.TxtpdtStandard.TabIndex = 5;
            this.TxtpdtStandard.UseSelectable = true;
            this.TxtpdtStandard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtpdtStandard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtpdtName
            // 
            // 
            // 
            // 
            this.TxtpdtName.CustomButton.Image = null;
            this.TxtpdtName.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.TxtpdtName.CustomButton.Name = "";
            this.TxtpdtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtpdtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtpdtName.CustomButton.TabIndex = 1;
            this.TxtpdtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtpdtName.CustomButton.UseSelectable = true;
            this.TxtpdtName.CustomButton.Visible = false;
            this.TxtpdtName.Lines = new string[0];
            this.TxtpdtName.Location = new System.Drawing.Point(98, 56);
            this.TxtpdtName.MaxLength = 32767;
            this.TxtpdtName.Name = "TxtpdtName";
            this.TxtpdtName.PasswordChar = '\0';
            this.TxtpdtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtpdtName.SelectedText = "";
            this.TxtpdtName.SelectionLength = 0;
            this.TxtpdtName.SelectionStart = 0;
            this.TxtpdtName.ShortcutsEnabled = true;
            this.TxtpdtName.Size = new System.Drawing.Size(197, 26);
            this.TxtpdtName.TabIndex = 4;
            this.TxtpdtName.UseSelectable = true;
            this.TxtpdtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtpdtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtpdtID
            // 
            // 
            // 
            // 
            this.TxtpdtID.CustomButton.Image = null;
            this.TxtpdtID.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.TxtpdtID.CustomButton.Name = "";
            this.TxtpdtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtpdtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtpdtID.CustomButton.TabIndex = 1;
            this.TxtpdtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtpdtID.CustomButton.UseSelectable = true;
            this.TxtpdtID.CustomButton.Visible = false;
            this.TxtpdtID.Lines = new string[0];
            this.TxtpdtID.Location = new System.Drawing.Point(98, 22);
            this.TxtpdtID.MaxLength = 32767;
            this.TxtpdtID.Name = "TxtpdtID";
            this.TxtpdtID.PasswordChar = '\0';
            this.TxtpdtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtpdtID.SelectedText = "";
            this.TxtpdtID.SelectionLength = 0;
            this.TxtpdtID.SelectionStart = 0;
            this.TxtpdtID.ShortcutsEnabled = true;
            this.TxtpdtID.Size = new System.Drawing.Size(197, 26);
            this.TxtpdtID.TabIndex = 3;
            this.TxtpdtID.UseSelectable = true;
            this.TxtpdtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtpdtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(153, 194);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 30);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(20, 194);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(130, 30);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // productTblTableAdapter
            // 
            this.productTblTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 626);
            this.Controls.Add(this.ProductSprtContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ProductSprtContainer1.Panel1.ResumeLayout(false);
            this.ProductSprtContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSprtContainer1)).EndInit();
            this.ProductSprtContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrdGridBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qR_ProjectDBDataSet)).EndInit();
            this.ProductSprtContainer2.Panel1.ResumeLayout(false);
            this.ProductSprtContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSprtContainer2)).EndInit();
            this.ProductSprtContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrdpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ProductSprtContainer1;
        private MetroFramework.Controls.MetroGrid PrdGridBox;
        private System.Windows.Forms.SplitContainer ProductSprtContainer2;
        private QR_ProjectDBDataSet qR_ProjectDBDataSet;
        private System.Windows.Forms.BindingSource productTblBindingSource;
        private QR_ProjectDBDataSetTableAdapters.ProductTblTableAdapter productTblTableAdapter;
        private System.Windows.Forms.PictureBox PrdpictureBox;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtpdtID;
        private MetroFramework.Controls.MetroTextBox TxtpdtPrice;
        private MetroFramework.Controls.MetroTextBox TxtpdtUnit;
        private MetroFramework.Controls.MetroTextBox TxtpdtStandard;
        private MetroFramework.Controls.MetroTextBox TxtpdtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblUnit;
        private MetroFramework.Controls.MetroLabel lblStandard;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblID;
    }
}