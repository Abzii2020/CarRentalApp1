namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            this.deleteRecord_btn = new System.Windows.Forms.Button();
            this.editRecord_btn = new System.Windows.Forms.Button();
            this.addRecord_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordList_gv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecordList_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteRecord_btn
            // 
            this.deleteRecord_btn.Location = new System.Drawing.Point(517, 362);
            this.deleteRecord_btn.Name = "deleteRecord_btn";
            this.deleteRecord_btn.Size = new System.Drawing.Size(147, 60);
            this.deleteRecord_btn.TabIndex = 9;
            this.deleteRecord_btn.Text = "Delete Record";
            this.deleteRecord_btn.UseVisualStyleBackColor = true;
            this.deleteRecord_btn.Click += new System.EventHandler(this.deleteRecord_btn_Click);
            // 
            // editRecord_btn
            // 
            this.editRecord_btn.Location = new System.Drawing.Point(319, 362);
            this.editRecord_btn.Name = "editRecord_btn";
            this.editRecord_btn.Size = new System.Drawing.Size(147, 60);
            this.editRecord_btn.TabIndex = 8;
            this.editRecord_btn.Text = "Edit Record";
            this.editRecord_btn.UseVisualStyleBackColor = true;
            this.editRecord_btn.Click += new System.EventHandler(this.editRecord_btn_Click);
            // 
            // addRecord_btn
            // 
            this.addRecord_btn.Location = new System.Drawing.Point(122, 362);
            this.addRecord_btn.Name = "addRecord_btn";
            this.addRecord_btn.Size = new System.Drawing.Size(147, 60);
            this.addRecord_btn.TabIndex = 7;
            this.addRecord_btn.Text = "Add New Record";
            this.addRecord_btn.UseVisualStyleBackColor = true;
            this.addRecord_btn.Click += new System.EventHandler(this.addRecord_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 67);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Rental Records ";
            // 
            // RecordList_gv
            // 
            this.RecordList_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordList_gv.Location = new System.Drawing.Point(57, 161);
            this.RecordList_gv.Name = "RecordList_gv";
            this.RecordList_gv.RowHeadersWidth = 51;
            this.RecordList_gv.RowTemplate.Height = 24;
            this.RecordList_gv.Size = new System.Drawing.Size(684, 184);
            this.RecordList_gv.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteRecord_btn);
            this.Controls.Add(this.editRecord_btn);
            this.Controls.Add(this.addRecord_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordList_gv);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordList_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteRecord_btn;
        private System.Windows.Forms.Button editRecord_btn;
        private System.Windows.Forms.Button addRecord_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RecordList_gv;
        private System.Windows.Forms.Button button1;
    }
}