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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortName;
    }


        //Launching Window Once Add Rental Tab is Clicked.
        private void addRentalRecordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog();
            //this = class being referred to "addrentalrecords class"
            addRentalRecord.MdiParent = this;
            //launches ford after click
        }

       

        private void manageVehicleListingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Hinders multiple launch of same window
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");
            if (!isOpen)
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
        }
        private void viewArchiveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageVehicleListing"))
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }

                
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes login window as well when main is closing
            _login.Close();

        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }
            var username = _user.username;
            tsilLoginText.Text = $"Logged In As: {username}";
            if (_roleName != "admin")
            {
                manageUserToolStripMenuItem.Visible = false;

            }
        }

        private void manageUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageVehicleListing"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
            

        }
    }
}
