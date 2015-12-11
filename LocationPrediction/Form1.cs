using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LocationPrediction
{
    public partial class Form1 : Form
    {
        private int Power = 100;
        int buttonOffset;
        String Est_x;
        String Est_y;
      
        public Form1()
        {
            InitializeComponent();
            this.Text = "Location Estimator ";
            buttonOffset = 10;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void AirgridInterfaceButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://192.168.2.20/index.cgi");
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
        private void Localize_Click(object sender, EventArgs e)
        {
            //create arraylist to save Measurement and Degrees Info
            String[] SSlist = new String[36];
            int[] AoAlist = new int[36];

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
            //**********************
            Robot_Management Robot = new Robot_Management(m31 ,textBoxRotate.Text , textBoxVelocity.Text);
            //**********************
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
                /////////////////////////////////////////////////////////
                AoAlist[i] = d_cnt;//pros8etei sth lista thn gwnia afi3hs
                SSlist[i] = signal_number;
                d_cnt += Convert.ToInt32(textBoxRotate.Text);

                
                Robot.Rotate(textBoxRotate.Text,textBoxVelocity.Text);  //after sending message rotate robot clockwise
                m31.SendMessage(i+1+"'st done", PC_BOT.PCBOTEventArgs.messageType.information);

                //m31.SendMessage(message, PC_BOT.PCBOTEventArgs.messageType.information);
                Thread.Sleep(5000);
                //webBrowser1.Refresh();
            }
            //make the predictions
            //**********************
            Bayesian_Model model = new Bayesian_Model(GeNIe_Path(), iterations());
            Data data = new Data();

            Est_x = model.InfereceWithBayesianNetworkWindowing36forX(data.find_AoA("350"), data.find_AoA("340"), data.find_AoA("330"), data.find_AoA("320"), data.find_AoA("310"), data.find_AoA("300"), data.find_AoA("290"), data.find_AoA("280"), data.find_AoA("270"),
                data.find_AoA("260"), data.find_AoA("250"), data.find_AoA("240"), data.find_AoA("230"), data.find_AoA("220"), data.find_AoA("210"), data.find_AoA("200"), data.find_AoA("190"), data.find_AoA("180"), data.find_AoA("170"), data.find_AoA("160"),
                data.find_AoA("150"), data.find_AoA("140"), data.find_AoA("130"), data.find_AoA("120"), data.find_AoA("110"), data.find_AoA("100"), data.find_AoA("90"), data.find_AoA("80"), data.find_AoA("70"), data.find_AoA("60"), data.find_AoA("50"), data.find_AoA("40"),
                data.find_AoA("30"), data.find_AoA("20"), data.find_AoA("10"), data.find_AoA("0"), data.find_SS(SSlist[35]), data.find_SS(SSlist[34]), data.find_SS(SSlist[33]), data.find_SS(SSlist[32]), data.find_SS(SSlist[31]), data.find_SS(SSlist[30]), data.find_SS(SSlist[29]), data.find_SS(SSlist[28]), data.find_SS(SSlist[27]),
                data.find_SS(SSlist[26]), data.find_SS(SSlist[25]), data.find_SS(SSlist[24]), data.find_SS(SSlist[23]), data.find_SS(SSlist[22]), data.find_SS(SSlist[21]), data.find_SS(SSlist[20]), data.find_SS(SSlist[19]), data.find_SS(SSlist[18]), data.find_SS(SSlist[17]), data.find_SS(SSlist[16]), data.find_SS(SSlist[15]), data.find_SS(SSlist[14]),
                data.find_SS(SSlist[13]), data.find_SS(SSlist[12]), data.find_SS(SSlist[11]), data.find_SS(SSlist[10]), data.find_SS(SSlist[9]), data.find_SS(SSlist[8]), data.find_SS(SSlist[7]), data.find_SS(SSlist[6]), data.find_SS(SSlist[5]), data.find_SS(SSlist[4]), data.find_SS(SSlist[3]), data.find_SS(SSlist[2]), data.find_SS(SSlist[1]), data.find_SS(SSlist[0]));

            Est_y = model.InfereceWithBayesianNetworkWindowing36forY(data.find_AoA("350"), data.find_AoA("340"), data.find_AoA("330"), data.find_AoA("320"), data.find_AoA("310"), data.find_AoA("300"), data.find_AoA("290"), data.find_AoA("280"), data.find_AoA("270"),
                 data.find_AoA("260"), data.find_AoA("250"), data.find_AoA("240"), data.find_AoA("230"), data.find_AoA("220"), data.find_AoA("210"), data.find_AoA("200"), data.find_AoA("190"), data.find_AoA("180"), data.find_AoA("170"), data.find_AoA("160"),
                 data.find_AoA("150"), data.find_AoA("140"), data.find_AoA("130"), data.find_AoA("120"), data.find_AoA("110"), data.find_AoA("100"), data.find_AoA("90"), data.find_AoA("80"), data.find_AoA("70"), data.find_AoA("60"), data.find_AoA("50"), data.find_AoA("40"),
                 data.find_AoA("30"), data.find_AoA("20"), data.find_AoA("10"), data.find_AoA("0"), data.find_SS(SSlist[35]), data.find_SS(SSlist[34]), data.find_SS(SSlist[33]), data.find_SS(SSlist[32]), data.find_SS(SSlist[31]), data.find_SS(SSlist[30]), data.find_SS(SSlist[29]), data.find_SS(SSlist[28]), data.find_SS(SSlist[27]),
                 data.find_SS(SSlist[26]), data.find_SS(SSlist[25]), data.find_SS(SSlist[24]), data.find_SS(SSlist[23]), data.find_SS(SSlist[22]), data.find_SS(SSlist[21]), data.find_SS(SSlist[20]), data.find_SS(SSlist[19]), data.find_SS(SSlist[18]), data.find_SS(SSlist[17]), data.find_SS(SSlist[16]), data.find_SS(SSlist[15]), data.find_SS(SSlist[14]),
                 data.find_SS(SSlist[13]), data.find_SS(SSlist[12]), data.find_SS(SSlist[11]), data.find_SS(SSlist[10]), data.find_SS(SSlist[9]), data.find_SS(SSlist[8]), data.find_SS(SSlist[7]), data.find_SS(SSlist[6]), data.find_SS(SSlist[5]), data.find_SS(SSlist[4]), data.find_SS(SSlist[3]), data.find_SS(SSlist[2]), data.find_SS(SSlist[1]), data.find_SS(SSlist[0]));


            PredictionLabel.Text = "Its your lucky day. It was found at coordinates: " + data.returnX(Est_x) + " , " + data.returnY(Est_y);
            PredictionLabel.Visible = true;

        }
        private void Test_Click(object sender, EventArgs e)
        {

            //create arraylist to save Measurement and Degrees Info
            String[] SSlist = new String[36];
            String[] AoAlist = new String[36];

            //*************** Fill Arraylist **********************
            SSlist[0] = "350";
            SSlist[1] = "340";
            SSlist[2] = "330";
            SSlist[3] = "320";
            SSlist[4] = "310";
            SSlist[5] = "300";
            SSlist[6] = "290";
            SSlist[7] = "280";
            SSlist[8] = "270";
            SSlist[9] = "260";
            SSlist[10] = "250";
            SSlist[11] = "240";
            SSlist[12] = "230";
            SSlist[13] = "220";
            SSlist[14] = "210";
            SSlist[15] = "200";
            SSlist[16] = "190";
            SSlist[17] = "180";
            SSlist[18] = "170";
            SSlist[19] = "160";
            SSlist[20] = "150";
            SSlist[21] = "140";
            SSlist[22] = "130";
            SSlist[23] = "120";
            SSlist[24] = "110";
            SSlist[25] = "100";
            SSlist[26] = "90";
            SSlist[27] = "80";
            SSlist[28] = "70";
            SSlist[29] = "60";
            SSlist[30] = "50";
            SSlist[31] = "40";
            SSlist[32] = "30";
            SSlist[33] = "20";
            SSlist[34] = "10";
            SSlist[35] = "0";
            //Set values from degrees and Velocity Textboxes
            int degrees = 10;
            int Vel = Convert.ToInt32(textBoxVelocity.Text);
            int times = 360 / degrees;
            int d_cnt = 0;
            //**********************
            Bayesian_Model model = new Bayesian_Model(GeNIe_Path(),iterations());
            Data data = new Data();

             Est_x = model.InfereceWithBayesianNetworkWindowing36forX(data.find_AoA("350"), data.find_AoA("340"), data.find_AoA("330"), data.find_AoA("320"), data.find_AoA("310"), data.find_AoA("300"), data.find_AoA("290"), data.find_AoA("280"), data.find_AoA("270"),
                data.find_AoA("260"), data.find_AoA("250"), data.find_AoA("240"), data.find_AoA("230"), data.find_AoA("220"), data.find_AoA("210"), data.find_AoA("200"), data.find_AoA("190"), data.find_AoA("180"), data.find_AoA("170"), data.find_AoA("160"),
                data.find_AoA("150"), data.find_AoA("140"), data.find_AoA("130"), data.find_AoA("120"), data.find_AoA("110"), data.find_AoA("100"), data.find_AoA("90"), data.find_AoA("80"), data.find_AoA("70"), data.find_AoA("60"), data.find_AoA("50"), data.find_AoA("40"),
                data.find_AoA("30"), data.find_AoA("20"), data.find_AoA("10"), data.find_AoA("0"), data.find_SS("-32"), data.find_SS("-37"), data.find_SS("-41"), data.find_SS("-40"), data.find_SS("-34"), data.find_SS("-36"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-38"),
                data.find_SS("-38"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-39"), data.find_SS("-38"), data.find_SS("-38"), data.find_SS("-40"), data.find_SS("-30"), data.find_SS("-31"), data.find_SS("-36"), data.find_SS("-41"), data.find_SS("-44"), data.find_SS("-41"),
                data.find_SS("-35"), data.find_SS("-38"), data.find_SS("-40"), data.find_SS("-34"), data.find_SS("-34"), data.find_SS("-37"), data.find_SS("-43"), data.find_SS("-48"), data.find_SS("-45"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-41"), data.find_SS("-31"), data.find_SS("-28"));

             Est_y = model.InfereceWithBayesianNetworkWindowing36forY(data.find_AoA("350"), data.find_AoA("340"), data.find_AoA("330"), data.find_AoA("320"), data.find_AoA("310"), data.find_AoA("300"), data.find_AoA("290"), data.find_AoA("280"), data.find_AoA("270"),
                data.find_AoA("260"), data.find_AoA("250"), data.find_AoA("240"), data.find_AoA("230"), data.find_AoA("220"), data.find_AoA("210"), data.find_AoA("200"), data.find_AoA("190"), data.find_AoA("180"), data.find_AoA("170"), data.find_AoA("160"),
                data.find_AoA("150"), data.find_AoA("140"), data.find_AoA("130"), data.find_AoA("120"), data.find_AoA("110"), data.find_AoA("100"), data.find_AoA("90"), data.find_AoA("80"), data.find_AoA("70"), data.find_AoA("60"), data.find_AoA("50"), data.find_AoA("40"),
                data.find_AoA("30"), data.find_AoA("20"), data.find_AoA("10"), data.find_AoA("0"), data.find_SS("-32"), data.find_SS("-37"), data.find_SS("-41"), data.find_SS("-40"), data.find_SS("-34"), data.find_SS("-36"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-38"),
                data.find_SS("-38"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-39"), data.find_SS("-38"), data.find_SS("-38"), data.find_SS("-40"), data.find_SS("-30"), data.find_SS("-31"), data.find_SS("-36"), data.find_SS("-41"), data.find_SS("-44"), data.find_SS("-41"),
                data.find_SS("-35"), data.find_SS("-38"), data.find_SS("-40"), data.find_SS("-34"), data.find_SS("-34"), data.find_SS("-37"), data.find_SS("-43"), data.find_SS("-48"), data.find_SS("-45"), data.find_SS("-42"), data.find_SS("-41"), data.find_SS("-41"), data.find_SS("-31"), data.find_SS("-28"));


            PredictionLabel.Text = "Its your lucky day. PC-BOT located at: "+data.returnX(Est_x)+" , "+ data.returnY(Est_y);
            PredictionLabel.Visible = true;
            ViewMap.Visible = true;
            Console.WriteLine(Est_x + "  ,  " + Est_y);
            
        }
        public int iterations()
        {
            if (SimpleRadioButton.Checked == true)
            {
                return 1;
            }
            else
            {
                return 4;
            }
        }
        public String GeNIe_Path()
        {
            if (SimpleRadioButton.Checked == true)
            {
                return "signal_list_equalWidthDiscretize_GTT_K2.xdsl";
            }
            else
            {
                return "C:/Users/Γιαννης/Documents/Visual Studio 2013/Projects/LocationPrediction/LocationPrediction/windowing_XandY_equalWidthDisc.csv";
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //groupBox1.Width = 200;
            //groupBox2.Width = 500;
            //groupBox3.Width = ;
            groupBox2.Location = new Point(220, groupBox2.Location.Y);
          
            groupBox3.Location = new Point(730, groupBox3.Location.Y);
        }
        private void textBoxRotate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Color> lstColour = new List<Color>();
                foreach (Control c in groupBox2.Controls)
                    lstColour.Add(c.ForeColor);

                
                groupBox2.ForeColor = Color.Red; //the colour you prefer for the text

                int index = 0;
                foreach (Control c in groupBox2.Controls)
                {
                    c.ForeColor = lstColour[index];
                    index++;
                }
            }
        }

        private void ViewMap_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            Map map = new Map(data.returnX(Est_x), data.returnY(Est_y));
            //Map map = new Map(-910, 700);
            map.Show();
        }

        

      
       
    }
}


//private void buttonGetSignal_Click(object sender, EventArgs e)
//{
//    //get cookie from web browser
//    String cookie = webBrowser1.Document.Cookie;
//    int startIndex = cookie.IndexOf("SESSIONID=");
//    int endIndex = cookie.IndexOf("; show_security", startIndex);
//    string cookie_string = cookie.Substring(startIndex + 10, endIndex - startIndex - 10);
//    Console.WriteLine(cookie_string);

//    //Set values from degrees and Velocity Textboxes
//    int degrees = 10;
//    int Vel = Convert.ToInt32(textBoxVelocity.Text);
//    int times = 360 / degrees;
//    int d_cnt = 0;
//    //**********************
//    Robot_Management Robot = new Robot_Management(m31 ,textBoxRotate.Text , textBoxVelocity.Text);
//    //*********************
//    for (int i = 0; i < 4; i++)
//    {
//        //---------------------------------------------------
//        //------------ Get infos from status.cgi ------------
//        //---------------------------------------------------

//        InitiateSSLTrust();
//        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://192.168.2.20/status.cgi");// Create a HttpWebRequest.
//        request.CookieContainer = new CookieContainer();//Create the cookie container and add a cookie.
//        // This example shows manually adding a cookie, but you would most
//        // likely read the cookies from isolated storage.
//        request.CookieContainer.Add(new Uri("https://192.168.2.20/status.cgi"), new Cookie("AIROS_SESSIONID", cookie_string));
//        NetworkCredential nc = new NetworkCredential("ubnt", "ubnt");
//        request.Credentials = nc;
//        request.Method = WebRequestMethods.Http.Get;
//        //--------------------------------------------------
//        //----------- End of Authentication and Cookies ----
//        //--------------------------------------------------

//        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//        StreamReader sr = new StreamReader(response.GetResponseStream());
//        string plain_text = sr.ReadToEnd();//get the plain text of whole page (status-cgi)
//        int startSignal = plain_text.IndexOf("\"signal\": ");
//        int endSignal = plain_text.IndexOf(", \"rs", startSignal);
//        string signal_number = plain_text.Substring(startSignal + 9, endSignal - startSignal - 9);//get desired substring 


//        d_cnt += degrees;

//        Robot.Rotate();  //after sending message rotate robot clockwise
//        //m31.SendMessage(message, PC_BOT.PCBOTEventArgs.messageType.information);
//        Thread.Sleep(5000);
//        //webBrowser1.Refresh();
//    }
//}
