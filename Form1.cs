using System;
using System.Windows.Forms;
using System.Xml;
using TurnCtrl;

namespace TurnClient
{
    public partial class Form1 : Form
    {
        LineGroupEditForm f = new LineGroupEditForm();

        AsokupeConfig map;
        public Form1(XmlDocument cfg)
        {
            InitializeComponent();
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            map = new AsokupeConfig(cfg);

            station1.Properties = new StationProperties();
            station1.GroupHeaderClick = GroupHeaderClick;
            station1.LineHeaderClick = LineHeaderClick;
            station1.PassNumClick = TunstileClick;

            map.DrawMap(station1, true);
            Activate();
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


        private void Form1_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            map.Validate();
        }


        public void GroupHeaderClick(object sender, MouseEventArgs e)
        {
            f.SetTarget(sender);
        }


        public void LineHeaderClick(object sender, MouseEventArgs e)
        {
            f.SetTarget(sender);
        }

        public void TunstileClick(object sender, MouseEventArgs e)
        {
            f.SetTarget(sender);
        }
    }
}
