namespace TurnClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ComposeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StationNameTbx = new System.Windows.Forms.TextBox();
            this.StationETbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.station1 = new TurnCtrl.Station();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComposeBtn
            // 
            this.ComposeBtn.FlatAppearance.BorderSize = 0;
            this.ComposeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComposeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComposeBtn.Location = new System.Drawing.Point(114, 0);
            this.ComposeBtn.Name = "ComposeBtn";
            this.ComposeBtn.Size = new System.Drawing.Size(141, 27);
            this.ComposeBtn.TabIndex = 2;
            this.ComposeBtn.Text = "Скомпоновать линейки";
            this.ComposeBtn.UseVisualStyleBackColor = true;
            this.ComposeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(261, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя станции:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StationNameTbx
            // 
            this.StationNameTbx.Location = new System.Drawing.Point(367, 4);
            this.StationNameTbx.Name = "StationNameTbx";
            this.StationNameTbx.Size = new System.Drawing.Size(144, 20);
            this.StationNameTbx.TabIndex = 4;
            this.StationNameTbx.TextChanged += new System.EventHandler(this.StationNameTbx_TextChanged);
            // 
            // StationETbx
            // 
            this.StationETbx.Location = new System.Drawing.Point(623, 4);
            this.StationETbx.Name = "StationETbx";
            this.StationETbx.Size = new System.Drawing.Size(144, 20);
            this.StationETbx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(517, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ЭКСПРЕСС-3 код:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(773, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // station1
            // 
            this.station1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.station1.AutoScroll = true;
            this.station1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.station1.Location = new System.Drawing.Point(2, 30);
            this.station1.Margin = new System.Windows.Forms.Padding(0);
            this.station1.Name = "station1";
            this.station1.Size = new System.Drawing.Size(1146, 575);
            this.station1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1146, 605);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StationETbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StationNameTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComposeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.station1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ComposeBtn;
        private TurnCtrl.Station station1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StationNameTbx;
        private System.Windows.Forms.TextBox StationETbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

