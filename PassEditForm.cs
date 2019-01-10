using System.IO.Ports;
using System.Windows.Forms;
using TurnCtrl;

namespace TurnClient
{
    public partial class PassEditForm : Form
    {
        public PassProperties prop;
        public PassEditForm(PassProperties prop)
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

            leftInvNum.Text = prop.OutRack.InventoryNum;
            leftSNum.Value = prop.OutRack.SerialNum;

            rightInvNum.Text = prop.InRack.InventoryNum;
            rightSNum.Value = prop.InRack.SerialNum;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            prop.Number = (byte)passNum.Value;
            prop.Wire.Address = (byte)address.Value;
            prop.Wire.Port = comboBox1.SelectedIndex == -1? string.Empty: comboBox1.SelectedItem.ToString();

            prop.InEnable = inEnable.Checked;
            prop.OutEnable = outEnable.Checked;

            prop.Baggage = baggage.Checked;
            prop.Express = express.Checked;

            prop.OutRack.InventoryNum = leftInvNum.Text;
            prop.OutRack.SerialNum = (ulong)leftSNum.Value;

            prop.InRack.InventoryNum = rightInvNum.Text;
            prop.InRack.SerialNum = (ulong)rightSNum.Value;



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
