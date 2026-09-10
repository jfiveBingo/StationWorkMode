using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace StationWorkMode
{
    public partial class FormPlan : Form
    {
        // file path
        public string filePath = @"\\OP1\Users\Public\Boughrara\file.dat";
        public string filePath1 = @"C:\Users\Public\Boughrara\file.dat";
        //public string filePath1 = @"D:\file.dat";

        //liste of lblDate
        List<Label> lblDateList = new List<Label>();

        //liste of lblDay
        List<Label> lblDayList = new List<Label>();

        //liste of lblRG
        List<Label> lblRGList = new List<Label>();

        //liste of cbx
        List<CheckBox> cbxList = new List<CheckBox>();
        private int currentMonth = 0;

        internal MyClass Myobject { get; private set; }

        private FileStream fileStream;
        private int nbJoursSup;
        private bool Editing = false;

        public FormPlan()
        {
            InitializeComponent();


            // put labels in lblDateList
            lblDateList.Add(lblDate1);
            lblDateList.Add(lblDate2);
            lblDateList.Add(lblDate3);
            lblDateList.Add(lblDate4);
            lblDateList.Add(lblDate5);
            lblDateList.Add(lblDate6);
            lblDateList.Add(lblDate7);
            lblDateList.Add(lblDate8);
            lblDateList.Add(lblDate9);
            lblDateList.Add(lblDate10);
            lblDateList.Add(lblDate11);
            lblDateList.Add(lblDate12);
            lblDateList.Add(lblDate13);
            lblDateList.Add(lblDate14);
            lblDateList.Add(lblDate15);
            lblDateList.Add(lblDate16);
            lblDateList.Add(lblDate17);
            lblDateList.Add(lblDate18);
            lblDateList.Add(lblDate19);
            lblDateList.Add(lblDate20);
            lblDateList.Add(lblDate21);
            lblDateList.Add(lblDate22);
            lblDateList.Add(lblDate23);
            lblDateList.Add(lblDate24);
            lblDateList.Add(lblDate25);
            lblDateList.Add(lblDate26);
            lblDateList.Add(lblDate27);
            lblDateList.Add(lblDate28);
            lblDateList.Add(lblDate29);
            lblDateList.Add(lblDate30);
            lblDateList.Add(lblDate31);
            

            // put labels in lblDayList
            lblDayList.Add(lblDay1);
            lblDayList.Add(lblDay2);
            lblDayList.Add(lblDay3);
            lblDayList.Add(lblDay4);
            lblDayList.Add(lblDay5);
            lblDayList.Add(lblDay6);
            lblDayList.Add(lblDay7);
            lblDayList.Add(lblDay8);
            lblDayList.Add(lblDay9);
            lblDayList.Add(lblDay10);
            lblDayList.Add(lblDay11);
            lblDayList.Add(lblDay12);
            lblDayList.Add(lblDay13);
            lblDayList.Add(lblDay14);
            lblDayList.Add(lblDay15);
            lblDayList.Add(lblDay16);
            lblDayList.Add(lblDay17);
            lblDayList.Add(lblDay18);
            lblDayList.Add(lblDay19);
            lblDayList.Add(lblDay20);
            lblDayList.Add(lblDay21);
            lblDayList.Add(lblDay22);
            lblDayList.Add(lblDay23);
            lblDayList.Add(lblDay24);
            lblDayList.Add(lblDay25);
            lblDayList.Add(lblDay26);
            lblDayList.Add(lblDay27);
            lblDayList.Add(lblDay28);
            lblDayList.Add(lblDay29);
            lblDayList.Add(lblDay30);
            lblDayList.Add(lblDay31);
            

            // put labels in lblRGList
            lblRGList.Add(lblRG1);
            lblRGList.Add(lblRG2);
            lblRGList.Add(lblRG3);
            lblRGList.Add(lblRG4);
            lblRGList.Add(lblRG5);
            lblRGList.Add(lblRG6);
            lblRGList.Add(lblRG7);
            lblRGList.Add(lblRG8);
            lblRGList.Add(lblRG9);
            lblRGList.Add(lblRG10);
            lblRGList.Add(lblRG11);
            lblRGList.Add(lblRG12);
            lblRGList.Add(lblRG13);
            lblRGList.Add(lblRG14);
            lblRGList.Add(lblRG15);
            lblRGList.Add(lblRG16);
            lblRGList.Add(lblRG17);
            lblRGList.Add(lblRG18);
            lblRGList.Add(lblRG19);
            lblRGList.Add(lblRG20);
            lblRGList.Add(lblRG21);
            lblRGList.Add(lblRG22);
            lblRGList.Add(lblRG23);
            lblRGList.Add(lblRG24);
            lblRGList.Add(lblRG25);
            lblRGList.Add(lblRG26);
            lblRGList.Add(lblRG27);
            lblRGList.Add(lblRG28);
            lblRGList.Add(lblRG29);
            lblRGList.Add(lblRG30);
            lblRGList.Add(lblRG31);
            


            // put cbx in cbxList
            cbxList.Add(cbx1);
            cbxList.Add(cbx2);
            cbxList.Add(cbx3);
            cbxList.Add(cbx4);
            cbxList.Add(cbx5);
            cbxList.Add(cbx6);
            cbxList.Add(cbx7);
            cbxList.Add(cbx8);
            cbxList.Add(cbx9);
            cbxList.Add(cbx10);
            cbxList.Add(cbx11);
            cbxList.Add(cbx12);
            cbxList.Add(cbx13);
            cbxList.Add(cbx14);
            cbxList.Add(cbx15);
            cbxList.Add(cbx16);
            cbxList.Add(cbx17);
            cbxList.Add(cbx18);
            cbxList.Add(cbx19);
            cbxList.Add(cbx20);
            cbxList.Add(cbx21);
            cbxList.Add(cbx22);
            cbxList.Add(cbx23);
            cbxList.Add(cbx24);
            cbxList.Add(cbx25);
            cbxList.Add(cbx26);
            cbxList.Add(cbx27);
            cbxList.Add(cbx28);
            cbxList.Add(cbx29);
            cbxList.Add(cbx30);
            cbxList.Add(cbx31);
            

        }

        private void WriteLogForm1(string message)
        {
            var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                form1.WriteLog(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!Editing)
            //{
            //    
            //    button1.Text = "Cancel";
            //    Editing = true;
            //}
            //else
            //{
            //    MakeBoxesInvisible();

            //    button1.Text = "Edit";
            //    Editing = false;
            //}
            MakeBoxesVisible();
        }

        private void MakeBoxesVisible()
        {
            cbx1.Visible = true;
            cbx2.Visible = true;
            cbx3.Visible = true;
            cbx4.Visible = true;
            cbx5.Visible = true;
            cbx6.Visible = true;
            cbx7.Visible = true;
            cbx8.Visible = true;
            cbx9.Visible = true;
            cbx10.Visible = true;
            cbx11.Visible = true;
            cbx12.Visible = true;
            cbx13.Visible = true;
            cbx14.Visible = true;
            cbx15.Visible = true;
            cbx16.Visible = true;
            cbx17.Visible = true;
            cbx18.Visible = true;
            cbx19.Visible = true;
            cbx20.Visible = true;
            cbx21.Visible = true;
            cbx22.Visible = true;
            cbx23.Visible = true;
            cbx24.Visible = true;
            cbx25.Visible = true;
            cbx26.Visible = true;
            cbx27.Visible = true;
            cbx28.Visible = true;
            cbx29.Visible = true;
            cbx30.Visible = true;
            cbx31.Visible = true;
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            ////Preparer la liste
            //List<string> items = new List<string>
            //{
            //"Item 2",
            //"Item 2",
            //"Item 3"
            //};

            ////Get the path
            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/fichier.txt";

            ////Enregistrer la liste
            //// Écrire les éléments de la liste dans le fichier
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    foreach (string item in items)
            //    {
            //        writer.WriteLine(item);
            //    }
            //}
            
            //Rendre tout les chexk BOx invisible
            MakeBoxesInvisible();

            //-----------------------
            // Create an instance of your object
            MyClass myObject = new MyClass();
            myObject.Month = DateTime.Now.Month;
            int DaysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //Creer un tableau
            string[] monTableau = new string[DaysInMonth];

            monTableau[0] = cbx1.Checked ? "ON" : "";
            monTableau[1] = cbx2.Checked ? "ON" : "";
            monTableau[2] = cbx3.Checked ? "ON" : "";
            monTableau[3] = cbx4.Checked ? "ON" : "";
            monTableau[4] = cbx5.Checked ? "ON" : "";
            monTableau[5] = cbx6.Checked ? "ON" : "";
            monTableau[6] = cbx7.Checked ? "ON" : "";
            monTableau[7] = cbx8.Checked ? "ON" : "";
            monTableau[8] = cbx9.Checked ? "ON" : "";
            monTableau[9] = cbx10.Checked ? "ON" : "";
            monTableau[10] = cbx11.Checked ? "ON" : "";
            monTableau[11] = cbx12.Checked ? "ON" : "";
            monTableau[12] = cbx13.Checked ? "ON" : "";
            monTableau[13] = cbx14.Checked ? "ON" : "";
            monTableau[14] = cbx15.Checked ? "ON" : "";
            monTableau[15] = cbx16.Checked ? "ON" : "";
            monTableau[16] = cbx17.Checked ? "ON" : "";
            monTableau[17] = cbx18.Checked ? "ON" : "";
            monTableau[18] = cbx19.Checked ? "ON" : "";
            monTableau[19] = cbx20.Checked ? "ON" : "";
            monTableau[20] = cbx21.Checked ? "ON" : "";
            monTableau[21] = cbx22.Checked ? "ON" : "";
            monTableau[22] = cbx23.Checked ? "ON" : "";
            monTableau[23] = cbx24.Checked ? "ON" : "";
            monTableau[24] = cbx25.Checked ? "ON" : "";
            monTableau[25] = cbx26.Checked ? "ON" : "";
            monTableau[26] = cbx27.Checked ? "ON" : "";
            monTableau[27] = cbx28.Checked ? "ON" : "";
            
            if (DaysInMonth > 28)
            {
                monTableau[28] = cbx29.Checked ? "ON" : "";
            }
            if (DaysInMonth > 29)
            {
                monTableau[29] = cbx30.Checked ? "ON" : "";
            }
            if (DaysInMonth > 30)
            {
                monTableau[30] = cbx31.Checked ? "ON" : "";
            }



            myObject.TableauDeStrings = monTableau;



            SaveRangingFile(myObject);
            

        }

        private void MakeBoxesInvisible()
        {
            cbx1.Visible = false;
            cbx2.Visible = false;
            cbx3.Visible = false;
            cbx4.Visible = false;
            cbx5.Visible = false;
            cbx6.Visible = false;
            cbx7.Visible = false;
            cbx8.Visible = false;
            cbx9.Visible = false;
            cbx10.Visible = false;
            cbx11.Visible = false;
            cbx12.Visible = false;
            cbx13.Visible = false;
            cbx14.Visible = false;
            cbx15.Visible = false;
            cbx16.Visible = false;
            cbx17.Visible = false;
            cbx18.Visible = false;
            cbx19.Visible = false;
            cbx20.Visible = false;
            cbx21.Visible = false;
            cbx22.Visible = false;
            cbx23.Visible = false;
            cbx24.Visible = false;
            cbx25.Visible = false;
            cbx26.Visible = false;
            cbx27.Visible = false;
            cbx28.Visible = false;
            cbx29.Visible = false;
            cbx30.Visible = false;
            cbx31.Visible = false;
            
        }

        private bool TrySelectFilePath()
        {
            // ------------------------------------------------
            // Essayer le chemin réseau
            // ------------------------------------------------

            try
            {
                string networkDirectory =
                    Path.GetDirectoryName(filePath);

                if (Directory.Exists(networkDirectory))
                {
                    // Le dossier réseau est accessible

                    if (File.Exists(filePath))
                    {
                        return true;
                    }

                    // Le dossier existe mais le fichier n'existe pas.
                    // On garde le chemin réseau pour pouvoir le créer.
                    return true;
                }
            }
            catch (Exception ex)
            {
                WriteLogForm1(
                    MyDate() +
                    " : Erreur accès chemin réseau : " +
                    ex.Message
                );
            }

            // ------------------------------------------------
            // Le réseau n'est pas accessible.
            // Essayer le chemin local.
            // ------------------------------------------------

            try
            {
                string localDirectory =
                    Path.GetDirectoryName(filePath1);

                if (!Directory.Exists(localDirectory))
                {
                    Directory.CreateDirectory(localDirectory);
                }

                filePath = filePath1;

                WriteLogForm1(
                    MyDate() +
                    " : Utilisation du fichier local : " +
                    filePath
                );

                return true;
            }
            catch (Exception ex)
            {
                WriteLogForm1(
                    MyDate() +
                    " : Impossible d'utiliser le fichier local : " +
                    ex.Message
                );

                return false;
            }
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            MakeBoxesInvisible();

            //obtenir le nombre de jours
            nbJoursSup = 31 - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            switch (nbJoursSup)
            {
                case 1:
                    pnl31.Visible = false;
                    break;
                case 2:
                    pnl31.Visible = false;
                    pnl30.Visible = false;
                    break;
                case 3:
                    pnl31.Visible = false;
                    pnl30.Visible = false;
                    pnl29.Visible = false;
                    break;
                default:
                    break;
            }



            //----------------------get serlized object myClass

            // Create a FileStream to open the file for reading
            //// Get filePath from Form1
            //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            //string filePath = ((Form1)f).filePath;

            if (ConfigurationManager.AppSettings[Form1.compilationMode] != null)
            {
                filePath = ConfigurationManager.AppSettings[Form1.compilationMode].ToString();
            }

            if (!TrySelectFilePath())
            {
                MessageBox.Show(
                    "Impossible d'accéder au fichier de configuration."
                );

                Myobject = new MyClass();
                Myobject.Month = 0;
                currentMonth = 0;
            }
            else
            {
                LoadRangingFile();
            }

            //test if file path exist

            //if (!File.Exists(filePath))
            //{
            //    if (File.Exists(filePath1))
            //    {
            //        filePath = filePath1;
            //        MessageBox.Show("filePath updated!");
            //    }
            //}


            try
            {
                fileStream = new FileStream(filePath, FileMode.Open);

                // Create a BinaryFormatter to deserialize the object from the file
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the object from the file
                MyClass deserializedObject = (MyClass)formatter.Deserialize(fileStream);
                currentMonth = deserializedObject.Month;
                Myobject = deserializedObject;

                // Close the file stream
                fileStream.Close();


            }
            catch (SerializationException se)
            {
                MessageBox.Show("Code erreur : F301 : Problem whene Serialization : " + se.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("Code erreur : F302 : Fichier n'existe pas : " + fnfe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Code erreur : F303 : An error occurred while processing the file." + ex);
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

            if (currentMonth == DateTime.Now.Month)
            {
                //si la valeur currentMonth défrante de zero, donc on a un object depuis le fichier donc on a une suavegarde
                //On a pas de sauvgarde !
                //set Month and year
                lblMonth.Text = DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year;

                //get days of the month
                DateTime currentDate = DateTime.Now;
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

                List<DateTime> daysOfMonth = new List<DateTime>();

                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(currentDate.Year, currentDate.Month, day);
                    daysOfMonth.Add(date);
                }

                //boucle de la parite 1-30/31/29...
                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month, day);
                    lblDateList[day - 1].Text = dateTime.ToShortDateString();
                    lblDayList[day - 1].Text = dateTime.ToString("ddd");
                    cbxList[day - 1].Checked = Myobject.TableauDeStrings[day - 1] == "ON" ? true : false;
                    lblRGList[day - 1].Text = Myobject.TableauDeStrings[day - 1];
                }

            }
            else
            {
                //On a pas de sauvgarde !
                //set Month and year
                lblMonth.Text = DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year;    

                //get days of the month
                DateTime currentDate = DateTime.Now;
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

                List<DateTime> daysOfMonth = new List<DateTime>();

                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(currentDate.Year, currentDate.Month, day);
                    daysOfMonth.Add(date);
                }

                //boucle de la parite 1-30/31/29...
                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month, day);
                    lblDateList[day - 1].Text = dateTime.ToShortDateString();
                    lblDayList[day - 1].Text = dateTime.ToString("ddd");
                }
                ////boucle de la parite 30-34
                //for (int day = 1; day <= 34 - daysInMonth; day++)
                //{
                //    DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month + 1, day);
                //    lblDateList[day + daysInMonth - 1].Text = dateTime.ToShortDateString();
                //    lblDayList[day + daysInMonth - 1].Text = dateTime.ToString("ddd");
                //}
            }

            


        }

        private void LoadRangingFile()
        {
            try
            {
                // Le fichier n'existe pas
                if (!File.Exists(filePath))
                {
                    WriteLogForm1(
                        MyDate() +
                        " : Le fichier n'existe pas : " +
                        filePath
                    );

                    // Nouveau fichier logique
                    Myobject = new MyClass();
                    Myobject.Month = 0;

                    currentMonth = 0;

                    return;
                }

                // Le fichier existe
                using (FileStream fileStream =
                       new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter =
                        new BinaryFormatter();

                    MyClass deserializedObject =
                        (MyClass)formatter.Deserialize(fileStream);

                    currentMonth = deserializedObject.Month;

                    Myobject = deserializedObject;
                }

                WriteLogForm1(
                    MyDate() +
                    " : Fichier chargé avec succès : " +
                    filePath
                );
            }
            catch (SerializationException se)
            {
                WriteLogForm1(
                    MyDate() +
                    " : F301 : Problème de désérialisation : " +
                    se.Message
                );

                Myobject = new MyClass();
                Myobject.Month = 0;
                currentMonth = 0;
            }
            catch (IOException ioex)
            {
                WriteLogForm1(
                    MyDate() +
                    " : F303 : Erreur d'accès au fichier : " +
                    ioex.Message
                );

                Myobject = new MyClass();
                Myobject.Month = 0;
                currentMonth = 0;
            }
            catch (Exception ex)
            {
                WriteLogForm1(
                    MyDate() +
                    " : F303 : Erreur : " +
                    ex.Message
                );

                Myobject = new MyClass();
                Myobject.Month = 0;
                currentMonth = 0;
            }
        }

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            //Methode ALlinOne
            //tester tout !! changer tout
            lblRG1.Text = cbx1.Checked ? "ON" : "";
            lblRG2.Text = cbx2.Checked ? "ON" : "";
            lblRG3.Text = cbx3.Checked ? "ON" : "";
            lblRG4.Text = cbx4.Checked ? "ON" : "";
            lblRG5.Text = cbx5.Checked ? "ON" : "";
            lblRG6.Text = cbx6.Checked ? "ON" : "";
            lblRG7.Text = cbx7.Checked ? "ON" : "";
            lblRG8.Text = cbx8.Checked ? "ON" : "";
            lblRG9.Text = cbx9.Checked ? "ON" : "";
            lblRG10.Text = cbx10.Checked ? "ON" : "";
            lblRG11.Text = cbx11.Checked ? "ON" : "";
            lblRG12.Text = cbx12.Checked ? "ON" : "";
            lblRG13.Text = cbx13.Checked ? "ON" : "";
            lblRG14.Text = cbx14.Checked ? "ON" : "";
            lblRG15.Text = cbx15.Checked ? "ON" : "";
            lblRG16.Text = cbx16.Checked ? "ON" : "";
            lblRG17.Text = cbx17.Checked ? "ON" : "";
            lblRG18.Text = cbx18.Checked ? "ON" : "";
            lblRG19.Text = cbx19.Checked ? "ON" : "";
            lblRG20.Text = cbx20.Checked ? "ON" : "";
            lblRG21.Text = cbx21.Checked ? "ON" : "";
            lblRG22.Text = cbx22.Checked ? "ON" : "";
            lblRG23.Text = cbx23.Checked ? "ON" : "";
            lblRG24.Text = cbx24.Checked ? "ON" : "";
            lblRG25.Text = cbx25.Checked ? "ON" : "";
            lblRG26.Text = cbx26.Checked ? "ON" : "";
            lblRG27.Text = cbx27.Checked ? "ON" : "";
            lblRG28.Text = cbx28.Checked ? "ON" : "";
            lblRG29.Text = cbx29.Checked ? "ON" : "";
            lblRG30.Text = cbx30.Checked ? "ON" : "";
            lblRG31.Text = cbx31.Checked ? "ON" : "";

            //Methode generale 


            //lblRG1.Text = cbx1.Checked ? "ON" : "";
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            //Rendre tout les chexk BOx invisible
            MakeBoxesInvisible();

            //-----------------------
            // Create an instance of your object
            MyClass myObject = new MyClass();
            myObject.Month = DateTime.Now.Month;
            int DaysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //Creer un tableau
            string[] monTableau = new string[DaysInMonth];

            monTableau[0] = cbx1.Checked ? "ON" : "";
            monTableau[1] = cbx2.Checked ? "ON" : "";
            monTableau[2] = cbx3.Checked ? "ON" : "";
            monTableau[3] = cbx4.Checked ? "ON" : "";
            monTableau[4] = cbx5.Checked ? "ON" : "";
            monTableau[5] = cbx6.Checked ? "ON" : "";
            monTableau[6] = cbx7.Checked ? "ON" : "";
            monTableau[7] = cbx8.Checked ? "ON" : "";
            monTableau[8] = cbx9.Checked ? "ON" : "";
            monTableau[9] = cbx10.Checked ? "ON" : "";
            monTableau[10] = cbx11.Checked ? "ON" : "";
            monTableau[11] = cbx12.Checked ? "ON" : "";
            monTableau[12] = cbx13.Checked ? "ON" : "";
            monTableau[13] = cbx14.Checked ? "ON" : "";
            monTableau[14] = cbx15.Checked ? "ON" : "";
            monTableau[15] = cbx16.Checked ? "ON" : "";
            monTableau[16] = cbx17.Checked ? "ON" : "";
            monTableau[17] = cbx18.Checked ? "ON" : "";
            monTableau[18] = cbx19.Checked ? "ON" : "";
            monTableau[19] = cbx20.Checked ? "ON" : "";
            monTableau[20] = cbx21.Checked ? "ON" : "";
            monTableau[21] = cbx22.Checked ? "ON" : "";
            monTableau[22] = cbx23.Checked ? "ON" : "";
            monTableau[23] = cbx24.Checked ? "ON" : "";
            monTableau[24] = cbx25.Checked ? "ON" : "";
            monTableau[25] = cbx26.Checked ? "ON" : "";
            monTableau[26] = cbx27.Checked ? "ON" : "";
            monTableau[27] = cbx28.Checked ? "ON" : "";
            
            if (DaysInMonth > 28)
            {
                monTableau[28] = cbx29.Checked ? "ON" : "";
            }
            if (DaysInMonth > 29)
            {
                monTableau[29] = cbx30.Checked ? "ON" : "";
            }
            if (DaysInMonth > 30)
            {
                monTableau[30] = cbx31.Checked ? "ON" : "";
            }

            myObject.TableauDeStrings = monTableau;

            SaveRangingFile(myObject);

            //Refresh
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            principalForm.LoadRgProgram();

            this.Close();
        }

        private void SaveRangingFile(MyClass myObject)
        {
            try
            {
                string directory = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directory))
                {
                    MessageBox.Show(
                        "Le dossier n'existe pas ou n'est pas accessible :\n"
                        + directory
                    );

                    return;
                }

                using (FileStream fileStream =
                       new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter =
                        new BinaryFormatter();

                    formatter.Serialize(fileStream, myObject);
                }

                WriteLogForm1(
                    MyDate() +
                    " : Fichier sauvegardé : " +
                    filePath
                );
            }
            catch (UnauthorizedAccessException uaex)
            {
                MessageBox.Show(
                    "Code erreur : F305 : Pas de permission d'écriture.\n\n"
                    + uaex.Message
                );
            }
            catch (IOException ioex)
            {
                MessageBox.Show(
                    "Code erreur : F306 : Impossible d'accéder au fichier.\n\n"
                    + ioex.Message
                );
            }
            catch (SerializationException se)
            {
                MessageBox.Show(
                    "Code erreur : F304 : Problème de sérialisation.\n\n"
                    + se.Message
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Code erreur : F306 : Erreur lors de la sauvegarde.\n\n"
                    + ex.Message
                );
            }
        }

        private string MyDate()
        {
            return DateTime.Now.ToShortDateString().Replace("/", "-") + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
