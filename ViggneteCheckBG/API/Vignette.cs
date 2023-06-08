using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViggneteCheckBG.API
{
    class Vignette
    {
        public static String[] validRegions = { "Е", "А", "В", "ВТ", "ВН", "ВР", "ЕВ", "ТХ", "К", "КН", "ОВ", "М", "РА", "РК", "ЕН", "РВ", "РР", "Р", "СС", "СН", "СМ", "СО", "С", "СА", "СВ", "СТ", "Т", "Х", "Н", "У" };
        public static void getLastChecks()
        {
            WebRequest request = WebRequest.Create("https://v-devs.eu/api.php?getLastVignetteChecks");
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            String[] strlist = responseFromServer.Split(moreData.htmlTag, 3,StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i <= 1; i++)
            {
                moreData.lastChecked.Add(strlist[i]);
            }
            reader.Close();
            dataStream.Close();
            response.Close();
        }
        public static void ClearVehicles()
        {
            moreData.lastChecked.Clear();
        }
        public static void getTotalChecks()
        {
            WebRequest request = WebRequest.Create("https://v-devs.eu/api.php?getTotalVignetteChecks");
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            moreData.totalChecks = Regex.Match(responseFromServer, @"\d+").Value; ;
            reader.Close();
            dataStream.Close();
            response.Close();
        }
        public static void Insert(string licenseNumber)
        {
            try
            {
                WebRequest request = WebRequest.Create("https://v-devs.eu/api.php?insertVignette&license_number=" + licenseNumber);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }catch(Exception dataError)
            {
                //
            }
        }
    }
}
