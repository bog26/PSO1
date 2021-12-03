using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO1
{
    public partial class Form7 : Form //  create/edit Warehouse alarm message
    {
        public Form7(int PID, bool alarmCreated)
        {
            InitializeComponent();
            InitializeManualAddedComponent(alarmCreated);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
