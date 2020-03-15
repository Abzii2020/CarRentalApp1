
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CarRentalApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }


        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            //Convert the user input into a byte array and compute hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Creating new string builder to collect bytes and create string
            StringBuilder sBuilder = new StringBuilder();

            //Loops through each byte of hashed data and format each as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        public static string DefaultHashPassword()
        {
            SHA256 sha = SHA256.Create();

            //Convert the user input into a byte array and compute hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));

            //Creating new string builder to collect bytes and create string
            StringBuilder sBuilder = new StringBuilder();

            //Loops through each byte of hashed data and format each as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}