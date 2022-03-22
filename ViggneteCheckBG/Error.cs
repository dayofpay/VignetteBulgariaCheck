using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViggneteCheckBG
{
    public partial class Error : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-кординати of на горен ляв ъгъл
            int nTopRect,      // y-кординати of на горен десен ъгъл
            int nRightRect,    // x-кординати of на долен ляв ъгъл
            int nBottomRect,   // y-кординати of на долен десен ъгъл
            int nWidthEllipse, // Ширина на елипса
            int nHeightEllipse // Височина на елипса
        );
        public static string getError
        {
            get;
            set;
        }
        public static string errorText
        {
            get;
            set;
        }
        public Error()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Error_Load(object sender, EventArgs e)
        {

            if(getError == "invalidVehicle")
            {
                pictureBox1.Image = Properties.Resources.car_64px;
            }
            else // Ако грешката е неиндифицирана
            {
                pictureBox1.Image = Properties.Resources.cancel_24px;
            }
            errorId.Text = errorText;
        }
    }
}
