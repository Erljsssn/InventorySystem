namespace inveentory__system
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
            this.components = new System.ComponentModel.Container();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.textBoxCostPrice = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.textBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCler = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnOnStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelItemName.Location = new System.Drawing.Point(317, 83);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(105, 20);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "Item Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelQuantity.Location = new System.Drawing.Point(317, 124);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(85, 20);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(317, 164);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxItemName.Location = new System.Drawing.Point(428, 83);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(199, 27);
            this.textBoxItemName.TabIndex = 2;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(428, 124);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(199, 27);
            this.numericUpDownQuantity.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(428, 164);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(199, 27);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.Text = "₱";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumnSupplier,
            this.dataGridViewTextBoxColumnCostPrice,
            this.dataGridViewTextBoxColumnSellingPrice,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewInventory.Location = new System.Drawing.Point(244, 427);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1038, 259);
            this.dataGridViewInventory.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumnSupplier
            // 
            this.dataGridViewTextBoxColumnSupplier.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumnSupplier.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnSupplier.Name = "dataGridViewTextBoxColumnSupplier";
            this.dataGridViewTextBoxColumnSupplier.ReadOnly = true;
            this.dataGridViewTextBoxColumnSupplier.Width = 125;
            // 
            // dataGridViewTextBoxColumnCostPrice
            // 
            this.dataGridViewTextBoxColumnCostPrice.HeaderText = "Cost Price";
            this.dataGridViewTextBoxColumnCostPrice.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnCostPrice.Name = "dataGridViewTextBoxColumnCostPrice";
            this.dataGridViewTextBoxColumnCostPrice.ReadOnly = true;
            this.dataGridViewTextBoxColumnCostPrice.Width = 125;
            // 
            // dataGridViewTextBoxColumnSellingPrice
            // 
            this.dataGridViewTextBoxColumnSellingPrice.HeaderText = "Selling Price";
            this.dataGridViewTextBoxColumnSellingPrice.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnSellingPrice.Name = "dataGridViewTextBoxColumnSellingPrice";
            this.dataGridViewTextBoxColumnSellingPrice.ReadOnly = true;
            this.dataGridViewTextBoxColumnSellingPrice.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Added";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(756, 83);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 33);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "💾 Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(0, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(0, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(317, 203);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 20);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxStock.Location = new System.Drawing.Point(428, 203);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(199, 27);
            this.textBoxStock.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(339, 393);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(227, 22);
            this.textBoxSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(266, 392);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search:";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelSupplier.Location = new System.Drawing.Point(317, 243);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(84, 20);
            this.labelSupplier.TabIndex = 9;
            this.labelSupplier.Text = "Supplier:";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxSupplier.Location = new System.Drawing.Point(428, 240);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(199, 27);
            this.textBoxSupplier.TabIndex = 10;
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelCostPrice.Location = new System.Drawing.Point(317, 283);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(104, 20);
            this.labelCostPrice.TabIndex = 11;
            this.labelCostPrice.Text = "Cost Price:";
            // 
            // textBoxCostPrice
            // 
            this.textBoxCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxCostPrice.Location = new System.Drawing.Point(428, 280);
            this.textBoxCostPrice.Name = "textBoxCostPrice";
            this.textBoxCostPrice.Size = new System.Drawing.Size(199, 27);
            this.textBoxCostPrice.TabIndex = 12;
            this.textBoxCostPrice.Text = "₱";
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelSellingPrice.Location = new System.Drawing.Point(300, 323);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(122, 20);
            this.labelSellingPrice.TabIndex = 13;
            this.labelSellingPrice.Text = "Selling Price:";
            // 
            // textBoxSellingPrice
            // 
            this.textBoxSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxSellingPrice.Location = new System.Drawing.Point(428, 320);
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            this.textBoxSellingPrice.Size = new System.Drawing.Size(199, 27);
            this.textBoxSellingPrice.TabIndex = 14;
            this.textBoxSellingPrice.Text = "₱";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1333, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(756, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "🗑️ Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(756, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "✏️ Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonCler
            // 
            this.buttonCler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCler.Location = new System.Drawing.Point(756, 190);
            this.buttonCler.Name = "buttonCler";
            this.buttonCler.Size = new System.Drawing.Size(82, 33);
            this.buttonCler.TabIndex = 23;
            this.buttonCler.Text = "🧹 Clear";
            this.buttonCler.UseVisualStyleBackColor = false;
            this.buttonCler.Click += new System.EventHandler(this.buttonCler_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Location = new System.Drawing.Point(752, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(52, 20);
            this.lblDateTime.TabIndex = 24;
            this.lblDateTime.Text = "TIME";
            this.lblDateTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1038, 702);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(191, 30);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "🔎︎ Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelContent);
            this.panelMenu.Controls.Add(this.btnOutOfStock);
            this.panelMenu.Controls.Add(this.btnOnStock);
            this.panelMenu.Location = new System.Drawing.Point(-1, 44);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 699);
            this.panelMenu.TabIndex = 27;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(177, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 32);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(200, 0);
            this.panelContent.TabIndex = 1;
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Location = new System.Drawing.Point(3, 38);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(177, 23);
            this.btnOutOfStock.TabIndex = 3;
            this.btnOutOfStock.Text = "Out Of Stock";
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            // 
            // btnOnStock
            // 
            this.btnOnStock.Location = new System.Drawing.Point(3, 67);
            this.btnOnStock.Name = "btnOnStock";
            this.btnOnStock.Size = new System.Drawing.Size(177, 23);
            this.btnOnStock.TabIndex = 2;
            this.btnOnStock.Text = "On Stock";
            this.btnOnStock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1327, 744);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.buttonCler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.labelCostPrice);
            this.Controls.Add(this.textBoxCostPrice);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.textBoxSellingPrice);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.MinimumSize = new System.Drawing.Size(200, 0);
            this.Name = "Form1";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnPaidOrders;
        private System.Windows.Forms.Button btnUnpaidOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label labelCostPrice;
        private System.Windows.Forms.TextBox textBoxCostPrice;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.TextBox textBoxSellingPrice;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCler;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnOutOfStock;
        private System.Windows.Forms.Button btnOnStock;
    }
}

