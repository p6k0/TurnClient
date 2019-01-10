using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
using TurnCtrl;

namespace TurnClient
{
    public partial class LineGroupEditForm : Form
    {

        private object target;
        public LineGroupEditForm()
        {
            InitializeComponent();
            Height = 24;
        }

        public void SetTarget(object target)
        {
            this.target = target;
            if (target is Turnstile)
            {
                MoveBottomBtn.Enabled = false;
                MoveTopBtn.Enabled = false;
                AddBtn.Enabled = false;
                Size = MinimumSize;
            }
            else
            {
                MoveBottomBtn.Enabled = true;
                MoveTopBtn.Enabled = true;
                AddBtn.Enabled = true;
                Size = MaximumSize;
            }
            SetBackColor();
            SetLocation();
            Show();
        }

        private void SetBackColor()
        {
            Control ctrl = (Control)target;
            if (ctrl is LineGroup)
                BackColor = ctrl.BackColor;
            else if (ctrl is TurnLine)
                BackColor = Color.FromArgb(0x26, 0xa6, 0x9a);
            else
                BackColor = ctrl.BackColor;
        }

        private void SetLocation()
        {
            Control ctrl = (Control)target;
            Point p = ctrl.PointToScreen(new Point(0, 0));
            if (ctrl is LineGroup)
                p.Offset((ctrl.Width - Width) / 2, 25);
            else if (ctrl is TurnLine)
                p.Offset((ctrl.Width - Width) / 2, 20);
            else
                p.Offset((ctrl.Width - Width) / 2, ctrl.Height - Height - 30);
            Location = p;
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            Deactivate -= LineGroupEditForm_Deactivate;
            Visible = false;
            if (target is LineGroup)
            {
                string tmp = Interaction.InputBox("Новое имя группы", "Редактирование", ((LineGroup)target).Properties.Name);
                if (tmp != string.Empty)
                {
                    ((LineGroup)target).Properties.Name = tmp;
                }
            }
            else if (target is TurnLine)
            {
                using (TurnLineEditForm f = new TurnLineEditForm(((TurnLine)target).Properties))
                {
                    f.ShowDialog();
                    /*if ( f.ShowDialog() == DialogResult.OK)*/
                    //((TurnLine)target).Compose();
                }
            }
            else
            {
                using (PassEditForm f = new PassEditForm(((Turnstile)target).Properties))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                        ((Turnstile)target).DrawIcons();
                }

            }
            Visible = true;
            Deactivate += LineGroupEditForm_Deactivate;
        }

        private void MoveTop_Click(object sender, EventArgs e)
        {
            if (target is LineGroup)
                ((LineGroup)target).MoveTop();
            else
                ((TurnLine)target).MoveTop();
            SetLocation();
        }

        private void MoveBottom_Click(object sender, EventArgs e)
        {
            if (target is LineGroup)
                ((LineGroup)target).MoveBottom();
            else
                ((TurnLine)target).MoveBottom();
            SetLocation();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Deactivate -= LineGroupEditForm_Deactivate;
            Visible = false;
            Control ctrl = (Control)target;
            if (MessageBox.Show(
                this,
                "Вы действительно хотите удалить данный элемент?\r\n Тут кнопки \"Вернуть\" нет",
                "Удаление элемента",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                Control p = ctrl.Parent;
                ctrl.Dispose();
                /*if (p is TurnLine)
                    ((TurnLine)p).Compose();
                else*/ if (p is Station)
                    ((Station)p).Compose();
                else if (p is LineGroup)
                    ((LineGroup)p).Compose();
                Hide();
                return;
            }
            Visible = true;
            Deactivate += LineGroupEditForm_Deactivate;
        }


        private void LineGroupEditForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (target is LineGroup)
                ((LineGroup)target).createLine();
            else
                ((TurnLine)target).CreatePass();
            SetLocation();
        }
    }
}
