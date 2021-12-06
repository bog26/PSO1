using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSO1.Model;

namespace PSO1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void OpenUserWindow(bool userHasAdminRights)
        {
            if (userHasAdminRights)
            {
                this.Hide();

                Form4 f4 = new Form4();
                //f4.Text = "Logged as: " + textBox1.Text;
                f4.Text = textBox1.Text;
                f4.Show();
            }
            else
            {
                this.Hide();
                Form5 f5 = new Form5();
                //f5.Text = "Logged as: "+textBox1.Text;
                f5.Text = textBox1.Text;
                f5.Show();
            }
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if(InternalDBQueries.CheckForExistingUser(textBox1.Text) && InternalDBQueries.CheckForCorrectPassword(textBox1.Text, textBox2.Text))
                {
                    IOMethods.SetUserFile(textBox1.Text);
                    OpenUserWindow(InternalDBQueries.CheckForAdminRights(textBox1.Text));
                }
                else
                {
                    MessageBox.Show("wrong user name or password");
                }
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                var context = new MSSQLConnection();
                if (InternalDBQueries.CheckForExistingUserGen(textBox1.Text, context) && InternalDBQueries.CheckForCorrectPassword(textBox1.Text, textBox2.Text))
                {
                    IOMethods.SetUserFile(textBox1.Text);
                    OpenUserWindow(InternalDBQueries.CheckForAdminRights(textBox1.Text));
                }
                else
                {
                    MessageBox.Show("wrong user name or password");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
