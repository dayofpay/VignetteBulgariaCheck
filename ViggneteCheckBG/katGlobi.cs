using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViggneteCheckBG
{
    public partial class katGlobi : Form
    {
        public katGlobi()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            katResult result = new katResult();
            result.checkSlip(sumpsNumber.Text, egn.Text);
            result.ShowDialog();        }

        private void katGlobi_Load(object sender, EventArgs e)
        {

        }
    }
}
