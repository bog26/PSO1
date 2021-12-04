
using System.Windows.Forms;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using System.Collections.Generic;
using PSO1.Model;

namespace PSO1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN ACCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(44, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 160);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit user rights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "User information";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add new Admin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account administration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1070, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "LOG OUT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(44, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 128);
            this.panel2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(24, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Delete Product";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Products";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Warehouse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store administration";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(44, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 189);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(24, 158);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 23);
            this.button13.TabIndex = 5;
            this.button13.Text = "Create offers";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 128);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "Dashboard";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 98);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Transactions";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Reviews";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 37);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Clients";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sales";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button14);
            this.panel4.Location = new System.Drawing.Point(44, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 43);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button14.Location = new System.Drawing.Point(21, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 36);
            this.button14.TabIndex = 0;
            this.button14.Text = "Messages";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::PSO1.Properties.Resources._260161;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button1;

        //Form4 manual-added components //TBD
        struct ControlDimensions
        {
            public int X;
            public int Y;
        }
        
        private void InitializeManualAddedComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));

            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();

            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();

            this.panel10 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();

            this.panel11 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();

            this.panel12 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button29 = new System.Windows.Forms.Button();

            this.panel13 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.button47 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button50 = new System.Windows.Forms.Button();

            this.panel14 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();

            this.panel15 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();

            this.panel16 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button40 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();


            this.panel17 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();

            this.panel18 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button45 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();

            this.panel19 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button46 = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();

            this.panel20 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();

            this.panel21 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();

            this.panelWarehouse = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.button51 = new System.Windows.Forms.Button();
            this.noStockAlarmSubPanel = new System.Windows.Forms.Panel();
            this.existingStockAlarmSubPanel = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.button52 = new System.Windows.Forms.Button();


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
            ControlDimensions EmailBox;
            EmailBox.X = LargeEmailPanel.X / 2 - 3 * xMargin;
            EmailBox.Y = LargeEmailPanel.Y / 2 - 4 * yMargin - 20;

            var standardFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            DisplayNewPanel(panel8, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel8", true);
            this.Controls.Add(this.panel8);
            panel8.Hide();

            

            string label10Text = "Please add product main characteristics";
            int xPosLabel10 = 3 * xMargin;
            int yPosLabel10 = yMargin;
            int sizeXLabel10 = CalculateLabelLenght(label10Text);
            int sizeYLabel10 = 24;
            DisplayNewLabelOnPanel(label10, panel8, new int[2] { xPosLabel10, yPosLabel10 }, new int[2]
                { sizeXLabel10, sizeYLabel10 }, label10Text);

            string label11Text = "Category";
            int xPosLabel11 = 3 * xMargin;
            int yPosLabel11 = yPosLabel10 + sizeYLabel10 + 6 * yItemsSpace;
            int sizeXLabel11 = CalculateLabelLenght(label11Text);
            int sizeYLabel11 = 24;
            DisplayNewLabelOnPanel(label11, panel8, new int[2] { xPosLabel11, yPosLabel11 }, new int[2]
                { sizeXLabel11, sizeYLabel11 }, label11Text);

            int xPosTextBox5 = xPosLabel11;
            int yPosTextBox5 = yPosLabel11 + sizeYLabel11 + 3*yItemsSpace;
            int sizeXTextBox5 = 120;
            int sizeYTextBox5 = 24;
            DisplayNewTextBoxOnPanel(textBox5, panel8, new int[2] { xPosTextBox5, yPosTextBox5 }, new int[2]
                { sizeXTextBox5, sizeYTextBox5 }, "new category");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);

            int xPosButton22 = xPosTextBox5;
            int yPosButton22 = yPosTextBox5 + sizeYTextBox5 + 3*yItemsSpace;
            int sizeXButton22 = 40;
            int sizeYButton22 = 24;
            DisplayNewButtonOnPanel(button22, panel8, new int[2] { xPosButton22, yPosButton22 }, new int[2]
                { sizeXButton22, sizeYButton22 }, "button22", "Add");
            this.button22.Click += new System.EventHandler(this.button22_Click);


            string label12Text = "Manufacturer";
            int xPosLabel12 = xPosLabel11 + sizeXLabel11 + xItemsSpace * 32;
            int yPosLabel12 = yPosLabel11;
            int sizeXLabel12 = CalculateLabelLenght(label12Text);
            int sizeYLabel12 = 24;
            DisplayNewLabelOnPanel(label12, panel8, new int[2] { xPosLabel12, yPosLabel12 }, new int[2]
                { sizeXLabel12, sizeYLabel12 }, label12Text);

            int xPosTextBox6 = xPosLabel12;
            int yPosTextBox6 = yPosLabel12 + sizeYLabel12 + yItemsSpace*3;
            int sizeXTextBox6 = 120;
            int sizeYTextBox6 = 24;
            DisplayNewTextBoxOnPanel(textBox6, panel8, new int[2] { xPosTextBox6, yPosTextBox6 }, new int[2]
                { sizeXTextBox6, sizeYTextBox6 }, "new manufacturer");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);

            int xPosButton23 = xPosTextBox6;
            int yPosButton23 = yPosTextBox6 + sizeYTextBox6 + yItemsSpace*3;
            int sizeXButton23 = 40;
            int sizeYButton23 = 24;
            DisplayNewButtonOnPanel(button23, panel8, new int[2] { xPosButton23, yPosButton23 }, new int[2]
                { sizeXButton23, sizeYButton23 }, "button23", "Add");
            this.button23.Click += new System.EventHandler(this.button23_Click);


            DisplayNewPanel(panel9, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel9", true);
            this.Controls.Add(this.panel9);
            panel9.Hide();

            string label14Text = "Please add product secondary characteristics";
            int xPosLabel14 = 3 * xMargin;
            int yPosLabel14 = yMargin;
            int sizeXLabel14 = CalculateLabelLenght(label14Text);
            int sizeYLabel14 = 24;
            DisplayNewLabelOnPanel(label14, panel9, new int[2] { xPosLabel14, yPosLabel14 }, new int[2]
                { sizeXLabel14, sizeYLabel14 }, label14Text);

            string label13Text = "Subcategory";
            int xPosLabel13 = xPosLabel14;
            int yPosLabel13 = yPosLabel14 + sizeYLabel14 + 6 * yItemsSpace;
            int sizeXLabel13 = CalculateLabelLenght(label13Text);
            int sizeYLabel13 = 24;
            DisplayNewLabelOnPanel(label13, panel9, new int[2] { xPosLabel13, yPosLabel13 }, new int[2]
                { sizeXLabel13, sizeYLabel13 }, label13Text);

            string label15Text = "Category";
            int xPosLabel15 = xPosLabel13 + sizeXLabel13 + 16 * xItemsSpace;
            int yPosLabel15 = yPosLabel13;
            int sizeXLabel15 = CalculateLabelLenght(label13Text);
            int sizeYLabel15 = 24;
            DisplayNewLabelOnPanel(label15, panel9, new int[2] { xPosLabel15, yPosLabel15 }, new int[2]
                { sizeXLabel15, sizeYLabel15 }, label15Text);

            int xPosTextBox7 = xPosLabel13;
            int yPosTextBox7 = yPosLabel13 + sizeYLabel13 + 3*yItemsSpace;
            int sizeXTextBox7 = 120;
            int sizeYTextBox7 = 24;
            DisplayNewTextBoxOnPanel(textBox7, panel9, new int[2] { xPosTextBox7, yPosTextBox7 }, new int[2]
                { sizeXTextBox7, sizeYTextBox7 }, "new subcategory");
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);

            string listBox1Text = "Select Category";
            int xlistBox1 = xPosLabel15;
            int ylistBox1 = yPosTextBox7;
            int sizeXlistBox1 = 140;
            int sizeYlistBox1 = 90;
            DisplayListBox(listBox1, panel9, new int[2] { xlistBox1, ylistBox1 }, new int[2]
                { sizeXlistBox1, sizeYlistBox1 }, listBox1Text, BindCategories());
            //listBox1.DataSource = BindCategories();
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);

            int xPosButton24 = xPosTextBox7;
            int yPosButton24 = yPosTextBox7 + sizeYTextBox7 + 3*yItemsSpace;
            int sizeXButton24 = 40;
            int sizeYButton24 = 24;
            DisplayNewButtonOnPanel(button24, panel9, new int[2] { xPosButton24, yPosButton24 }, new int[2]
                { sizeXButton24, sizeYButton24 }, "button24", "Add");
            this.button24.Click += new System.EventHandler(this.button24_Click);

            DisplayNewPanel(panel10, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel10", true);
            this.Controls.Add(this.panel10);
            panel10.Hide();

            string label16Text = "Please fill all product fields";
            int xPosLabel16 = 3 * xMargin;
            int yPosLabel16 = yMargin;
            int sizeXLabel16 = CalculateLabelLenght(label16Text);
            int sizeYLabel16 = 24;
            DisplayNewLabelOnPanel(label16, panel10, new int[2] { xPosLabel16, yPosLabel16 }, new int[2]
                { sizeXLabel16, sizeYLabel16 }, label16Text);

            string label17Text = "Product name:";
            int xPosLabel17 = xPosLabel16;
            int yPosLabel17 = yPosLabel16 + sizeYLabel16 + 6 * yItemsSpace;
            int sizeXLabel17 = CalculateLabelLenght(label17Text);
            int sizeYLabel17 = 24;
            DisplayNewLabelOnPanel(label17, panel10, new int[2] { xPosLabel17, yPosLabel17 }, new int[2]
                { sizeXLabel17, sizeYLabel17 }, label17Text);

            string label18Text = "Product model:";
            int xPosLabel18 = xPosLabel17 + sizeXLabel17 + 32 * xItemsSpace;
            int yPosLabel18 = yPosLabel17;
            int sizeXLabel18 = CalculateLabelLenght(label17Text);
            int sizeYLabel18 = 24;
            DisplayNewLabelOnPanel(label18, panel10, new int[2] { xPosLabel18, yPosLabel18 }, new int[2]
                { sizeXLabel18, sizeYLabel18 }, label18Text);

            int xPosTextBox8 = xPosLabel17;
            int yPosTextBox8 = yPosLabel17 + sizeYLabel17 + yItemsSpace;
            int sizeXTextBox8 = 130;
            int sizeYTextBox8 = 24;
            DisplayNewTextBoxOnPanel(textBox8, panel10, new int[2] { xPosTextBox8, yPosTextBox8 }, new int[2]
                { sizeXTextBox8, sizeYTextBox8 }, "Product name");
            //textBox8.TextChanged += new EventHandler(textBox8_TextChanged);

            int xPosTextBox9 = xPosLabel18;
            int yPosTextBox9 = yPosLabel18 + sizeYLabel18 + yItemsSpace;
            int sizeXTextBox9 = 130;
            int sizeYTextBox9 = 24;
            DisplayNewTextBoxOnPanel(textBox9, panel10, new int[2] { xPosTextBox9, yPosTextBox9 }, new int[2]
                { sizeXTextBox9, sizeYTextBox9 }, "Product model");
            //textBox9.TextChanged += new EventHandler(textBox9_TextChanged);

            string label19Text = "Manufacturer:";
            int xPosLabel19 = xPosLabel17;
            int yPosLabel19 = yPosTextBox8 + sizeYTextBox8 + yItemsSpace;
            int sizeXLabel19 = CalculateLabelLenght(label19Text);
            int sizeYLabel19 = 24;
            DisplayNewLabelOnPanel(label19, panel10, new int[2] { xPosLabel19, yPosLabel19 }, new int[2]
                { sizeXLabel19, sizeYLabel19 }, label19Text);

            string label20Text = "Subcategory:";
            int xPosLabel20 = xPosLabel18;
            int yPosLabel20 = yPosTextBox9 + sizeYTextBox9 + yItemsSpace;
            int sizeXLabel20 = CalculateLabelLenght(label20Text);
            int sizeYLabel20 = 24;
            DisplayNewLabelOnPanel(label20, panel10, new int[2] { xPosLabel20, yPosLabel20 }, new int[2]
                { sizeXLabel20, sizeYLabel20 }, label20Text);

            string listBox2Text = "Select Manufacturer";
            int xlistBox2 = xPosLabel19;
            int ylistBox2 = yPosLabel19 + sizeYLabel19 + yItemsSpace;
            int sizeXlistBox2 = 140;
            int sizeYlistBox2 = 70;
            DisplayListBox(listBox2, panel10, new int[2] { xlistBox2, ylistBox2 }, new int[2]
                { sizeXlistBox2, sizeYlistBox2 }, listBox2Text, BindManufacturers());
            //listBox2.DataSource = BindManufacturers();  
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);

            string listBox3Text = "Select subcategory";
            int xlistBox3 = xPosLabel20;
            int ylistBox3 = yPosLabel20 + sizeYLabel20 + yItemsSpace;
            int sizeXlistBox3 = 140;
            int sizeYlistBox3 = 70;
            DisplayListBox(listBox3, panel10, new int[2] { xlistBox3, ylistBox3 }, new int[2]
                { sizeXlistBox3, sizeYlistBox3 }, listBox3Text, BindSubcategories());
            //listBox2.DataSource = BindManufacturers();
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);

            string label21Text = "Starting stock:";
            int xPosLabel21 = xPosLabel19;
            int yPosLabel21 = ylistBox2 + sizeYlistBox2 + yItemsSpace;
            int sizeXLabel21 = CalculateLabelLenght(label21Text);
            int sizeYLabel21 = 24;
            DisplayNewLabelOnPanel(label21, panel10, new int[2] { xPosLabel21, yPosLabel21 }, new int[2]
                { sizeXLabel21, sizeYLabel21 }, label21Text);

            string label22Text = "Sell price:";
            int xPosLabel22 = xPosLabel21 + sizeXLabel21 + 16 * xItemsSpace;
            int yPosLabel22 = yPosLabel21;
            int sizeXLabel22 = CalculateLabelLenght(label22Text);
            int sizeYLabel22 = 24;
            DisplayNewLabelOnPanel(label22, panel10, new int[2] { xPosLabel22, yPosLabel22 }, new int[2]
                { sizeXLabel22, sizeYLabel22 }, label22Text);

            string label23Text = "Supplier price:";
            int xPosLabel23 = xPosLabel22 + sizeXLabel22 + 16 * xItemsSpace;
            int yPosLabel23 = yPosLabel21;
            int sizeXLabel23 = CalculateLabelLenght(label22Text);
            int sizeYLabel23 = 24;
            DisplayNewLabelOnPanel(label23, panel10, new int[2] { xPosLabel23, yPosLabel23 }, new int[2]
                { sizeXLabel23, sizeYLabel23 }, label23Text);

            int xPosTextBox10 = xPosLabel21;
            int yPosTextBox10 = yPosLabel21 + sizeYLabel21 + 3*yItemsSpace;
            int sizeXTextBox10 = 70;
            int sizeYTextBox10 = 24;
            DisplayNewTextBoxOnPanel(textBox10, panel10, new int[2] { xPosTextBox10, yPosTextBox10 }, new int[2]
                { sizeXTextBox10, sizeYTextBox10 }, "Stock");
            //textBox10.TextChanged += new EventHandler(textBox10_TextChanged);

            int xPosTextBox11 = xPosLabel22;
            int yPosTextBox11 = yPosLabel22 + sizeYLabel22 + 3*yItemsSpace;
            int sizeXTextBox11 = 70;
            int sizeYTextBox11 = 24;
            DisplayNewTextBoxOnPanel(textBox11, panel10, new int[2] { xPosTextBox11, yPosTextBox11 }, new int[2]
                { sizeXTextBox11, sizeYTextBox11 }, "sell price");
            //textBox11.TextChanged += new EventHandler(textBox11_TextChanged);

            int xPosTextBox12 = xPosLabel23;
            int yPosTextBox12 = yPosLabel23 + sizeYLabel22 + 3*yItemsSpace;
            int sizeXTextBox12 = 70;
            int sizeYTextBox12 = 24;
            DisplayNewTextBoxOnPanel(textBox12, panel10, new int[2] { xPosTextBox12, yPosTextBox12 }, new int[2]
                { sizeXTextBox12, sizeYTextBox12 }, "Supplier price");

            string Button25Text = "Add product to DB";
            int xPosButton25 = xPosLabel16 + sizeXLabel16 + 24 * xItemsSpace;
            int yPosButton25 = yPosLabel16;
            int sizeXButton25 = CalculateLabelLenght(Button25Text) * 2;
            int sizeYButton25 = 24;
            DisplayNewButtonOnPanel(button25, panel10, new int[2] { xPosButton25, yPosButton25 }, new int[2]
                { sizeXButton25, sizeYButton25 }, "button25", Button25Text);
            this.button25.Click += new System.EventHandler(this.button25_Click);

            DisplayNewPanel(panel11, new int[2] { 300, 82 }, new int[2] { 180, 450 }, "panel11", true);
            this.Controls.Add(this.panel11);
            panel11.Hide();

            int xPosButton19 = origX;
            int yPosButton19 = origY;
            int sizeXButton19 = 140;
            int sizeYButton19 = 24;
            DisplayNewButtonOnPanel(button19, panel11, new int[2] { origX, origY }, new int[2] { sizeXButton19, sizeYButton19 },
                "button19", "Add main characteristics");
            this.button19.Click += new System.EventHandler(this.button19_Click);

            int xPosButton20 = xPosButton19;
            int yPosButton20 = yPosButton19 + sizeYButton19 + 3*yItemsSpace;
            int sizeXButton20 = 140;
            int sizeYButton20 = 24;
            DisplayNewButtonOnPanel(button20, panel11, new int[2] { xPosButton20, yPosButton20 }, new int[2]
                { sizeXButton20, sizeYButton20 }, "button20", "Add sec characteristics");
            this.button20.Click += new System.EventHandler(this.button20_Click);

            int xPosButton21 = xPosButton19;
            int yPosButton21 = yPosButton20 + sizeYButton20 + 3*yItemsSpace;
            int sizeXButton21 = 140;
            int sizeYButton21 = 24;
            DisplayNewButtonOnPanel(button21, panel11, new int[2] { xPosButton21, yPosButton21 }, new int[2]
                { sizeXButton21, sizeYButton21 }, "button21", "Add product");
            this.button21.Click += new System.EventHandler(this.button21_Click);

            int xPosButton26 = xPosButton19;
            int yPosButton26 = yPosButton21 + sizeYButton21 + 3*yItemsSpace;
            int sizeXButton26 = 140;
            int sizeYButton26 = 24;
            DisplayNewButtonOnPanel(button26, panel11, new int[2] { xPosButton26, yPosButton26 }, new int[2]
                { sizeXButton26, sizeYButton26 }, "button26", "Search products");
            this.button26.Click += new System.EventHandler(this.button26_Click);

            DisplayNewPanel(panel12, new int[2] { 300, 82 }, new int[2] { 180, 450 }, "panel12", true);
            this.Controls.Add(this.panel12);
            panel12.Hide();

            string label24Text = "Product search:";
            int xPosLabel24 = xMargin;
            int yPosLabel24 = yMargin;
            int sizeXLabel24 = CalculateLabelLenght(label24Text);
            int sizeYLabel24 = 24;
            
            DisplayNewLabelOnPanel(label24, panel12, new int[2] { xPosLabel24, yPosLabel24 }, new int[2]
                { sizeXLabel24, sizeYLabel24 }, label24Text);

            DisplayNewButtonOnPanel(button27, panel12, label24, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Back", standardFont);
            this.button27.Click += new System.EventHandler(this.button27_Click);

            DisplayNewButtonOnPanel(button28, panel12, button27, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Search", standardFont);

            this.button28.Click += new System.EventHandler(this.button28_Click);

            string label26Text = "Key words:";

            DisplayNewLabelOnPanel(label26, panel12, button28, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght(label26Text), SMALLTEXT }, label26Text, standardFont);

            DisplayNewTextBoxOnPanel(textBox13, panel12, label26, new int[2] { xItemsSpace, 0 },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");

            string label27Text = "Min. price: ";
            DisplayNewLabelOnPanel(label27, panel12, label26, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght(label27Text), SMALLTEXT }, label27Text, standardFont);

            string label28Text = "Max. price:";
            DisplayNewLabelOnPanel(label28, panel12, label27, new int[2] { 0, yItemsSpace },
                new int[2] { CalculateLabelLenght(label28Text), SMALLTEXT }, label28Text, standardFont);

            DisplayNewTextBoxOnPanel(textBox14, panel12,  new int[2] { textBox13.Location.X, label27.Location.Y },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");

            DisplayNewTextBoxOnPanel(textBox15, panel12, new int[2] { textBox13.Location.X, label28.Location.Y },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "");

   
            string checkBox1Text = "Category";
            DisplayCheckBox(checkBox1, panel12, label28, new int[2] { 0, 2*yItemsSpace },
                            new int[2] { CalculateLabelLenght(checkBox1Text), SMALLTEXT }, checkBox1Text, standardFont);
            

            List<int[]> SizeAndSpaceListBox4 = new List<int[]>();
            int[] sizeListBox4 = {140, 60};
            SizeAndSpaceListBox4.Add(sizeListBox4);
            int[] spacersListBox4 = { 0, 3*yItemsSpace };
            SizeAndSpaceListBox4.Add(spacersListBox4);
            int[] spaceFactorListBox4 = { 1, 0 };
            SizeAndSpaceListBox4.Add(spaceFactorListBox4);
            DisplayListBox(listBox4, panel12, checkBox1, SizeAndSpaceListBox4, "Category", BindCategories());
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);


            string checkBox2Text = "Manufacturer";
            DisplayCheckBox(checkBox2, panel12, listBox4, new int[2] { 0, yItemsSpace },
                            new int[2] { CalculateLabelLenght(checkBox2Text), SMALLTEXT }, checkBox2Text, standardFont);

            List<int[]> SizeAndSpaceListBox5 = new List<int[]>();
            int[] sizeListBox5 = { 140, 60 };
            SizeAndSpaceListBox5.Add(sizeListBox5);
            int[] spacersListBox5 = { 0, 3*yItemsSpace };
            SizeAndSpaceListBox5.Add(spacersListBox5);
            int[] spaceFactorListBox5 = { 1, 0 };
            SizeAndSpaceListBox4.Add(spaceFactorListBox4);
            DisplayListBox(listBox5, panel12, checkBox2, SizeAndSpaceListBox4, "Manufacturer", BindManufacturers());
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);

            DisplayNewPanel(panel13, new int[2] { 550, 82 }, new int[2] { 610, 450 }, "panel13", true);
            this.Controls.Add(this.panel13);
            panel13.Hide();

            string label25Text = "Products found:";
            int xPosLabel25 = xMargin;
            int yPosLabel25 = yMargin;
            int sizeXLabel25 = CalculateLabelLenght(label25Text);
            int sizeYLabel25 = 24;
            DisplayNewLabelOnPanel(label25, panel13, new int[2] { xPosLabel25, yPosLabel25 }, new int[2]
                { sizeXLabel25, sizeYLabel25 }, label25Text);

            int xPosDataGridView3 = xPosLabel25;
            int yPosDataGridView3 = yPosLabel25 + sizeYLabel25 + 3*yItemsSpace;
            int sizeXDataGridView3 = 600;
            int sizeYDataGridView3 = 150;
            DisplayNewDataGridViewOnPanel(dataGridView3, panel13, new int[2]
                { xPosDataGridView3, yPosDataGridView3}, new int[2] { sizeXDataGridView3, sizeYDataGridView3 });

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.CellContentClick += new DataGridViewCellEventHandler(dataGridView3_CellContentClick);

            string checkBox3Text = "Enable update";
            DisplayCheckBox(checkBox3, panel13, dataGridView3, new int[2] { 0, 2*yItemsSpace },
                            new int[2] { CalculateLabelLenght(checkBox3Text), SMALLTEXT }, checkBox3Text, standardFont);

            DisplayNewButtonOnPanel(button30, panel13, checkBox3, new int[2] { 0, 2*yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Update", standardFont);
            this.button30.Click += new System.EventHandler(this.button30_Click);

            DisplayNewTextBoxOnPanel(textBox16, panel13, new int[2] { button30.Location.X + button30.Width + xItemsSpace, button30.Location.Y + 3 },
                new int[2] { LONGITEM, SMALLTEXT }, "value");

            DisplayNewButtonOnPanel(button47, panel13, button30, new int[2] { 0, 2*yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Select file", standardFont);
            this.button47.Click += new System.EventHandler(this.button47_Click);

            DisplayNewTextBoxOnPanel(textBox21, panel13, new int[2] { button47.Location.X + button30.Width + xItemsSpace, button47.Location.Y + 3 },
                new int[2] { LONGITEM, SMALLTEXT }, "file content");

            this.openFileDialog1.FileName = "openFileDialog1";

            DisplayNewButtonOnPanel(button48, panel13, button47, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Upload image", standardFont);
            this.button48.Click += new System.EventHandler(this.button48_Click);

            DisplayNewButtonOnPanel(button49, panel13, button48, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Upload spec sheet", standardFont);
            this.button49.Click += new System.EventHandler(this.button49_Click);

            DisplayNewButtonOnPanel(button50, panel13, button49, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Download spec sheet", standardFont);
            this.button50.Click += new System.EventHandler(this.button50_Click);

            DisplayPicture(pictureBox1, panel13, textBox16, new int[2] { 5*xItemsSpace, 0 }, new int[2]
                { 200, 200 });

            this.saveFileDialog1.FileName = "DataSheet.pdf";


            DisplayNewPanel(panel15, new int[2] { 300, 82 }, new int[2] { 180, 450 }, "panel15", true);
            this.Controls.Add(this.panel15);
            panel15.Hide();
            
            int xPosButton31 = origX;
            int yPosButton31 = origY;
            int sizeXButton31 = 140;
            int sizeYButton31 = 24;
            DisplayNewButtonOnPanel(button31, panel15, new int[2] { origX, origY }, new int[2] { sizeXButton31, sizeYButton31 },
                "button31", "Inbox");
            button31.Font = standardFont;
            this.button31.Click += new System.EventHandler(this.button31_Click);

            DisplayNewButtonOnPanel(button32, panel15, button31, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Sent", standardFont);
            this.button32.Click += new System.EventHandler(this.button32_Click);

            DisplayNewButtonOnPanel(button33, panel15, button32, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Deleted", standardFont);
            this.button33.Click += new System.EventHandler(this.button33_Click);

            DisplayNewButtonOnPanel(button34, panel15, button33, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Spam", standardFont);
            this.button34.Click += new System.EventHandler(this.button34_Click);

            DisplayNewButtonOnPanel(button35, panel15, button34, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Compose", standardFont);
            this.button35.Click += new System.EventHandler(this.button35_Click);

            
            DisplayNewPanel(panel16, new int[2] { 550, 82 }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panel16", true);
            this.Controls.Add(this.panel16);
            panel16.Hide();
            
            string label31Text = "Inbox";
            int xPosLabel31 = xMargin;
            int yPosLabel31 = yMargin;
            int sizeXLabel31 = CalculateLabelLenght(label24Text);
            int sizeYLabel31 = 24;
            DisplayNewLabelOnPanel(label31, panel16, new int[2] { xPosLabel31, yPosLabel31 }, new int[2]
                { sizeXLabel31, sizeYLabel31 }, label31Text);


            DisplayNewDataGridViewOnPanel(dataGridView4, panel16, new int[2]
                                        { label31.Location.X, label31.Location.Y+label31.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.CellContentClick += new DataGridViewCellEventHandler(dataGridView4_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox2, panel16, dataGridView4, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox2", standardFont);

            DisplayNewButtonOnPanel(button38, panel16, label31, new int[2] { 10 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Delete", standardFont);
            this.button38.Click += new System.EventHandler(this.button38_Click);

            DisplayNewButtonOnPanel(button40, panel16, button38, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Spam", standardFont);
            this.button40.Click += new System.EventHandler(this.button40_Click);

            DisplayNewButtonOnPanel(button43, panel16, button40, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Reply", standardFont);
            this.button43.Click += new System.EventHandler(this.button43_Click);

            DisplayNewButtonOnPanel(button44, panel16, button43, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "FWD", standardFont);
            this.button44.Click += new System.EventHandler(this.button44_Click);

            DisplayNewButtonOnPanel(button39, panel16, dataGridView4, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Search", standardFont);
            this.button39.Click += new System.EventHandler(this.button39_Click);

            DisplayNewTextBoxOnPanel(textBox20, panel16, button39, new int[2] { 0, 2 * xItemsSpace },
              new int[2] { MEDIUMITEM, SMALLTEXT }, "");

            DisplayNewPanel(panel17, new int[2] { 550, 82 }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panel17", true);
            this.Controls.Add(this.panel17);
            panel17.Hide();

            string label32Text = "Sent";
            int xPosLabel32 = xMargin;
            int yPosLabel32 = yMargin;
            int sizeXLabel32 = CalculateLabelLenght(label32Text);
            int sizeYLabel32 = 24;
            DisplayNewLabelOnPanel(label32, panel17, new int[2] { xPosLabel32, yPosLabel32 }, new int[2]
                { sizeXLabel32, sizeYLabel32 }, label32Text);

            DisplayNewDataGridViewOnPanel(dataGridView5, panel17, new int[2]
                                        { label32.Location.X, label32.Location.Y+label32.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.CellContentClick += new DataGridViewCellEventHandler(dataGridView5_CellContentClick);

            DisplayNewRichTextBoxOnPanel(richTextBox3, panel17, dataGridView5, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox3", standardFont);

            DisplayNewButtonOnPanel(button42, panel17, label32, new int[2] { 10 * xItemsSpace, 0 }, new int[2]
                { MEDIUMITEM, SMALLTEXT }, "Delete", standardFont);
            this.button42.Click += new System.EventHandler(this.button42_Click);

            DisplayNewPanel(panel18, new int[2] { 550, 82 }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panel18", true);
            this.Controls.Add(this.panel18);
            panel18.Hide();

            string label33Text = "Deleted";
            int xPosLabel33 = xMargin;
            int yPosLabel33 = yMargin;
            int sizeXLabel33 = CalculateLabelLenght(label33Text);
            int sizeYLabel33 = 24;
            DisplayNewLabelOnPanel(label33, panel18, new int[2] { xPosLabel33, yPosLabel33 }, new int[2]
                { sizeXLabel33, sizeYLabel33 }, label33Text);

            DisplayNewDataGridViewOnPanel(dataGridView6, panel18, new int[2]
                                        { label33.Location.X, label33.Location.Y+label33.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.CellContentClick += new DataGridViewCellEventHandler(dataGridView6_CellContentClick);
       
            DisplayNewRichTextBoxOnPanel(richTextBox4, panel18, dataGridView6, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox4", standardFont);

            DisplayNewPanel(panel19, new int[2] { 550, 82 }, new int[2] { 610, 450 }, "panel19", true);
            this.Controls.Add(this.panel19);
            panel19.Hide();

            string label34Text = "Spam";
            int xPosLabel34 = xMargin;
            int yPosLabel34 = yMargin;
            int sizeXLabel34 = CalculateLabelLenght(label34Text);
            int sizeYLabel34 = 24;
            DisplayNewLabelOnPanel(label34, panel19, new int[2] { xPosLabel34, yPosLabel34 }, new int[2]
                { sizeXLabel34, sizeYLabel34 }, label34Text);

            DisplayNewDataGridViewOnPanel(dataGridView7, panel19, new int[2]
                                        { label34.Location.X, label34.Location.Y+label34.Size.Height + 2*yItemsSpace},
                                         new int[2] { EmailBox.X, EmailBox.Y });
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView7.CellContentClick += new DataGridViewCellEventHandler(dataGridView7_CellContentClick);

            //DisplayListBox(listBox10, panel19, label34, new int[2] { 0, yItemsSpace }, new int[2] { 100, 200 }, "listBox10", BindSpamMessages(crtUser));

            DisplayNewRichTextBoxOnPanel(richTextBox5, panel19, dataGridView7, new int[2] { 2 * xItemsSpace, 0 }, new int[2]
                { EmailBox.X, EmailBox.Y }, "richTextBox5", standardFont);

            DisplayNewPanel(panel20, new int[2] { 550, 82 }, new int[2] { LargeEmailPanel.X, LargeEmailPanel.Y }, "panel20", true);
            this.Controls.Add(this.panel20);
            panel20.Hide();

            string label35Text = "Compose";
            int xPosLabel35 = xMargin;
            int yPosLabel35 = yMargin;
            int sizeXLabel35 = CalculateLabelLenght(label34Text);
            int sizeYLabel35 = 24;
            DisplayNewLabelOnPanel(label35, panel20, new int[2] { xPosLabel35, yPosLabel35 }, new int[2]
                { sizeXLabel35, sizeYLabel35 }, label35Text);

            DisplayNewLabelOnPanel(label36, panel20, label35, new int[2] { xItemsSpace, yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "To:", standardFont);
            DisplayNewLabelOnPanel(label37, panel20, label36, new int[2] { 0, 2*yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "Title:", standardFont);
            DisplayNewLabelOnPanel(label38, panel20, label37, new int[2] { 0, 2*yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "Message:", standardFont);
            DisplayNewTextBoxOnPanel(textBox17, panel20, new int[2] { label36.Location.X+ label38.Size.Width+ 2*xItemsSpace, 
                label36.Location.Y }, new int[2] { STDTEXTBOX, SMALLTEXT }, "");
            DisplayNewTextBoxOnPanel(textBox18, panel20, textBox17, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "");

            DisplayNewRichTextBoxOnPanel(richTextBox1, panel20, textBox18, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { 400, 200 }, "richTextBox1", standardFont);

            DisplayNewButtonOnPanel(button36, panel20, richTextBox1, new int[2] { 0, yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Send", standardFont);
            this.button36.Click += new System.EventHandler(this.button36_Click);
           
            string checkBox4Text = "encryption";
            DisplayCheckBox(checkBox4, panel20, button36, new int[2] { 5*xItemsSpace, 0 },
                            new int[2] { CalculateLabelLenght(checkBox1Text), SMALLTEXT }, checkBox4Text, standardFont);

            DisplayNewPanel(panel21, new int[2] { 235, 46 }, new int[2] { 900, 350 }, "panel21", true);
            this.Controls.Add(this.panel21);
            panel21.Hide();

            DisplayNewLabelOnPanel(label40, panel21, new int[2] { xMargin, yMargin }, new int[2]
               { 70, 24 }, "Transactions count");

            DisplayNewLabelOnPanel(label39, panel21, label40, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            int xPosLabel41 = label40.Location.X + label40.Size.Width + 8 * xItemsSpace;
            int yPosLabel41 = label40.Location.Y;
            DisplayNewLabelOnPanel(label41, panel21, new int[2] { xPosLabel41, yPosLabel41 }, new int[2]
               { 70, 24 }, "Messages count");

            DisplayNewLabelOnPanel(label42, panel21, label41, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            int xPosLabel43 = label41.Location.X + label41.Size.Width + 8 * xItemsSpace;
            int yPosLabel43 = label41.Location.Y;
            DisplayNewLabelOnPanel(label43, panel21, new int[2] { xPosLabel43, yPosLabel43 }, new int[2]
               { 70, 24 }, "Reviews count");

            DisplayNewLabelOnPanel(label44, panel21, label43, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            int xPosLabel45 = label43.Location.X + label43.Size.Width + 8 * xItemsSpace;
            int yPosLabel45 = label43.Location.Y;
            DisplayNewLabelOnPanel(label45, panel21, new int[2] { xPosLabel45, yPosLabel45 }, new int[2]
               { 70, 24 }, "Sold Products");

            DisplayNewLabelOnPanel(label46, panel21, label45, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            int xPosLabel47 = label45.Location.X + label45.Size.Width + 8 * xItemsSpace;
            int yPosLabel47 = label45.Location.Y;
            DisplayNewLabelOnPanel(label47, panel21, new int[2] { xPosLabel47, yPosLabel47 }, new int[2]
               { 70, 24 }, "Total income");

            DisplayNewLabelOnPanel(label48, panel21, label47, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            int xPosLabel49 = label39.Location.X;
            int yPosLabel49 = label39.Location.Y + label39.Size.Height + 12 * yItemsSpace;
            DisplayNewLabelOnPanel(label49, panel21, new int[2] { xPosLabel49, yPosLabel49 }, new int[2]
               { 70, 24 }, "Total credit bought");

            DisplayNewLabelOnPanel(label50, panel21, label49, new int[2] { 0, 2 * yItemsSpace }, new int[2]
                { SHORTITEM, SMALLTEXT }, "0", standardFont);

            DisplayNewPanel(panelWarehouse, new int[2] { 235, 46 }, new int[2] { 900, 350 }, "panelWarehouse", true);
            this.Controls.Add(this.panelWarehouse);
            panelWarehouse.Hide();

            DisplayNewLabelOnPanel(label53, panelWarehouse, new int[2] { xMargin, yMargin }, new int[2]
            { 70, 24 }, "Warehouse");

            int xPosDataGridView8 = label53.Location.X;
            int yPosDataGridView8 = label53.Location.Y + label53.Size.Height + 3 * yItemsSpace;
            int sizeXDataGridView8 = 400;
            int sizeYDataGridView8 = 150;
            DisplayNewDataGridViewOnPanel(dataGridView8, panelWarehouse, new int[2]
                { xPosDataGridView8, yPosDataGridView8}, new int[2] { sizeXDataGridView8, sizeYDataGridView8 });
            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView8.CellContentClick += new DataGridViewCellEventHandler(dataGridView8_CellContentClick);

            int noStockAlarmSubPanelPosX = dataGridView8.Location.X + dataGridView8.Size.Width + 4 * xItemsSpace;
            int noStockAlarmSubPanelPosY = dataGridView8.Location.Y;
            DisplayNewPanel(noStockAlarmSubPanel, panelWarehouse, new int[2] { noStockAlarmSubPanelPosX, noStockAlarmSubPanelPosY },
                           new int[2] { 200, 150 }, "noStockAlarmSubPanel", true);
            noStockAlarmSubPanel.Hide();

            //int label39PosX = label38.Location.X + 4 * xItemsSpace;
            //int label39PosY = label38.Location.Y + label38.Size.Height + 4 * yItemsSpace;

            string label54Text = "Alarm set:";
            DisplayNewLabelOnPanel(label54, noStockAlarmSubPanel, new int[2] { 4*xMargin, 2*yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT },  label54Text, standardFont);

            string label55Text = "No";
            DisplayNewLabelOnPanel(label55, noStockAlarmSubPanel, label54, new int[2] { 2 * xItemsSpace, 0 },
                new int[2] { CalculateLabelLenght(label55Text), SMALLTEXT }, label55Text, standardFont);
            //label55.Hide();

            DisplayNewButtonOnPanel(button51, noStockAlarmSubPanel, label54, new int[2] { 0, 4*yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Create alarm", standardFont);
            this.button51.Click += new System.EventHandler(this.button51_Click);
            //button51.Hide();


            //existingStockAlarmSubPanel
            int existingStockAlarmSubPanelPosX = dataGridView8.Location.X + dataGridView8.Size.Width + 4 * xItemsSpace;
            int existingStockAlarmSubPanelPosY = dataGridView8.Location.Y;
            DisplayNewPanel(existingStockAlarmSubPanel, panelWarehouse, new int[2] { existingStockAlarmSubPanelPosX, existingStockAlarmSubPanelPosY },
                           new int[2] { 200, 150 }, "existingStockAlarmSubPanel", true);
            existingStockAlarmSubPanel.Hide();

            //int label39PosX = label38.Location.X + 4 * xItemsSpace;
            //int label39PosY = label38.Location.Y + label38.Size.Height + 4 * yItemsSpace;

            string label56Text = "Alarm set:";
            DisplayNewLabelOnPanel(label56, existingStockAlarmSubPanel, new int[2] { 4 * xMargin, 2 * yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, label56Text, standardFont);

            string label57Text = "Yes";
            DisplayNewLabelOnPanel(label57, existingStockAlarmSubPanel, label56, new int[2] { 2 * xItemsSpace, 0 },
                new int[2] { CalculateLabelLenght(label55Text), SMALLTEXT }, label57Text, standardFont);
            //label55.Hide();

            DisplayNewButtonOnPanel(button52, existingStockAlarmSubPanel, label56, new int[2] { 0, 4 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Edit alarm", standardFont);
            this.button52.Click += new System.EventHandler(this.button52_Click);


        }

        private Form7 f7;
        //private OpenDialog f7;
        //OpenDialog
        private bool AlarmDialogOpened = false;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button23;

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button24;

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button25;

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button26;

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button29;

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.TextBox textBox21;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button50;


        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button30;

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;

        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.DataGridView dataGridView4;

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.DataGridView dataGridView5;

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.DataGridView dataGridView6;

        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.DataGridView dataGridView7;

        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button36;
        private string crtUser = Model.IOMethods.GetUserName();
        private System.Windows.Forms.CheckBox checkBox4;


        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;

        private System.Windows.Forms.Panel panelWarehouse;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.Panel noStockAlarmSubPanel;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Panel existingStockAlarmSubPanel;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Button button52;

    }
}