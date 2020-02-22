using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataService service = new DataService();
            if (service.ValidLogin(txtUserName.Text))
            {
                this.Hide();
                Form mainForm = new Main();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid Username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
