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


    public partial class AddEditVehicle : Form
    {
        // private bool isEditMode;
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities carRentalEntities;
        


        public AddEditVehicle( ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            title_lbl.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            carRentalEntities = new CarRentalEntities();
        }

        public AddEditVehicle(TypeOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            title_lbl.Text = "Edit New Vehicle";
            this.Text = "Edit New Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please to ensure that you selected a valid record to edit");
            }
            else
            {
                isEditMode = true;
                carRentalEntities = new CarRentalEntities();
                populateFields(carToEdit);
            }



            /* InitializeComponent();
             title_lbl.Text = "Edit Vehicle";
             isEditMode = true;
             carRentalEntities = new CarRentalEntities();
             PopulateFields(carToEdit);*/

        }

        public void populateFields(TypeOfCar car)
        {
            id_lbl.Text = car.id.ToString();
            make_tb.Text = car.Make;
            model_tb.Text = car.Model;
            vin_tb.Text = car.VIN;
            year_tb.Text = car.Year.ToString();
            license_tb.Text = car.LicensePlateNumber;

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(make_tb.Text) || string.IsNullOrWhiteSpace(model_tb.Text))
                {
                    MessageBox.Show("Please to ensure make and model is provided:");
                }
                else
                {
                    //if true
                    if (isEditMode)
                    {
                        //edit code
                        var id = int.Parse(id_lbl.Text);
                        var car = carRentalEntities.TypeOfCars.FirstOrDefault(q => q.id == id);
                        car.Make = make_tb.Text;
                        car.Model = model_tb.Text;
                        car.VIN = vin_tb.Text;
                        car.Year = int.Parse(year_tb.Text);
                        car.LicensePlateNumber = license_tb.Text;
                        

                    }
                    else
                    {
                        //declaration and initialisation of variable
                        var newCar = new TypeOfCar
                        {
                            LicensePlateNumber = license_tb.Text,
                            Make = make_tb.Text,
                            Model = model_tb.Text,
                            VIN = vin_tb.Text,
                            Year = int.Parse(year_tb.Text)
                        };

                        carRentalEntities.TypeOfCars.Add(newCar);
                        
                    }
                    carRentalEntities.SaveChanges();
                    _manageVehicleListing.PopulateGrid();
                    MessageBox.Show("Operation Completed. Refresh Grid to see Changes");
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

   
