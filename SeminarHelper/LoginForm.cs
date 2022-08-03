using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA;
using OpenQA.Selenium.Chrome;

namespace SeminarHelper
{
    public partial class LoginForm : Form
    {
        private Logger logger;
        public LoginForm(ChromeDriver driver)
        {
            InitializeComponent();
            logger = new Logger(driver);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!logger.Log(textBoxName.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Neplatné údaje. Zkuste to znovu.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
                

            
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginButton_Click(this, null);
            }
        }
    }
}
