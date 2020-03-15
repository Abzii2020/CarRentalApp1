using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography; //Library use in order to create object of encryp type
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public Login()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = username_tb.Text.Trim();
                var password = password_tb.Text;




                var password_hashed = Utils.HashPassword(password);

                //Checks for first user with credentials entered from form
                var user = carRentalEntities.Users.FirstOrDefault(q => q.username == username && q.password == password_hashed
                    && q.isActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please enter valid credentials");

                }
                else
                {
                    //var role = user.UserRoles.FirstOrDefault();
                    //ar roleShortName = role.Role.shortName;
                    //Create instance of main window form
                    var mainWindow  = new MainWindow(this, user);
                    //Once login clicked and credentials are correct then show main window
                    mainWindow.Show();
                    //then hide the login form
                    Hide();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured..Please Try Again...");
            }


        }
    }
}
