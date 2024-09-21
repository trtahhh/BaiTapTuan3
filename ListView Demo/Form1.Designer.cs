namespace ListView_Demo
{
    partial class lvlDemo
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
            this.lvInfo = new System.Windows.Forms.ListView();
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvInfo
            // 
            this.lvInfo.BackColor = System.Drawing.Color.White;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastName,
            this.firstName,
            this.phone});
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(11, 40);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(235, 285);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 96;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 89;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 89;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(262, 242);
            this.txtPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(117, 20);
            this.txtPN.TabIndex = 1;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(262, 160);
            this.txtFN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(117, 20);
            this.txtFN.TabIndex = 2;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(262, 84);
            this.txtLN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(117, 20);
            this.txtLN.TabIndex = 3;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(284, 274);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(284, 331);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(284, 302);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lvlDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(407, 381);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.lvInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "lvlDemo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lvlDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}

