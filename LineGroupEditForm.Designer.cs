namespace TurnClient
{
    partial class LineGroupEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoveBottomBtn = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoveTopBtn = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoveBottomBtn
            // 
            this.MoveBottomBtn.BackColor = System.Drawing.Color.Silver;
            this.MoveBottomBtn.FlatAppearance.BorderSize = 0;
            this.MoveBottomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveBottomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveBottomBtn.Image = global::TurnClient.Properties.Resources.arrowDown;
            this.MoveBottomBtn.Location = new System.Drawing.Point(0, 50);
            this.MoveBottomBtn.Name = "MoveBottomBtn";
            this.MoveBottomBtn.Size = new System.Drawing.Size(100, 50);
            this.MoveBottomBtn.TabIndex = 2;
            this.MoveBottomBtn.UseVisualStyleBackColor = false;
            this.MoveBottomBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.DeleteButton.Image = global::TurnClient.Properties.Resources.Delete;
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 100);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoveTopBtn
            // 
            this.MoveTopBtn.BackColor = System.Drawing.Color.Silver;
            this.MoveTopBtn.FlatAppearance.BorderSize = 0;
            this.MoveTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveTopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveTopBtn.Image = global::TurnClient.Properties.Resources.arrowUp;
            this.MoveTopBtn.Location = new System.Drawing.Point(0, 0);
            this.MoveTopBtn.Name = "MoveTopBtn";
            this.MoveTopBtn.Size = new System.Drawing.Size(100, 50);
            this.MoveTopBtn.TabIndex = 1;
            this.MoveTopBtn.UseVisualStyleBackColor = false;
            this.MoveTopBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Silver;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::TurnClient.Properties.Resources.edit;
            this.EditButton.Location = new System.Drawing.Point(50, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 100);
            this.EditButton.TabIndex = 0;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineGroupEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.MoveBottomBtn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MoveTopBtn);
            this.Controls.Add(this.EditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineGroupEditForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Свойства группы линеек";
            this.Deactivate += new System.EventHandler(this.LineGroupEditForm_Deactivate);
            this.Click += new System.EventHandler(this.LineGroupEditForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button MoveBottomBtn;
        private System.Windows.Forms.Button MoveTopBtn;
        private System.Windows.Forms.Button DeleteButton;
    }
}