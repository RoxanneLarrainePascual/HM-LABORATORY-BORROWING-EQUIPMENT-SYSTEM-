namespace ProjectBorrowingEquip.Pascual
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.panLogout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblReturns = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panFill = new System.Windows.Forms.Panel();
            this.cbEquipment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuantityReturned = new System.Windows.Forms.ComboBox();
            this.lblQuantityReturned = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogout
            // 
            this.panLogout.BackColor = System.Drawing.Color.Silver;
            this.panLogout.Controls.Add(this.pictureBox1);
            this.panLogout.Controls.Add(this.lblLogout);
            this.panLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panLogout.Location = new System.Drawing.Point(0, 568);
            this.panLogout.Name = "panLogout";
            this.panLogout.Size = new System.Drawing.Size(341, 78);
            this.panLogout.TabIndex = 0;
            this.panLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.panLogout_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblLogout.Location = new System.Drawing.Point(125, 23);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(102, 24);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "LOGOUT";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblStudents.Location = new System.Drawing.Point(110, 443);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(181, 28);
            this.lblStudents.TabIndex = 10;
            this.lblStudents.Text = "STUDENT LIST";
            this.lblStudents.Click += new System.EventHandler(this.lblStudents_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.lblStudents);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.lblEquipment);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblReturns);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblBorrow);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panLogout);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 631);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(47, 430);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(47, 357);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblEquipment.Location = new System.Drawing.Point(110, 367);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(218, 28);
            this.lblEquipment.TabIndex = 8;
            this.lblEquipment.Text = "EQUIPMENT LIST";
            this.lblEquipment.Click += new System.EventHandler(this.lblEquipment_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(47, 289);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // lblReturns
            // 
            this.lblReturns.AutoSize = true;
            this.lblReturns.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblReturns.Location = new System.Drawing.Point(110, 301);
            this.lblReturns.Name = "lblReturns";
            this.lblReturns.Size = new System.Drawing.Size(123, 28);
            this.lblReturns.TabIndex = 6;
            this.lblReturns.Text = "RETURNS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblBorrow
            // 
            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblBorrow.Location = new System.Drawing.Point(110, 234);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(131, 28);
            this.lblBorrow.TabIndex = 4;
            this.lblBorrow.Text = "BORROW ";
            this.lblBorrow.Click += new System.EventHandler(this.lblBorrow_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblDashboard.Location = new System.Drawing.Point(110, 169);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(162, 28);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "DASHBOARD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblTitle.Location = new System.Drawing.Point(377, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 28);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "RETURN EQUIPMENT";
            // 
            // panFill
            // 
            this.panFill.BackColor = System.Drawing.Color.DimGray;
            this.panFill.Controls.Add(this.cbEquipment);
            this.panFill.Controls.Add(this.label1);
            this.panFill.ForeColor = System.Drawing.Color.Silver;
            this.panFill.Location = new System.Drawing.Point(382, 107);
            this.panFill.Name = "panFill";
            this.panFill.Size = new System.Drawing.Size(738, 126);
            this.panFill.TabIndex = 4;
            // 
            // cbEquipment
            // 
            this.cbEquipment.FormattingEnabled = true;
            this.cbEquipment.Location = new System.Drawing.Point(262, 56);
            this.cbEquipment.Name = "cbEquipment";
            this.cbEquipment.Size = new System.Drawing.Size(217, 24);
            this.cbEquipment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment";
            // 
            // cbQuantityReturned
            // 
            this.cbQuantityReturned.FormattingEnabled = true;
            this.cbQuantityReturned.Location = new System.Drawing.Point(294, 19);
            this.cbQuantityReturned.Name = "cbQuantityReturned";
            this.cbQuantityReturned.Size = new System.Drawing.Size(200, 24);
            this.cbQuantityReturned.TabIndex = 5;
            // 
            // lblQuantityReturned
            // 
            this.lblQuantityReturned.AutoSize = true;
            this.lblQuantityReturned.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityReturned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblQuantityReturned.Location = new System.Drawing.Point(48, 18);
            this.lblQuantityReturned.Name = "lblQuantityReturned";
            this.lblQuantityReturned.Size = new System.Drawing.Size(220, 28);
            this.lblQuantityReturned.TabIndex = 4;
            this.lblQuantityReturned.Text = "Quantity Returned";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.dtpReturned);
            this.panel2.Controls.Add(this.lblDateReturned);
            this.panel2.Controls.Add(this.cbCondition);
            this.panel2.Controls.Add(this.lblCondition);
            this.panel2.Controls.Add(this.lblQuantityReturned);
            this.panel2.Controls.Add(this.cbQuantityReturned);
            this.panel2.Location = new System.Drawing.Point(382, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 148);
            this.panel2.TabIndex = 5;
            // 
            // dtpReturned
            // 
            this.dtpReturned.Location = new System.Drawing.Point(291, 107);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(253, 22);
            this.dtpReturned.TabIndex = 9;
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblDateReturned.Location = new System.Drawing.Point(48, 103);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(173, 28);
            this.lblDateReturned.TabIndex = 8;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // cbCondition
            // 
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Location = new System.Drawing.Point(293, 65);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(200, 24);
            this.cbCondition.TabIndex = 7;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.lblCondition.Location = new System.Drawing.Point(48, 61);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(122, 28);
            this.lblCondition.TabIndex = 6;
            this.lblCondition.Text = "Condition";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(467, 479);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(218, 46);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "RETURN";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(174)))));
            this.btnClear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(782, 479);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(218, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1170, 632);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panFill);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panLogout.ResumeLayout(false);
            this.panLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panFill.ResumeLayout(false);
            this.panFill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblReturns;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panFill;
        private System.Windows.Forms.ComboBox cbEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuantityReturned;
        private System.Windows.Forms.Label lblQuantityReturned;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}