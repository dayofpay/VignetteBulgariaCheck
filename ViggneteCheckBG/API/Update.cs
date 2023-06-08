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
    class Update
    {
        public class IsLatest
        {
            public static bool Check()
            {
                WebRequest request = WebRequest.Create("https://v-devs.eu/api.php?getLatestVersion&source=vignette");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                String[] version = responseFromServer.Split('<');
                reader.Close();
                dataStream.Close();
                response.Close();
                if(version[0] == Properties.Settings.Default.softwareVersion)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class getDownloadURL
        {
            public static string Get()
            {
                WebRequest request = WebRequest.Create("https://v-devs.eu/api.php?getLatestVersion&source=vignette&getDownloadURL");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                String[] urlResponse = responseFromServer.Split('<');
                reader.Close();
                dataStream.Close();
                response.Close();
                return urlResponse[0];
            }
        }
    }
}
