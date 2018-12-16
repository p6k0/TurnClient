using System;
using System.Windows.Forms;
using System.Xml;
using TurnCtrl;

namespace TurnClient
{
    public partial class Form1 : Form
    {
        AsokupeConfig map;
        public Form1(XmlDocument cfg)
        {
            InitializeComponent();
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            map = new AsokupeConfig(cfg);
            station1.Properties = new StationProperties();
            map.DrawMap(station1, true);
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            station1.LineGroupCreate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            station1.Compose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Конфигурация станции|*.atcfg";
                sfd.FileName = station1.Properties.Name + "_" + station1.Properties.ExpressCode + ".atcfg";
                sfd.OverwritePrompt = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                    map.SaveMap(station1, sfd.FileName);
            }
        }


        private void StationNameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            map.Validate();
        }
    }
}
