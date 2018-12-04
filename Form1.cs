using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i< 100; i++)
            {

                this.Controls.Add(new TurnCtrl.Turnstile_2000(new TurnCtrl.PassProperies(), toolTip1, true) { Left = 10+60*i, Top = 10 });
            }
        }

    }
}
