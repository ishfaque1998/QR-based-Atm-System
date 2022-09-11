namespace ATM
{
    partial class PinChange
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
            this.select = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pinCode = new System.Windows.Forms.TextBox();
            this.cnfrmPincode = new System.Windows.Forms.TextBox();
            this.cnfrm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.select.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.select.ForeColor = System.Drawing.Color.Navy;
            this.select.Location = new System.Drawing.Point(164, 201);
            this.select.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(340, 55);
            this.select.TabIndex = 3;
            this.select.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(164, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Password";
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(555, 93);
            this.pinCode.Multiline = true;
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(183, 35);
            this.pinCode.TabIndex = 7;
            this.pinCode.TextChanged += new System.EventHandler(this.withDraw_TextChanged);
            // 
            // cnfrmPincode
            // 
            this.cnfrmPincode.Location = new System.Drawing.Point(556, 201);
            this.cnfrmPincode.Multiline = true;
            this.cnfrmPincode.Name = "cnfrmPincode";
            this.cnfrmPincode.Size = new System.Drawing.Size(182, 36);
            this.cnfrmPincode.TabIndex = 8;
            this.cnfrmPincode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnfrm
            // 
            this.cnfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfrm.FillColor = System.Drawing.Color.PaleTurquoise;
            this.cnfrm.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cnfrm.ForeColor = System.Drawing.Color.White;
            this.cnfrm.Location = new System.Drawing.Point(589, 333);
            this.cnfrm.Margin = new System.Windows.Forms.Padding(2);
            this.cnfrm.Name = "cnfrm";
            this.cnfrm.Size = new System.Drawing.Size(136, 38);
            this.cnfrm.TabIndex = 32;
            this.cnfrm.Text = "Confirm";
            this.cnfrm.Click += new System.EventHandler(this.cnfrm_Click);
            // 
            // PinChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnfrm);
            this.Controls.Add(this.cnfrmPincode);
            this.Controls.Add(this.pinCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select);
            this.Name = "PinChange";
            this.Text = "PinChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label select;
        private Label label1;
        private TextBox pinCode;
        private TextBox cnfrmPincode;
        private Guna.UI2.WinForms.Guna2Button cnfrm;
    }
}