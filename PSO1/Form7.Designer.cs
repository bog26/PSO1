
using System.Drawing;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using System.Windows.Forms;

namespace PSO1
{
    partial class Form7
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
            this.SuspendLayout();
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

            //remove top form controls completely:
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }
        private void InitializeManualAddedComponent(int PID)
        //private void InitializeManualAddedComponent(bool alarm)
        {
            crtProdID = PID;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panelCreateAlarm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEditAlarm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();

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

            var standardFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            var mediumFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            var blueText = SystemColors.HotTrack;
            var blackText = SystemColors.ControlText;

            DisplayNewPanel(panelCreateAlarm, new int[2] { 2*xMargin, yMargin },
                           new int[2] { this.Size.Width-6*xMargin, this.Size.Height - 10*yMargin },
                           "panelCreateAlarm ", true);
            this.Controls.Add(this.panelCreateAlarm);
            panelCreateAlarm.Hide();

            DisplayNewLabelOnPanel(label1, panelCreateAlarm, new int[2] { xMargin, yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Create alarm", mediumFont, blackText);

            DisplayNewLabelOnPanel(label2, panelCreateAlarm, label1, new int[2] { 0, yItemsSpace }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Min Amount", standardFont);

            int numericUpDown1PosX = label2.Location.X + label2.Size.Width + 4 * xItemsSpace;
            int numericUpDown1PosY = label2.Location.Y;
            DisplayNumericUpDownOnPanel(numericUpDown1, panelCreateAlarm, new int[2] { numericUpDown1PosX, numericUpDown1PosY },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "", standardFont);
            numericUpDown1.Minimum = 1;

            DisplayNewButtonOnPanel(button1, panelCreateAlarm, label2, new int[2] { 1, 4 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Create Alarm", standardFont);
            this.button1.Click += new System.EventHandler(this.button1_Click);



            DisplayNewPanel(panelEditAlarm, new int[2] { 2 * xMargin, yMargin },
                           new int[2] { this.Size.Width - 6 * xMargin, this.Size.Height - 10 * yMargin },
                           "panelEditAlarm ", true);
            this.Controls.Add(this.panelEditAlarm);
            panelEditAlarm.Hide();

            DisplayNewLabelOnPanel(label3, panelEditAlarm, new int[2] { xMargin, yMargin }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Edit alarm", mediumFont, blackText);

            DisplayNewLabelOnPanel(label4, panelEditAlarm, label3, new int[2] { 0, yItemsSpace }, new int[2]
                { STDTEXTBOX, SMALLTEXT }, "Min Amount", standardFont);

            int numericUpDown2PosX = label4.Location.X + label4.Size.Width + 4 * xItemsSpace;
            int numericUpDown2PosY = label4.Location.Y;
            DisplayNumericUpDownOnPanel(numericUpDown2, panelEditAlarm, new int[2] { numericUpDown1PosX, numericUpDown1PosY },
                new int[2] { STDTEXTBOX, SMALLTEXT }, "", standardFont);
            numericUpDown2.Minimum = 1;

            DisplayNewButtonOnPanel(button2, panelEditAlarm, label4, new int[2] { 1, 4 * yItemsSpace }, new int[2]
                { LONGITEM, SMALLTEXT }, "Update Alarm", standardFont);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            /*
            if (alarm)
            {
                panelCreateAlarm.Hide();
                panelEditAlarm.Show();
            }
            else
            {
                panelCreateAlarm.Show();
                panelEditAlarm.Hide();
            }
            */

        }
        private int crtProdID;
        private string crtUser = Model.IOMethods.GetUserName();
        private System.Windows.Forms.Panel panelCreateAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEditAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        #endregion
    }
}