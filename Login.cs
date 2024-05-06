using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FITNESS_CLUB
{
    public partial class Login : Form
    {
        private const string CorrectUsername = "raj";
        private const string CorrectPassword = "3738";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Register obj1 = new Register();
            obj1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string enteredUsername = usernameTxt.Text;
            string enteredPassword = passwordTxt.Text;

            if (IsValidUser(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login successful!");
                // You can redirect to another form or perform other actions here
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
               
           
        }
        private bool IsValidUser(string username, string password)
        {
            // Check if the entered username and password match the correct ones
            return username == CorrectUsername && password == CorrectPassword;
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
