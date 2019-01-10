namespace LuckyCatWinFormsApp
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lstDishOrdered = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.cbxDiscount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(53, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(53, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(53, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Price:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(59, 192);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(315, 34);
            this.txtSubtotal.TabIndex = 3;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(59, 386);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(315, 34);
            this.txtTax.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(59, 492);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(315, 34);
            this.txtTotal.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.btnBack.Location = new System.Drawing.Point(59, 614);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 44);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.btnPay.Location = new System.Drawing.Point(230, 614);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(142, 44);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Bill";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lstDishOrdered
            // 
            this.lstDishOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDishOrdered.FormattingEnabled = true;
            this.lstDishOrdered.ItemHeight = 29;
            this.lstDishOrdered.Location = new System.Drawing.Point(453, 40);
            this.lstDishOrdered.Name = "lstDishOrdered";
            this.lstDishOrdered.Size = new System.Drawing.Size(492, 613);
            this.lstDishOrdered.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(56, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(62, 98);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(311, 34);
            this.txtEmpName.TabIndex = 0;
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDiscount.FormattingEnabled = true;
            this.cbxDiscount.Location = new System.Drawing.Point(59, 294);
            this.cbxDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(315, 37);
            this.cbxDiscount.TabIndex = 10;
            this.cbxDiscount.SelectedIndexChanged += new System.EventHandler(this.cbxDiscount_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(56, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount:";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDiscount);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDishOrdered);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListBox lstDishOrdered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.ComboBox cbxDiscount;
        private System.Windows.Forms.Label label5;
    }
}