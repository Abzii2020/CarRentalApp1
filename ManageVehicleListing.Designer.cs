namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.vehicleList_gv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addCar_btn = new System.Windows.Forms.Button();
            this.editCar_btn = new System.Windows.Forms.Button();
            this.deleteCar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleList_gv
            // 
            this.vehicleList_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleList_gv.Location = new System.Drawing.Point(12, 107);
            this.vehicleList_gv.Name = "vehicleList_gv";
            this.vehicleList_gv.RowHeadersWidth = 51;
            this.vehicleList_gv.RowTemplate.Height = 24;
            this.vehicleList_gv.Size = new System.Drawing.Size(668, 168);
            this.vehicleList_gv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // addCar_btn
            // 
            this.addCar_btn.Location = new System.Drawing.Point(68, 343);
            this.addCar_btn.Name = "addCar_btn";
            this.addCar_btn.Size = new System.Drawing.Size(147, 60);
            this.addCar_btn.TabIndex = 2;
            this.addCar_btn.Text = "Add New Car";
            this.addCar_btn.UseVisualStyleBackColor = true;
            this.addCar_btn.Click += new System.EventHandler(this.addCar_btn_Click);
            // 
            // editCar_btn
            // 
            this.editCar_btn.Location = new System.Drawing.Point(265, 343);
            this.editCar_btn.Name = "editCar_btn";
            this.editCar_btn.Size = new System.Drawing.Size(147, 60);
            this.editCar_btn.TabIndex = 3;
            this.editCar_btn.Text = "Edit Car";
            this.editCar_btn.UseVisualStyleBackColor = true;
            this.editCar_btn.Click += new System.EventHandler(this.editCar_btn_Click);
            // 
            // deleteCar_btn
            // 
            this.deleteCar_btn.Location = new System.Drawing.Point(463, 343);
            this.deleteCar_btn.Name = "deleteCar_btn";
            this.deleteCar_btn.Size = new System.Drawing.Size(147, 60);
            this.deleteCar_btn.TabIndex = 4;
            this.deleteCar_btn.Text = "Delete Car";
            this.deleteCar_btn.UseVisualStyleBackColor = true;
            this.deleteCar_btn.Click += new System.EventHandler(this.deleteCar_btn_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.deleteCar_btn);
            this.Controls.Add(this.editCar_btn);
            this.Controls.Add(this.addCar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleList_gv);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleList_gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCar_btn;
        private System.Windows.Forms.Button editCar_btn;
        private System.Windows.Forms.Button deleteCar_btn;
    }
}