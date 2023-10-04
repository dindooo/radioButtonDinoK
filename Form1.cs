using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonDinoK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            string text = "Napravili ste rezervaciju za : \r\n";

            if (rdoAutobus.Checked)
            {
                text += "Autobus.";
            }
            else if (rdoAvion.Checked)
            {
                text += "Avion.";
            }
            else if (rdoVlastiti.Checked)
            {
                text += "Vlastiti prijevoz";
            }
         
            txtIspis.Text = text;
        }
    }
}
