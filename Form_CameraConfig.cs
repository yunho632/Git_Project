using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WVision
{
    public class Config
    {
        private string ActiveFile = "";
        public string ConfigXmlName = "";

        private object LockObject = new object();

        public Config()
        {

        }
        public Config(string pConfigXmlName)
        {
            this.ConfigXmlName = pConfigXmlName;
            this.UpdateConfig();
        }

        private void UpdateCameras()
        {
            {
                if (this.ActiveFile == "") return;
                Config configCameras = new Config();


                configCameras.ConfigXmlName = this.ActiveFile;
                configCameras.UpdateConfig();
               // this.dataGridView_Camera.RowCount = 0;

                //if (configCameras.GetSectionGroup("CameraList") == null)
                //{
                //    configCameras.AddSectionGroup("", "CameraList");
                //}
                //else
                //{
                //    foreach (System.Configuration.ConfigurationSection Section in configCameras.GetAllSection("CameraList"))
                //    {

                //        string[] RowData = new string[this.dataGridView_Camera.Columns.Count];
                //        for (int iCol = 0; iCol < this.dataGridView_Camera.ColumnCount; iCol++)
                //        {
                //            RowData[iCol] = configCameras.GetValue(Section.SectionInformation.SectionName, this.dataGridView_Camera.Columns[iCol].HeaderText.ToString(), "").ToString();
                //        }
                //        this.dataGridView_Camera.Rows.Add(RowData);

                //    }
                //}


                //this.Text = string.Format("{0} - {1}", "Camera List", System.IO.Path.GetFileName(this.ActiveFile));
            }



        }
        public void UpdateConfig()
        {
            try
            {
                lock (LockObject)
                {
                    //this.config = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap { ExeConfigFilename = ConfigXmlName }, ConfigurationUserLevel.None);
                }
            }
            catch (Exception ex)
            {
               
                //this.config = null;
            }

        }


    }

    public partial class Form_CameraConfig : Form
    {
        public Form_CameraConfig()
        {
            InitializeComponent();
        }


    }
}

