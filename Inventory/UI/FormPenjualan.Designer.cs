namespace Inventory
{
    partial class FormPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.sell_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.dgvJual = new System.Windows.Forms.DataGridView();
            this.item_cb = new System.Windows.Forms.ComboBox();
            this.item_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtty_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // qtty_txt
            // 
            this.qtty_txt.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtty_txt.Location = new System.Drawing.Point(225, 82);
            this.qtty_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qtty_txt.Name = "qtty_txt";
            this.qtty_txt.Size = new System.Drawing.Size(298, 40);
            this.qtty_txt.TabIndex = 4;
            this.qtty_txt.TextChanged += new System.EventHandler(this.qtty_txt_TextChanged);
            // 
            // price_txt
            // 
            this.price_txt.Enabled = false;
            this.price_txt.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(225, 148);
            this.price_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(298, 40);
            this.price_txt.TabIndex = 5;
            // 
            // sell_btn
            // 
            this.sell_btn.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_btn.Image = ((System.Drawing.Image)(resources.GetObject("sell_btn.Image")));
            this.sell_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sell_btn.Location = new System.Drawing.Point(552, 14);
            this.sell_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sell_btn.Name = "sell_btn";
            this.sell_btn.Size = new System.Drawing.Size(135, 65);
            this.sell_btn.TabIndex = 6;
            this.sell_btn.Text = "Sell";
            this.sell_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sell_btn.UseVisualStyleBackColor = true;
            this.sell_btn.Click += new System.EventHandler(this.sell_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Image = ((System.Drawing.Image)(resources.GetObject("reset_btn.Image")));
            this.reset_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Location = new System.Drawing.Point(552, 123);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(135, 65);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "Reset";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(777, 123);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(135, 65);
            this.close_btn.TabIndex = 8;
            this.close_btn.Text = "Close";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dgvJual
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvJual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_dgv,
            this.tanggal_dgv,
            this.qtty_dgv,
            this.price_dgv});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJual.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJual.Location = new System.Drawing.Point(42, 241);
            this.dgvJual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJual.Name = "dgvJual";
            this.dgvJual.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJual.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJual.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvJual.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvJual.Size = new System.Drawing.Size(870, 446);
            this.dgvJual.TabIndex = 9;
            // 
            // item_cb
            // 
            this.item_cb.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_cb.FormattingEnabled = true;
            this.item_cb.Location = new System.Drawing.Point(225, 14);
            this.item_cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.item_cb.Name = "item_cb";
            this.item_cb.Size = new System.Drawing.Size(298, 41);
            this.item_cb.TabIndex = 10;
            this.item_cb.TextChanged += new System.EventHandler(this.item_cb_TextChanged);
            // 
            // item_dgv
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.item_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.item_dgv.HeaderText = "Item Name";
            this.item_dgv.MinimumWidth = 6;
            this.item_dgv.Name = "item_dgv";
            this.item_dgv.ReadOnly = true;
            this.item_dgv.Width = 150;
            // 
            // tanggal_dgv
            // 
            this.tanggal_dgv.HeaderText = "Purchased Date";
            this.tanggal_dgv.MinimumWidth = 6;
            this.tanggal_dgv.Name = "tanggal_dgv";
            this.tanggal_dgv.ReadOnly = true;
            this.tanggal_dgv.Width = 110;
            // 
            // qtty_dgv
            // 
            this.qtty_dgv.HeaderText = "Quantity (pcs)";
            this.qtty_dgv.MinimumWidth = 6;
            this.qtty_dgv.Name = "qtty_dgv";
            this.qtty_dgv.ReadOnly = true;
            this.qtty_dgv.Width = 90;
            // 
            // price_dgv
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.price_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.price_dgv.HeaderText = "Price (pcs)";
            this.price_dgv.MinimumWidth = 6;
            this.price_dgv.Name = "price_dgv";
            this.price_dgv.ReadOnly = true;
            this.price_dgv.Width = 185;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 709);
            this.Controls.Add(this.item_cb);
            this.Controls.Add(this.dgvJual);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.sell_btn);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.qtty_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtty_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button sell_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dgvJual;
        private System.Windows.Forms.ComboBox item_cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtty_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_dgv;
    }
}