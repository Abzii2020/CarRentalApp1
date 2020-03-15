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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
            _user = user;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var password = password_tb.Text;
                var confirmPassword = confirmPassword_tb.Text;
                var user = carRentalEntities.Users.FirstOrDefault(q => q.id == _user.id);
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again!");
                }

                _user.password = Utils.HashPassword(password);
                carRentalEntities.SaveChanges();
                MessageBox.Show("Password was reset Successfully");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error has occured please try again...");
            }
            
        }
    }
}
