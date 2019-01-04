using System.IO.Ports;
using System.Windows.Forms;
using TurnCtrl;

namespace TurnClient
{
    public partial class PassEditForm : Form
    {
        public PassProperies prop;
        public PassEditForm(PassProperies prop)
        {
            this.prop = prop;
            InitializeComponent();
            this.Text = "Настройка прохода (порядковый номер: "+prop.Order+")";
            foreach (string port in SerialPort.GetPortNames())
                comboBox1.Items.Add(port);
            passNum.Value = prop.Number;
            address.Value = prop.Wire.Address;
            comboBox1.SelectedItem = prop.Wire.Port;

            baggage.Checked = prop.Baggage;
            express.Checked = prop.Express;

            inEnable.Checked = prop.InEnable;
            outEnable.Checked = prop.OutEnable;

            leftInvNum.Text = prop.LeftRack.InventoryNum;
            leftSNum.Value = prop.LeftRack.SerialNum;

            rightInvNum.Text = prop.RightRack.InventoryNum;
            rightSNum.Value = prop.RightRack.SerialNum;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            prop.Number = (int)passNum.Value;
            prop.Wire.Address = (byte)address.Value;
            prop.Wire.Port = comboBox1.SelectedIndex == -1? string.Empty: comboBox1.SelectedItem.ToString();

            prop.InEnable = inEnable.Checked;
            prop.OutEnable = outEnable.Checked;

            prop.Baggage = baggage.Checked;
            prop.Express = express.Checked;

            prop.LeftRack.InventoryNum = leftInvNum.Text;
            prop.LeftRack.SerialNum = (ulong)leftSNum.Value;

            prop.RightRack.InventoryNum = rightInvNum.Text;
            prop.RightRack.SerialNum = (ulong)rightSNum.Value;



            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            this.Close();
        }
    }
}
