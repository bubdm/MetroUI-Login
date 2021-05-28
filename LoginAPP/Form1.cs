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
using System.Runtime.InteropServices;

namespace LoginAPP
{
    public partial class Form1 : MetroSetForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static string username = "admin";
        public static string password = "123";

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
