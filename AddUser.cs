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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        private ManageUsers _manageUsers;
        public AddUser( ManageUsers manageUser)
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
            _manageUsers = manageUser;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = carRentalEntities.Roles.ToList();
            role_cb.DataSource = roles;
            role_cb.ValueMember = "id";
            role_cb.DisplayMember = "name";

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = username_tb.Text;
                var roleId = (int)role_cb.SelectedValue;
                var password = Utils.DefaultHashPassword();

                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };

                carRentalEntities.Users.Add(user);
                carRentalEntities.SaveChanges();


                var userid = user.id;

                var userRole = new UserRole
                {
                    roleID = roleId,
                    userID = userid,

                };

                carRentalEntities.UserRoles.Add(userRole);
                carRentalEntities.SaveChanges();

                MessageBox.Show("New User Added Successfully...");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured...");
            }
        }
        
    }
}
