namespace LuckyCatWinFormsApp
{
    partial class OrderDish
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDish = new System.Windows.Forms.ComboBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.lstDishOrdered = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.DishImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dish:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(184, 130);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(223, 34);
            this.txtQty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(47, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity: ";
            // 
            // cmbDish
            // 
            this.cmbDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDish.FormattingEnabled = true;
            this.cmbDish.Location = new System.Drawing.Point(184, 70);
            this.cmbDish.Name = "cmbDish";
            this.cmbDish.Size = new System.Drawing.Size(223, 37);
            this.cmbDish.TabIndex = 3;
            this.cmbDish.SelectedIndexChanged += new System.EventHandler(this.cmbDish_SelectedIndexChanged);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnAddDish.Location = new System.Drawing.Point(160, 193);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(135, 45);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "Add Cart";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // lstDishOrdered
            // 
            this.lstDishOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDishOrdered.FormattingEnabled = true;
            this.lstDishOrdered.ItemHeight = 29;
            this.lstDishOrdered.Location = new System.Drawing.Point(451, 44);
            this.lstDishOrdered.Name = "lstDishOrdered";
            this.lstDishOrdered.Size = new System.Drawing.Size(513, 613);
            this.lstDishOrdered.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnClear.Location = new System.Drawing.Point(42, 607);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 55);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnSubmit.Location = new System.Drawing.Point(221, 607);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 55);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DishImage
            // 
            this.DishImage.Location = new System.Drawing.Point(42, 291);
            this.DishImage.Name = "DishImage";
            this.DishImage.Size = new System.Drawing.Size(363, 294);
            this.DishImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DishImage.TabIndex = 8;
            this.DishImage.TabStop = false;
            // 
            // OrderDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.DishImage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstDishOrdered);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.cmbDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "OrderDish";
            this.Text = "OrderDish";
            this.Load += new System.EventHandler(this.OrderDish_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DishImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.ListBox lstDishOrdered;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox DishImage;
    }
}