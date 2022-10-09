namespace projectc
{
    partial class loginadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginadmin));
            this.label5 = new System.Windows.Forms.Label();
            this.adminBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.adminbox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(43, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Admin Login";
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(89, 88);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(130, 30);
            this.adminBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adminBtn.StateCommon.Border.Rounding = 10;
            this.adminBtn.StateCommon.Border.Width = 1;
            this.adminBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.TabIndex = 16;
            this.adminBtn.Values.Text = "Admin";
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // adminbox
            // 
            this.adminbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbox.ForeColor = System.Drawing.Color.Gray;
            this.adminbox.Location = new System.Drawing.Point(16, 53);
            this.adminbox.Name = "adminbox";
            this.adminbox.Size = new System.Drawing.Size(285, 23);
            this.adminbox.TabIndex = 18;
            this.adminbox.UseSystemPasswordChar = true;
            this.adminbox.TextChanged += new System.EventHandler(this.adminbox_TextChanged);
            this.adminbox.Enter += new System.EventHandler(this.adminbox_Enter);
            this.adminbox.Leave += new System.EventHandler(this.adminbox_Leave_1);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(129, 121);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(52, 17);
            this.cancel.TabIndex = 31;
            this.cancel.Text = "cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // loginadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(316, 147);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.adminbox);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label5);
            this.Name = "loginadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginadmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton adminBtn;
        private System.Windows.Forms.TextBox adminbox;
        private System.Windows.Forms.Label cancel;
    }
}