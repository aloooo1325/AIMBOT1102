namespace Entities
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.sta = new System.Windows.Forms.Label();
            this.ON = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIMBOT";
            // 
            // sta
            // 
            this.sta.AutoSize = true;
            this.sta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sta.Location = new System.Drawing.Point(40, 207);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(75, 29);
            this.sta.TabIndex = 1;
            this.sta.Text = "status";
            this.sta.Click += new System.EventHandler(this.label2_Click);
            // 
            // ON
            // 
            this.ON.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ON.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ON.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ON.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ON.ForeColor = System.Drawing.Color.White;
            this.ON.Location = new System.Drawing.Point(237, 64);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(81, 32);
            this.ON.TabIndex = 2;
            this.ON.Text = "ON";
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Entities.Properties.Resources.ChatGPT_Image_Apr_23__2026__02_08_45_PM;
            this.ClientSize = new System.Drawing.Size(703, 406);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.sta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VISHNU X CHEATS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sta;
        private Guna.UI2.WinForms.Guna2Button ON;
    }
}

