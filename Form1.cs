using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // TODO: initial serverconnect and panel_inf
        Serverconnect server = new Serverconnect();
        string user = "";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login(object sender, EventArgs e)
        {
            if (user.Length == 0)
            {
                // TODO: login form ;
                login_button.Text = "用户登录";
            }
            else
            {
                logout();
            }
        }

        private void logout()
        {
            user = "";
            login_button.Text = "用户登录";
            // do someting else;
        }
    }
}
