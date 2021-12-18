using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using PSO1.Model;
using static PSO1.Model.InternalDBQueries;
using System.IO;
using static PSO1.Model.UserInputCheck;
using static PSO1.Model.DBUpdates;
using static PSO1.Model.InfoMessagesConstruction;

namespace PSO1
{
    public partial class Form5 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        public Form5()
        {
            InitializeComponent();
            InitializeManualAddedComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = BindCrtUserDataToGrid(crtUser);
            dataGridView6.DataSource = BindCrtUserAddressToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            //MessageBox.Show($"row {selection} clicked"); // selection test ok
            string rawText;
            bool encryption;
            if (textBox1.Text != string.Empty)
            {
                rawText = DBUpdates.GetMessage(crtUser, selection, textBox1.Text);

                if (!DBUpdates.IsMessageEncrypted(crtUser, selection, textBox1.Text))
                {
                    encryption = false;
                }
                else
                {
                    encryption = true;
                }
            }
            else
            {
                rawText = DBUpdates.GetMessage(crtUser, selection);
                if (!DBUpdates.IsMessageEncrypted(crtUser, selection))
                {
                    encryption = false;
                }
                else
                {
                    encryption = true;
                }
            }
            if (!encryption)
            {
                richTextBox1.Text = rawText;
            }
            else
            {
                string key = "abracadabra";
                string decryptedMessage = Encryption.StringDecrypt(rawText, key);
                richTextBox1.Text = decryptedMessage;
            }
            DBUpdates.ReadMsg(crtUser, selection);
            UpdateUnreadMsgNr(crtUser);
            panelInbox1.Show();
        }

       

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {


        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void ShoWUserInformationFormElements()
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button16
            HideShowAllPanels(panelMessage1);
        }
        private void HideUserInformationFormElements()
        {


        }
 
        private void HideShowEmailPanels(Panel panel)
        {
            panelInbox1.Hide();
            panelSent1.Hide();
            panelDeleted1.Hide();
            panelSpam1.Hide();
            panelCompose1.Hide();
            panel.Show();
        }
        private void HideShowAllPanels(Panel panel)
        {
            panelMessage1.Hide();
            panelInbox1.Hide();
            panelSent1.Hide();
            panelDeleted1.Hide();
            panelSpam1.Hide();
            panelCompose1.Hide();
            panelUserInfo.Hide();
            panelProducts.Hide();
            panelWishList.Hide();
            panelShoppingCart.Hide();
            panelTransactions.Hide();
            panelProductSpec.Hide();
            panelFinancialStatus.Hide();
            panelAddCredit.Hide();
            panelUserProductReviews.Hide();
            panel.Show();
        }

        private void button15_Click(object sender, EventArgs e) //Wish list
        {
            listBox3.DataSource = BindWishListProducts(crtUser);
            HideShowAllPanels(panelWishList);
        }

            private void button16_Click(object sender, EventArgs e) //Inbox
        {
            dataGridView1.DataSource = BindInboxMessagesToGridView(crtUser);
            HideShowEmailPanels(panelInbox1);
        }
        private void button17_Click(object sender, EventArgs e) //Sent
        {
            dataGridView2.DataSource = BindSentMessagesToGridView(crtUser);
            HideShowEmailPanels(panelSent1);
        }

        private void button18_Click(object sender, EventArgs e) //Deleted
        {
            dataGridView3.DataSource = BindDeletedMessagesToGridView(crtUser);
            HideShowEmailPanels(panelDeleted1);
        }
        private void button19_Click(object sender, EventArgs e) //spam
        {
            dataGridView4.DataSource = BindSpamMessagesToGridView(crtUser);
            HideShowEmailPanels(panelSpam1);
        }
        private void button20_Click(object sender, EventArgs e) //compose
        {
            HideShowEmailPanels(panelCompose1);
        }

        private void button21_Click(object sender, EventArgs e) //Delete
        {
            int selection = dataGridView1.CurrentCell.RowIndex;
            DBUpdates.DeleteReceiverMsg(crtUser, selection);
            dataGridView1.DataSource = BindInboxMessagesToGridView(crtUser);
            HideShowEmailPanels(panelInbox1);

        }

        private void button22_Click(object sender, EventArgs e) //Spam
        {
            int selection = dataGridView1.CurrentCell.RowIndex;
            DBUpdates.SpamMsg(crtUser, selection);
            dataGridView1.DataSource = BindInboxMessagesToGridView(crtUser);
            HideShowEmailPanels(panelInbox1);
        }
        private void button23_Click(object sender, EventArgs e) //"Reply"
        {
            string[] messageFields = MessageReplyFieldsInit();

            string receiver;
            string title;
            string message;

            FillReplyMessage(messageFields, out receiver, out title, out message);
            textBox2.Text = receiver;
            textBox3.Text = title;
            richTextBox5.Text = message;

            HideShowEmailPanels(panelCompose1);
        }
        private void button24_Click(object sender, EventArgs e) //"FWD"
        {
            string[] messageFields = MessageFWDFieldsInit();
            string title;
            string message;

            FillFwdMessage(messageFields, out title, out message);
            textBox2.Text = "";
            textBox3.Text = title;
            richTextBox5.Text = message;
            HideShowEmailPanels(panelCompose1);
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                dataGridView1.DataSource = BindInboxSearchMessagesToGridView(crtUser, textBox1.Text);
                HideShowEmailPanels(panelInbox1);
            }

        }

        private string[] MessageReplyFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView1.CurrentCell.RowIndex;
            string receiverText = DBUpdates.GetReplyReceiver(crtUser, selection);
            string titleText = "re: " + DBUpdates.GetReplyTitle(crtUser, selection);
            string messageText = "\n" + richTextBox1.Text;
            string[] messageFields = new string[3] { receiverText, titleText, messageText };
            return messageFields;
        }
        private string[] MessageFWDFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView1.CurrentCell.RowIndex;
            StringBuilder title = new StringBuilder();
            title.Append("Fwd: ");
            title.Append(DBUpdates.GetReplyTitle(crtUser, selection));
            string titleText = title.ToString();
            string messageText = richTextBox1.Text;
            string[] messageFields = new string[2] { titleText, messageText };
            return messageFields;
        }

        private void FillReplyMessage(string[] messageFields, out string receiverBox, out string titleBox, out string messageBox)
        {
            receiverBox = messageFields[0];
            titleBox = messageFields[1];
            messageBox = messageFields[2];
        }
        private void FillFwdMessage(string[] messageFields, out string titleBox, out string messageBox)
        {
            titleBox = messageFields[0];
            messageBox = messageFields[1];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSentMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox2, panelSent1, rawText, DBUpdates.IsSentMessageEncrypted, DBUpdates.ReadSentMsg, crtUser);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            int selection = dataGridView2.CurrentCell.RowIndex;
            DBUpdates.DeleteSenderMsg(crtUser, selection);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetDeletedMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox3, panelDeleted1, rawText, DBUpdates.IsDeletedMessageEncrypted, DBUpdates.ReadDeletedMsg, crtUser);
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSpamMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox4, panelSpam1, rawText, DBUpdates.IsSpamMessageEncrypted, DBUpdates.ReadSpamMsg, crtUser);
        }

        private void button27_Click(object sender, EventArgs e) //"Send"
        {
            if (CheckIfEmailDataInputNotEmpty())
            {

                string withEncryption = EncriptionRequested();
                string messageBody;
                if (withEncryption == "true")
                {
                    string crtUser = IOMethods.GetUserName();
                    string key = "abracadabra";
                    string encryptedMessage = Encryption.StringEncrypt(richTextBox5.Text, key);
                    messageBody = encryptedMessage;
                }
                else
                {
                    messageBody = richTextBox5.Text;
                }
                string[] messageFields = new string[] { Form.ActiveForm.Text, textBox2.Text, textBox3.Text, messageBody, withEncryption };
                var newMessage = Messaging.CreateMessage(messageFields);
                var connection = new MSSQLConnection<psDBContext>().Context;
                if (WriteMessageToDB(newMessage, connection))
                {
                    MessageBox.Show("Message sent");
                }
                else
                {
                    MessageBox.Show("Your message could not be sent. Check if receiver name is correct!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private string EncriptionRequested()
        {
            string withEncryption = "false";
            if (checkBox1.Checked)
            {
                withEncryption = "true";
            }
            return withEncryption;
        }

        private bool CheckIfEmailDataInputNotEmpty()
        {
            bool correctInputData = false;

            if (textBox2.Text != String.Empty
               && textBox3.Text != String.Empty
               && richTextBox5.Text != String.Empty)
            {
                correctInputData = true;
            }

            return correctInputData;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 1)
            {
                string cellContent = dataGridView5.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox4.Text = cellContent;
                textBox4.Refresh();
            }
        }
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 1)
            {
                string cellContent = dataGridView6.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox5.Text = cellContent;
                textBox5.Refresh();
            }
        }

        private void button28_Click(object sender, EventArgs e) //"update"
        {
            string value = textBox4.Text;
            int activeCellIndex = dataGridView5.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView5.Columns[activeCellIndex].Name;
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView5.DataSource = BindCrtUserDataToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);
        }

        private void button29_Click(object sender, EventArgs e) //"update"
        {
            string value = textBox5.Text;
            int activeCellIndex = dataGridView6.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView6.Columns[activeCellIndex].Name;
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserAddressToDB(activeColumn, value);
            dataGridView6.DataSource = BindCrtUserAddressToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);
        }

        private void button30_Click(object sender, EventArgs e) //"Change Password"
        {
            textBox6.Text = "old password";
            textBox7.Text = "new password";
            textBox6.Show();
            textBox7.Show();
            button31.Show();
        }

        private void button31_Click(object sender, EventArgs e) //"Update Password"
        {
            var connection = new MSSQLConnection<psDBContext>().Context;
            if (CheckForCorrectPassword(ActiveForm.Text, textBox6.Text,connection))
            {
                string newPassVal = textBox7.Text;
                WriteNewPassToDB(newPassVal);
                MessageBox.Show("password changed");
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            textBox6.Hide();
            textBox7.Hide();
            button31.Hide();
        }

        private void UpdateDataGridMessageBox(string column, string value)
        {
            MessageBox.Show("updating " + column + " with " + value);
        }

        private void button6_Click(object sender, EventArgs e) //"Products"
        {
            HideShowAllPanels(panelProducts);
        }

        private void button32_Click(object sender, EventArgs e) //"Search"
        {
            ProductsQuery();
            button40.Hide();
            panelProducts.Show();
        }

        private void ProductsQuery()
        {
            
            string categorySelection = "";
            string manufacturerSelection = "";

            if (checkBox2.Checked == true)
            {
                categorySelection = listBox1.SelectedItem.ToString();
            }
            if (checkBox3.Checked == true)
            {
                manufacturerSelection = listBox2.SelectedItem.ToString();
            }
            dataGridView7.DataSource = BindProductsToGridForClient(textBox8.Text, textBox9.Text, textBox10.Text, categorySelection, manufacturerSelection);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int columnHeadIndex = -1;
            int rowSelection = e.RowIndex;


            if (e.RowIndex != columnHeadIndex)
            {
                int productID = Int32.Parse(dataGridView7.Rows[rowSelection].Cells[0].Value.ToString());
                richTextBox6.Text = GetProductSpec(productID);
                richTextBox8.Text = GetProductSpec(productID);
                var connection = new MSSQLConnection<psDBContext>().Context;
                numericUpDown1.Maximum = GetMaxAmount(productID,connection);
                richTextBox6.Refresh();
                button40.Show();
                label30.Text = ConstructProductHierarchy(productID, connection);
                label32.Text = GetProductPrice(productID, connection).ToString();
                label32.Show();

                searchWithProductId = new GenericDBItemsQueries<UserItemReview>(productID);
                //richTextBox11.Text = ConstructProductReviewsProt(searchWithProductId);
                richTextBox11.Text = ConstructProductReviews(productID, connection);
                //ConstructProductReviewsProt
                //label46.Text = "Rating: " + GetProductRatingProt1(searchWithProductId);
                label46.Text = "Rating: " + GetProductRating(productID,connection);
                //GetProductRating

                try
                {
                    byte[] pictureData = GetPictureData(productID);
                    Bitmap picture = GetBitmap(pictureData);
                    pictureBox1.Image = picture;
                    pictureBox1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                panelProducts.Show();
            }
        }
        private void button33_Click(object sender, EventArgs e) //"Add to cart"
        {
            bool selectionOk =false;
            if(dataGridView7.CurrentCell !=null)
            {
                selectionOk = true;
            }
            if(selectionOk)
            {
                int rowIndex = Int32.Parse(dataGridView7.CurrentCell.RowIndex.ToString());
                int productID = Int32.Parse(dataGridView7.Rows[rowIndex].Cells[0].Value.ToString());
                int amount = Int32.Parse(numericUpDown1.Value.ToString());
                var connection = new MSSQLConnection<psDBContext>().Context;
                if (amount > 0 && !IsProductInCart(crtUser, productID, connection))
                {
                    CreateNewShoppingCartItem(crtUser, productID, amount);
                    string plural = (amount > 1) ? "s" : string.Empty;
                    MessageBox.Show($"{amount} item{plural} with PID {productID} added to cart");
                    UpdateShoppingCartNr(crtUser, connection);
                }
            }
            
            
        }
        private void button34_Click(object sender, EventArgs e) //"Add to wishlist"
        {

            if (dataGridView7.CurrentCell != null)
            {
                int rowIndex = Int32.Parse(dataGridView7.CurrentCell.RowIndex.ToString());
                int productID = Int32.Parse(dataGridView7.Rows[rowIndex].Cells[0].Value.ToString());
                DBUpdates.SaveProductToWishlist(crtUser, productID);
                //DBUpdates.SaveProductToWishlist(crtUser, productID);
                MessageBox.Show($"product with PID {productID} added to wishlist");
                
            }
            else 
            {
                MessageBox.Show("please select a product");
            }
            var connection = new MSSQLConnection<psDBContext>().Context;
            MessageBox.Show($"size of wish list: {InternalDBQueries.GetWishListSize(crtUser, connection)} ");

        }

        private void button40_Click(object sender, EventArgs e) //"Open Specifications"
        {
           
            HideShowAllPanels(panelProductSpec);
        }

            private void button36_Click(object sender, EventArgs e) //"Add to cart"
        {
            //MessageBox.Show(InternalDBQueries.GetWishListStr(crtUser));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox4.DataSource = BindCartProducts(crtUser);
            HideShowAllPanels(panelShoppingCart);
        }
        private void buttonShoppingCart1_Click(object sender, EventArgs e)
        {
            listBox4.DataSource = BindCartProducts(crtUser);
            HideShowAllPanels(panelShoppingCart);
        }

        private void button37_Click(object sender, EventArgs e) //Remove selection
        {
            int selection = listBox4.SelectedIndex;
            DeleteCartItem(crtUser, selection);
            listBox4.DataSource = BindCartProducts(crtUser);
            HideShowAllPanels(panelShoppingCart);
            var connection = new MSSQLConnection<psDBContext>().Context;
            UpdateShoppingCartNr(crtUser,connection);
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            int selection = listBox4.SelectedIndex;
            var connection = new MSSQLConnection<psDBContext>().Context;
            numericUpDown2.Value = GetShoppingCartItemAmount(crtUser, selection, connection);
        }

        private void button38_Click(object sender, EventArgs e) //Checkout
        {
            if(CheckIfEnoughFounds(crtUser))
            {
                var connection = new MSSQLConnection<psDBContext>().Context;
                CheckoutCartItems(crtUser,connection);
                listBox4.DataSource = BindCartProducts(crtUser);
                HideShowAllPanels(panelShoppingCart);
                UpdateShoppingCartNr(crtUser,connection);
                string[] transInfo = GetLastTransInfo(crtUser,connection);
                string[] purchaseInfo = SysMessaging.CreatePurchaseInfo(transInfo);
                var newMessage = SysMessaging.CreateSysMessage(purchaseInfo);
                WriteMessageToDB(newMessage, connection);
            }
            else
            {
                MessageBox.Show("Insufficient fonds. Please add more credit");
            }
        }

        private void button39_Click(object sender, EventArgs e) //Remove selection(wishlist)
        {
            int selection = listBox3.SelectedIndex;
            DeleteWishListItem(crtUser, selection);
            listBox3.DataSource = BindWishListProducts(crtUser);
            HideShowAllPanels(panelWishList);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDown2.Value;
            int selection = listBox4.SelectedIndex;
            ModifyShoppingCartItemAmount(crtUser, selection, value);
            //MessageBox.Show("Value changed to " + numericUpDown1.Value.ToString());
        }

        private void button41_Click(object sender, EventArgs e) //Back to search
        {
            HideShowAllPanels(panelProducts);
        }

        private void button7_Click(object sender, EventArgs e) //Purchases
        {
            HideShowAllPanels(panelTransactions);
            dataGridView8.DataSource = BindPurchasesToGrid(crtUser);
            //dataGridView8.DataSource = BindTransactionsToGrid(crtUser);
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //richTextBox7.Text = "Transaction info";

            int columnHeadIndex = -1;
            int rowSelection = e.RowIndex;
            int transId = Int32.Parse(dataGridView8.Rows[rowSelection].Cells[0].Value.ToString());

            if (e.RowIndex != columnHeadIndex)
            {
                richTextBox7.Text = ConstructTransactionInfo(transId, crtUser);

            }

            richTextBox7.Refresh();
            panelTransactions.Show();
        }

        private void UpdateShoppingCartNr<T>(string user, T context) where T:IDbContext
        {
            //var connection = new MSSQLConnection<psDBContext>().Context;
            //string nr = GetNrOfProductsInCart(crtUser, connection).ToString();
            string nr = GetNrOfProductsInCart(crtUser, context).ToString();
            UpdateButtonText(button5, "Shopping cart", nr);
            UpdateButtonText(buttonShoppingCart1, "Shopping cart", nr);

        }

        private void UpdateUnreadMsgNr(string user)
        {
            var connection = new MSSQLConnection<psDBContext>().Context;
            string nr = GetNrOfUnreadMessages(crtUser, connection).ToString();
            UpdateButtonText(button2, "Messages", nr);
            //UpdateButtonText(button16, "Inbox", nr);
            //button16

        }

        private void button42_Click(object sender, EventArgs e) //Download spec sheet
        {
            int crtRowIndex = dataGridView8.CurrentCell.RowIndex;
            int crtProductId = int.Parse(dataGridView8.Rows[crtRowIndex].Cells[0].Value.ToString());

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string specFileName = saveFileDialog1.FileName;
                byte[] specData = DBUpdates.GetSpecData(crtProductId);

                var bw = new BinaryWriter(File.Open(specFileName, FileMode.OpenOrCreate));
                using (bw)
                {
                    bw.Write(specData);
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) //Status
        {
            var connection = new MSSQLConnection<psDBContext>().Context;
            label37.Text = GetCrtCreditStatus(crtUser, connection);
            dataGridView9.DataSource = BindTransactionsToGrid(crtUser);
            HideShowAllPanels(panelFinancialStatus);
        }

        private void button10_Click(object sender, EventArgs e) //AddCredit
        {
            HideShowAllPanels(panelAddCredit);
        }

        private void button44_Click(object sender, EventArgs e) //Add Credit
        {
            //MessageBox.Show("adding credit");
            bool correctInput = CheckCreditInput(textBox12.Text);
            if(correctInput)
            {
                string creditText = $"adding credit amount: {textBox12.Text}";
                MessageBox.Show(creditText);
                decimal addedCredit;
                bool decInputOk = decimal.TryParse(textBox12.Text, out addedCredit);
                if(decInputOk)
                {
                    AddCredit(crtUser, addedCredit);
                }
            }
            else
            {
                MessageBox.Show("please add a correct amount!");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox5.DataSource = BindPurchasedProductsToListbox(crtUser);
            HideShowAllPanels(panelUserProductReviews);
        }

        private void button45_Click(object sender, EventArgs e) //Write review
        {
            
            HideReviewSubPanels(newReviewSubPanel);
        }

        private void listBox5_Click(object sender, EventArgs e)
        {
            int selection = listBox5.SelectedIndex;
            var connection = new MSSQLConnection<psDBContext>().Context;
            bool existingReview = CheckIfReviewedProduct(crtUser, selection, connection);
            if(existingReview)
            {

                int reviewId = GetCrtReviewId(crtUser, selection,connection);
                richTextBox10.Text = ConstructProductReviewInfo(reviewId);
                HideReviewSubPanels(existingReviewsSubPanel);
            }
            else
            {
                //GetProductName
                label42.Text = listBox5.SelectedItem.ToString();
                HideReviewSubPanels(noReviewsSubPanel);
            }
   
        }

        private void button47_Click(object sender, EventArgs e) //Submit
        {
            int selection = listBox5.SelectedIndex;
            var connection = new MSSQLConnection<psDBContext>().Context;
            int PID = GetCrtPIDFromPurchasedProdList(crtUser, selection, connection);
            int rating = (int)numericUpDown3.Value;
            string title = textBox13.Text;
            string review = richTextBox9.Text;
            CreateNewReview(crtUser, PID, title,review, rating);
            newReviewSubPanel.Hide();
        }

        private void HideReviewSubPanels(Panel panel)
        {
            existingReviewsSubPanel.Hide();
            noReviewsSubPanel.Hide();
            newReviewSubPanel.Hide();
            panel.Show(); 
        }
    }
}
