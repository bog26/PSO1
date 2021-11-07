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
    public partial class Form3 : System.Windows.Forms.Form
    {
        private psDBContext psContext;
        public bool ExecutedFromAdminAccount = false;
        public Form3(bool fromAdminAccount)
        {
            InitializeComponent();
            ExecutedFromAdminAccount = fromAdminAccount;
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckFillDataCorrectness())
            {
                MessageBox.Show("input data is correct.");
                
                if(!InternalDBQueries.CheckForExistingUser(textBox1.Text))
                {
                    CreateUser();
                }
                else
                {
                    MessageBox.Show("user already existing");
                }
            }
            else
            {
                MessageBox.Show("input data is wrong");
            }
        }
        public bool CheckFillDataCorrectness()
        {
            bool correctUserData = false;
            int StreetNr;
            int PostalCode;
            if (textBox1.Text != String.Empty
                && textBox2.Text != String.Empty
                && textBox3.Text != String.Empty
                && textBox4.Text != String.Empty
                && textBox5.Text != String.Empty
                && textBox6.Text != String.Empty
                && textBox8.Text != String.Empty
                && textBox10.Text != String.Empty
                && textBox11.Text != String.Empty
                && int.TryParse(textBox6.Text, out StreetNr)
                && int.TryParse(textBox10.Text, out PostalCode))
            {
                correctUserData = true;
            }
            return correctUserData;
        }

        public bool CheckForExistingAdmin()
        {
            bool existingAdmin;
            psContext = new psDBContext();
            var admins = psContext.Admins.ToList();
            if (admins.Count == 0)
            {
                existingAdmin = false;
            }
            else 
            {
                existingAdmin = true;
            }
            MessageBox.Show("existing admins: "+ admins.Count);
            return existingAdmin;
        }
        public void CreateAdmin()
        {
            var newAdmin = new Admin();
            UserPersonalData userPersonalData = GatherUserData();
            UserAddress userAddress = GatherUserAddress();

            newAdmin.UserName = textBox1.Text;
            newAdmin.Password = textBox12.Text;
            newAdmin.UserInfo = userPersonalData;
            newAdmin.UserAddress = userAddress;

            psContext = new psDBContext();
            psContext.Admins.Add(newAdmin);
            psContext.SaveChanges();

            //test:
            MessageBox.Show("Testing new admin data: " + newAdmin.UserInfo.FirstName + " "
                + newAdmin.UserInfo.LastName + " password: "+ newAdmin.Password + "Street: "+ newAdmin.UserAddress.Street);
        }

        public void CreateClient()
        {
            var newClient = new Client();
            UserPersonalData userPersonalData = GatherUserData();
            UserAddress userAddress = GatherUserAddress();
           
            newClient.UserName = textBox1.Text;
            newClient.Password = textBox12.Text;
            newClient.UserInfo = userPersonalData;

            newClient.UserAddress = userAddress;
            newClient.WishList = new WishList(newClient.UserName);
            //newClient.WishList.WishProducts = new List<Product>();
            //WishProducts = new List<Product>();
            //WishList = new WishList(UserName);

            psContext = new psDBContext();
            psContext.Clients.Add(newClient);
            psContext.SaveChanges();

            //test:
            MessageBox.Show("Testing new client data: " + newClient.UserInfo.FirstName + " "
                + newClient.UserInfo.LastName + " password: " + newClient.Password);
        }

        public void CreateUser()
        {
            bool alreadyExistingAdmin = CheckForExistingAdmin();
            if (alreadyExistingAdmin && !ExecutedFromAdminAccount)
            {
                CreateClient();
                MessageBox.Show("Client account succesfully created");
            }
            else
            {
                CreateAdmin();
                MessageBox.Show("Admin account succesfully created");
            }
        }

        public UserPersonalData GatherUserData()
        {

            //var userAddress = GatherUserAddress();

            string userBirthDateStr = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime userBirthDate = Convert.ToDateTime(userBirthDateStr);
            //MessageBox.Show(clientBirthDate.ToShortDateString());  //ok

            var userPersonalData = new UserPersonalData
            {
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                BirthDate = userBirthDate,
                Email = textBox4.Text,
                Telephone = textBox11.Text,
            };
            return userPersonalData;

        }
        public UserAddress GatherUserAddress()
        {
            var userAddress = new UserAddress
            {
                Street = textBox5.Text,
                StreetNr = int.Parse(textBox6.Text),
                City = textBox7.Text,
                Region = textBox8.Text,
                Country = textBox9.Text,
                PostalCode = int.Parse(textBox10.Text)
            };
            return userAddress;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
