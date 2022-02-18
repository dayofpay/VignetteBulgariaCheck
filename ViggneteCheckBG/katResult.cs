using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViggneteCheckBG
{
    public partial class katResult : Form
    {
        public static string resultInfo
        {
            get;
            set;
        }
        public katResult()
        {
            InitializeComponent();
        }

        private void katResult_Load(object sender, EventArgs e)
        {
        }
        public void checkSlip(string sumpsNomer,string egn)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("https://e-uslugi.mvr.bg/api/Obligations/AND?mode=1&obligedPersonIdent=" + egn + "&drivingLicenceNumber=" + sumpsNomer);
                WebResponse webResponse = webRequest.GetResponse();
                Stream data = webResponse.GetResponseStream();
                StreamReader reader = new StreamReader(data);
                string response = reader.ReadToEnd();
                JObject jsReader = JObject.Parse(response);
                string getResult = (string)jsReader["hasNonHandedSlip"];
                string getCode = (string)jsReader["code"];
                string getMessage = (string)jsReader["message"];
                if (getResult == "True")
                {
                    img.Image = Properties.Resources.spam_40px;
                    this.info.Location = new Point(100, 81);
                    info.Text = @"Имате неплатени глоби,
за да ги платите,
трябва да посетите лично Пътна Полиция !";
                }
                else if (getResult == "False")
                {
                    this.info.Location = new Point(165, 81);
                    img.Image = Properties.Resources.Done_100px;
                    info.Text = @"Нямате невръчени глоби !";
                }
            }catch(Exception error)
            {

            }
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void img_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
