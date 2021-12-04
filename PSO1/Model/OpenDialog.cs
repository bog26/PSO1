using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO1.Model
{
    class OpenDialog : Form
    {
        private static OpenDialog openForm = null;
        public static OpenDialog GetInstance()
        {
            if (openForm == null)
            {
                openForm = new OpenDialog();
                openForm.FormClosed += delegate { openForm = null; };
            }
            return openForm;
        }
    }
}
