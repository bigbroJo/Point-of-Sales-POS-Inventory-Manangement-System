
namespace BriteSparx_POS_System
{
    partial class Sale_Reciept
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.g17Wst2024DataSet1 = new BriteSparx_POS_System.G17Wst2024DataSet();
            this.customerTableAdapter1 = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.CUSTOMERTableAdapter();
            this.employeeTableAdapter1 = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.EMPLOYEETableAdapter();
            this.productTableAdapter1 = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.PRODUCTTableAdapter();
            this.salE_ITEMSTableAdapter1 = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.SALE_ITEMSTableAdapter();
            this.saleTableAdapter1 = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.SALETableAdapter();
            this.sales_Receipt_Report = new BriteSparx_POS_System.Sales_Receipt_Report();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1814, 1061);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // g17Wst2024DataSet1
            // 
            this.g17Wst2024DataSet1.DataSetName = "G17Wst2024DataSet";
            this.g17Wst2024DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // salE_ITEMSTableAdapter1
            // 
            this.salE_ITEMSTableAdapter1.ClearBeforeFill = true;
            // 
            // saleTableAdapter1
            // 
            this.saleTableAdapter1.ClearBeforeFill = true;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(12, 50);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(159, 61);
            this.btnPrintReceipt.TabIndex = 1;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // Sale_Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 1061);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Sale_Reciept";
            this.Text = "Sale_Reciept";
            this.Load += new System.EventHandler(this.Sale_Reciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private G17Wst2024DataSet g17Wst2024DataSet1;
        private G17Wst2024DataSetTableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private G17Wst2024DataSetTableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
        private G17Wst2024DataSetTableAdapters.PRODUCTTableAdapter productTableAdapter1;
        private G17Wst2024DataSetTableAdapters.SALE_ITEMSTableAdapter salE_ITEMSTableAdapter1;
        private G17Wst2024DataSetTableAdapters.SALETableAdapter saleTableAdapter1;
        private Sales_Receipt_Report sales_Receipt_Report;
        private System.Windows.Forms.Button btnPrintReceipt;
    }
}