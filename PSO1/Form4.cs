using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using static PSO1.Model.InternalDBQueries;
using PSO1.Model;
using System.IO;

namespace PSO1
{
    public partial class Form4 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;
        
        public Form4()
        {
            InitializeComponent();
            InitializeManualAddedComponent();
            synchronizationContext = SynchronizationContext.Current;
            //BackgroundTasks();
            BackgroundTasksAsync();
        }

        //https://stephenhaunts.com/2014/10/14/using-async-and-await-to-update-the-ui-thread/comment-page-1/
        private async void BackgroundTasks()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    string transCount = InternalDBQueries.GetAllTransCount().ToString();
                    UpdateTransactionCount(transCount);
                    string msgCount = InternalDBQueries.GetSentMesssagesCount().ToString();
                    UpdateMessageCount(msgCount);
                    string revCount = InternalDBQueries.GetReviewsCount().ToString();
                    UpdateReviewsCount(revCount);
                    string soldProdCount = InternalDBQueries.GetSoldProductsCount().ToString();
                    UpdateSoldProductsCount(soldProdCount);
                    string totalIncome = InternalDBQueries.GetTotalIncome().ToString();
                    UpdateTotalIncome(totalIncome);
                    string totalBoughtCredit = InternalDBQueries.GetTotalBoughtCredit().ToString();
                    UpdateBoughtCredit(totalBoughtCredit);
                    Thread.Sleep(100);
                }

            });
        }

        private async void BackgroundTasksAsync()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    Task<string> transCountTsk = InternalDBQueries.GetAllTransCountAsync();
                    Task<string> msgCountTsk = InternalDBQueries.GetSentMesssagesCountAsync();
                    Task<string> revCountTsk = InternalDBQueries.GetReviewsCountAsync();
                    Task<string> soldProdCountTsk = InternalDBQueries.GetSoldProductsCountAsync();
                    Task<string> totalIncomeTsk = InternalDBQueries.GetTotalIncomeAsync();
                    Task<string> totalBoughtCreditTsk = InternalDBQueries.GetTotalBoughtCreditAsync();

                    List<Task> backgroundTasks = new List<Task> { transCountTsk, msgCountTsk, revCountTsk,
                                                        soldProdCountTsk, totalIncomeTsk, totalBoughtCreditTsk};
                    Dictionary<int, Task> backgroundTasksDict = new Dictionary<int, Task>();
                    int taskDictKey = 0;
                    foreach(Task task in backgroundTasks)
                    {
                        backgroundTasksDict.Add(taskDictKey, task);
                        taskDictKey++;
                    }

                    while (backgroundTasks.Count>0)
                    {
                        Task finishedTask = await Task.WhenAny(backgroundTasks);
                        string result = ((Task<string>)finishedTask).Result;

                        int dKey = backgroundTasksDict.First(x => x.Value == finishedTask).Key;
 
                        switch (dKey)
                        {
                            case 0:
                                UpdateTransactionCount(result);
                                break;
                            case 1:
                                UpdateMessageCount(result);
                                break;
                            case 2:
                                UpdateReviewsCount(result);
                                break;
                            case 3:
                                UpdateSoldProductsCount(result);
                                break;
                            case 4:
                                UpdateTotalIncome(result);
                                break;
                            case 5:
                                UpdateBoughtCredit(result);
                                break;
                            default:
                                break;

                        }
                        backgroundTasks.Remove(finishedTask);
                    }
                    Thread.Sleep(500);
                }
            });

        }

        public void UpdateTransactionCount(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label39.Text = o.ToString();
            }), value);
        }


        public void UpdateMessageCount(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label42.Text = o.ToString();
            }), value);
        }

        public void UpdateReviewsCount(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label44.Text = o.ToString();
            }), value);
        }

        public void UpdateSoldProductsCount(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label46.Text = o.ToString();
            }), value);
        }

        public void UpdateTotalIncome(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label48.Text = o.ToString();
            }), value);
        }
        public void UpdateBoughtCredit(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label50.Text = o.ToString();
            }), value);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideEmailPanels();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        /*
        private async void button11_Click(object sender, EventArgs e) //Transactions
        {
            HideShowPanels(panel21);
            await Task.Run(() =>
            {
                while(true)
                {
                    string transCount = InternalDBQueries.GetAllTransCount().ToString();
                    UpdateTransactionCount(transCount);
                    Thread.Sleep(1000);
                }

            } );
        }
        */
        
        private void button11_Click(object sender, EventArgs e) //Transactions
        {
            HideShowPanels(panel21);
        }
        

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool executedFromAdminAccount = true;
            Form3 f3 = new Form3(executedFromAdminAccount);
            f3.Show();
        }
        
        //TBD: move all to Form4.Designer
        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        TextBox textBox1 = new TextBox();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Button button15 = new Button();
        Label label8 = new Label();
        TextBox textBox2 = new TextBox();
        Button button16 = new Button();
        Label label9 = new Label();
        Button button17 = new Button();
        TextBox textBox3 = new TextBox(); //old pass
        TextBox textBox4 = new TextBox(); //new pass
        Button button18 = new Button();
        Panel panel5 = new Panel();
        //Button button19 = new Button();
        //Panel panel6 = new Panel();
        //Button button20 = new Button();
        Panel panel7 = new Panel();
        //Button button21 = new Button();
        //Button button26 = new Button();



        private void button4_Click(object sender, EventArgs e)
        {
            //panel5.Hide();
            //panel11.Hide();
            //panel6.Hide();
            //panel8.Hide();
            //panel9.Hide();
            //panel10.Hide();
            //panel11.Hide();
            //panel12.Hide();
            //panel13.Hide();
            //panel15.Hide();
            HideEmailPanels();
            //panel7.Show();
            HideShowPanels(panel7);
            DisplayNewPanel(panel7, new int[2] { 235, 46 }, new int[2] { 900, 350 }, "panel7", true);
            Form.ActiveForm.Controls.Add(panel7);
            int[] panelItemsOriginCoord = new int[2] {5, 5};
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            //panel7.Show();

            int yPosLabel5 = origY + yMargin;
            DisplayNewLabelOnPanel(label5, panel7, new int[2] { origX+ xMargin, yPosLabel5 }, new int[2] 
                { 168, 24 }, "Personal info");

            string loggedUser = ActiveForm.Text;
            int xPosDataGridView1 = origX + xMargin;
            int yPosDataGridView1 = yPosLabel5 + yItemsSpace + 24;
            int sizeXDataGridView1 = 650;
            int sizeYDataGridView1 = 45;
            DisplayNewDataGridViewOnPanel(dataGridView1, panel7, new int[2]
                { xPosDataGridView1, yPosDataGridView1}, new int[2] { sizeXDataGridView1, sizeYDataGridView1 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            int yPosLabel6 = yPosDataGridView1 + yItemsSpace + sizeYDataGridView1;
            int sizeXLabel6 = 168;
            int sizeYLabel6 = 24;
            DisplayNewLabelOnPanel(label6, panel7, new int[2] { origX + xMargin, yPosLabel6 }, new int[2] 
                { sizeXLabel6, sizeYLabel6 }, "Address");

            int xPosDataGridView2 = xPosDataGridView1;
            int yPosDataGridView2 = yPosLabel6 + yItemsSpace + sizeYLabel6;
            int sizeXDataGridView2 = 650;
            int sizeYDataGridView2 = 45;
            DisplayNewDataGridViewOnPanel(dataGridView2, panel7, new int[2]
                { origX + xMargin, yPosDataGridView2}, new int[2] { sizeXDataGridView2, sizeYDataGridView2 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.CellContentClick += new DataGridViewCellEventHandler(dataGridView2_CellContentClick);

            int xPosLabel7 = xPosDataGridView1 + sizeXDataGridView1 + xItemsSpace;
            int yPosLabel7 = yPosDataGridView1;
            int sizeXLabel7 = 168;
            int sizeYLabel7 = 24;
            DisplayNewLabelOnPanel(label7, panel7, new int[2] { xPosLabel7, yPosLabel7 }, new int[2] 
                { sizeXLabel7, sizeYLabel7 }, "Value");

            int xPosTextBox1 = xPosLabel7;
            int yPosTextBox1 = yPosLabel7+ sizeYLabel7 + 3;
            int sizeXTextBox1 = 60;
            int sizeYTextBox1 = 24;
            DisplayNewTextBoxOnPanel(textBox1, panel7, new int[2] { xPosTextBox1, yPosTextBox1 }, new int[2] 
                { sizeXTextBox1, sizeYTextBox1 }, "Value");
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            int xPosButton15 = xPosTextBox1 + sizeXTextBox1 + 10;
            int yPosButton15 = yPosTextBox1;
            int sizeXButton15 = 60;
            int sizeYButton15 = 24;
            DisplayNewButtonOnPanel(button15, panel7, new int[2] { xPosButton15, yPosButton15 }, new int[2] 
                { sizeXButton15, sizeYButton15 }, "button15", "Update");
            button15.Click += new EventHandler(button15_Click);

            int xPosLabel8 = xPosDataGridView2 + sizeXDataGridView2 + xItemsSpace;
            int yPosLabel8 = yPosDataGridView2;
            int sizeXLabel8 = 168;
            int sizeYLabel8 = 24;
            DisplayNewLabelOnPanel(label8, panel7, new int[2] { xPosLabel8, yPosLabel8 }, new int[2] 
                { sizeXLabel8, sizeYLabel8 }, "Value");

            int xPosTextBox2 = xPosLabel8;
            int yPosTextBox2 = yPosLabel8 + sizeYLabel8 + 3;
            int sizeXTextBox2 = 60;
            int sizeYTextBox2 = 24;
            DisplayNewTextBoxOnPanel(textBox2, panel7, new int[2] { xPosTextBox2, yPosTextBox2 }, new int[2]
                { sizeXTextBox2, sizeYTextBox2 }, "Value");
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);

            int xPosButton16 = xPosTextBox2 + sizeXTextBox2 + 10;
            int yPosButton16 = yPosTextBox2;
            int sizeXButton16 = 60;
            int sizeYButton16 = 24;
            DisplayNewButtonOnPanel(button16, panel7, new int[2] { xPosButton16, yPosButton16 }, new int[2] 
                { sizeXButton16, sizeYButton16 }, "button16", "Update");
            button16.Click += new EventHandler(button16_Click);

            int xPosLabel9 = xPosDataGridView2;
            int yPosLabel9 = yPosDataGridView2 + sizeYDataGridView2 + yItemsSpace;
            int sizeXLabel9 = 168;
            int sizeYLabel9 = 24;
            DisplayNewLabelOnPanel(label9, panel7, new int[2] { xPosLabel9, yPosLabel9 }, new int[2] 
                { sizeXLabel9, sizeYLabel9 }, "Password");

            int xPosButton17 = xPosLabel9;
            int yPosButton17 = yPosLabel9 + sizeYLabel9 + yItemsSpace;
            int sizeXButton17 = 120;
            int sizeYButton17 = 24;
            DisplayNewButtonOnPanel(button17, panel7, new int[2] { xPosButton17, yPosButton17 }, new int[2] 
                { sizeXButton17, sizeYButton17 }, "button17", "Change Password");
            button17.Click += new EventHandler(button17_Click);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex>=1 )
            {
                string cellContent = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox1.Text = cellContent;
                textBox1.Refresh();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[e.ColumnIndex].Value != null)
            {
                string cellContent = dataGridView2.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox2.Text = cellContent;
                textBox2.Refresh();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnHeadIndex = -1;
            int[] allowedColumnIndexes = new int[5] {1,6,7,8,9};

            if (e.RowIndex != columnHeadIndex)
            {

                if (DBUpdates.DataGridViewAllowCustomExtraction(e.ColumnIndex, allowedColumnIndexes))
                {
                    string cellContent = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    textBox16.Text = cellContent;
                    textBox16.Refresh();

                    int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
                    int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());
                    try
                    {
                        byte[] pictureData = DBUpdates.GetPictureData(crtProductId);
                        Bitmap picture = GetBitmap(pictureData);
                        pictureBox1.Image = picture;
                        pictureBox1.Show();
                        panel13.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideUserInformationFormElements();
            panel11.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel7.Hide();
            panel21.Hide();
            panelWarehouse.Hide();
            panel15.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            int activeCellIndex = dataGridView1.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView1.Columns[activeCellIndex].Name;
            //MessageBox.Show("cell column index:"+activeCellIndex);
           
            //MessageBox.Show("updating " + activeColumn+" with "+ value);
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e) 
        {
            string value = textBox2.Text;
            int activeCellIndex = dataGridView2.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView2.Columns[activeCellIndex].Name;

            //MessageBox.Show("updating " + activeColumn + " with " + value);
            UpdateDataGridMessageBox(activeColumn, value);

            DBUpdates.WriteUserAddressToDB(activeColumn, value);
            dataGridView2.Refresh();
        }

        private void UpdateDataGridMessageBox(string column, string value)
        {
            MessageBox.Show("updating " + column + " with " + value);
        }


        private void button17_Click(object sender, EventArgs e)
        {

            int xPosTextBox3 = label9.Location.X + label9.Size.Width + 45;
            int yPosTextBox3 = label9.Location.Y;
            int sizeXTextBox3 = 120;
            int sizeYTextBox3 = 24;
            DisplayNewTextBoxOnPanel(textBox3, panel7, new int[2] { xPosTextBox3, yPosTextBox3 }, new int[2]
                { sizeXTextBox3, sizeYTextBox3 }, "old password");
            textBox3.TextChanged += new EventHandler(textBox3_TextChanged);

            int xPosTextBox4 = xPosTextBox3;
            int yPosTextBox4 = label9.Location.Y + 40;
            int sizeXTextBox4 = 120;
            int sizeYTextBox4 = 24;
            DisplayNewTextBoxOnPanel(textBox4, panel7, new int[2] { xPosTextBox4, yPosTextBox4 }, new int[2]
                { sizeXTextBox4, sizeYTextBox4 }, "new password");
            textBox4.TextChanged += new EventHandler(textBox4_TextChanged);

            int xPosButton18 = xPosTextBox3 + sizeXTextBox3 + 10;
            int yPosButton18 = yPosTextBox3;
            int sizeXButton18 = 60;
            int sizeYButton18 = 24;
            DisplayNewButtonOnPanel(button18, panel7, new int[2] { xPosButton18, yPosButton18 }, new int[2] 
                { sizeXButton18, sizeYButton18 }, "button18", "Update Password");
            button18.Click += new EventHandler(button18_Click);

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            HideEmailPanels();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    
        private void HideUserInformationFormElements()
        {
            clearPanel(panel7);
        }
        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Text = crtUser + " - DASHBOARD";
            f6.Show();

        }
        private void button18_Click(object sender, EventArgs e)
        {
            var connection = new MSSQLConnection<psDBContext>().Context;
            if (CheckForCorrectPassword(ActiveForm.Text, textBox3.Text, connection))
            {
                //MessageBox.Show("correct password");
                string newPassVal = textBox4.Text;
                DBUpdates.WriteNewPassToDB(newPassVal);
                MessageBox.Show("password changed");
            }
            else 
            {
                MessageBox.Show("wrong password");
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //Products
        {
            panel7.Hide();
            panel13.Hide();
            panel15.Hide();
            HideEmailPanels();
            //panel11.Show();
            HideShowPanels(panel11);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel10.Hide();
            panel13.Hide();
            panel15.Hide();
            panel8.Show();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button20_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel13.Hide();
            panel15.Hide();
            panel9.Show();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel13.Hide();
            panel15.Hide();
            panel10.Show();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel13.Hide();
            panel15.Hide();
            panel12.Show();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            panel11.Show();

        }

        private void button28_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel9.Hide();

            ProductsQuery();

        }
        private void button29_Click(object sender, EventArgs e)
        {
            if(button29.Text == "Disable edit")
            {
                button29.Text = "Enable edit";
                //panel14.Hide();
            }
            else
            {
                button29.Text = "Disable edit";
                //panel14.Hide();
            }
        }

        private void button30_Click(object sender, EventArgs e) //Update
        {
            if( AllowProductUpdate() )
            {
                string value = textBox16.Text;
                int activeCellIndex = dataGridView3.CurrentCell.ColumnIndex;
                int activeColumn = dataGridView3.Columns[activeCellIndex].DisplayIndex;
                int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
                int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());
                bool successfulDBUpdate = DBUpdates.WriteProductDataToDB(crtProductId, activeColumn, value);
                if(successfulDBUpdate)
                {
                    ProductsQuery();
                    MessageBox.Show("DB updated");  
                }
                else 
                {
                    MessageBox.Show("DB update failed due to incorrect input data");
                }
            }
        }
        private bool AllowProductUpdate()
        {
            bool allowUpdate = false;
            if (checkBox3.Checked == true)
            {
                allowUpdate = true;
            }
            return allowUpdate;
        }

        private void ProductsQuery()
        {
            //dataGridView3.DataSource = BindProductsToGridPrototype1(textBox13.Text);
            //dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text);
            string categorySelection = "";
            string manufacturerSelection = "";

            if (checkBox1.Checked == true)
            {
                categorySelection = listBox4.SelectedItem.ToString();
            }
            if (checkBox2.Checked == true)
            {
                manufacturerSelection = listBox5.SelectedItem.ToString();
            }

            //dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text, categorySelection);
            dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text, categorySelection, manufacturerSelection);
            panel13.Show();
        }
        //public void CheckBoxSelected

        private void button47_Click(object sender, EventArgs e) //Select file
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFileDialog1.FileName);
                textBox21.Text = sr.ReadToEnd();
            }
                
        }

        private void button48_Click(object sender, EventArgs e) //Save to DB
        {
            int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
            int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgFileName = openFileDialog1.FileName;
                DBUpdates.SaveProductImgToDB(crtProductId, imgFileName);
                MessageBox.Show("Image saved to DB");
            }

        }

        private void button49_Click(object sender, EventArgs e) //Upload spec sheet
        {
            int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
            int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string specFileName = openFileDialog1.FileName;
                DBUpdates.SaveProductSpecToDB(crtProductId, specFileName);
                MessageBox.Show("File saved to DB");
            }
        }

        private void button50_Click(object sender, EventArgs e) //Download spec sheet
        {
            int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
            int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string specFileName = saveFileDialog1.FileName;
                byte[] specData = DBUpdates.GetSpecData(crtProductId);

                var bw = new BinaryWriter(File.Open(specFileName, FileMode.OpenOrCreate));
                using(bw)
                {
                    bw.Write(specData);
                }

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string newCategory = textBox5.Text;
            if((newCategory!= string.Empty) && (newCategory != "new category") )
            {
                DBUpdates.CreateNewCategory(newCategory);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string newManufacturer = textBox6.Text;
            if ((newManufacturer != string.Empty) && (newManufacturer != "new manufacturer"))
            {
                DBUpdates.CreateNewManufacturer(newManufacturer);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string subCategory = textBox7.Text;
            string category = listBox1.SelectedItem.ToString();
            if ((subCategory != string.Empty) && (subCategory != "new subcategory"))
            {
                DBUpdates.CreateNewSubCategory(subCategory, category);
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            

            if (CheckNewProductDataInputCorrectness())
            {
                string[] productProperties = new string[4]
                                { textBox8.Text, textBox9.Text,
                                  listBox2.SelectedItem.ToString(),
                                  listBox3.SelectedItem.ToString()};
                int startingStock = int.Parse(textBox10.Text);
                decimal sellPrice = decimal.Parse(textBox11.Text);
                decimal supplierPrice = decimal.Parse(textBox12.Text);
                decimal[] prices = new decimal[2] { sellPrice, supplierPrice };

                DBUpdates.CreateNewProduct(productProperties, startingStock, prices);

            }
        }

        private bool CheckNewProductDataInputCorrectness()
        {
            bool correctInputData = false;
            int startingStock;
            decimal sellPrice;
            decimal supplierPrice;
            if(   textBox8.Text != String.Empty
               && textBox9.Text != String.Empty
               && textBox10.Text != String.Empty
               && textBox11.Text != String.Empty
               && textBox12.Text != String.Empty
               && textBox8.Text != "Product name"
               && textBox9.Text != "Product model"
               && int.TryParse(textBox10.Text, out startingStock)
               && decimal.TryParse(textBox11.Text, out sellPrice)
               && decimal.TryParse(textBox12.Text, out supplierPrice) )
            {
                correctInputData = true;
            }

            return correctInputData;
        }
        

        private void button31_Click(object sender, EventArgs e) //Inbox
        {
            dataGridView4.DataSource = BindInboxMessagesToGridView(crtUser);
            HideShowEmailPanels(panel16);
        }
        private void button32_Click(object sender, EventArgs e) //Sent
        {
            dataGridView5.DataSource = BindSentMessagesToGridView(crtUser);
            HideShowEmailPanels(panel17);
        }
        private void button33_Click(object sender, EventArgs e) //Deleted
        {
            dataGridView6.DataSource = BindDeletedMessagesToGridView(crtUser);
            HideShowEmailPanels(panel18);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = BindSpamMessagesToGridView(crtUser);
            HideShowEmailPanels(panel19);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            HideShowEmailPanels(panel20);
        }

        private void button36_Click(object sender, EventArgs e) //"Send"
        {
            if(CheckIfEmailDataInputNotEmpty())
            {
                //string[] messageFields = new string[] { Form.ActiveForm.Text, textBox17.Text, textBox18.Text, richTextBox1.Text};
                string withEncryption = EncriptionRequested();
                string messageBody;
                if(withEncryption == "true")
                {
                    string crtUser = IOMethods.GetUserName();
                    //string key = InternalDBQueries.GetPassword(crtUser);
                    string key = "abracadabra";
                    string encryptedMessage = Encryption.StringEncrypt(richTextBox1.Text, key);
                    messageBody = encryptedMessage;
                }
                else 
                {
                    messageBody = richTextBox1.Text;
                }
                string[] messageFields = new string[] { Form.ActiveForm.Text, textBox17.Text, textBox18.Text, messageBody, withEncryption };
                //var newMessage = Messaging.CreateMessage(messageFields);
                var newMessage = Messaging.CreateMessage(messageFields);
                var connection = new MSSQLConnection<psDBContext>().Context;
                if (DBUpdates.WriteMessageToDB(newMessage, connection))
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

        public static void ComposeMessage()
        {

        }
        public static string GetUser()
        {
            return ActiveForm.Text;
            
        }

        private bool CheckIfEmailDataInputNotEmpty()
        {
            bool correctInputData = false;
            
            if (textBox17.Text != String.Empty
               && textBox18.Text != String.Empty
               && richTextBox1.Text != String.Empty)
            {
                correctInputData = true;
            }

            return correctInputData;
        }
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox7.DataSource = BindReceivedMessages(crtUser);
            //HideShowEmailPanels(panel16);
        }

        
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            //MessageBox.Show($"row {selection} clicked"); // selection test ok
            string rawText;
            bool encryption;
            if (textBox20.Text != string.Empty)
            {
                rawText = DBUpdates.GetMessage(crtUser, selection, textBox20.Text);

                if (!DBUpdates.IsMessageEncrypted(crtUser, selection, textBox20.Text))
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
                richTextBox2.Text = rawText;
            }
            else
            {
                string key = "abracadabra";
                string decryptedMessage = Encryption.StringDecrypt(rawText, key);
                richTextBox2.Text = decryptedMessage;
            }
            DBUpdates.ReadMsg(crtUser, selection);
            panel16.Show();
        }


        public delegate bool EcryptionCheck(string user, int selection);
        public delegate void DBupdate(string user, int selection);

        /*
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox3, panel17, rawText, DBUpdates.IsMessageEncrypted, DBUpdates.ReadMsg);
        }*/

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSentMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox3, panel17, rawText, DBUpdates.IsSentMessageEncrypted, DBUpdates.ReadSentMsg, crtUser);
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetDeletedMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox4, panel18, rawText, DBUpdates.IsDeletedMessageEncrypted, DBUpdates.ReadDeletedMsg, crtUser);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSpamMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox5, panel19, rawText, DBUpdates.IsSpamMessageEncrypted, DBUpdates.ReadSpamMsg, crtUser);
        }

        private string EncriptionRequested()
        {
            string withEncryption = "false";
            if(checkBox4.Checked)
            {
                withEncryption = "true";
            }
            return withEncryption;
        }

        private void button38_Click(object sender, EventArgs e) //Delete
        {
            int selection = dataGridView4.CurrentCell.RowIndex; 
            DBUpdates.DeleteReceiverMsg(crtUser, selection);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            //int selection = listBox8.SelectedIndex;
            int selection = dataGridView5.CurrentCell.RowIndex;
            DBUpdates.DeleteSenderMsg(crtUser, selection);
            //DBUpdates.DeleteMsg(crtUser, selection);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //listBox7.DataSource = BindReceivedMessages(crtUser);
            //HideShowEmailPanels(panel16);
            if(textBox20.Text!=string.Empty)
            {
                //listBox7.DataSource = BindSearchMessages(textBox20.Text, crtUser);
                dataGridView4.DataSource = BindInboxSearchMessagesToGridView(crtUser, textBox20.Text); 
                HideShowEmailPanels(panel16);
            }
            
        }

        private void button40_Click(object sender, EventArgs e) //Spam
        {
            int selection = dataGridView4.CurrentCell.RowIndex;
            DBUpdates.SpamMsg(crtUser, selection);
        }
        private void button43_Click(object sender, EventArgs e) //"Reply"
        {
            string[] messageFields = MessageReplyFieldsInit();

            string receiver;
            string title;
            string message;

            FillReplyMessage(messageFields, out receiver, out title, out message);
            textBox17.Text = receiver;
            textBox18.Text = title;
            richTextBox1.Text = message;

            HideShowEmailPanels(panel20);
        }
        private void button44_Click(object sender, EventArgs e) //"FWD"
        {
            string[] messageFields = MessageFWDFieldsInit();
            string title;
            string message;

            FillFwdMessage(messageFields, out title, out message);
            textBox17.Text = "";
            textBox18.Text = title;
            richTextBox1.Text = message;
            HideShowEmailPanels(panel20);
        }
        private string[] MessageReplyFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView4.CurrentCell.RowIndex;
            string receiverText = DBUpdates.GetReplyReceiver(crtUser, selection);
            string titleText = "re: "+ DBUpdates.GetReplyTitle(crtUser, selection);
            string messageText = "\n" + richTextBox2.Text;
            string[] messageFields = new string[3] { receiverText, titleText, messageText };
            return messageFields;
        }
        private string[] MessageFWDFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView4.CurrentCell.RowIndex;
            StringBuilder title = new StringBuilder();
            title.Append("Fwd: ");
            title.Append(DBUpdates.GetReplyTitle(crtUser, selection));
            string titleText = title.ToString();
            string messageText = richTextBox2.Text;
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


        private void FowardMessage()
        {

        }


        private void HideShowEmailPanels(Panel panel)
        {
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
            panel.Show();
        }
        private void HideEmailPanels()
        {
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
        }

        private void HideShowPanels(Panel panel)
        {
            panel11.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            HideEmailPanels();
            panel7.Hide();
            panel21.Hide();
            panelWarehouse.Hide();
            panel.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideShowPanels(panelWarehouse);
            dataGridView8.DataSource = BindWarehouseProductsToGrid(crtUser);
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TBD: method that checks if clicked product has an alarm set
            //bool alarmIsCreated = CheckIfAlarmIsCreated(crtUser,)


            int columnHeadIndex = -1;
            int rowSelection = e.RowIndex;
            int crtProductId = int.Parse(dataGridView8.Rows[rowSelection].Cells[0].Value.ToString());

            if (rowSelection != columnHeadIndex)
            {
                bool alarmIsCreated = CheckIfAlarmIsCreated(crtUser, crtProductId);
                if(alarmIsCreated)
                {
                    HideShowAlarmSubPanels(existingStockAlarmSubPanel);
                }
                else
                {
                    HideShowAlarmSubPanels(noStockAlarmSubPanel);
                }
                //MessageBox.Show("Alarm created: " + alarmIsCreated.ToString());
                
            }



            //string cellContent = dataGridView8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //textBox16.Text = cellContent;
            //textBox16.Refresh();
  
        }

        private void HideShowAlarmSubPanels(Panel panel)
        {
            existingStockAlarmSubPanel.Hide();
            noStockAlarmSubPanel.Hide();
            panel.Show();
        }



        private void button51_Click(object sender, EventArgs e) //Create alarm
        {
            bool existingAlarm = false;
            AlarmMenuStart(existingAlarm);
        }

        private void button52_Click(object sender, EventArgs e) //Edit alarm
        {
            bool existingAlarm = true;
            AlarmMenuStart(existingAlarm);
        }

        private void AlarmMenuStart(bool existingAlarm)
        {
            int columnHeadIndex = -1;
            int selection = dataGridView8.CurrentRow.Index;
            if (selection != columnHeadIndex)
            {
                int crtProductId = int.Parse(dataGridView8.Rows[selection].Cells[0].Value.ToString());
                AlarmDialogInit(crtProductId, existingAlarm);
            }
        }

       
        private void AlarmDialogInit(int prodId, bool existingAlarm)
        {
            if(!AlarmDialogOpened)
            {
                f7 = new Form7(prodId, existingAlarm);
                AlarmDialogOpened = true;
            }
            f7.HideShowAlarmPanels(existingAlarm, prodId);
            f7.Show();
        }



    }
}
