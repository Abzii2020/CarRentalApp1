using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public ManageRentalRecords()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }


       
        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void editRecord_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Obtain id for row to be edited 
                //Cast to integer
                var Id = (int)RecordList_gv.SelectedRows[0].Cells["id"].Value;

                //Query database for records
                var record
                    = carRentalEntities.CarRentalRecords.FirstOrDefault(q => q.ID == Id);

                //Launch window to edit data retrieved 
                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void deleteRecord_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = (int)RecordList_gv.SelectedRows[0].Cells["id"].Value;

                var record = carRentalEntities.TypeOfCars.FirstOrDefault(q => q.id == Id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want to Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete vehicle from table
                    carRentalEntities.TypeOfCars.Remove(record);
                    carRentalEntities.SaveChanges();

                    PopulateGrid();
                }

                //Delete vehicle from table
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {

            try
            {
                PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }



        private void PopulateGrid()
        {
            var records = carRentalEntities.CarRentalRecords.Select(q => new
            {
                Customer = q.Customer_Name,
                Rented = q.DateRented,
                Returned = q.DateReturned,
                Id = q.ID,
                q.Cost,
                car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model
            }).ToList() ;
            RecordList_gv.DataSource = records;
            RecordList_gv.Columns["Returned"].HeaderText = "Return Date";
            RecordList_gv.Columns["Rented"].HeaderText = "Rent Date";
            RecordList_gv.Columns["id"].Visible = false;
        }

    }
}
