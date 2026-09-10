using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StationWorkMode
{
    public partial class Form1 : Form
    {
        private bool _closing = false;

        public static string compilationMode = "SCC";

        //public string filePath = @"\\OP1\Users\Public\Boughrara\file.dat";
        //public string filePath1 = @"D:\file.dat";

        public string filePath = @"C:\file.dat";

        //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/file.dat";


        private int currentMonth = 0;

        private string[] monTableauDeStrings;

        internal MyClass Myobject { get; private set; }

        /// <summary>
        /// udp client for Tc Forgotten check
        /// </summary>
        public UdpClient ClientTC;

        private FileStream fileStream;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\WorkModeRgMissingAlarm.wav");
        System.Media.SoundPlayer player0x11 = new System.Media.SoundPlayer(@"d:\WorkMode0x11.wav");

        //string builder for log show
        StringBuilder strLogText = new StringBuilder();

        //btnTest.Visible = false;

        //Font Code 1
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        Font myFont00;
        Font myFont2;
        Font myFont3;
        Font myFontUtc;
        Font myFontLocal;
        //End Font Code 1

        //int portBC = txbBC.Text.ToString();


        //cLIENT bOUCHAOUI
        //UdpClient Client = new UdpClient(16010);
        UdpClient ClientBC;

        //Client boughezoul
        //UdpClient ClientBG = new UdpClient(16110);
        UdpClient ClientBG;


        internal void IdleTest()
        {
            //arreter les clients
            ClientBC.Close();
            ClientBG.Close();
        }

        internal void StopIdleTest()
        {
            //demarer les clients

            //cLIENT bOUCHAOUI
            //Client = new UdpClient(16010);

            //Client boughezoul
            //UdpClient ClientBG = new UdpClient(17615);
            //ClientBG = new UdpClient(16110);

            BeginRecieveBG();
            BeginRecieve();
        }

        internal void SetLabel(string textBC, string textBG)
        {
            lblMode.Text = textBC;
            lblModeBG.Text = textBG;
        }

        // bouchaoui
        //UdpClient Client = new UdpClient(16010);
        //UdpClient Client = new UdpClient(16010);

        StringBuilder data = new StringBuilder();
        StringBuilder dataBG = new StringBuilder();

        internal void ChangePath(string selectedText)
        {
            filePath = @selectedText;
        }

        //COunter no Data
        int countNoDataBC = 0;
        int countNoDataBG = 0;

        internal void ForceBCRangMissing()
        {
            //TODO Stop Gadget ! show principal Form !

            //Test RangMiss
            lblRgMessage.Visible = true;
            btnAck.Visible = true;

            WriteLog(DateTime.Now.ToLongTimeString() + " : " + lblMode.Text + " : BC Rang. Missing Test");

            PlayAlarmSound();

            
        }

        private void PlayAlarmSound()
        {
            try
            {
                player.PlayLooping();
            }
            catch (Exception soundEx)
            {

                WriteLog(MyDate() + " : Err : Play Sound Problem ! " + soundEx.Message);
            }
        }

        private string MyDate()
        {
            //return DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" +
            //DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            return DateTime.Now.ToShortDateString().Replace("/", "-") + " " + DateTime.Now.ToLongTimeString();
        }

        internal void ForceBGRangMissing()
        {

            //TODO Stop Gadget ! show principal Form !

            //Test RangMiss
            lblRgMessageBG.Visible = true;
            btnAckBG.Visible = true;

            WriteLog(MyDate() + " : " + lblModeBG.Text + " : BC Rang. Missing Test");

            PlayAlarmSound();
        }

        //boolean to see if its the first tick of timer 
        private bool firstTickTimerTest = true;
        private bool firstTickTimerTestBG = true;
        private bool subed;
        private bool subedBG;
        private int bigFormWidth = 691;
        private int bigFormHight = 382;
        private int smallFormWidth = 360;
        private int smallFormHight = 382;
        private string rgStatus;
        private DateTime oldTime;
        private string dataTC;
        private int tcFunctionCalls = 0;
        private int reminingTimeTC;
        private string xformat = "HH:mm";
        private string lastBgModeBD;
        //lastEndString
        private string lastEndString;
        private bool dbModeBG = true;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        public Form1()
        {
            InitializeComponent();

            lblCompilationMode.Text = compilationMode;

            if (compilationMode == "SCC")
            {
                lblUpdateDate.Visible = false;
                lblCompilationMode.Visible = false;
                lblLastBgModeDB.Visible = false;
                lblEndString.Visible = false;
            }
            
                
            //test if file path exist

            //TODO get path from configation and compilationMode

            //Log open app
            WriteLog(MyDate() + " : Application Started!");

            //ConfigurationManager.ConnectionStrings[compilationMode].ConnectionString;

            if (ConfigurationManager.AppSettings[compilationMode] != null)
            {
                filePath = ConfigurationManager.AppSettings[compilationMode].ToString();
            }

            if (File.Exists(filePath))
            {
                WriteLog(MyDate() + " : File path test succeeded!");
                //Load le programe de RG

                LoadRgProgram();
            }
            else
            {
                WriteLog(MyDate() + " : File path test failed!");

                //if (File.Exists(filePath1))
                //{
                //    WriteLog(MyDate() + " : File path updated!");
                //    filePath = filePath1;
                //    //Load le programe de RG
                //    LoadRgProgram();
                //}
                //else
                //{
                //    WriteLog("File path test failed!");
                //    //No path try force the path in test window
                //}
            }

            try
            {
                //Font Code 2
                byte[] fontData = Properties.Resources.LCDM2B;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.LCDM2B.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.LCDM2B.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
                //LCDM2B : 28/20 small
                myFont = new Font(fonts.Families[0], 28F, FontStyle.Bold);

                //Font Code 00
                //byte[] fontData00 = Properties.Resources.DS_DIGIB;
                //IntPtr fontPtr00 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData00.Length);
                //System.Runtime.InteropServices.Marshal.Copy(fontData00, 0, fontPtr00, fontData00.Length);
                //uint dummy00 = 0;
                //fonts.AddMemoryFont(fontPtr00, Properties.Resources.DS_DIGIB.Length);
                //AddFontMemResourceEx(fontPtr00, (uint)Properties.Resources.DS_DIGIB.Length, IntPtr.Zero, ref dummy00);
                //System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr00);
                myFont00 = new Font(fonts.Families[0], 20F, FontStyle.Bold);

                byte[] fontData2 = Properties.Resources.Candaral;
                IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData2.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData2, 0, fontPtr2, fontData2.Length);
                uint dummy2 = 1;
                fonts.AddMemoryFont(fontPtr2, Properties.Resources.Candaral.Length);
                AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.Candaral.Length, IntPtr.Zero, ref dummy2);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);

                myFont2 = new Font(fonts.Families[0], 14F, FontStyle.Regular);
                myFont3 = new Font(fonts.Families[0], 18F, FontStyle.Regular);

                byte[] fontData3 = Properties.Resources.Candaral;
                IntPtr fontPtr3 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData3.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData3, 0, fontPtr3, fontData3.Length);
                uint dummy3 = 1;
                fonts.AddMemoryFont(fontPtr3, Properties.Resources.Candaral.Length);
                AddFontMemResourceEx(fontPtr3, (uint)Properties.Resources.Candaral.Length, IntPtr.Zero, ref dummy3);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr3);

                myFontUtc = new Font(fonts.Families[0], 14F, FontStyle.Bold);
                myFontLocal = new Font(fonts.Families[0], 14F, FontStyle.Regular);

                //End FOnt Code 2
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Erreur : " + ex.Message.ToString());
                WriteLog("Erreur : " + ex.Message.ToString());
            }

            BeginRecieve();
            BeginRecieveBG();
            //BeginRecieveTC();

            //TODO delete this
            //lblFristTickTimerTest.Text = firstTickTimerTest.ToString();

            timerFirstTime.Start();
            timerFirstTimeBG.Start();

            try
            {
                //show onley panel2
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.Panel1Collapsed = true;
                this.Size = new Size(smallFormWidth, smallFormHight);

                //this.TopMost = true;
            }
            catch (Exception ex1)
            {
                //MessageBox.Show("Erreur 000 : " + ex1.Message.ToString());
                WriteLog("Erreur 000 : " + ex1.Message.ToString());
            }

            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width - 150 , scrn.Bounds.Top + 2);
                    return;
                }
            }

        }

        public void LoadRgProgram()
        {
            //----------------------get serlized object myClass

            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/file.dat";

            // Create a FileStream to open the file for reading
            //filePath = @"\\OP1\Users\Public\Boughrara\file.dat";
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open);

                // Create a BinaryFormatter to deserialize the object from the file
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the object from the file
                MyClass deserializedObject = (MyClass)formatter.Deserialize(fileStream);
                currentMonth = deserializedObject.Month;
                monTableauDeStrings = deserializedObject.TableauDeStrings;
                Myobject = deserializedObject;

                // Close the file stream
                fileStream.Close();

                if (monTableauDeStrings != null && monTableauDeStrings[DateTime.Now.Day - 1] == "ON")
                {
                    rgStatus = "ON";
                }
                else
                {
                    rgStatus = "OFF";
                }

                //afficher le statu du Ranging
                lblRgStatus.Text = "Date : " + DateTime.Now.ToShortDateString() + " Ranging is : " + rgStatus;


            }
            catch (SerializationException srExp)
            {
                WriteLog(MyDate() + " : Problem whene Serialization.");
                WriteLog("Code Erreur: F101 : " + srExp.Message.Replace("\r\n", ""));
            }
            catch (FileNotFoundException fnfExp)
            {
                //MessageBox.Show("The file does not exist.");
                WriteLog(MyDate() + " : The file does not exist.");
                WriteLog("Code Erreur: F102 : " + fnfExp.Message.Replace("\r\n", ""));
            }
            catch (Exception fexp)
            {
                WriteLog(MyDate() + " : Error while processing the file !");
                WriteLog("Code Erreur: F103 : " + fexp.Message.Replace("\r\n", ""));
            }
            finally
            {
                // Close the file stream
                //fileStream.Close();
            }

            // Use the deserialized object
            // ...

            //-----------------------the code of if and else !

            //Todo  If the object's current month is the same as the current month, retrieve the object's information.

            //if (currentMonth == DateTime.Now.Month)
            //{
            //    //on a l'objet on execute pour ce jour !
            //    //on met le tableau a jour !
            //    monTableauDeStrings = 
            //}
        }

        

        private void BeginRecieveBG()
        {
            
            try
            {
                ClientBG = new UdpClient(16110);
                //ClientBG = new UdpClient(2246);
                //ClientBG.JoinMulticastGroup(IPAddress.Parse("239.0.0.5"));
                ClientBG.BeginReceive(new AsyncCallback(recvBG), null);
            }
            catch (Exception ex)
            {
                lblDataBG.Text = ex.Message.ToString();
                WriteLog(MyDate() + " : Port 16110 déja utilisé ");
            }
            
        }

        private void recvBG(IAsyncResult ar)
        {
            if (_closing || IsDisposed || Disposing)
                return;

            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 1111);

            try
            {
                byte[] receivedBG = ClientBG.EndReceive(ar, ref RemoteIP);
                //data.Append(Encoding.Default.GetString(received));

                dataBG.Append(BitConverter.ToString(receivedBG));
            }
            catch (Exception extBG)
            {
                //MessageBox.Show("Err Code BG00" + extBG.Message.ToString());
                WriteLog("Err Code BG00" + extBG.Message.ToString());
            }

            string str = dataBG.ToString();
            str = str.Replace("-", " ");
            dataBG.Clear();
            //break the string into chunksize
            int chunkSize = 48;
            int stringLength = str.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                string strToAppend = str.Substring(i, chunkSize);
                //Console.WriteLine(str.Substring(i, chunkSize));
                if (strToAppend.Length > 24)
                {
                    dataBG.AppendLine(strToAppend.Insert(24, " "));
                }
                else
                {
                    dataBG.AppendLine(strToAppend);
                }
            }

            //supprimer la ligne
            if (dataBG.Length > 2)
            {
                dataBG.Remove(dataBG.Length - 2, 2);
            }



            //data = Formater(received);




            //System.ObjectDisposedException : 'Impossible d'accéder à un objet supprimé.
            //Nom de l'objet : 'Form1'.'
            
            
            try
            {
                //To avoid cross threading we use methode invoker
                this.Invoke(new MethodInvoker(delegate
                {

                    try
                    {
                        //deduire le mode d'apres la fin du string
                        //Ecrire le mode , et changer la couleur d'image alarm

                        //tester si la forme ni pas supprimé avant l'invoke


                        AfficherLeModeBG(dataBG);



                    }
                    catch (ObjectDisposedException expODE)
                    {
                        WriteLog("Err AMG00" + expODE.Message.ToString());
                        Console.WriteLine("Err AMG00" + expODE.Message.ToString());
                    }
                    catch (Exception exp)
                    {

                        WriteLog("Err AMG01" + exp.Message.ToString());
                    }



                }));

                ClientBG.BeginReceive(new AsyncCallback(recvBG), null);
            }
            catch (ObjectDisposedException expODE)
            {
                WriteLog("Err BGM00" + expODE.Message.ToString());
                Console.WriteLine("Err AMG00" + expODE.Message.ToString());
            }
            catch (Exception expCLBG)
            {

                //MessageBox.Show("Err BGM00" + expCLBG.Message.ToString());
                WriteLog("Err BGM01" + expCLBG.Message.ToString());
            }
        }

        private void AfficherLeModeBG(StringBuilder dataBG)
        {
            //Afficher les Raw Data
            lblDataBG.Text = dataBG.ToString();

            

            StringBuilder stb = dataBG;
            string EndString = "";
            countNoDataBG = 0;
            

            if (dataBG.Length > 2)
            {
                EndString = dataBG.ToString().Substring(dataBG.Length - 2);
            }


            //switch (EndString)
            //{
            //    case "91":
            //        //if (lastBgModeBD != "Tm+Range" && lastBgModeBD != "Tm+Tc")
            //        if (lastBgModeBD != "Tm+Tc")
            //        {
            //            //WriteLog("lastBgModeBD : " + lastBgModeBD);
            //            lblModeBG.Text = "TM";
            //            picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.GreenLight;
            //        }
            //        else
            //        {
            //            if (lastBgModeBD == "Tm+Range")
            //            {
            //                lblModeBG.Text = "TM+RG";
            //                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
            //            }
            //            else
            //            {
            //                if (lastBgModeBD == "Tm+Tc")
            //                {
            //                    lblModeBG.Text = "TM+TC";
            //                    picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;
            //                }
            //            }

            //        }
            //        break;
            //    case "92":
            //        lblModeBG.Text = "TM+RG";
            //        picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
            //        if (lastBgModeBD == "Tm+Tc") { lastBgModeBD = ""; }
            //        break;
            //    case "93":
            //        lblModeBG.Text = "TM+TC";
            //        picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;
            //        break;
            //    case "94":
            //        lblModeBG.Text = "TM+CLB";
            //        picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.BlueLight;
            //        break;
            //    default:
            //        break;
            //}

            switch (EndString)
            {
                case "91":

                    //TODO test si il été TM+RG (92)  (lastEndString) donc on test si il est pas encore le temps du RG
                    //notTimeOfRG (entre 15 et 25 ou entre 45 et 55)
                    //get minutes 

                    int minutes = DateTime.Now.Minute;

                    if (((minutes > 15 && minutes < 25) || (minutes > 45 && minutes < 55)) && lastEndString== "TM+RG")
                    {
                        lastBgModeBD = lastBgMode();
                        
                        WriteLog(MyDate() + " : lastBgModeBD = " + lastBgModeBD);
                    }


                    //if (lastBgModeBD == "Tm+Range")
                    //{
                    //    UpdateMode("TM+RG", StationWorkMode.Properties.Resources.YellowLight);
                    //}
                    //else if (lastBgModeBD == "Tm+Tc")
                    //{
                    //    UpdateMode("TM+TC", StationWorkMode.Properties.Resources.RedLight);
                    //}
                    //else
                    //{
                    //    UpdateMode("TM", StationWorkMode.Properties.Resources.GreenLight);
                    //}

                    if (lastBgModeBD != "Tm+Tc")
                    {
                        UpdateMode("TM", StationWorkMode.Properties.Resources.GreenLight);
                    }
                    else
                    {
                            if (lastBgModeBD == "Tm+Tc")
                            {
                                UpdateMode("TM+TC", StationWorkMode.Properties.Resources.RedLight);
                            }
                    }

                    break;

                case "92":
                    UpdateMode("TM+RG", StationWorkMode.Properties.Resources.YellowLight);
                    if (lastBgModeBD == "Tm+Tc")
                    {
                        lastBgModeBD = string.Empty; // Réinitialisation intentionnelle ?
                    }
                    break;

                case "93":
                    UpdateMode("TM+TC", StationWorkMode.Properties.Resources.RedLight);
                    break;

                case "94":
                    UpdateMode("TM+CLB", StationWorkMode.Properties.Resources.BlueLight);
                    break;

                default:
                    // Log ou gestion d'erreur pour les valeurs inattendues.
                    //Console.WriteLine($"Valeur inattendue : {EndString}");//TODO WriteLog();
                    
                    break;
            }

            lastEndString = lblModeBG.Text;
            

            //vider le string
            dataBG.Clear();

            //activer le test
            firstTickTimerTestBG = true;
            timerNoDataBG.Stop();
            timerNoDataBG.Start();
            //TDOD delete test
            //lblFristTickTimerTestBG.Text = firstTickTimerTestBG.ToString();
        }

        private void UpdateMode(string mode, Image indicator)
        {
            lblModeBG.Text = mode;
            picBoxAlarmBG.Image = indicator;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oldTime = DateTime.Now;
            lblTime.Font = myFont;
            lblTime2.Font = myFont;
            lblTime3.Font = myFont00;

            ////R1R2R3
            //lblR11.Font = myFont2;
            //lblR12.Font = myFont2;
            //lblR13.Font = myFont2;

            //lblR5.Font = myFont2;
            //lblR6.Font = myFont2;
            //lblR2.Font = myFont3;
            //lblR3.Font = myFont3;
            ////lblUtc.Font = myFontUtc;
            //lblR4.Font = myFont2;

            //sw.Close();

            

            //WriteLog(DateTime.Now.ToLongTimeString() + " : BC Mode : " + lblMode.Text);
            //WriteLog(DateTime.Now.ToLongTimeString() + " : BG Mode : " + lblModeBG.Text);

            ///create file sepirate from write log

            //test N/A
            //lblMode.Text = "N/A";
            //lblModeBG.Text = "N/A";

            //AfficherLeMode(data.Append("11 22 92"));
        }

        private void BeginRecieve()
        {
            try
            {
                ClientBC = new UdpClient(16010);
                ClientBC.BeginReceive(new AsyncCallback(recv), null);
            }
            catch (Exception ex)
            {
                lblData.Text = ex.Message.ToString();
                WriteLog(MyDate() + " : Port 16010 déja utilisé ");

            }
        }

        void recv(IAsyncResult res)
        {
            if (_closing || IsDisposed || Disposing)
                return;

            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 2222);

            try
            {
                byte[] received = ClientBC.EndReceive(res, ref RemoteIP);
                //data.Append(Encoding.Default.GetString(received));

                data.Append(BitConverter.ToString(received));
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Erreur BC000 : " + exp.Message.ToString());
                WriteLog("Erreur BC000 : " + exp.Message.ToString());
            }
            

            string str = data.ToString();
            str = str.Replace("-", " ");
            data.Clear();
            //break the string into chunksize
            int chunkSize = 48;
            int stringLength = str.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                //Console.WriteLine(str.Substring(i, chunkSize));
                string strToAppend = str.Substring(i, chunkSize);
                if (strToAppend.Length > 24)
                {
                    data.AppendLine(strToAppend.Insert(24, " "));
                }
                else
                {
                    data.AppendLine(strToAppend);
                }
            }

            if (data.Length > 2)
            {
                data.Remove(data.Length - 2, 2); 
            }


            //data = Formater(received);






            try
            {
                //To avoid cross threading we use methode invoker
                this.Invoke(new MethodInvoker(delegate
                {



                    //deduire le mode d'apres la fin du string
                    //Ecrire le mode , et changer la couleur d'image alarm

                    AfficherLeMode(data);



                    //label3.Text = received.ToString();
                    //timerBC.Enabled = true;
                }));

                ClientBC.BeginReceive(new AsyncCallback(recv), null);
            }
            catch (ObjectDisposedException expOde)
            {
                //ObjectDisposedException
                //MessageBox.Show("Erreur BCM00 : " + expOde.Message.ToString());
                WriteLog("Erreur BCM00 : " + expOde.Message.ToString());
                Console.WriteLine("Err AMG00" + expOde.Message.ToString());
            }
            catch (Exception expCLBC)
            {

                //MessageBox.Show("Erreur BCM01 : "+expCLBC.Message.ToString());
                WriteLog("Erreur BCM01 : " + expCLBC.Message.ToString());
            }
        }

        private void AfficherLeMode(StringBuilder data)
        {
            lblData.Text = data.ToString();
            
            StringBuilder stb = data;
            string EndString = "";
            countNoDataBC = 0;
            

            if (data.Length > 2)
            {
                EndString = data.ToString().Substring(data.Length - 2);

            }
            

            switch (EndString)
            {
                case "91":

                    lblMode.Text = "TM";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.GreenLight;
                    //Stop timer Write mesage !
                    //StopTcTimer();
                    break;

                case "92":

                    lblMode.Text = "TM+RG";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.YellowLight;
                    //Stop timer Write mesage !
                    //StopTcTimer();
                    break;
                case "93":

                    lblMode.Text = "TM+TC";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.RedLight;
                    //Start Tc Forgoten Check
                    //CheckTcForgotten();
                    break;
                case "94":

                    lblMode.Text = "TM+CLB";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.BlueLight;
                    //Stop timer Write mesage !
                    //StopTcTimer();
                    break;
                default:
                    //lblMode.Text = EndString;
                    break;
            }

            //vider le string
            data.Clear();

            //activer le test
            firstTickTimerTest = true;
            timerTest.Stop();
            timerTest.Start();

            //TDOD delete test
            //lblFristTickTimerTest.Text = firstTickTimerTest.ToString();
        }

        private void StopTcTimer()
        {

            tcFunctionCalls = 0;

            // Stop Tc timer // Write Message

            if (timerTC.Enabled)
            {
                timerTC.Enabled = false;
                timerTC.Interval = 6000;
                reminingTimeTC = 6000;

                //timerTC.Stop();
                WriteLog("Tc Timer Stopped with interval " + timerTC.Interval);
            }
            if (ClientTC != null)
            {
                try
                {
                    ClientTC.Close();
                }
                catch (Exception)
                {
                    WriteLog("ERR 400 Client Tc closed EXCEPTION");
                }
                
            }
        }

        private void CheckTcForgotten()
        {
            BeginRecieveTC();
        }

        private void BeginRecieveTC()
        {
            //add code to call this function one time
            //int = 0 + 1 time
            //return to zero if TC is gone
            if (tcFunctionCalls == 0)
            {
                timerTC.Enabled = true;
                tcFunctionCalls++;
                try
                {
                    ClientTC = new UdpClient(2246);
                    ClientTC.JoinMulticastGroup(IPAddress.Parse("239.0.0.5"));
                    ClientTC.BeginReceive(new AsyncCallback(recvTC), null);
                }
                catch (Exception ex)
                {
                    //lblData.Text = ex.Message.ToString();
                    WriteLog(MyDate() + " : Port 2246 déja utilisé ");
                    WriteLog("TC01" + ex.Message.ToString().Replace("\r\n", ""));

                }
            }
            
        }

        
        static int SearchBytes(byte[] haystack, byte[] needle)
        {
            var len = needle.Length;
            var limit = haystack.Length - len;
            for (var i = 0; i <= limit; i++)
            {
                var k = 0;
                for (; k < len; k++)
                {
                    if (needle[k] != haystack[i + k]) break;
                }
                if (k == len) return i;
            }
            return -1;
        }

        private byte[] MyStringToByteArray(string v)
        {
            string text = v;

            byte[] dataNewHex = new byte[0];
            if (text.Contains("-"))
            {
                dataNewHex = StringToByteArray(text.Replace("-", ""));
            }
            else
            {
                if (text.Contains(" "))
                {
                    dataNewHex = StringToByteArray(text.Replace(" ", ""));
                }
            }

            return dataNewHex;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        void recvTC(IAsyncResult res)
        {
            if (_closing || IsDisposed || Disposing)
                return;

            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 1111);

            try
            {

                if (ClientTC.Client != null)
                {
                    byte[] received = ClientTC.EndReceive(res, ref RemoteIP);
                    //data.Append(Encoding.Default.GetString(received));

                    //dataTC = GetGroupeValue_60E00601(received).ToString();
                    dataTC = GetTcNumber(received).ToString();
                }

            }
            catch (Exception exp)
            {
                //MessageBox.Show("Erreur : " + exp.Message.ToString());
                WriteLog(MyDate() + " Erreur TCM00 : " + exp.Message.ToString());
                //throw exp;
            }

            
            try
            {
                //To avoid cross threading we use methode invoker
                this.Invoke(new MethodInvoker(delegate
                {
                    //afficher data
                    if (dataTC != null)
                    {
                        //lblTC.Text = dataTC.ToString();
                    }
                }));

                if (ClientTC.Client != null)
                {
                    ClientTC.BeginReceive(new AsyncCallback(recvTC), null);
                }
                
            }
            catch (Exception expCLBC)
            {
                //MessageBox.Show("Erreur TCM01 : " + expCLBC.Message.ToString());
                WriteLog("Erreur TCM01 : " + expCLBC.Message.ToString());
                //throw expCLBC;
            }
        }

        private object GetTcNumber(byte[] received)
        {
            string value = "N/A";
            //parcourir jusqu'a la valeur 42 6c !! 66 198
            byte[] groupeIndex = MyStringToByteArray("01 06 E0 60");
            //
            byte[] kiSymbole = MyStringToByteArray("3C 4B 49 3E");

            //WriteLog(MyDate() + " :  MyStringToByteArray 42 C6 ");
            int index = SearchBytes(received, groupeIndex);

            //copy the received byte array (of last 400 bytes ) to a new bytearray to search in for tc number ! 
            byte[] received400 = new byte[201];
            if (index > 0 && received.Length - index > 200)
            {
                Array.Copy(received, index, received400, 0, 200);
            }

            int indexKi = -1;

            if (received400.Length > 1)
            {
                indexKi = SearchBytes(received400, kiSymbole);
            }

            //index = Array.
            //prendre la valeur i+4
            if (indexKi > -1 && indexKi + 4 < received400.Length)
            {
                //value = "0x" + BitConverter.ToString(received400, indexKi + 4, 3);
                value = "K"+Encoding.ASCII.GetString(received400, indexKi + 4, 3).Replace("<","");
                //dire que cmd send, => restart timer
                WriteLog(MyDate() + " : cmd Sent timerTC. /Stop /Start CMD : " + value);

                timerTC.Stop();
                WriteLog(MyDate() + " : timerTC.Stop(); " + timerTC.Enabled);
                timerTC.Start();
                WriteLog(MyDate() + " : timerTC.Start(); " + timerTC.Enabled);
                timerTC.Interval = 1000;
            }
            //WriteLog(MyDate() + " :  value " + value.ToString());

            //if CMD sent the timer begin from 0
            //timerTcAlarm return to 0.

            return value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLastBgModeDB.Text = lastBgModeBD;
            lblEndString.Text = lastEndString;
            //if (chkBoxUtc.Checked)
            //{
            //    lblTime.Text = DateTime.Now.AddHours(0).ToLongTimeString();
            //}
            //else
            //{
            //    lblTime.Text = DateTime.Now.AddHours(+1).ToLongTimeString();
            //}

            lblTime.Text = DateTime.Now.AddHours(0).ToString(xformat);
            lblTime2.Text = DateTime.Now.AddHours(+1).ToString("HH:mm");
            lblTime3.Text = DateTime.Now.AddHours(0).ToString("ss");

            //test
            //lblTimerTC.Text = timerTC.Interval.ToString();
            //lblTimerTCEnabled.Text = timerTC.Enabled.ToString();

            //******
            //if (reminingTimeTC <= 0)
            //{
            //    reminingTimeTC = timerTC.Interval;
            //    timerTC.Start();
            //    WriteLog("timerTC.Start();");
            //}
            //if (timerTC.Enabled)
            //{
            //    reminingTimeTC = reminingTimeTC - 500;
            //    WriteLog("timerTC.Interval : " + timerTC.Interval.ToString() + " remining : " + (reminingTimeTC).ToString());
            //}
            

            if (DateTime.Now.Date != oldTime.Date)
            {
                //Refresh
                LoadRgProgram();
            }

            oldTime = DateTime.Now;
        }

        public void TestSendDataBG(StringBuilder testData)
        {
            AfficherLeModeBG(testData);
            //TODO timerBG.Enabled = true;
        }

        public void TestSendDataBC(StringBuilder testData)
        {

            AfficherLeMode(testData);
            //TODO timerBC.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////**************OLD CODE****************************
            //// si la fenetere plus que min  ok btn recois Hide !
            //// le btn 

            ////728; 316
            ////this.Size = new Size(728, 316);
            ////btnMore.Visible = false;

            //if (!Max)
            //{
            //    //368; 581
            //    //368; 539
            //    //mode show , = fenetre max
            //    btnMore.Text = "Less <";
            //    //minimiser la fenetre 
            //    this.Size = new Size(368, 540);
            //    Max = true;


            //}
            //else
            //{
            //    //Max is false // fenetre mini
            //    //368; 301
            //    //mode not show 
            //    btnMore.Text = "More >";
            //    //Maximiser la fenetre
            //    this.Size = new Size(368, 300);
            //    Max = false;

            //}

            //****************NEW CODE*****************

            if (splitContainer2.Panel1Collapsed)
            {
                //change form dimention to 720; 315
                this.Size = new Size(bigFormWidth, bigFormHight);
                //change form position // faire décalage
                this.Left -= 685 - 365;


                splitContainer2.Panel1Collapsed = false;
                splitContainer2.Panel2Collapsed = false;
            }
            
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            //383; 316
            this.Size = new Size(smallFormWidth, smallFormHight);
            btnMoreData.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if 3 fois no Data then
            //Counter +1
            if (data.Length == 0)
            {
                if (countNoDataBC >3)
                {
                    lblMode.Text = "No TM";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.BlackLight;
                    countNoDataBC = 0;
                    timerBC.Enabled = false;
                    // Stop Tc timer // Write Message
                    StopTcTimer();
                }
                else
                {
                    countNoDataBC++;
                }
            }
            else
            {
                //TODO rendre 0 ...
                countNoDataBC = 0;
            }
            //TODO afficher le counteur

            //lblCountNoDataBC.Text = countNoDataBC.ToString();
        }

        private void timerBG_Tick(object sender, EventArgs e)
        {
            if (dataBG.Length == 0)
            {
                if (countNoDataBG > 3)
                {
                    lblModeBG.Text = "Idle";
                    picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.BlackLight;
                    countNoDataBG = 0;
                    timerBG.Enabled = false;
                }
                else
                {
                    countNoDataBG++;
                }

            }
            else
            {
                countNoDataBG = 0;
            }
            //afficher le counteur

            //lblCountNoDataBG.Text = countNoDataBG.ToString();

        }

        private void timerTest_Tick(object sender, EventArgs e)
        {

            if (!firstTickTimerTest)
            {
                //TODO set mode to Idle, if data is null
                if (data.Length == 0)
                {
                    lblMode.Text = "No TM";
                    picBoxAlarm.Image = StationWorkMode.Properties.Resources.BlackLight;
                    timerTest.Stop();
                    //lblFristTickTimerTest.Text = firstTickTimerTest.ToString();
                }
                else
                {
                    //timerTest.Enabled = false;
                    //timerTest.Stop();
                }
                //TestSendDataBC();
                //TestSendDataBG();
                firstTickTimerTest = true;
                //lblFristTickTimerTest.Text = firstTickTimerTest.ToString();
            }
            else
            {
                firstTickTimerTest = false;
                //lblFristTickTimerTest.Text = firstTickTimerTest.ToString();
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            FormTest form2 = new FormTest();
            form2.Show();

        }

        private void timerNoDataBG_Tick(object sender, EventArgs e)
        {
            if (!firstTickTimerTestBG)
            {
                if (dataBG.Length == 0)
                {
                    lblModeBG.Text = "No TM";
                    picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.BlackLight;
                    timerNoDataBG.Enabled = false;
                    //lblFristTickTimerTestBG.Text = firstTickTimerTestBG.ToString();
                }
                //TestSendDataBC();
                //TestSendDataBG(); 
                firstTickTimerTestBG = true;
                //lblFristTickTimerTestBG.Text = firstTickTimerTestBG.ToString();
            }
            else
            {
                firstTickTimerTestBG = false;
                //lblFristTickTimerTestBG.Text = firstTickTimerTestBG.ToString();
            }
        }

        

        private void timerFirstTime_Tick(object sender, EventArgs e)
        {
            int minutes = DateTime.Now.Minute;

            //if start in BC intervales

            //LOG TIMER
            //WriteLog(DateTime.Now.ToLongTimeString() + " : " + lblMode.Text + " : timerFirstTime_Tick Log");


            ///BC intervales
            ///00 mins to 10 mins
            ///30 mins to 40 mins
            ///Test RangMiss
            ///
            if ((minutes > 0 && minutes < 10) || (minutes > 30 && minutes < 40))
            {

                //si le mode n'est pas TM+RG
                //on affiche le message missing

                if (lblMode.Text == "TM")
                {
                    //le jour du jour dans le tableau donne RG ON !
                    if (monTableauDeStrings != null && monTableauDeStrings[DateTime.Now.Day - 1] == "ON")
                    {
                        //TODO Stop Gadget ! show principal Form !

                        RestoreMainForm();

                        //Alarm
                        lblRgMessage.Visible = true;
                        btnAck.Visible = true;
                        //cbxOK.Checked = false;
                        //cbxOK.Visible = true;

                        //fenetre show
                        //this.Restore();

                        //timerFirstTime.Interval = 1000 * 60 * 30;//TODO 1000*60*30
                        //TODO if not alarm timer stay small !!possible (TC ou CLB)
                        //TODO log file

                        ///Function WriteLog
                        ///entree Time + Message
                        ///ecrire dans ce temps Mode trouvé, + alaram lancé.
                        ///End
                        ///

                        WriteLog(MyDate() + " : " + lblMode.Text + " : BC Rang. Missing");

                        //lblRgMessage.Text = timerFirstTime.Interval.ToString();

                        //timerFirstTime.Stop();
                        //timerFirstTime.Start();

                        //substuct the minutes supplimentaire from interval and add them in final
                        int timeSup = 0;
                        //calculer le temps
                        if (minutes > 30)
                        {
                            timeSup = (minutes - 31) * 60 * 1000;
                        }
                        else
                        if (minutes > 0 && minutes < 30)
                        {
                            timeSup = (minutes - 1) * 60 * 1000;
                        }
                        timerRgMissBC.Interval = 1800000 - timeSup;
                        //une variable booleen , subed , ca vedire le temps de l'interval été changé
                        subed = true;

                        PlayAlarmSound();
                    }

                    

                }

                //else 
                ///if start not in intervals
                ///wait intel interval

                //*************************************************************************************
                //stop le timer first time
                //demarer le timer de tjr

                timerRgMissBC.Start();
                
                timerFirstTime.Stop();

            }


            //else 
            ///if start not in intervals
            ///wait intel interval

        }

        private void RestoreMainForm()
        {
            //throw new NotImplementedException();
        }

        private void timerRgMissBC_Tick(object sender, EventArgs e)
        {

            if (subed)
            {
                //reset interval
                timerRgMissBC.Interval = 1800000;
                subed = false;
            }

            int minutes = DateTime.Now.Minute;

            //if start in BC intervales

            //LOG timer
            //WriteLog(DateTime.Now.ToLongTimeString() + " : " + lblMode.Text + " : timerRgMissBC_Tick Log");

            ///BC intervales
            ///00 mins to 10 mins
            ///30 mins to 40 mins
            ///Test RangMiss
            ///
            if ((minutes > 0 && minutes < 10) || (minutes > 30 && minutes < 40))
            {
                //si le mode n'est pas TM+RG
                //on affiche le message missing

                if (lblMode.Text == "TM")
                {
                    //le jour du jour dans le tableau donne RG ON !
                    if (monTableauDeStrings != null && monTableauDeStrings[DateTime.Now.Day-1] == "ON")
                    {
                        //TODO Stop Gadget ! show principal Form !

                        //Test RangMiss
                        lblRgMessage.Visible = true;
                        btnAck.Visible = true;
                        //cbxOK.Checked = false;
                        //cbxOK.Visible = true;

                        WriteLog(MyDate() + " : " + lblMode.Text + " : BC Rang. Missing");

                        //lblRgMessage.Text = timerFirstTime.Interval.ToString();

                        //timerFirstTime.Stop();
                        //timerFirstTime.Start();
                        PlayAlarmSound();
                    }

                    
                }

                //else 
                ///if start not in intervals
                ///wait intel interval



            }

        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txbLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txbLog.Text = text;
            }
        }

        public void WriteLog(string v)
        {
                //witre log in textBox

                strLogText.AppendLine(v);
                string stringLog = strLogText.ToString();


                //txbLog.Text = stringLog.Remove(stringLog.Length - 2, 2);
                SetText(stringLog.Remove(stringLog.Length - 2, 2));
        }

        //private void WriteLogFile(string v)
        //{
        //    //impossible d'ecrire dans un textwriter fermé !
        //    try
        //    {
        //        using (var nsw = new StreamWriter(fileName, true))
        //        {
        //            //witre log in textlab

        //            strLogText.AppendLine(v);
        //            string stringLog = strLogText.ToString();
        //            txbLog.Text = stringLog.Remove(stringLog.Length - 2, 2);


        //            nsw.WriteLine(v);
        //            nsw.Close();

        //        }
        //    }
        //    catch (Exception x)
        //    {

        //        MessageBox.Show(x.Message);
        //    }
        //}

        private void SaveLog()
        {
            string TimeValide = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() +
            DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();

            string fileName = @"D:\Temp\LogStationWorkMode" + TimeValide + ".txt";
            //TODO logFile on the same path

            //impossible d'ecrire dans un textwriter fermé !
            try
            {
                using (var nsw = new StreamWriter(fileName))
                {
                    //witre log in textlab

                    //strLogText.AppendLine(v);
                    //string stringLog = strLogText.ToString();
                    //txbLog.Text = stringLog.Remove(stringLog.Length - 2, 2);


                    nsw.WriteLine(txbLog.Text);
                    nsw.Close();

                }
            }
            catch (Exception x)
            {

                //MessageBox.Show("Err SavecLOG 000 : " + x.Message);
                WriteLog("Err SavecLOG 000 : " + x.Message);
            }
        }

        private string ConvertTimeToValidString(DateTime now)
        {
            return now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + now.Millisecond.ToString();
        }

        private void lblRgMessage_DoubleClick(object sender, EventArgs e)
        {
            //lblRgMessage.Visible = false;
            

            //WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + lblRgMessage.Text);
            //WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + lblRgMessageBG.Text );
        }

        private void lblR2_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            //if (xformat.Equals("HH:mm"))
            //{
            //    xformat = "HH:mm:ss";
            //}
            //else
            //{
            //    xformat = "HH:mm";
            //}

            if (lblTime3.Visible)
            {
                lblTime3.Visible = false;
            }
            else
            {
                lblTime3.Visible = true;
            }
        }

        private void txbLog_TextChanged(object sender, EventArgs e)
        {
            txbLog.SelectionStart = txbLog.Text.Length;
            txbLog.ScrollToCaret();
        }

        private void lblMode_TextChanged(object sender, EventArgs e)
        {
            if (lblMode.Text == "No TM")
            {
                lblMode.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMode.ForeColor = System.Drawing.Color.Black;
            }

            WriteLog(MyDate() + " : BC Mode : " + lblMode.Text );
        }

        private void lblModeBG_TextChanged(object sender, EventArgs e)
        {
            if (lblModeBG.Text == "No TM")
            {
                lblModeBG.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblModeBG.ForeColor = System.Drawing.Color.Black;
            }
            WriteLog(MyDate() + " : BG Mode : " + lblModeBG.Text);
        }

        private void btnLess_Click_1(object sender, EventArgs e)
        {

            //if (!splitContainer2.Panel2Collapsed)
            //{
            //    //return to  small form
            //    this.Size = new Size(380, 315);
            //    //returen to corn postion
            //    this.Left += 720 - 380;
            //    splitContainer2.Panel2Collapsed = false;
            //    splitContainer2.Panel1Collapsed = true;
            //}
            
        }

        private void btnMoreData_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel1Collapsed)
            {
                //change form dimention to 720; 346
                this.Size = new Size(bigFormWidth, bigFormHight);
                //change form position // faire décalage
                this.Left -= bigFormWidth - smallFormWidth;


                splitContainer2.Panel1Collapsed = false;
                splitContainer2.Panel2Collapsed = false;

                btnMoreData.Visible = false;
                btnLessData.Visible = true;

                // Figure out which screen we're on
                //var allScreens = Screen.AllScreens.ToList();
                //var thisScreen = allScreens.SingleOrDefault(s => this.Left >= s.WorkingArea.Left && this.Left < s.WorkingArea.Right);

                if (this.Left <0)
                {
                    this.Left = 10;
                }
                
            }
        }

        private void btnLessData_Click(object sender, EventArgs e)
        {

            if (!splitContainer2.Panel2Collapsed)
            {
                //return to  small form //715; 346
                this.Size = new Size(smallFormWidth, smallFormHight);
                //returen to corn postion
                this.Left += bigFormWidth - smallFormWidth;
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.Panel1Collapsed = true;

                btnMoreData.Visible = true;
                btnLessData.Visible = false;
            }
        }

        private void timerRgMissBG_Tick(object sender, EventArgs e)
        {
            if (subedBG)
            {
                //reset interval to30 minutes
                timerRgMissBG.Interval = 1800000;
                subedBG = false; //fin  de l'action de soustraction du temps qui décale entre une heure pille  et demi heure
            }

            int minutes = DateTime.Now.Minute;

            //if start in BC intervales

            //LOG timer
            //WriteLog(DateTime.Now.ToLongTimeString() + " : " + lblMode.Text + " : timerRgMissBC_Tick Log");

            ///BC intervales
            ///15 mins to 25 mins
            ///45 mins to 55 mins
            ///Test RangMiss
            ///
            if ((minutes > 15 && minutes < 25) || (minutes > 45 && minutes < 55))
            {
                //si le mode n'est pas TM+RG
                //on affiche le message missing

                if (lblModeBG.Text == "TM" || lblModeBG.Text == "TM+TC")
                {
                    //le jour du jour dans le tableau donne RG ON !
                    if (monTableauDeStrings != null && monTableauDeStrings[DateTime.Now.Day - 1] == "ON")
                    {
                        lastBgModeBD = lastBgMode();
                        //get lastBgMode
                        WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);

                        //if lastBgMode() is tm and not Tc or ranging than alarm

                        // Switch pour gérer les différents cas
                        switch (lastBgModeBD)
                        {
                            case "Tm":
                                //TODO Stop Gadget ! show principal Form !

                                //Alarm RangMiss
                                lblRgMessageBG.Visible = true;
                                btnAckBG.Visible = true;

                                WriteLog(MyDate() + " : " + lblModeBG.Text + " : BG Rang. Missing");

                                PlayAlarmSound();
                                break;

                            case "Tm+Tc":
                                lblModeBG.Text = "TM+TC";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;
                                break;

                            case "Tm+Range":
                                lblModeBG.Text = "TM+RG";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
                                break;

                            default:
                                
                                break;
                        }



                        
                        
                        
                    }
                    else
                    {
                        lastBgModeBD = lastBgMode();
                        //get lastBgMode
                        WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);

                        // Switch pour gérer les différents cas
                        switch (lastBgModeBD)
                        {
                            case "Tm":
                                lblModeBG.Text = "TM";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.GreenLight;
                                break;

                            case "Tm+Tc":
                                lblModeBG.Text = "TM+TC";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;
                                break;

                            case "Tm+Range":
                                lblModeBG.Text = "TM+RG";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
                                break;

                            default:

                                break;
                        }
                    }

                    
                }

            }
        }

        private void timerFirstTimeBG_Tick(object sender, EventArgs e)
        {
            int minutes = DateTime.Now.Minute;

            //if start in BC intervales

            //LOG TIMER
            //WriteLog(DateTime.Now.ToLongTimeString() + " : " + lblMode.Text + " : timerFirstTime_Tick Log");


            ///BC intervales
            ///00 mins to 10 mins
            ///30 mins to 40 mins
            ///Test RangMiss
            ///
            if ((minutes > 15 && minutes < 25) || (minutes > 45 && minutes < 55))
            {

                //si le mode n'est pas TM+RG
                //on affiche le message missing

                if (lblModeBG.Text == "TM" || lblModeBG.Text == "TM+TC")
                {
                    //le jour du jour dans le tableau donne RG ON !
                    if (monTableauDeStrings != null && monTableauDeStrings[DateTime.Now.Day - 1] == "ON")
                    {
                        //get lastBgMode
                        lastBgModeBD = lastBgMode();
                        
                        WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);

                        // Switch pour gérer les différents cas
                        switch (lastBgModeBD)
                        {
                            case "Tm":
                                //TODO Stop Gadget ! show principal Form !

                                //Alarm RangMiss

                                lblRgMessageBG.Visible = true;
                                btnAckBG.Visible = true;
                                //cbxOKBG.Checked = false;
                                //cbxOKBG.Visible = true;

                                WriteLog(MyDate() + " : " + lblModeBG.Text + " : BG Rang. Missing");

                                //substuct the minutes supplimentaire from interval and add them in final
                                int timeSup = 0;
                                //calculer le temps
                                if (minutes > 45)
                                {
                                    timeSup = (minutes - 46) * 60 * 1000;
                                }
                                else
                                if (minutes > 15 && minutes < 25)
                                {
                                    timeSup = (minutes - 16) * 60 * 1000;
                                }
                                timerRgMissBG.Interval = 1800000 - timeSup;
                                //une variable booleen , subed , ca vedire le temps de l'interval été changé
                                subedBG = true;

                                PlayAlarmSound();
                                break;

                            case "Tm+Tc":
                                lblModeBG.Text = "TM+TC";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;

                                //TODO voir si ca must be deleted
                                //substuct the minutes supplimentaire from interval and add them in final
                                timeSup = 0;
                                //calculer le temps
                                if (minutes > 45)
                                {
                                    timeSup = (minutes - 46) * 60 * 1000;
                                }
                                else
                                if (minutes > 15 && minutes < 25)
                                {
                                    timeSup = (minutes - 16) * 60 * 1000;
                                }
                                timerRgMissBG.Interval = 1800000 - timeSup;
                                //une variable booleen , subed , ca vedire le temps de l'interval été changé
                                subedBG = true;
                                break;

                            case "Tm+Range":
                                lblModeBG.Text = "TM+RG";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
                                break;

                            default:

                                break;
                        }

                        
                    }
                    else
                    {
                        //get lastBgMode
                        lastBgModeBD = lastBgMode();

                        WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);

                        // Switch pour gérer les différents cas
                        switch (lastBgModeBD)
                        {
                            case "Tm":
                                lblModeBG.Text = "TM";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.GreenLight;
                                break;

                            case "Tm+Tc":
                                lblModeBG.Text = "TM+TC";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.RedLight;
                                break;

                            case "Tm+Range":
                                lblModeBG.Text = "TM+RG";
                                picBoxAlarmBG.Image = StationWorkMode.Properties.Resources.YellowLight;
                                break;

                            default:

                                break;
                        }
                    }

                    

                }

                //else 
                ///if start not in intervals
                ///wait intel interval

                //*************************************************************************************
                //stop le timer first time
                //demarer le timer de tjr

                timerRgMissBG.Start();

                timerFirstTimeBG.Stop();

            }


            //else 
            ///if start not in intervals
            ///wait intel interval
        }

        private void lblRgMessageBG_DoubleClick(object sender, EventArgs e)
        {
            //lblRgMessageBG.Visible = false;

            //WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + lblRgMessageBG.Text);
        }

        private void ackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lblRgMessage.Visible = false;

            //WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + lblRgMessage.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //lblRgMessageBG.Visible = false;

            //WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + lblRgMessageBG.Text);
        }

        private void cbxOK_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbxOK.Checked)
            //{
            //    //lblRgMessage.Visible = false;
            //    cbxOK.Visible = false;
            //    WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + cbxOK.Text);
            //}
        }

        private void cbxOKBG_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbxOKBG.Checked)
            //{
            //    //lblRgMessageBG.Visible = false;
            //    cbxOKBG.Visible = false;
            //    WriteLog(DateTime.Now.ToLongTimeString() + " : Acknowledge : " + cbxOKBG.Text);
            //}
        }

        private void btnAck_Click(object sender, EventArgs e)
        {
            lblRgMessage.Visible = false;
            WriteLog(MyDate() + " : Ack : BC Rang. Missing");
            btnAck.Visible = false;

            player.Stop();
        }

        private void btnAckBG_Click(object sender, EventArgs e)
        {
            lblRgMessageBG.Visible = false;
            WriteLog(MyDate() + " : Ack : BG Rang. Missing");
            btnAckBG.Visible = false;

            player.Stop();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Alt | Keys.T))
            {
                FormTest form2 = new FormTest();
                form2.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //private void chkBoxUtc_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkBoxUtc.Checked)
        //    {
        //        //UTC
        //        lblR4.Text = "UTC" + Environment.NewLine + "Time";
        //        lblR4.Font = new Font(lblR4.Font, FontStyle.Regular);
        //        lblR4.ForeColor = Color.OliveDrab;
        //        lblTime.ForeColor = Color.OliveDrab;
        //        //lblTime.BackColor = Color.LightGreen;
        //    }
        //    else
        //    {
        //        //Local
        //        //lblR4.Text = Environment.NewLine + "Time";
        //        lblR4.Text = "Local" + Environment.NewLine + "Time";
        //        lblR4.Font = new Font(lblR4.Font, FontStyle.Regular);
        //        lblR4.ForeColor = Color.Black;
        //        lblTime.ForeColor = Color.Black;
        //        //lblTime.BackColor = Color.Transparent;
        //    }
        //}

        private void rangingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlan form3 = new FormPlan();
            form3.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRgProgram();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveLog();
        }

        private void getFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRgProgram();
        }

        private void timerTC_Tick(object sender, EventArgs e)
        {
            //Si le mode est TC , on déclanche l'alame et si pa le firstTick

            if (lblMode.Text == "TM+TC" )
            {
                lblTCAlarm.Visible = true;
                btnAckTC.Visible = true;
                reminingTimeTC = timerTC.Interval;
                WriteLog(MyDate() + " : lblTCAlarm !");
            }
        }

        private void btnAckTC_Click(object sender, EventArgs e)
        {
            lblTCAlarm.Visible = false;
            //timerTC.Stop();
            WriteLog(MyDate() + " : TC Acknowledgement !");
            btnAckTC.Visible = false;
        }

        internal string dataBase = "global";
        internal string server = "127.0.0.1";
        internal string user = "root1";
        internal string password = "123456";

        public string lastBgMode()
        {
            // show form for waiting 

            //FormDBWait formDBWait = new FormDBWait();
            //formDBWait.Location = this.Location; // Set the start position to match the main form
            //formDBWait.Show();

            if (compilationMode == "Local")
            {
                return GetLastBgModeFromConnection("Local");
            }

            if (compilationMode == "SCC")
            {
                // Try SCC1 first
                string result = GetLastBgModeFromConnection("DB1");

                if (result != "KO")
                {
                    //formDBWait.Close();
                    return result;
                }

                WriteLog(MyDate() + " : DB1 failed, trying DB2...");

                // DB1 failed -> try DB2
                result = GetLastBgModeFromConnection("DB2");

                if (result != "KO")
                {
                    return result;
                }

                WriteLog(MyDate() + " : DB1 and DB2 failed.");

                //formDBWait.Close();

                return "KO";
            }

            //formDBWait.Close();

            WriteLog(MyDate() + " : Unknown compilation mode: " + compilationMode);

            return "KO";
        }

        private string GetLastBgModeFromConnection(string connectionName)
        {
            try
            {
                ConnectionStringSettings connectionSettings =
                    ConfigurationManager.ConnectionStrings[connectionName];

                if (connectionSettings == null)
                {
                    WriteLog(MyDate() + " : Connection string not found: " + connectionName);
                    return "KO";
                }

                string connectionString = connectionSettings.ConnectionString;

                using (MySql.Data.MySqlClient.MySqlConnection conn =
                       new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    conn.Open();

                    WriteLog(MyDate() + " : MySQL connection OK: " + connectionName);

                    string query =
                        "SELECT remark " +
                        "FROM `dais_eventandalarm` " +
                        "WHERE `remark` LIKE '%DEV[EEA884E7]%' " +
                        "ORDER BY `occur_time` DESC " +
                        "LIMIT 1;";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            WriteLog(MyDate() + " : No result from " + connectionName);
                            return "KO";
                        }

                        string sqlResult = result.ToString();

                        return ExtractMode(sqlResult);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog(
                    MyDate() + " : MySQL connection/query failed [" +
                    connectionName + "] : " +
                    ex.Message
                );

                return "KO";
            }
        }

        static string ExtractMode(string input)
        {
            // Expression régulière pour capturer le mode après "to"
            string pattern = @"to\s(\S+)";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                // Retourne le groupe capturé (le mode)
                return match.Groups[1].Value;
            }

            return string.Empty; // Retourne une chaîne vide si pas de correspondance
        }

        private void timerDB_Tick(object sender, EventArgs e)
        {
            //rendre ce timer marche avec le timer Ranging, et (chaque 30 minutes)
            
            lastBgModeBD = lastBgMode();

            WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);
        }

        private void stopDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(dbModeBG)
            {
                stopDataBaseTSMItem.Text = "Start databBase";
                timerDB.Stop();
                dbModeBG = false;
            }
            else
            {
                stopDataBaseTSMItem.Text = "Stop databBase";
                timerDB.Start();
                dbModeBG = true;
            }
            
        }

        private void refreshDBBGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastBgModeBD = lastBgMode();

            WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);
        }

        private void dBConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastBgModeBD = lastBgMode();

            WriteLog(MyDate() + " : lastBgMode = " + lastBgModeBD);
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Screen screen = Screen.FromControl(this);

            // Vérifiez si la fenêtre est proche du bord droit
            if (this.Right >= screen.WorkingArea.Right - 10) // Ajustez la marge si nécessaire
            {
                // Réduire la fenêtre principale
                //this.Size = new Size(600, 600);
                //minimiser la fenetre principal
                this.Hide();

                //afficher la form6

                Form6 form6 = new Form6();
                // Positionner et afficher Form6
                form6.StartPosition = FormStartPosition.Manual;
                form6.Location = new Point(screen.WorkingArea.Right - form6.Width + 10, 30); // À gauche
                if (!form6.Visible)
                    form6.Show();
            }
            // Si la fenêtre revient dans une position normale, cacher Form6
            //else if (this.Left > 10 && form6.Visible)
            //{
            //    form6.Hide();
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
            ClientBC?.Close();
            ClientBG?.Close();
        }
    }
}
