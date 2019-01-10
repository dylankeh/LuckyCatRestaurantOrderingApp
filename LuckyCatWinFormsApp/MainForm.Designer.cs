namespace LuckyCatWinFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOrderDish = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lvTable = new System.Windows.Forms.ListView();
            this.imgTable = new System.Windows.Forms.ImageList(this.components);
            this.btnBeginServer = new System.Windows.Forms.Button();
            this.btnEndServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderDish
            // 
            this.btnOrderDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnOrderDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnOrderDish.Location = new System.Drawing.Point(13, 290);
            this.btnOrderDish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderDish.Name = "btnOrderDish";
            this.btnOrderDish.Size = new System.Drawing.Size(160, 50);
            this.btnOrderDish.TabIndex = 0;
            this.btnOrderDish.Text = "Order Dish";
            this.btnOrderDish.UseVisualStyleBackColor = false;
            this.btnOrderDish.Click += new System.EventHandler(this.btnOrderDish_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.lblEmployee.Location = new System.Drawing.Point(13, 678);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(108, 25);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Welcome ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnCheckOut.Location = new System.Drawing.Point(13, 348);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(160, 50);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnNewUser.Location = new System.Drawing.Point(13, 464);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(160, 50);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnLogOut.Location = new System.Drawing.Point(13, 406);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(160, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lvTable
            // 
            this.lvTable.BackColor = System.Drawing.Color.White;
            this.lvTable.GridLines = true;
            this.lvTable.LargeImageList = this.imgTable;
            this.lvTable.Location = new System.Drawing.Point(184, 22);
            this.lvTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(802, 650);
            this.lvTable.TabIndex = 6;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            // 
            // imgTable
            // 
            this.imgTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTable.ImageStream")));
            this.imgTable.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTable.Images.SetKeyName(0, "table_empty.png");
            this.imgTable.Images.SetKeyName(1, "table_occupy.png");
            // 
            // btnBeginServer
            // 
            this.btnBeginServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnBeginServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnBeginServer.Location = new System.Drawing.Point(13, 174);
            this.btnBeginServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeginServer.Name = "btnBeginServer";
            this.btnBeginServer.Size = new System.Drawing.Size(160, 50);
            this.btnBeginServer.TabIndex = 7;
            this.btnBeginServer.Text = "Begin Server";
            this.btnBeginServer.UseVisualStyleBackColor = false;
            this.btnBeginServer.Click += new System.EventHandler(this.btnBeginServer_Click);
            // 
            // btnEndServer
            // 
            this.btnEndServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(176)))), ((int)(((byte)(172)))));
            this.btnEndServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.btnEndServer.Location = new System.Drawing.Point(13, 232);
            this.btnEndServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndServer.Name = "btnEndServer";
            this.btnEndServer.Size = new System.Drawing.Size(160, 50);
            this.btnEndServer.TabIndex = 8;
            this.btnEndServer.Text = "End Server";
            this.btnEndServer.UseVisualStyleBackColor = false;
            this.btnEndServer.Click += new System.EventHandler(this.btnEndServer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnEndServer);
            this.Controls.Add(this.btnBeginServer);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnOrderDish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDish;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ImageList imgTable;
        private System.Windows.Forms.Button btnBeginServer;
        private System.Windows.Forms.Button btnEndServer;
    }
}