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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public ManageUsers()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
           

            if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void passwordReset_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtain id for row to be edited 
                //Cast to integer
                var Id = (int)ManageUser_gv.SelectedRows[0].Cells["id"].Value;

                //Query database for records
                var user
                    = carRentalEntities.Users.FirstOrDefault(q => q.id == Id);

                //var genericPassword = "Password@123";

                //Launch window to edit data retrieved 
                var hashedPassword = Utils.DefaultHashPassword();
                user.password = hashedPassword;
                carRentalEntities.SaveChanges();

                MessageBox.Show($"{user.username}'s Password has been reset!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void deactUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtain id for row to be edited 
                //Cast to integer
                var Id = (int)ManageUser_gv.SelectedRows[0].Cells["id"].Value;

                //Query database for records
                var user
                    = carRentalEntities.Users.FirstOrDefault(q => q.id == Id);
                user.isActive = user.isActive == true ? false : true;
                
                carRentalEntities.SaveChanges();

                MessageBox.Show($"{user.username}'s Activation Status has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void PopulateGrid()
        {
            var users = carRentalEntities.Users.Select(q => new
            {
                q.id,
                q.username,
                q.UserRoles.FirstOrDefault().Role.name,
                q.isActive
               
            }).ToList();
            ManageUser_gv.DataSource = users;
            ManageUser_gv.Columns["username"].HeaderText = "Username";
            ManageUser_gv.Columns["name"].HeaderText = "Role Name";
            ManageUser_gv.Columns["isActive"].HeaderText = "Active";
            ManageUser_gv.Columns["id"].Visible = false;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
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
    }
}
