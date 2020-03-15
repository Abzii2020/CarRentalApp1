namespace CarRentalApp
{
    partial class ManageUsers
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
            this.deactUser_btn = new System.Windows.Forms.Button();
            this.passwordReset_btn = new System.Windows.Forms.Button();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageUser_gv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // deactUser_btn
            // 
            this.deactUser_btn.Location = new System.Drawing.Point(604, 443);
            this.deactUser_btn.Name = "deactUser_btn";
            this.deactUser_btn.Size = new System.Drawing.Size(190, 60);
            this.deactUser_btn.TabIndex = 15;
            this.deactUser_btn.Text = "Deactivate/Activate User";
            this.deactUser_btn.UseVisualStyleBackColor = true;
            this.deactUser_btn.Click += new System.EventHandler(this.deactUser_btn_Click);
            // 
            // passwordReset_btn
            // 
            this.passwordReset_btn.Location = new System.Drawing.Point(381, 443);
            this.passwordReset_btn.Name = "passwordReset_btn";
            this.passwordReset_btn.Size = new System.Drawing.Size(147, 60);
            this.passwordReset_btn.TabIndex = 14;
            this.passwordReset_btn.Text = "Reset Password";
            this.passwordReset_btn.UseVisualStyleBackColor = true;
            this.passwordReset_btn.Click += new System.EventHandler(this.passwordReset_btn_Click);
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(148, 443);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(147, 60);
            this.addUser_btn.TabIndex = 13;
            this.addUser_btn.Text = "Add New User";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Users";
            // 
            // ManageUser_gv
            // 
            this.ManageUser_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageUser_gv.Location = new System.Drawing.Point(63, 145);
            this.ManageUser_gv.Name = "ManageUser_gv";
            this.ManageUser_gv.RowHeadersWidth = 51;
            this.ManageUser_gv.RowTemplate.Height = 24;
            this.ManageUser_gv.Size = new System.Drawing.Size(783, 262);
            this.ManageUser_gv.TabIndex = 11;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 539);
            this.Controls.Add(this.deactUser_btn);
            this.Controls.Add(this.passwordReset_btn);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageUser_gv);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deactUser_btn;
        private System.Windows.Forms.Button passwordReset_btn;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ManageUser_gv;
    }
}