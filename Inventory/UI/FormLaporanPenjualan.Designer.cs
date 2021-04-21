namespace Inventory
{
    partial class FormLaporanPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanPenjualan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.laporan_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.report_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.item_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtty_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // laporan_dtp
            // 
            this.laporan_dtp.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporan_dtp.Location = new System.Drawing.Point(92, 28);
            this.laporan_dtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.laporan_dtp.Name = "laporan_dtp";
            this.laporan_dtp.Size = new System.Drawing.Size(470, 40);
            this.laporan_dtp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // report_btn
            // 
            this.report_btn.Image = ((System.Drawing.Image)(resources.GetObject("report_btn.Image")));
            this.report_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report_btn.Location = new System.Drawing.Point(583, 28);
            this.report_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(135, 65);
            this.report_btn.TabIndex = 2;
            this.report_btn.Text = "Report";
            this.report_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(746, 28);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(135, 65);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dgvReport
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_dgv,
            this.qtty_dgv,
            this.price_dgv,
            this.total_dgv});
            this.dgvReport.Location = new System.Drawing.Point(18, 146);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReport.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReport.Size = new System.Drawing.Size(863, 539);
            this.dgvReport.TabIndex = 4;
            // 
            // item_dgv
            // 
            this.item_dgv.HeaderText = "Item Name";
            this.item_dgv.MinimumWidth = 6;
            this.item_dgv.Name = "item_dgv";
            this.item_dgv.ReadOnly = true;
            this.item_dgv.Width = 150;
            // 
            // qtty_dgv
            // 
            this.qtty_dgv.HeaderText = "Quantity (pcs)";
            this.qtty_dgv.MinimumWidth = 6;
            this.qtty_dgv.Name = "qtty_dgv";
            this.qtty_dgv.ReadOnly = true;
            this.qtty_dgv.Width = 75;
            // 
            // price_dgv
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.price_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.price_dgv.HeaderText = "Price (pcs)";
            this.price_dgv.MinimumWidth = 6;
            this.price_dgv.Name = "price_dgv";
            this.price_dgv.ReadOnly = true;
            this.price_dgv.Width = 125;
            // 
            // total_dgv
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.total_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.total_dgv.HeaderText = "Total Price";
            this.total_dgv.MinimumWidth = 6;
            this.total_dgv.Name = "total_dgv";
            this.total_dgv.ReadOnly = true;
            this.total_dgv.Width = 180;
            // 
            // FormLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 709);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laporan_dtp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLaporanPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Penjualan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker laporan_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtty_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_dgv;
    }
}