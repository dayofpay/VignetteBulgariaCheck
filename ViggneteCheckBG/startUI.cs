using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ViggneteCheckBG
{
    public partial class startUI : Form
    {
        public class vignetteJson
        {
            public string status { get; set; }
        }
        public static bool validVignette
        {
            get;
            set;
        }
        public startUI()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startUI_Load(object sender, EventArgs e)
        {
        }

        private void checkVignette_Click(object sender, EventArgs e)
        {
            if(licenseNumber.Text.Length > 4)
            {
                checkLicense(licenseNumber.Text);
            }
            else
            {
                MessageBox.Show("Не съществува МПС с такъв номер");
            }
        }
        public void checkLicense(string licenseNum)
        {
            WebRequest webRequest = WebRequest.Create("https://check.bgtoll.bg/check/vignette/plate/BG/" + licenseNum);
            WebResponse webResponse = webRequest.GetResponse();
            Stream data = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string response = reader.ReadToEnd();
            JObject jsReader = JObject.Parse(response);
            mainPanel.Visible = true;
            if (response.Contains("public.ui.ok.noVignette"))
            {
                pictureBox1.Image = Properties.Resources.cancel_24px;
                pictureBox1.Update();
                validVignette = false;
                vVignette.Text = "Няма Винетка !";
                vTill.Text = "Няма винетка !";
                MessageBox.Show("Няма намерена винетка !", "Vignette Check BG | No Vignette Found For This License Number ! ");
            }
            else
            {
                string validTill = (string)jsReader["vignette"]["validityDateFrom"];
                string licenseNumber = (string)jsReader["vignette"]["licensePlateNumber"];
                string mdt = (string)jsReader["vignette"]["vehicleClassCode"];
                string currency = (string)jsReader["vignette"]["currency"];
                string validTo = (string)jsReader["vignette"]["validityDateToFormated"];
                string vPrice = (string)jsReader["vignette"]["price"];
                string vNum = (string)jsReader["vignette"]["vignetteNumber"];
                string em = (string)jsReader["vignette"]["emissionsClass"];
                if(em == null)
                {
                    moreData.emisions = "Няма информация";
                }
                else
                {
                    moreData.emisions = em;
                }
                vTill.Text = validTill;
                licPlate.Text = licenseNumber;
                if(mdt == "car")
                {
                    pictureBox4.Image = Properties.Resources.car_64px;
                    pictureBox4.Update();
                    mdtType.Text = "Автомобил";
                }
                else
                {
                    pictureBox4.Image = Properties.Resources.question_mark_64px;
                    pictureBox4.Update();
                    mdtType.Text = "Неизвестно";
                }
                price.Text = vPrice + "  " + currency;
                vignetteNum.Text = vNum;
                vTo.Text = validTo;
                vVignette.Text = "Валидна винетка !";
                validVignette = true;
                pictureBox1.Image = Properties.Resources.approval_30px;
                pictureBox1.Update();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void moreInfo_Click(object sender, EventArgs e)
        {
            moreInfo more = new moreInfo();
            more.ShowDialog();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вие вече сте в това меню !", "Vignette Check BG");
        }

        private void licenseNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
