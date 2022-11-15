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
От: v-devs.online
Версия: " + Properties.Settings.Default.softwareVersion;
            API.Vignette.getLastChecks();
            vehicleOne.Text = moreData.lastChecked[0];
            vehicleTwo.Text = moreData.lastChecked[1];
            API.Vignette.getTotalChecks();
            totalChecks.Text = $"Общо направени проверки : {moreData.totalChecks}";
        }
        private void checkVignette_Click(object sender, EventArgs e)
        {
            textReset();
            bool checkNum = API.Vignette.validRegions.Any(getData => licenseNumber.Text.Contains(getData));
            if (checkNum && licenseNumber.Text.Length <=8)
            {

                checkLicense(licenseNumber.Text);
                API.Vignette.Insert(licenseNumber.Text);
                alert.Show(this, "Успешно проверихте МПС с рег. номер "+licenseNumber.Text, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                totalChecks.Text = $"Общо направени проверки : {moreData.totalChecks}";
            }
            else
            {
                /* Стар Код
                Error.errorText = "Не съществува МПС с такъв номер";
                Error.getError = "invalidVehicle";
                newEror.ShowDialog();
                */
                alert.Show(this, "Не съществува МПС с такъв номер", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
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
                licPlate.Text = "Няма винетка !";
                mdtType.Text = "Няма винетка !";
                vTill.Text = "Няма винетка !";
                vTo.Text = "Няма винетка !";
                price.Text = "Няма винетка !";
                vignetteNum.Text = "Няма винетка !";
                countryText.Text = "Неизвестно";
                countryImgBox.Image = Properties.Resources.country_480px;
                countryImgBox.Update();
                confsStatus.Text = "Неизвестно";
                alert.Show(this, "Това МПС не разполага с винетка !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
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
                string confiscateStatus = (string)jsReader["vignette"]["exempt"];
                string country = (string)jsReader["vignette"]["country"];
                if(country == "BG")
                {
                    countryImgBox.Image = Properties.Resources.bulgaria_480px;
                    countryImgBox.Update();
                    countryText.Text = "България";
                }
                else
                {
                    countryText.Text = country;
                    countryImgBox.Image = Properties.Resources.country_480px;
                    countryImgBox.Update();
                }
                if(Convert.ToBoolean(confiscateStatus) == true)
                {
                    confsStatus.Text = "Конфискуван";
                }
                else
                {
                    confsStatus.Text = "Не е конфискуван";
                }
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
            alert.Show(this, "Вие вече сте в това меню !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
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
                alert.Show(this, "Благодарим ви за добрата оценка !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

            }
            else
            {
                alert.Show(this, "Благодарим ви за оценката !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
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
                confsStatusLabel.ForeColor = Color.FromArgb(128, 191, 169);
                confsPanel.ForeColor = Color.FromArgb(128, 191, 169);
                confsStatus.ForeColor = Color.FromArgb(128, 191, 169);
                infoLabel.ForeColor = Color.FromArgb(128, 191, 169);
                countryLabel.ForeColor = Color.FromArgb(128, 191, 169);
                countryPanel.ForeColor = Color.FromArgb(128, 191, 169);
                countryText.ForeColor = Color.FromArgb(128, 191, 169);
                totalChecks.ForeColor = Color.FromArgb(128, 191, 169);
                label9.ForeColor = Color.FromArgb(128, 191, 169);
                vehicleOne.ForeColor = Color.FromArgb(128, 191, 169);
                vehicleTwo.ForeColor = Color.FromArgb(128, 191, 169);
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

        private void buttonCheckViggnette_Click(object sender, EventArgs e)
        {
            alert.Show(this, "Вие вече сте в това меню !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            katGlobi globi = new katGlobi();
            globi.ShowDialog();
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }
        public void textReset()
        {
            API.Vignette.ClearVehicles();
            API.Vignette.getLastChecks();
            API.Vignette.getTotalChecks();
            vehicleOne.Text = moreData.lastChecked[0];
            vehicleTwo.Text = moreData.lastChecked[1];
            vehicleOne.Update();
            vehicleTwo.Update();
            totalChecks.Text = $"Общо направени проверки : {moreData.totalChecks}";
            totalChecks.Update();
        }
    }
}
