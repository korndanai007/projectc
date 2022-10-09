namespace projectc
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.rnamebox = new System.Windows.Forms.TextBox();
            this.rsurbox = new System.Windows.Forms.TextBox();
            this.rtelbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ruserbox = new System.Windows.Forms.TextBox();
            this.rpasswordbox = new System.Windows.Forms.TextBox();
            this.raddressbox = new System.Windows.Forms.TextBox();
            this.rcardbox = new System.Windows.Forms.TextBox();
            this.regBtn2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rconpass = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rnamebox
            // 
            this.rnamebox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnamebox.ForeColor = System.Drawing.Color.Gray;
            this.rnamebox.Location = new System.Drawing.Point(15, 81);
            this.rnamebox.Name = "rnamebox";
            this.rnamebox.Size = new System.Drawing.Size(285, 23);
            this.rnamebox.TabIndex = 6;
            this.rnamebox.Text = "name";
            this.rnamebox.TextChanged += new System.EventHandler(this.rnamebox_TextChanged);
            this.rnamebox.Enter += new System.EventHandler(this.rnamebox_Enter);
            this.rnamebox.Leave += new System.EventHandler(this.rnamebox_Leave);
            // 
            // rsurbox
            // 
            this.rsurbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rsurbox.ForeColor = System.Drawing.Color.Gray;
            this.rsurbox.Location = new System.Drawing.Point(15, 110);
            this.rsurbox.Name = "rsurbox";
            this.rsurbox.Size = new System.Drawing.Size(285, 23);
            this.rsurbox.TabIndex = 8;
            this.rsurbox.Text = "surname";
            this.rsurbox.Enter += new System.EventHandler(this.rsurbox_Enter);
            this.rsurbox.Leave += new System.EventHandler(this.rsurbox_Leave);
            // 
            // rtelbox
            // 
            this.rtelbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rtelbox.ForeColor = System.Drawing.Color.Gray;
            this.rtelbox.Location = new System.Drawing.Point(15, 139);
            this.rtelbox.Name = "rtelbox";
            this.rtelbox.Size = new System.Drawing.Size(285, 23);
            this.rtelbox.TabIndex = 10;
            this.rtelbox.Text = "phone";
            this.rtelbox.Enter += new System.EventHandler(this.rtelbox_Enter);
            this.rtelbox.Leave += new System.EventHandler(this.rtelbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(82, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "Register";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "-----------------------------------------";
            // 
            // ruserbox
            // 
            this.ruserbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ruserbox.ForeColor = System.Drawing.Color.Gray;
            this.ruserbox.Location = new System.Drawing.Point(16, 328);
            this.ruserbox.Name = "ruserbox";
            this.ruserbox.Size = new System.Drawing.Size(285, 23);
            this.ruserbox.TabIndex = 16;
            this.ruserbox.Text = "user";
            this.ruserbox.Enter += new System.EventHandler(this.ruserbox_Enter);
            this.ruserbox.Leave += new System.EventHandler(this.ruserbox_Leave);
            // 
            // rpasswordbox
            // 
            this.rpasswordbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rpasswordbox.ForeColor = System.Drawing.Color.Gray;
            this.rpasswordbox.Location = new System.Drawing.Point(16, 357);
            this.rpasswordbox.Name = "rpasswordbox";
            this.rpasswordbox.Size = new System.Drawing.Size(285, 23);
            this.rpasswordbox.TabIndex = 18;
            this.rpasswordbox.Text = "password";
            this.rpasswordbox.Enter += new System.EventHandler(this.rpasswordbox_Enter);
            this.rpasswordbox.Leave += new System.EventHandler(this.rpasswordbox_Leave);
            // 
            // raddressbox
            // 
            this.raddressbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.raddressbox.ForeColor = System.Drawing.Color.Gray;
            this.raddressbox.Location = new System.Drawing.Point(15, 197);
            this.raddressbox.Multiline = true;
            this.raddressbox.Name = "raddressbox";
            this.raddressbox.Size = new System.Drawing.Size(284, 99);
            this.raddressbox.TabIndex = 25;
            this.raddressbox.Text = "address";
            this.raddressbox.Enter += new System.EventHandler(this.raddressbox_Enter);
            this.raddressbox.Leave += new System.EventHandler(this.raddressbox_Leave);
            // 
            // rcardbox
            // 
            this.rcardbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rcardbox.ForeColor = System.Drawing.Color.Gray;
            this.rcardbox.Location = new System.Drawing.Point(16, 168);
            this.rcardbox.Name = "rcardbox";
            this.rcardbox.Size = new System.Drawing.Size(285, 23);
            this.rcardbox.TabIndex = 26;
            this.rcardbox.Text = "card number";
            this.rcardbox.Enter += new System.EventHandler(this.rcardbox_Enter);
            this.rcardbox.Leave += new System.EventHandler(this.rcardbox_Leave);
            // 
            // regBtn2
            // 
            this.regBtn2.Location = new System.Drawing.Point(89, 415);
            this.regBtn2.Name = "regBtn2";
            this.regBtn2.Size = new System.Drawing.Size(130, 30);
            this.regBtn2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regBtn2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.regBtn2.StateCommon.Border.Rounding = 10;
            this.regBtn2.StateCommon.Border.Width = 1;
            this.regBtn2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn2.TabIndex = 28;
            this.regBtn2.Values.Text = "Register";
            this.regBtn2.Click += new System.EventHandler(this.regBtn2_Click_1);
            // 
            // rconpass
            // 
            this.rconpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rconpass.ForeColor = System.Drawing.Color.Gray;
            this.rconpass.Location = new System.Drawing.Point(16, 386);
            this.rconpass.Name = "rconpass";
            this.rconpass.Size = new System.Drawing.Size(285, 23);
            this.rconpass.TabIndex = 29;
            this.rconpass.Text = "confirm password";
            this.rconpass.Enter += new System.EventHandler(this.rconpass_Enter);
            this.rconpass.Leave += new System.EventHandler(this.rconpass_Leave);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(128, 448);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(52, 17);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(316, 474);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.rconpass);
            this.Controls.Add(this.regBtn2);
            this.Controls.Add(this.rcardbox);
            this.Controls.Add(this.raddressbox);
            this.Controls.Add(this.rpasswordbox);
            this.Controls.Add(this.ruserbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtelbox);
            this.Controls.Add(this.rsurbox);
            this.Controls.Add(this.rnamebox);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rnamebox;
        private System.Windows.Forms.TextBox rsurbox;
        private System.Windows.Forms.TextBox rtelbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ruserbox;
        private System.Windows.Forms.TextBox rpasswordbox;
        private System.Windows.Forms.TextBox raddressbox;
        private System.Windows.Forms.TextBox rcardbox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton regBtn2;
        private System.Windows.Forms.TextBox rconpass;
        private System.Windows.Forms.Label cancel;
    }
}