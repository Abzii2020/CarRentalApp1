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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public ManageVehicleListing()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
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

        private void addCar_btn_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();

        }

        private void editCar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtain id for row to be edited 
                //Cast to integer
                var Id = (int)vehicleList_gv.SelectedRows[0].Cells["id"].Value;

                //Query database for records
                var car = carRentalEntities.TypeOfCars.FirstOrDefault(q => q.id == Id);

                //Launch window to edit data retrieved 
                var addEditVehicle = new AddEditVehicle(car,this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            


        }

        private void deleteCar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = (int)vehicleList_gv.SelectedRows[0].Cells["id"].Value;

                var car = carRentalEntities.TypeOfCars.FirstOrDefault(q => q.id == Id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want to Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if(dr == DialogResult.Yes)
                {
                    //Delete vehicle from table
                    carRentalEntities.TypeOfCars.Remove(car);
                    carRentalEntities.SaveChanges();

                    PopulateGrid();
                }
                

                //vehicleList_gv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }


        public void PopulateGrid()
        {
            var cars = carRentalEntities.TypeOfCars.Select(q => new
            {
                Make = q.Make,
                Model = q.Model,
                VIN = q.VIN,
                Year = q.Year,
                LicencePlate = q.LicensePlateNumber,
                q.id,
            }).ToList();
            vehicleList_gv.DataSource = cars;
            vehicleList_gv.Columns[4].HeaderText = "License";
            vehicleList_gv.Columns["id"].Visible = false;

        }
    }
}
