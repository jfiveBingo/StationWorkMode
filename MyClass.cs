using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StationWorkMode
{
    [Serializable]
    class MyClass
    {

        /// <summary>
        /// La proprieté Current Month
        /// </summary>
        public int Month { get => month; set => month = value; }
        public string[] TableauDeStrings { get => tableauDeStrings; set => tableauDeStrings = value; }

        ///// <summary>
        /////  liste of lblDate
        ///// </summary>
        //public List<Label> DateList { get => lblDateList; set => lblDateList = value; }
        ///// <summary>
        ///// liste of lblDay
        ///// </summary>
        //public List<Label> DayList { get => lblDayList; set => lblDayList = value; }
        ///// <summary>
        ///// liste of lblRG
        ///// </summary>
        //public List<Label> RGList { get => lblRGList; set => lblRGList = value; }
        ///// <summary>
        ///// liste of cbx
        ///// </summary>
        //public List<CheckBox> CbxList { get => cbxList; set => cbxList = value; }
        ///// <summary>
        ///// tableu de string de 1 a 34 contient Ranging "ON" ou "OFF"
        ///// </summary>
        //public string[] RGtable { get => tableauDeStrings; set => tableauDeStrings = value; }

        /// <summary>
        /// The current monthe.
        /// </summary>
        int month;

        ///// <summary>
        ///// liste of lblDate
        ///// </summary>
        //private List<Label> lblDateList = new List<Label>();


        ///// <summary>
        ///// liste of lblDay
        ///// </summary>
        //private List<Label> lblDayList = new List<Label>();


        ///// <summary>
        ///// liste of lblRG
        ///// </summary>
        //private List<Label> lblRGList = new List<Label>();

        ///// <summary>
        ///// liste of cbx
        ///// </summary>
        //private List<CheckBox> cbxList = new List<CheckBox>();

        /// <summary>
        /// tableu de string de 1 a 31
        /// </summary>
        private string[] tableauDeStrings;


    }
}
