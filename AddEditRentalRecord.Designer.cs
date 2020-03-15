namespace CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.car_cb = new System.Windows.Forms.ComboBox();
            this.rent_picker = new System.Windows.Forms.DateTimePicker();
            this.return_picker = new System.Windows.Forms.DateTimePicker();
            this.customer_tb = new System.Windows.Forms.TextBox();
            this.cost_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recordId_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(29, 21);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(515, 64);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Add Rental Records";
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(342, 300);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(164, 89);
            this.submit_btn.TabIndex = 1;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Returned";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type of Car";
            // 
            // car_cb
            // 
            this.car_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_cb.FormattingEnabled = true;
            this.car_cb.Location = new System.Drawing.Point(32, 332);
            this.car_cb.Name = "car_cb";
            this.car_cb.Size = new System.Drawing.Size(233, 24);
            this.car_cb.TabIndex = 6;
            // 
            // rent_picker
            // 
            this.rent_picker.Location = new System.Drawing.Point(32, 226);
            this.rent_picker.Name = "rent_picker";
            this.rent_picker.Size = new System.Drawing.Size(248, 22);
            this.rent_picker.TabIndex = 7;
            // 
            // return_picker
            // 
            this.return_picker.Location = new System.Drawing.Point(311, 226);
            this.return_picker.Name = "return_picker";
            this.return_picker.Size = new System.Drawing.Size(260, 22);
            this.return_picker.TabIndex = 8;
            // 
            // customer_tb
            // 
            this.customer_tb.Location = new System.Drawing.Point(32, 143);
            this.customer_tb.Multiline = true;
            this.customer_tb.Name = "customer_tb";
            this.customer_tb.Size = new System.Drawing.Size(248, 22);
            this.customer_tb.TabIndex = 9;
            // 
            // cost_tb
            // 
            this.cost_tb.Location = new System.Drawing.Point(311, 143);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Size = new System.Drawing.Size(233, 22);
            this.cost_tb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // recordId_lbl
            // 
            this.recordId_lbl.AutoSize = true;
            this.recordId_lbl.Location = new System.Drawing.Point(218, 377);
            this.recordId_lbl.Name = "recordId_lbl";
            this.recordId_lbl.Size = new System.Drawing.Size(0, 17);
            this.recordId_lbl.TabIndex = 12;
            this.recordId_lbl.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.recordId_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cost_tb);
            this.Controls.Add(this.customer_tb);
            this.Controls.Add(this.return_picker);
            this.Controls.Add(this.rent_picker);
            this.Controls.Add(this.car_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.title_lbl);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox car_cb;
        private System.Windows.Forms.DateTimePicker rent_picker;
        private System.Windows.Forms.DateTimePicker return_picker;
        private System.Windows.Forms.TextBox customer_tb;
        private System.Windows.Forms.TextBox cost_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recordId_lbl;
    }
}

