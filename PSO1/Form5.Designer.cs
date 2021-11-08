
using System.Windows.Forms;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using System.Collections.Generic;

namespace PSO1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT ACCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1070, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(28, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 51);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Messages";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(28, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 96);
            this.panel3.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(34, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete account";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(34, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "User information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(31, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account administration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(28, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 195);
            this.panel2.TabIndex = 4;
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button15.Location = new System.Drawing.Point(31, 67);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 23);
            this.button15.TabIndex = 5;
            this.button15.Text = "Wish list";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(31, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Reviews";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(31, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Transactions";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(31, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Products";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shopping";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(31, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Shopping cart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Location = new System.Drawing.Point(28, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 113);
            this.panel4.TabIndex = 5;
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(31, 65);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Add credit";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Finances";
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(31, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Status";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clientBindingSource1
            // 
            //this.clientBindingSource1.DataSource = typeof(PSO1.Model.Client);
            // 
            // clientBindingSource
            // 
            //this.clientBindingSource.DataSource = typeof(PSO1.Model.Client);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::PSO1.Properties.Resources._6145266e516ec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged as client";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        struct ControlDimensions
        {
            public int X;
            public int Y;
            public int PosX;
            public int PosY;
        }
        private void InitializeManualAddedComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));

            this.buttonShoppingCart1 = new System.Windows.Forms.Button();

            this.panelMessage1 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();

            this.panelInbox1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.panelSent1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();

            this.panelDeleted1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();

            this.panelSpam1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();

            this.panelCompose1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();

            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();

            this.panelProducts = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();

            this.panelWishList = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button36 = new System.Windows.Forms.Button();

            this.panelShoppingCart = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();

            this.panelTransactions = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();



            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 5; //40
            int yItemsSpace = 5; //15
            const int SMALLTEXT = 24;
            const int SHORTITEM = 140;
            const int STDTEXTBOX = 70;
            const int MEDIUMITEM = 70;
            const int LONGITEM = 140;
            ControlDimensions LargeEmailPanel;
            LargeEmailPanel.X = 610;
            LargeEmailPanel.Y = 450;
            LargeEmailPanel.PosX = 500;
            LargeEmailPanel.PosY = 68;

            ControlDimensions StandardPanel;
            StandardPanel.X = 900;
            StandardPanel.Y = 360;
            StandardPanel.PosX = 235;
            StandardPanel.PosY = 68;

            ControlDimensions EmailBox;
            EmailBox.X = LargeEmailPanel.X / 2 - 3 * xMargin;
            EmailBox.Y = LargeEmailPanel.Y / 2 - 4 * yMargin - 20;

            var standardFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            
            this.Controls.Add(this.buttonShoppingCart1);
            DisplayNewButton(buttonShoppingCart1, new int[2] { 910,10}, new int[2] { 160, 35 }, "Shopping Cart", "Shopping Cart");
            this.buttonShoppingCart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoppingCart1.Click += new System.EventHandler(this.buttonShoppingCart1_Click);
            //buttonShoppingCart1.ForeColor = System.Drawing.Color.Red;

            DisplayNewPanel(panelMessage1, new int[2] { 300, 68 }, new int[2] { 180, 200 }, "panelMessage1", true);
            this.Controls.Add(this.panelMessage1);
            panelMessage1.Hide();

            int xPosButton16 = origX;
            int yPosButton16 = origY;
            int sizeXButton16 = 140;
            int sizeYButton16 = 24;
            DisplayNewButtonOnPanel(button16, panelMessage1, new int[2] { origX, origY }, new int[2] { sizeXButton16, sizeYButton16 },
                "button16", "Inbox");
            button16.Font = standardFont;
            this.button16.Click += new System.EventHandler(this.button16_Click);

            DisplayNewButtonOnPanel(button17, panelMessage1, button16, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Sent", standardFont);
            this.button17.Click += new System.EventHandler(this.button17_Click);

            DisplayNewButtonOnPanel(button18, panelMessage1, button17, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Deleted", standardFont);
            this.button18.Click += new System.EventHandler(this.button18_Click);

            DisplayNewButtonOnPanel(button19, panelMessage1, button18, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Spam", standardFont);
            this.button19.Click += new System.EventHandler(this.button19_Click);

            DisplayNewButtonOnPanel(button20, panelMessage1, button19, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Compose", standardFont);
            this.button20.Click += new System.EventHandler(this.button20_Click);

            DisplayNewPanel(panelInbox1, new int[2] { LargeEmailPanel.PosX, LargeEmailPanel.PosY }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panelInbox1", true);
            this.Controls.Add(this.panelInbox1);
            panelInbox1.Hide();

            string label6Text = "Inbox";
            int xPosLabel6 = xMargin;
            int yPosLabel6 = yMargin;
            int sizeXLabel6 = CalculateLabelLenght(label6Text);
            int sizeYLabel6 = 24;
            DisplayNewLabelOnPanel(label6, panelInbox1, new int[2] { xPosLabel6, yPosLabel6 }, new int[2]
                { sizeXLabel6, sizeYLabel6 }, label6Text);


            DisplayNewDataGridViewOnPanel(dataGridView1, panelInbox1, new int[2]
                                        { label6.Location.X, label6.Location.Y+label6.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox1, panelInbox1, dataGridView1, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox1", standardFont);

            DisplayNewButtonOnPanel(button21, panelInbox1, label6, new int[2] { 10 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Delete", standardFont);
            this.button21.Click += new System.EventHandler(this.button21_Click);

            DisplayNewButtonOnPanel(button22, panelInbox1, button21, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Spam", standardFont);
            this.button22.Click += new System.EventHandler(this.button22_Click);

            DisplayNewButtonOnPanel(button23, panelInbox1, button22, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Reply", standardFont);
            this.button23.Click += new System.EventHandler(this.button23_Click);

            DisplayNewButtonOnPanel(button24, panelInbox1, button23, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "FWD", standardFont);
            this.button24.Click += new System.EventHandler(this.button24_Click);

            DisplayNewButtonOnPanel(button25, panelInbox1, dataGridView1, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Search", standardFont);
            this.button25.Click += new System.EventHandler(this.button25_Click);

            DisplayNewTextBoxOnPanel(textBox1, panelInbox1, button25, new int[2] { 0, 2 * xItemsSpace },
              new int[2] { MEDIUMITEM, SMALLTEXT }, "");
            
            DisplayNewPanel(panelSent1, new int[2] { LargeEmailPanel.PosX, LargeEmailPanel.PosY }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panelSent1", true);
            this.Controls.Add(this.panelSent1);
            panelSent1.Hide();
            
            string label7Text = "Sent";
            int xPosLabel7 = xMargin;
            int yPosLabel7 = yMargin;
            int sizeXLabel7 = CalculateLabelLenght(label7Text);
            int sizeYLabel7 = SMALLTEXT;
            DisplayNewLabelOnPanel(label7, panelSent1, new int[2] { xPosLabel7, yPosLabel7 }, new int[2]
                { sizeXLabel7, sizeYLabel7 }, label7Text);

            DisplayNewDataGridViewOnPanel(dataGridView2, panelSent1, new int[2]
                                        { label7.Location.X, label7.Location.Y+label7.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.CellContentClick += new DataGridViewCellEventHandler(dataGridView2_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox2, panelSent1, dataGridView2, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox2", standardFont);

            DisplayNewButtonOnPanel(button26, panelSent1, label7, new int[2] { 10 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Delete", standardFont);
            this.button26.Click += new System.EventHandler(this.button26_Click);

            DisplayNewPanel(panelDeleted1, new int[2] { LargeEmailPanel.PosX, LargeEmailPanel.PosY }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panelDeleted1", true);
            this.Controls.Add(this.panelDeleted1);
            panelDeleted1.Hide();

            string label8Text = "Deleted";
            int xPosLabel8 = xMargin;
            int yPosLabel8 = yMargin;
            int sizeXLabel8 = CalculateLabelLenght(label8Text);
            int sizeYLabel8 = 24;
            DisplayNewLabelOnPanel(label8, panelDeleted1, new int[2] { xPosLabel8, yPosLabel8 }, new int[2]
                { sizeXLabel8, sizeYLabel8 }, label8Text);

            DisplayNewDataGridViewOnPanel(dataGridView3, panelDeleted1, new int[2]
                                        { label8.Location.X, label8.Location.Y+label8.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.CellContentClick += new DataGridViewCellEventHandler(dataGridView3_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox3, panelDeleted1, dataGridView3, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox3", standardFont);

            DisplayNewPanel(panelSpam1, new int[2] { LargeEmailPanel.PosX, LargeEmailPanel.PosY }, new int[2] { 610, 450 }, "panelSpam1", true);
            this.Controls.Add(this.panelSpam1);
            panelSpam1.Hide();

            string label9Text = "Spam";
            int xPosLabel9 = xMargin;
            int yPosLabel9 = yMargin;
            int sizeXLabel9 = CalculateLabelLenght(label9Text);
            int sizeYLabel9 = 24;
            DisplayNewLabelOnPanel(label9, panelSpam1, new int[2] { xPosLabel9, yPosLabel9 }, new int[2]
                { sizeXLabel9, sizeYLabel9 }, label9Text);

            DisplayNewDataGridViewOnPanel(dataGridView4, panelSpam1, new int[2]
                                        { label9.Location.X, label9.Location.Y+label9.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.CellContentClick += new DataGridViewCellEventHandler(dataGridView4_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox4, panelSpam1, dataGridView4, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox4", standardFont);

            DisplayNewPanel(panelCompose1, new int[2] { LargeEmailPanel.PosX, LargeEmailPanel.PosY }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panel20", true);
            this.Controls.Add(this.panelCompose1);
            panelCompose1.Hide();

            string label10Text = "Compose";
            int xPosLabel10 = xMargin;
            int yPosLabel10 = yMargin;
            int sizeXLabel10 = CalculateLabelLenght(label10Text);
            int sizeYLabel35 = 24;
            DisplayNewLabelOnPanel(label10, panelCompose1, new int[2] { xPosLabel10, yPosLabel10 }, new int[2]
                { sizeXLabel10, sizeYLabel35 }, label10Text);

            DisplayNewLabelOnPanel(label11, panelCompose1, label10, new int[2] { xItemsSpace, yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "To:", standardFont);
            DisplayNewLabelOnPanel(label12, panelCompose1, label11, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "Title:", standardFont);
            DisplayNewLabelOnPanel(label13, panelCompose1, label12, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "Message:", standardFont);
            DisplayNewTextBoxOnPanel(textBox2, panelCompose1, new int[2] { label11.Location.X+ label13.Size.Width+ 2*xItemsSpace,
                label11.Location.Y }, new int[2] { STDTEXTBOX, SMALLTEXT }, "");
            DisplayNewTextBoxOnPanel(textBox3, panelCompose1, textBox2, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "");

            DisplayNewRichTextBoxOnPanel(richTextBox5, panelCompose1, textBox3, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { 400, 200 }, "richTextBox5", standardFont);

            DisplayNewButtonOnPanel(button27, panelCompose1, richTextBox5, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Send", standardFont);
            this.button27.Click += new System.EventHandler(this.button27_Click);

            string checkBox1Text = "encryption";
            DisplayCheckBox(checkBox1, panelCompose1, button27, new int[2] { 5 * xItemsSpace, 0 },
                            new int[2] { CalculateLabelLenght(checkBox1Text), SMALLTEXT }, checkBox1Text, standardFont);

            DisplayNewPanel(panelUserInfo, new int[2] { StandardPanel.PosX, StandardPanel.PosY }, 
                            new int[2] { StandardPanel.X, StandardPanel.Y }, "panelUserInfo", true);
            this.Controls.Add(this.panelUserInfo);
            panelUserInfo.Hide();

            DisplayNewLabelOnPanel(label14, panelUserInfo, new int[2] { origX + xMargin, origY + yMargin }, new int[2]
                                    { 168, 24 }, "Personal info");

            DisplayNewDataGridViewOnPanel(dataGridView5, panelUserInfo, new int[2]
                { label14.Location.X, label14.Location.Y + label14.Size.Height +4*yItemsSpace}, new int[2] { 650, 45 });
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.CellContentClick += new DataGridViewCellEventHandler(dataGridView5_CellContentClick);

            DisplayNewLabelOnPanel(label15, panelUserInfo, new int[2] { origX + xMargin, 
                                    dataGridView5.Location.Y + dataGridView5.Size.Height + 4 * yItemsSpace }, 
                                    new int[2] { 168, 24 }, "Address");

            DisplayNewDataGridViewOnPanel(dataGridView6, panelUserInfo, new int[2]
                { label15.Location.X, label15.Location.Y + label15.Size.Height +4*yItemsSpace}, new int[2] { 650, 45 });
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.CellContentClick += new DataGridViewCellEventHandler(dataGridView6_CellContentClick);

            int label16PosX = dataGridView5.Location.X + dataGridView5.Size.Width + 4 * xItemsSpace;
            DisplayNewLabelOnPanel(label16, panelUserInfo, new int[2] { label16PosX, dataGridView5.Location.Y },
                                    new int[2] { 168, 24 }, "Value");

            int textBox4PosY = label16.Location.Y + label16.Size.Height ;
            DisplayNewTextBoxOnPanel(textBox4, panelUserInfo, new int[2] { label16PosX, textBox4PosY }, 
                                     new int[2]{ 60, SMALLTEXT }, "Value");

            DisplayNewButtonOnPanel(button28, panelUserInfo, label16, new int[2] { 4 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Update", standardFont);
            this.button28.Click += new System.EventHandler(this.button28_Click);

            int label17PosX = dataGridView6.Location.X + dataGridView6.Size.Width + 4 * xItemsSpace;
            DisplayNewLabelOnPanel(label17, panelUserInfo, new int[2] { label17PosX, dataGridView6.Location.Y },
                                    new int[2] { 168, 24 }, "Value");

            int textBox5PosY = label17.Location.Y + label17.Size.Height;
            DisplayNewTextBoxOnPanel(textBox5, panelUserInfo, new int[2] { label17PosX, textBox5PosY },
                                     new int[2] { 60, SMALLTEXT }, "Value");

            DisplayNewButtonOnPanel(button29, panelUserInfo, label17, new int[2] { 4 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Update", standardFont);
            this.button29.Click += new System.EventHandler(this.button29_Click);

            DisplayNewLabelOnPanel(label18, panelUserInfo, new int[2] { origX + xMargin,
                                    dataGridView6.Location.Y + dataGridView6.Size.Height + 4 * yItemsSpace },
                                    new int[2] { 168, 24 }, "Password");

            DisplayNewButtonOnPanel(button30, panelUserInfo, label18, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Change Password", standardFont);
            this.button30.Click += new System.EventHandler(this.button30_Click);

            int textBox6PosX = button30.Location.X + button30.Size.Width + 4 * xItemsSpace;
            DisplayNewTextBoxOnPanel(textBox6, panelUserInfo, new int[2] { textBox6PosX, button30.Location.Y },
                                     new int[2] { 120, SMALLTEXT }, "old password");
            textBox6.Hide();

            DisplayNewButtonOnPanel(button31, panelUserInfo, button30, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Update Password", standardFont);
            this.button31.Click += new System.EventHandler(this.button31_Click);
            button31.Hide();

            int textBox7PosX = button31.Location.X + button31.Size.Width + 4 * xItemsSpace;
            DisplayNewTextBoxOnPanel(textBox7, panelUserInfo, new int[2] { textBox6PosX, button31.Location.Y },
                                     new int[2] { 120, SMALLTEXT }, "new password");
            textBox7.Hide();

            DisplayNewPanel(panelProducts, new int[2] { StandardPanel.PosX, StandardPanel.PosY },
                            new int[2] { StandardPanel.X, StandardPanel.Y }, "panelProducts", true);
            this.Controls.Add(this.panelProducts);
            panelProducts.Hide();

            DisplayNewLabelOnPanel(label19, panelProducts, new int[2] { xMargin, yMargin }, new int[2]
                { CalculateLabelLenght(label19.Text), SMALLTEXT }, "Product search:");

            DisplayNewButtonOnPanel(button32, panelProducts, label19, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Search", standardFont);
            this.button32.Click += new System.EventHandler(this.button32_Click);

            DisplayNewLabelOnPanel(label20, panelProducts, button32, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght("Key words:"), SMALLTEXT }, "Key words:", standardFont);

            DisplayNewTextBoxOnPanel(textBox8, panelProducts, label20, new int[2] { xItemsSpace, 0 },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");

            string label21Text = "Min. price: ";
            DisplayNewLabelOnPanel(label21, panelProducts, label20, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght(label21Text), SMALLTEXT }, label21Text, standardFont);

            string label22Text = "Max. price:";
            DisplayNewLabelOnPanel(label22, panelProducts, label21, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght(label22Text), SMALLTEXT }, label22Text, standardFont);

            DisplayNewTextBoxOnPanel(textBox9, panelProducts, new int[2] { textBox8.Location.X, label21.Location.Y },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");

            DisplayNewTextBoxOnPanel(textBox10, panelProducts, new int[2] { textBox9.Location.X, label22.Location.Y },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");
            
            string checkBox2Text = "Category";
            DisplayCheckBox(checkBox2, panelProducts, label22, new int[2] { 0, 2 * yItemsSpace },
                            new int[2] { CalculateLabelLenght(checkBox2Text), SMALLTEXT }, checkBox2Text, standardFont);

            DisplayListBox(listBox1, panelProducts, checkBox2, new int[2] { 0, 2 * yItemsSpace },
                        new int[2] { 140, 60 },"Category", BindCategories());

            string checkBox3Text = "Manufacturer";
            DisplayCheckBox(checkBox3, panelProducts, listBox1, new int[2] { 0, 2 * yItemsSpace },
                            new int[2] { CalculateLabelLenght(checkBox2Text), SMALLTEXT }, checkBox3Text, standardFont);

            DisplayListBox(listBox2, panelProducts, checkBox3, new int[2] { 0, 2 * yItemsSpace },
                        new int[2] { 140, 60 }, "Manufacturer", BindManufacturers());

            int label23PosX = label19.Location.X + label19.Size.Width + 20 * yItemsSpace;
            int label23PosY = label19.Location.Y;
            string label23Text = "Product found:";
            DisplayNewLabelOnPanel(label23, panelProducts, new int[2] { label23PosX, label23PosY }, new int[2]
                { CalculateLabelLenght(label23Text), SMALLTEXT }, label23Text);

            int dataGridView7PosX = label23.Location.X;
            int dataGridView7PosY = label23.Location.Y + label23.Size.Height + 4 * yItemsSpace;
            DisplayNewDataGridViewOnPanel(dataGridView7, panelProducts, new int[2]
                { dataGridView7PosX, dataGridView7PosY}, new int[2] { 650, 150 });
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView7.CellContentClick += new DataGridViewCellEventHandler(dataGridView7_CellContentClick);

            int label24PosX = dataGridView7.Location.X ;
            int label24PosY = dataGridView7.Location.Y + dataGridView7.Size.Height + 2 * yItemsSpace;
            string label24Text = "Product specification:";
            DisplayNewLabelOnPanel(label24, panelProducts, new int[2] { label24PosX, label24PosY }, new int[2]
                { CalculateLabelLenght(label24Text), SMALLTEXT }, label24Text);

            DisplayNewRichTextBoxOnPanel(richTextBox6, panelProducts, label24, new int[2] { 0, yItemsSpace }, new int[2]
                { label24.Size.Width, 100}, "richTextBox6", standardFont);
            this.richTextBox6.ReadOnly = true;

            DisplayNewButtonOnPanel(button33, panelProducts, richTextBox6, new int[2] { 4 * xItemsSpace, 0 }, new int[2]
                { LONGITEM, SMALLTEXT }, "Add to cart", standardFont);
            this.button33.Click += new System.EventHandler(this.button33_Click);

            DisplayNewButtonOnPanel(button34, panelProducts, button33, new int[2] { 0, 2*yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Add to wishlist", standardFont);
            this.button34.Click += new System.EventHandler(this.button34_Click);

            //DisplayNewTextBoxOnPanel(textBox11, panelProducts, button33, new int[2] { 2*xItemsSpace, 0 },
            //    new int[2] { STDTEXTBOX, SMALLTEXT }, "");
            DisplayNumericUpDownOnPanel(numericUpDown1, panelProducts, button33, new int[2] { 2 * xItemsSpace, 0 },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "", standardFont);

            DisplayNewPanel(panelWishList, new int[2] { StandardPanel.PosX, StandardPanel.PosY },
                            new int[2] { StandardPanel.X, StandardPanel.Y }, "panelProducts", true);
            this.Controls.Add(this.panelWishList);
            panelWishList.Hide();

            DisplayNewLabelOnPanel(label27, panelWishList, new int[2] { xMargin, yMargin }, new int[2]
                { CalculateLabelLenght(label27.Text), SMALLTEXT }, "Wish list");

            //DisplayListBox(listBox3, panelWishList, label27, new int[2] { 0, 2 * yItemsSpace },
            //            new int[2] { 140, 60 }, "listBox3", BindWishListPIDs(crtUser));

            DisplayListBox(listBox3, panelWishList, label27, new int[2] { 0, 2 * yItemsSpace },
                       new int[2] { 200, 100 }, "listBox3", BindWishListProducts(crtUser));

            DisplayNewButtonOnPanel(button36, panelWishList, label27, new int[2] { 8 * xItemsSpace, 0 }, new int[2]
                { LONGITEM, SMALLTEXT }, "Show wish List", standardFont);
            this.button36.Click += new System.EventHandler(this.button36_Click);
            button36.Hide();

            DisplayNewPanel(panelShoppingCart, new int[2] { StandardPanel.PosX, StandardPanel.PosY },
                            new int[2] { StandardPanel.X, StandardPanel.Y }, "panelShoppingCart", true);
            this.Controls.Add(this.panelShoppingCart);
            panelShoppingCart.Hide();

            DisplayNewLabelOnPanel(label28, panelShoppingCart, new int[2] { xMargin, yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Shopping Cart");

            DisplayListBox(listBox4, panelShoppingCart, label28, new int[2] { 0, 2 * yItemsSpace },
                       new int[2] { 200, 100 }, "listBox4", BindCartProducts(crtUser));

            DisplayNewButtonOnPanel(button37, panelShoppingCart, listBox4, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Remove selection", standardFont);
            this.button37.Click += new System.EventHandler(this.button37_Click);

            DisplayNewButtonOnPanel(button38, panelShoppingCart, button37, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Checkout", standardFont);
            this.button38.Click += new System.EventHandler(this.button38_Click);

            DisplayNewPanel(panelTransactions, new int[2] { StandardPanel.PosX, StandardPanel.PosY },
                            new int[2] { StandardPanel.X, StandardPanel.Y }, "panelTransactions", true);
            this.Controls.Add(this.panelTransactions);
            panelTransactions.Hide();

            DisplayNewLabelOnPanel(label29, panelTransactions, new int[2] { xMargin, yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Transactions");

            int dataGridView8PosX = label29.Location.X;
            int dataGridView8PosY = label9.Location.Y + label9.Size.Height + 4 * yItemsSpace;
            DisplayNewDataGridViewOnPanel(dataGridView8, panelTransactions, new int[2]
                { dataGridView8PosX, dataGridView8PosY}, new int[2] { 350, 150 });
            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView8.CellContentClick += new DataGridViewCellEventHandler(dataGridView8_CellContentClick);


            DisplayNewRichTextBoxOnPanel(richTextBox7, panelTransactions, dataGridView8, new int[2] { 4*xItemsSpace, 0 }, new int[2]
                { dataGridView8.Size.Width, dataGridView8.Size.Height}, "richTextBox7", standardFont);
            this.richTextBox7.ReadOnly = true;


        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private string crtUser = Model.IOMethods.GetUserName();

        private System.Windows.Forms.Button buttonShoppingCart1;

        private System.Windows.Forms.Panel panelMessage1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;

        private System.Windows.Forms.Panel panelInbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel panelSent1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox2;

        private System.Windows.Forms.Panel panelDeleted1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.RichTextBox richTextBox3;

        private System.Windows.Forms.Panel panelSpam1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.RichTextBox richTextBox4;

        private System.Windows.Forms.Panel panelCompose1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;

        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Panel panelWishList;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button36;

        private System.Windows.Forms.Panel panelShoppingCart;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;

        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private OpenFileDialog openFileDialog1;
    }
}