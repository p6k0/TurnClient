using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TurnCtrl;

namespace TurnClient
{
    public partial class LineGroupEditForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public readonly LineGroup group;
        public LineGroupEditForm(LineGroup group)
        {
            this.group = group;
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 100, 100, 100, 100));
            //Верхний сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(100, 0, 0, 0);
                g.AddArc(40, 40, 20, 20, 225, 90);
                MoveTopBtn.Region = new Region(g);
            }
            //нижний сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(0, 50, 100, 50);
                g.AddArc(40, -10, 20, 20, 45, 90);
                MoveBottomBtn.Region = new Region(g);
            }

            //левый сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(0, 0, 0, 100);
                g.AddArc(40, 40, 20, 20, 135, 90);
                DeleteButton.Region = new Region(g);
            }
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(50, 100, 50, 0);
                g.AddArc(-10, 40, 20, 20, 315, 90);
                EditButton.Region = new Region(g);
            }

            Left = Cursor.Position.X - 50;
            Top = Cursor.Position.Y - 50;
        }

        public LineGroupEditForm()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 200, 200, 200, 200));

            //Верхний сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(200, 0, 0, 0);
                g.AddArc(80, 80, 40, 40, 225, 90);
                MoveTopBtn.Region = new Region(g);
            }
            //нижний сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(0, 100, 200, 100);
                g.AddArc(80, -20, 40, 40, 45, 90);
                MoveBottomBtn.Region = new Region(g);
            }

            //левый сектор
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(0, 0, 0, 200);
                g.AddArc(80, 80, 40, 40, 135, 90);
                DeleteButton.Region = new Region(g);
            }
            using (GraphicsPath g = new GraphicsPath())
            {
                g.AddLine(100, 200, 100, 0);
                g.AddArc(-20, 80, 40, 40, 315, 90);
                EditButton.Region = new Region(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            group.Properties.Name = Interaction.InputBox("Введи новое имя группы", "Новое имя группы", group.Properties.Name);
            group.Upd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group.MoveTop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            group.MoveBottom();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                this,
                "Удаление группы линеек",
                "Вы действительно хотите удалить эту группу линеек и все ее содержимое?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                Station st = ((Station)group.Parent);
                group.Dispose();
                st.Compose();
                Close();
            }
        }

        private void LineGroupEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LineGroupEditForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
