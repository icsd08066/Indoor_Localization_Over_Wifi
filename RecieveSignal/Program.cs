using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace RecieveSignal
{
    public class ReceiveSignal
    {
        public static string data = null;

        public static void StartListening() {
            
            byte[] bytes = new byte[1024];
            
            DBConnect dbc = new DBConnect();
            dbc.initialize();

            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());//to dns get hostname dinei plhrofories gia to host pou trexei thn efarmogh
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            //IPAddress ipAddress = IPAddress.Any;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8000);


            Socket Listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try { 
                Listener.Bind(localEndPoint);// dinei sto serversocket pou na akousei
                Listener.Listen(10);//listen max 1 connections

                while (true)
                {
                    Console.WriteLine("Waiting for incoming Connection...!");
                    Socket Handler = Listener.Accept();//dhmiourgw allo socket 
                    data = null;

                    while (true)
                    {
                        bytes = new byte[2048];
                        int bytesRec = Handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1) { break; }
                    }

                    //----------- get string we want to use --------------------
                    int start = data.IndexOf("-");
                    int end = data.IndexOf("<EOF>", start);
                    string data2 = data.Substring(start, end - start);
                    Console.WriteLine("All :{0}", data2);
                    //-------------SPLIT USEFULL STRING ------------
                    int j=0;
                    int counter = 0;
                    string[] strArr = null;
                    char[] splitchar = {','};// define comma delimeter
                    strArr = data2.Split(splitchar);
                    List<int> list = new List<int>(4);
                    for (counter = 0; counter <= strArr.Length - 1; counter++) {
                        
                        Console.WriteLine("{0}", strArr[counter]);
                        int x = Int32.Parse(strArr[counter]);
                        list.Add(x);
                        j++;
                    }
                    Console.WriteLine("-------------");
                    list.ForEach(Console.WriteLine);
                    Console.WriteLine("-------------");
                    //-----add in database---------
                    dbc.insert(list[0],list[1],list[2],list[3]);

                    //-------------------------------------------
                    byte[] msg = Encoding.ASCII.GetBytes(data2);
                    Handler.Send(msg);
                    Handler.Shutdown(SocketShutdown.Both);
                    Handler.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        
        }

        static int Main(string[] args)
        {
            
            StartListening();
            return 0;
        }
    }
}
