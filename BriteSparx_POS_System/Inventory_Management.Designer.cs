
namespace BriteSparx_POS_System
{
    partial class Inventory_Management
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
            this.dgvProductManage = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g17Wst2024DataSet = new BriteSparx_POS_System.G17Wst2024DataSet();
            this.pRODUCTTableAdapter = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.PRODUCTTableAdapter();
            this.txtsearchProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewProdArchiveStat = new System.Windows.Forms.TextBox();
            this.txtNewProdReoder = new System.Windows.Forms.TextBox();
            this.txtNewProdDescription = new System.Windows.Forms.TextBox();
            this.txtNewProdAvailStock = new System.Windows.Forms.TextBox();
            this.txtNewProdSalePrice = new System.Windows.Forms.TextBox();
            this.txtNewProdName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProductDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalePrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderReorderThreshold = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderArchiveStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearchProductDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReorderThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArchiveStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductManage
            // 
            this.dgvProductManage.AutoGenerateColumns = false;
            this.dgvProductManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.availableStockDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.reorderThresholdDataGridViewTextBoxColumn,
            this.archiveStatusDataGridViewTextBoxColumn});
            this.dgvProductManage.DataSource = this.pRODUCTBindingSource;
            this.dgvProductManage.Location = new System.Drawing.Point(51, 213);
            this.dgvProductManage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductManage.Name = "dgvProductManage";
            this.dgvProductManage.Size = new System.Drawing.Size(1059, 185);
            this.dgvProductManage.TabIndex = 0;
            this.dgvProductManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductManage_CellContentClick);
            this.dgvProductManage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductManage_RowHeaderMouseClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // availableStockDataGridViewTextBoxColumn
            // 
            this.availableStockDataGridViewTextBoxColumn.DataPropertyName = "available_Stock";
            this.availableStockDataGridViewTextBoxColumn.HeaderText = "available_Stock";
            this.availableStockDataGridViewTextBoxColumn.Name = "availableStockDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // reorderThresholdDataGridViewTextBoxColumn
            // 
            this.reorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "Reorder_Threshold";
            this.reorderThresholdDataGridViewTextBoxColumn.HeaderText = "Reorder_Threshold";
            this.reorderThresholdDataGridViewTextBoxColumn.Name = "reorderThresholdDataGridViewTextBoxColumn";
            // 
            // archiveStatusDataGridViewTextBoxColumn
            // 
            this.archiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Archive_Status";
            this.archiveStatusDataGridViewTextBoxColumn.HeaderText = "Archive_Status";
            this.archiveStatusDataGridViewTextBoxColumn.Name = "archiveStatusDataGridViewTextBoxColumn";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.g17Wst2024DataSet;
            // 
            // g17Wst2024DataSet
            // 
            this.g17Wst2024DataSet.DataSetName = "G17Wst2024DataSet";
            this.g17Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // txtsearchProduct
            // 
            this.txtsearchProduct.Location = new System.Drawing.Point(180, 55);
            this.txtsearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearchProduct.Name = "txtsearchProduct";
            this.txtsearchProduct.Size = new System.Drawing.Size(132, 23);
            this.txtsearchProduct.TabIndex = 1;
            this.txtsearchProduct.TextChanged += new System.EventHandler(this.txtsearchProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNewProdArchiveStat);
            this.groupBox1.Controls.Add(this.txtNewProdReoder);
            this.groupBox1.Controls.Add(this.txtNewProdDescription);
            this.groupBox1.Controls.Add(this.txtNewProdAvailStock);
            this.groupBox1.Controls.Add(this.txtNewProdSalePrice);
            this.groupBox1.Controls.Add(this.txtNewProdName);
            this.groupBox1.Location = new System.Drawing.Point(51, 470);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(991, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product Details:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 231);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 61);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Archive Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reorder Threshold:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sale Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name:";
            // 
            // txtNewProdArchiveStat
            // 
            this.txtNewProdArchiveStat.Location = new System.Drawing.Point(468, 176);
            this.txtNewProdArchiveStat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdArchiveStat.Name = "txtNewProdArchiveStat";
            this.txtNewProdArchiveStat.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdArchiveStat.TabIndex = 5;
            // 
            // txtNewProdReoder
            // 
            this.txtNewProdReoder.Location = new System.Drawing.Point(468, 118);
            this.txtNewProdReoder.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdReoder.Name = "txtNewProdReoder";
            this.txtNewProdReoder.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdReoder.TabIndex = 4;
            this.txtNewProdReoder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewProdReoder_KeyPress);
            // 
            // txtNewProdDescription
            // 
            this.txtNewProdDescription.Location = new System.Drawing.Point(164, 118);
            this.txtNewProdDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdDescription.Name = "txtNewProdDescription";
            this.txtNewProdDescription.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdDescription.TabIndex = 3;
            this.txtNewProdDescription.TextChanged += new System.EventHandler(this.txtNewProdDescription_TextChanged);
            // 
            // txtNewProdAvailStock
            // 
            this.txtNewProdAvailStock.Location = new System.Drawing.Point(164, 176);
            this.txtNewProdAvailStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdAvailStock.Name = "txtNewProdAvailStock";
            this.txtNewProdAvailStock.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdAvailStock.TabIndex = 2;
            this.txtNewProdAvailStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewProdAvailStock_KeyPress);
            // 
            // txtNewProdSalePrice
            // 
            this.txtNewProdSalePrice.Location = new System.Drawing.Point(468, 69);
            this.txtNewProdSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdSalePrice.Name = "txtNewProdSalePrice";
            this.txtNewProdSalePrice.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdSalePrice.TabIndex = 1;
            this.txtNewProdSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewProdSalePrice_KeyPress);
            // 
            // txtNewProdName
            // 
            this.txtNewProdName.Location = new System.Drawing.Point(164, 69);
            this.txtNewProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProdName.Name = "txtNewProdName";
            this.txtNewProdName.Size = new System.Drawing.Size(132, 23);
            this.txtNewProdName.TabIndex = 0;
            this.txtNewProdName.TextChanged += new System.EventHandler(this.txtNewProdName_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(51, 786);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 43);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BriteSparx_POS_System.Properties.Resources.britesparx1;
            this.pictureBox1.Location = new System.Drawing.Point(1237, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderProductName
            // 
            this.errorProviderProductName.ContainerControl = this;
            // 
            // errorProviderProductDescription
            // 
            this.errorProviderProductDescription.ContainerControl = this;
            // 
            // errorProviderSalePrice
            // 
            this.errorProviderSalePrice.ContainerControl = this;
            // 
            // errorProviderReorderThreshold
            // 
            this.errorProviderReorderThreshold.ContainerControl = this;
            // 
            // errorProviderArchiveStatus
            // 
            this.errorProviderArchiveStatus.ContainerControl = this;
            // 
            // txtSearchProductDescription
            // 
            this.txtSearchProductDescription.Location = new System.Drawing.Point(180, 104);
            this.txtSearchProductDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProductDescription.Name = "txtSearchProductDescription";
            this.txtSearchProductDescription.Size = new System.Drawing.Size(132, 23);
            this.txtSearchProductDescription.TabIndex = 7;
            this.txtSearchProductDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Product Description:";
            // 
            // Inventory_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1778, 862);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchProductDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearchProduct);
            this.Controls.Add(this.dgvProductManage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory_Management";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReorderThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArchiveStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductManage;
        private G17Wst2024DataSet g17Wst2024DataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private G17Wst2024DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderThresholdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewProdArchiveStat;
        private System.Windows.Forms.TextBox txtNewProdReoder;
        private System.Windows.Forms.TextBox txtNewProdDescription;
        private System.Windows.Forms.TextBox txtNewProdAvailStock;
        private System.Windows.Forms.TextBox txtNewProdSalePrice;
        private System.Windows.Forms.TextBox txtNewProdName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderProductName;
        private System.Windows.Forms.ErrorProvider errorProviderProductDescription;
        private System.Windows.Forms.ErrorProvider errorProviderSalePrice;
        private System.Windows.Forms.ErrorProvider errorProviderReorderThreshold;
        private System.Windows.Forms.ErrorProvider errorProviderArchiveStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchProductDescription;
    }
}