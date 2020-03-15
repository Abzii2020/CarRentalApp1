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
    public partial class AddEditRentalRecord : Form
    {
        //Declaration of Class
        private bool isEditMode;
        private readonly CarRentalEntities carRentalEntities;


        public AddEditRentalRecord()
        {
            InitializeComponent();
            title_lbl.Text = "Add New Rental Record";
            this.Text = "Add Rental Record";
            isEditMode = false;
            //Instance creation
            carRentalEntities = new CarRentalEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            title_lbl.Text = "Edit New Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please to ensure that you selected a valid record to edit");
            }
            else
            {
                isEditMode = true;
                carRentalEntities = new CarRentalEntities();
                populateFields(recordToEdit);
            }

        }

        private void populateFields(CarRentalRecord recordToEdit)
        {
            //throw new NotImplementedException();

            customer_tb.Text = recordToEdit.Customer_Name;
            rent_picker.Value = (DateTime) recordToEdit.DateRented;
            return_picker.Value = (DateTime)recordToEdit.DateReturned;
            cost_tb.Text = recordToEdit.Cost.ToString();
            recordId_lbl.Text = recordToEdit.ID.ToString();



        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //Validating form
            try
            {
                string customerName = customer_tb.Text;
                var rented = rent_picker.Value;
                var returned = return_picker.Value;
                double cost = Convert.ToDouble(cost_tb.Text);

                var car = car_cb.Text;
                var isValid = true;
                var error = "";

                //Checking if customer did not enter name field 
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(car))
                {
                    isValid = false;
                    error += "Error: Please Enter Missing Information.";

                }
                if (rented > returned)
                {
                    isValid = false;
                    error += "Error: Illegal Date Selection";

                }
                if (isValid)
                {
                    //Object declaration of rentalrecord
                    var rentalRecord = new CarRentalRecord();

                    if (isEditMode)
                    {
                        var id = int.Parse(recordId_lbl.Text);
                        var record = carRentalEntities.CarRentalRecords.FirstOrDefault(q => q.ID == id);
                    } 

                    //Values populated from form details
                    rentalRecord.Customer_Name = customerName;
                    rentalRecord.DateRented = rented;
                    rentalRecord.DateReturned = returned;
                    rentalRecord.Cost = (decimal)cost; //Casting cost which is of double data type to decimal which is type in DB
                    rentalRecord.TypeOfCarID = (int)car_cb.SelectedValue;

                    if (!isEditMode)
                        carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();


                    MessageBox.Show($"Customer: {customerName} \n\r" +
                    $"Rent Date: {rented}\n\r" +
                    $"Return Date: {returned}\n\r" +
                    $"Cost: ${cost}\n\r" +
                    $"Car Type: {car}\n\r" +
                    $"THANK YOU FOR YOUR BUSINESS");

                    Close();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw; // Normally ends program once exception occurs.
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Access type of cars table and provide data back as list (Select * from TypeOfCars)
            var cars = carRentalEntities.TypeOfCars.Select(q => new { Id = q.id, Name = q.Make + " " + q.Model}).ToList();

            car_cb.DisplayMember = "Name";
            //Storing info in DB
            car_cb.ValueMember = "id";
            car_cb.DataSource = cars;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }*/

        //N.B Once object is selected twice a click event is created automatically

    }
}
