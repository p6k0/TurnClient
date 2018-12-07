using System;
using System.Windows.Forms;
using System.Xml;
using TurnCtrl;

namespace TurnClient
{
    public partial class Form1 : Form
    {
        public Form1(XmlDocument cfg)
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            TurnCtrl.StationProperties prop = new TurnCtrl.StationProperties();
            prop.ExpressCode = Convert.ToInt32(cfg.DocumentElement.GetAttribute("E"));
            prop.Name = cfg.DocumentElement.GetAttribute("Name");
            station1.Properties = prop;
            StationNameTbx.Text = prop.Name;
            StationETbx.Text = prop.ExpressCode.ToString();
            bool CanEdit = true;
            foreach (XmlElement grEl in cfg.DocumentElement.SelectNodes("Group"))
            {
                TurnCtrl.LineGroupProperties lgpr = new TurnCtrl.LineGroupProperties()
                {
                    Name = grEl.GetAttribute("Name"),
                    Id = Convert.ToInt32(grEl.GetAttribute("Id"))
                };
                TurnCtrl.LineGroup gr = station1.LineGroupAdd(lgpr, CanEdit);
                foreach (XmlElement lnEl in grEl.SelectNodes("Line"))
                {
                    TurnCtrl.TurnLineProperties lnpr = new TurnCtrl.TurnLineProperties
                    {
                        Name = lnEl.GetAttribute("Name"),
                        Id = Convert.ToInt32(lnEl.GetAttribute("Id"))
                    };
                    TurnCtrl.TurnLine ln = gr.addLine(lnpr, CanEdit);
                    XmlNodeList passList = lnEl.SelectNodes("Turn");
                    TurnCtrl.RackProperties EmptyRack = null,prevRack=null;
                    for (int i = 0; i < passList.Count; i++)
                    {
                        XmlElement turnEl = (XmlElement)passList[i];
                        if (i == 0)
                        {
                            EmptyRack = new TurnCtrl.RackProperties()
                            {
                                InventoryNum = turnEl.GetAttribute("InvNum"),
                                SerialNum = Convert.ToUInt64(turnEl.GetAttribute("SNum"))
                            }; 
                            continue;
                        };
                        TurnCtrl.PassProperies turnpr = new TurnCtrl.PassProperies
                        {
                            Id = Convert.ToInt32(turnEl.GetAttribute("Id"))-1,
                            PassNum = Convert.ToInt32(turnEl.GetAttribute("PassNum")),
                           // Address = Convert.ToInt32(turnEl.GetAttribute("Address")),
                            Baggage = Convert.ToBoolean(turnEl.GetAttribute("Baggage")),
                            Express = Convert.ToBoolean(turnEl.GetAttribute("Express")),
                            InEnable = Convert.ToBoolean(turnEl.GetAttribute("InEnable")),
                            OutEnable = Convert.ToBoolean(turnEl.GetAttribute("OutEnable")),
                            RightRack = new TurnCtrl.RackProperties
                            {
                                InventoryNum = turnEl.GetAttribute("InvNum"),
                                SerialNum = Convert.ToUInt64(turnEl.GetAttribute("SNum"))
                            }
                            
                        };
                        if (i == 1)
                        {
                            turnpr.LeftRack = EmptyRack;
                        }
                        else
                        {
                            turnpr.LeftRack = prevRack;
                        }

                        ln.addTurnstile(turnpr, CanEdit);
                        prevRack = turnpr.RightRack;
                    }
                    ln.Compose();
                }
                gr.Compose();
            }
            station1.Compose();



            /*for(int i = 0; i< 100; i++)
            {

                this.Controls.Add(new TurnCtrl.Turnstile_2000(new TurnCtrl.PassProperies(), toolTip1, true) { Left = 10+60*i, Top = 10 });
            }*/

            //this.Controls.Add(new TurnCtrl.LineGroup(new TurnCtrl.LineGroupProperties(), true) { Width= 1900 });

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
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Station/>");
            doc.DocumentElement.SetAttribute("E", StationETbx.Text);
            doc.DocumentElement.SetAttribute("Name", StationNameTbx.Text);
            doc.DocumentElement.SetAttribute("LastModify", DateTime.Now.Ticks.ToString());
            doc.DocumentElement.SetAttribute("Ver", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            foreach(LineGroup gr in station1.getGroups())
            {
                XmlElement grEl = doc.CreateElement("Group");
                grEl.SetAttribute("Name", gr.Properties.Name);
                grEl.SetAttribute("Id", gr.Properties.Id.ToString());
                foreach( TurnLine ln in gr.getTurnLines())
                {
                    XmlElement lnEl = doc.CreateElement("Line");
                    lnEl.SetAttribute("Name", ln.Properties.Name);
                    lnEl.SetAttribute("Id", ln.Properties.Id.ToString());
                    lnEl.SetAttribute("Type", ln.Properties.TurnstileModel.ToString());
                    Turnstile[] t = ln.getTurnstiles();
                    XmlElement tEl = doc.CreateElement("Turn");
                    tEl.SetAttribute("Id", "1");
                    tEl.SetAttribute("SNum", t[0].Properties.LeftRack.SerialNum.ToString());
                    tEl.SetAttribute("InvNum", t[0].Properties.LeftRack.InventoryNum);
                    lnEl.AppendChild(tEl);
                    foreach(Turnstile tt in t)
                    {
                        tEl = doc.CreateElement("Turn");

                        tEl.SetAttribute("Id", (tt.Properties.Id+1).ToString());

                        tEl.SetAttribute("PassNum", tt.Properties.PassNum.ToString());
                        tEl.SetAttribute("InEnable", tt.Properties.InEnable.ToString());
                        tEl.SetAttribute("OutEnable", tt.Properties.OutEnable.ToString());
                        tEl.SetAttribute("Baggage", tt.Properties.Baggage.ToString());
                        tEl.SetAttribute("Express", tt.Properties.Express.ToString());
                        tEl.SetAttribute("Port", tt.Properties.Port.ToString());
                        tEl.SetAttribute("Addr", tt.Properties.Address.ToString());

                        tEl.SetAttribute("SNum", tt.Properties.RightRack.SerialNum.ToString());
                        tEl.SetAttribute("InvNum", tt.Properties.RightRack.InventoryNum);

                        lnEl.AppendChild(tEl);
                    }

                    grEl.AppendChild(lnEl);
                }


                doc.DocumentElement.AppendChild(grEl);
            }


            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Турникетный комплекс АСОКУПЭ(.atcfg) | *.atcfg";
                dlg.FileName = StationNameTbx.Text + "_" + StationETbx.Text + ".atcfg";
                if (dlg.ShowDialog()== DialogResult.OK)
                {

                    doc.Save(dlg.FileName);
                }
            }

        }

        private void StationNameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
