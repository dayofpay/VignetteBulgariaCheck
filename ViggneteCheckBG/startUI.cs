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
        Error newEror = new Error();
        public static string autoTheme = "Автоматично";
        public static string darkTheme = "Тъмна";
        public static string lightTheme = "Светла";
        public static string defaultTheme = "По подразбиране";
        public static string randomTheme = "Случайна";
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
            licenseNumber.KeyPress += new KeyPressEventHandler(clickedButton);
        }
        private void clickedButton(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkVignette_Click(this, new EventArgs());
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour <= 18)
            {
                welcomeText.Text = @"Добър ден," + Environment.UserName + Environment.NewLine +
                     DateTime.Now.ToLongTimeString();
            }
            else
            {
                welcomeText.Text = @"Добър вечер," + Environment.UserName + Environment.NewLine +
                     DateTime.Now.ToLongTimeString();
            }
        }
        private void startUI_Load(object sender, EventArgs e)
        {
            timer1.Interval = (500);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            infoLabel.Text = @"Софтуера е разработен
От: v-devs.eu
Версия: " + Properties.Settings.Default.softwareVersion;
        }

        private void checkVignette_Click(object sender, EventArgs e)
        {
            if(licenseNumber.Text.Length > 4)
            {
                checkLicense(licenseNumber.Text);
            }
            else
            {
                Error.errorText = "Не съществува МПС с такъв номер";
                Error.getError = "invalidVehicle";
                newEror.ShowDialog();
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

        private void penalties_Click(object sender, EventArgs e)
        {
            katGlobi globi = new katGlobi();
            globi.ShowDialog();
        }

        private void licensing1_Load(object sender, EventArgs e)
        {
        }

        private void ratingStats_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
            if(ratingStats.Value >= 3)
            {
                MessageBox.Show("Благодарим ви за добрата оценка !","Vignette Check BG");
            }
            else
            {
                MessageBox.Show("Благодарим ви за оценката !", "Vignette Check BG");
            }
        }

        private void theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(theme.Text == defaultTheme)
            {
                this.BackColor = Color.FromArgb(52, 174, 235);
            }
            if(theme.Text == darkTheme) {
                this.BackColor = Color.FromArgb(17, 30, 49);
                panel1.ForeColor = Color.FromArgb(128, 191, 169);
                panel2.ForeColor = Color.FromArgb(128, 191, 169);
                panel3.ForeColor = Color.FromArgb(128, 191, 169);
                panel4.ForeColor = Color.FromArgb(128, 191, 169);
                panel5.ForeColor = Color.FromArgb(128, 191, 169);
                panel6.ForeColor = Color.FromArgb(128, 191, 169);
                label1.ForeColor = Color.FromArgb(128, 191, 169);
                welcomeText.ForeColor = Color.FromArgb(128, 191, 169);
                infoLabel.ForeColor = Color.FromArgb(128, 191, 169);
            }
            if (theme.Text == autoTheme)
            {
                if(DateTime.Now.Hour > 6 && DateTime.Now.Hour < 18)
                {
                    this.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    this.BackColor = Color.FromArgb(17, 30, 49);
                }
            }
            if(theme.Text == lightTheme)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (theme.Text == randomTheme)
            {
                Random getRandom = new Random();
                this.BackColor = Color.FromArgb(getRandom.Next(1, 255), getRandom.Next(1, 255), getRandom.Next(1, 255));
            }
        }
    }

}
