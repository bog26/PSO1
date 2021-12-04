using PSO1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSO1.Model.DBUpdates;

namespace PSO1
{
    public partial class Form7 : Form //  create/edit Warehouse alarm message
    {
        public Form7(int PID, bool alarmCreated)
        {
            InitializeComponent();
            //InitializeManualAddedComponent(alarmCreated);
            InitializeManualAddedComponent(PID);
            HideShowAlarmPanels(alarmCreated, PID); //TBD : fix => show correct panel
        }
        private void button1_Click(object sender, EventArgs e) //Create Alarm
        {
            CreateNewWarehouseProductStockAlarm(crtUser, crtProdID, (int)numericUpDown1.Value);

            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e) //Edit Alarm
        {
            ModifyWarehouseProductStockAlarm(crtUser, crtProdID, (int)numericUpDown2.Value);
            this.Hide();
        }
        /*
        public void HideShowAlarmPanels(bool alarm)
        {
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
        }*/

        public void HideShowAlarmPanels(bool alarm, int ctrPID)
        {
            crtProdID = ctrPID;
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
        }
    }
}
