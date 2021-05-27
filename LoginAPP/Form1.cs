using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using MetroSet_UI.Design;
using MetroSet_UI;
using MetroFramework;
using MetroFramework.Forms;
namespace LoginAPP
{
    public partial class Form1 : MetroSetForm
    {
        public static string username = "admin";
        public static string password = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text != username || passwordbox.Text != password)
            {
                MessageBox.Show("Incorrect data!");
            }
            else
            {
                MessageBox.Show("Welcome!");
                
                // your code goes here
            }
        }
    }
}
