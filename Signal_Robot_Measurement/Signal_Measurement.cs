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
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Threading;
using System.IO.IsolatedStorage;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;

namespace Signal_Robot_Measurment
{
    public partial class Signal_Measurement : Form
    {
        //Power setting can be from 0 to 100%
        //It is recommended that the power be kept at 100%.
        private int Power = 100;
        List<string> signal_list = new List<string>();
        public Signal_Measurement()
        {
            InitializeComponent();
            this.Text = "Signal Strength Measurement";
        }

        private void AirgridInterfaceButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://192.168.2.20/index.cgi");
        }

        private void buttonGetSignal_Click(object sender, EventArgs e)
        {
            //get cookie from web browser
            String cookie = webBrowser1.Document.Cookie;
            int startIndex = cookie.IndexOf("SESSIONID=");
            int endIndex = cookie.IndexOf("; show_security", startIndex);
            string cookie_string = cookie.Substring(startIndex + 10, endIndex - startIndex - 10);
            Console.WriteLine(cookie_string);

            //Set values from degrees and Velocity Textboxes
            int degrees = 10;
            int Vel = Convert.ToInt32(textBoxVelocity.Text);
            int times = 360 / degrees;
            int d_cnt = 0;
            for (int i = 0; i < 36; i++)
            {
                //---------------------------------------------------
                //------------ Get infos from status.cgi ------------
                //---------------------------------------------------

                InitiateSSLTrust();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://192.168.2.20/status.cgi");// Create a HttpWebRequest.
                request.CookieContainer = new CookieContainer();//Create the cookie container and add a cookie.
                // This example shows manually adding a cookie, but you would most
                // likely read the cookies from isolated storage.
                request.CookieContainer.Add(new Uri("https://192.168.2.20/status.cgi"), new Cookie("AIROS_SESSIONID", cookie_string));
                NetworkCredential nc = new NetworkCredential("ubnt", "ubnt");
                request.Credentials = nc;
                request.Method = WebRequestMethods.Http.Get;
                //--------------------------------------------------
                //----------- End of Authentication and Cookies ----
                //--------------------------------------------------

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string plain_text = sr.ReadToEnd();//get the plain text of whole page (status-cgi)
                int startSignal = plain_text.IndexOf("\"signal\": ");
                int endSignal = plain_text.IndexOf(", \"rs", startSignal);
                string signal_number = plain_text.Substring(startSignal + 9, endSignal - startSignal - 9);//get desired substring 
                Console.WriteLine("----------------");
                Console.WriteLine(signal_number);
                String message = signal_number + "," + textBoxX.Text + "," + textBoxY.Text + "," + d_cnt;
                sendsignal(message);//send signal message with proper parameters
                signal_list.Add(message);
                d_cnt += degrees;
                Rotate();//after sending message rotate robot clockwise
                m31.SendMessage(message, PC_BOT.PCBOTEventArgs.messageType.information);
                Thread.Sleep(5000);
                //webBrowser1.Refresh();
            }
            MessageBox.Show("The calculations are complete");

            for (int j = 0; j < times; j++)
            {
                Console.WriteLine(signal_list[j]);
            }
            
        }

        //sends signal to server
        public void sendsignal(string message)
        {

            byte[] bytes = new byte[1024];

            try
            {

                IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());//vriskei tis plhrofories gia ton host

                //IPAddress ipAddress = ipHostInfo.AddressList[0];// pairnei apo ton host thn ip toy
                StreamReader streamReader = new StreamReader("change_s_host.txt");
                string text = streamReader.ReadToEnd();
                IPAddress ipAddress = IPAddress.Parse(text);
                IPEndPoint remoteEP = new System.Net.IPEndPoint(ipAddress, 8000); // dhmioyrgei end point anoigontas thn porta 11000

                try
                {
                    Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sender.Connect(remoteEP);//sundesh me to endpoint

                    Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(message + "<EOF>");//encode the data string into a byte array
                    int bytesSend = sender.Send(msg);//send it
                    Console.WriteLine(bytesSend);
                    //-----waiting for answer-------
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        //create trust in Cetrificate to succsfully load the webpage
        public static void InitiateSSLTrust()
        {
            try
            {
                //Change SSL checks so that all checks pass
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(
                        delegate
                        { return true; }
                    );
            }
            catch (Exception ex)
            {
                // ActivityLog.InsertSyncActivity(ex);
            }
        }
        //Rotate M3 Bot clockwise including form parameters
        private void Rotate()
        {
            try
            {
                int degrees = Convert.ToInt32(textBoxRotate.Text);
                int Vel = Convert.ToInt32(textBoxVelocity.Text);

                //The call to Rotate() takes 4 parameters.
                //1) the number of degrees to rotate (rotate x degrees)
                //2) The rotation velocity (mm/s)
                //3) The power setting (by default 100)
                //4) The direction (Clockwise or Anticlockwise)
                m31.Rotate(degrees, Vel, Power, PC_BOT.M3.rotate.Clockwise);
            }
            catch (Exception ex)
            {
                //We have a problem, so we will send out an error message.
                m31.SendMessage(ex.Message, PC_BOT.PCBOTEventArgs.messageType.error);
            }
        }
        //function to stop M3 Bot
        private void Stop(object sender, EventArgs e)
        {
            m31.Stop();
        }

        private void m31_PositionEvent(object sender, PC_BOT.PCBOTPositionEventArgs e)
        {
            m31.SendMessage("Done", PC_BOT.PCBOTEventArgs.messageType.information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 36; j++)
            {
                Rotate();
                Thread.Sleep(5000);
            }
           
        }
    }
}
