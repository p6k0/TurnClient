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
            this.AddBtn = new System.Windows.Forms.Button();
            this.MoveBottomBtn = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoveTopBtn = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Image = global::TurnClient.Properties.Resources.add;
            this.AddBtn.Location = new System.Drawing.Point(184, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(24, 24);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MoveBottomBtn
            // 
            this.MoveBottomBtn.FlatAppearance.BorderSize = 0;
            this.MoveBottomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveBottomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveBottomBtn.Image = global::TurnClient.Properties.Resources.arrowDown;
            this.MoveBottomBtn.Location = new System.Drawing.Point(136, 4);
            this.MoveBottomBtn.Name = "MoveBottomBtn";
            this.MoveBottomBtn.Size = new System.Drawing.Size(24, 24);
            this.MoveBottomBtn.TabIndex = 2;
            this.MoveBottomBtn.UseVisualStyleBackColor = false;
            this.MoveBottomBtn.Click += new System.EventHandler(this.MoveBottom_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.DeleteButton.Image = global::TurnClient.Properties.Resources.Delete;
            this.DeleteButton.Location = new System.Drawing.Point(52, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoveTopBtn
            // 
            this.MoveTopBtn.FlatAppearance.BorderSize = 0;
            this.MoveTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveTopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveTopBtn.Image = global::TurnClient.Properties.Resources.arrowUp;
            this.MoveTopBtn.Location = new System.Drawing.Point(100, 4);
            this.MoveTopBtn.Name = "MoveTopBtn";
            this.MoveTopBtn.Size = new System.Drawing.Size(24, 24);
            this.MoveTopBtn.TabIndex = 1;
            this.MoveTopBtn.UseVisualStyleBackColor = false;
            this.MoveTopBtn.Click += new System.EventHandler(this.MoveTop_Click);
            // 
            // EditButton
            // 
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::TurnClient.Properties.Resources.edit;
            this.EditButton.Location = new System.Drawing.Point(4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(24, 24);
            this.EditButton.TabIndex = 0;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // LineGroupEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(212, 32);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MoveBottomBtn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MoveTopBtn);
            this.Controls.Add(this.EditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(212, 32);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(80, 32);
            this.Name = "LineGroupEditForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Свойства группы линеек";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.LineGroupEditForm_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button MoveBottomBtn;
        private System.Windows.Forms.Button MoveTopBtn;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddBtn;
    }
}