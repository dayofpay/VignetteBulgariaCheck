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
    public partial class moreInfo : Form
    {
        public moreInfo()
        {
            InitializeComponent();
            mainPanel.Visible = true;
            emisions.Text = moreData.emisions;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
        }

        private void moreInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
