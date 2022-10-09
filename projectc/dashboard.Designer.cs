namespace projectc
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.datais = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.adelbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rebtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.auserbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.adashbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.abookbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.da = new System.Windows.Forms.TextBox();
            this.us = new System.Windows.Forms.TextBox();
            this.bk = new System.Windows.Forms.TextBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datais)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datais
            // 
            this.datais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datais.Location = new System.Drawing.Point(243, 217);
            this.datais.Name = "datais";
            this.datais.Size = new System.Drawing.Size(443, 129);
            this.datais.TabIndex = 78;
            this.datais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datais_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "Issue Book User";
            // 
            // adelbtn
            // 
            this.adelbtn.Location = new System.Drawing.Point(413, 457);
            this.adelbtn.Name = "adelbtn";
            this.adelbtn.Size = new System.Drawing.Size(89, 30);
            this.adelbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adelbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adelbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adelbtn.StateCommon.Border.Rounding = 10;
            this.adelbtn.StateCommon.Border.Width = 1;
            this.adelbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adelbtn.TabIndex = 67;
            this.adelbtn.Values.Text = "Del";
            this.adelbtn.Click += new System.EventHandler(this.adelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.rebtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.auserbtn);
            this.panel1.Controls.Add(this.adashbtn);
            this.panel1.Controls.Add(this.abookbtn);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 564);
            this.panel1.TabIndex = 61;
            // 
            // rebtn
            // 
            this.rebtn.Location = new System.Drawing.Point(13, 333);
            this.rebtn.Name = "rebtn";
            this.rebtn.Size = new System.Drawing.Size(130, 30);
            this.rebtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rebtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rebtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rebtn.StateCommon.Border.Rounding = 10;
            this.rebtn.StateCommon.Border.Width = 1;
            this.rebtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebtn.TabIndex = 79;
            this.rebtn.Values.Text = "Return";
            this.rebtn.Click += new System.EventHandler(this.rebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "History Issue";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(13, 521);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(130, 30);
            this.logoutbtn.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.logoutbtn.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.logoutbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logoutbtn.StateCommon.Border.Rounding = 10;
            this.logoutbtn.StateCommon.Border.Width = 1;
            this.logoutbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.TabIndex = 13;
            this.logoutbtn.Values.Text = "Logout";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click_1);
            // 
            // auserbtn
            // 
            this.auserbtn.Location = new System.Drawing.Point(13, 227);
            this.auserbtn.Name = "auserbtn";
            this.auserbtn.Size = new System.Drawing.Size(130, 30);
            this.auserbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.auserbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.auserbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.auserbtn.StateCommon.Border.Rounding = 10;
            this.auserbtn.StateCommon.Border.Width = 1;
            this.auserbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auserbtn.TabIndex = 10;
            this.auserbtn.Values.Text = "Users";
            this.auserbtn.Click += new System.EventHandler(this.auserbtn_Click);
            // 
            // adashbtn
            // 
            this.adashbtn.Location = new System.Drawing.Point(13, 280);
            this.adashbtn.Name = "adashbtn";
            this.adashbtn.Size = new System.Drawing.Size(130, 30);
            this.adashbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adashbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adashbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adashbtn.StateCommon.Border.Rounding = 10;
            this.adashbtn.StateCommon.Border.Width = 1;
            this.adashbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adashbtn.TabIndex = 11;
            this.adashbtn.Values.Text = "Issue";
            this.adashbtn.Click += new System.EventHandler(this.adashbtn_Click);
            // 
            // abookbtn
            // 
            this.abookbtn.Location = new System.Drawing.Point(13, 176);
            this.abookbtn.Name = "abookbtn";
            this.abookbtn.Size = new System.Drawing.Size(130, 30);
            this.abookbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.abookbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.abookbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.abookbtn.StateCommon.Border.Rounding = 10;
            this.abookbtn.StateCommon.Border.Width = 1;
            this.abookbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abookbtn.TabIndex = 9;
            this.abookbtn.Values.Text = "Books";
            this.abookbtn.Click += new System.EventHandler(this.abookbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Date";
            // 
            // da
            // 
            this.da.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da.ForeColor = System.Drawing.Color.Gray;
            this.da.Location = new System.Drawing.Point(552, 390);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(153, 23);
            this.da.TabIndex = 69;
            // 
            // us
            // 
            this.us.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.us.ForeColor = System.Drawing.Color.Gray;
            this.us.Location = new System.Drawing.Point(229, 390);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(153, 23);
            this.us.TabIndex = 63;
            // 
            // bk
            // 
            this.bk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk.ForeColor = System.Drawing.Color.Gray;
            this.bk.Location = new System.Drawing.Point(393, 390);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(153, 23);
            this.bk.TabIndex = 65;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(435, 183);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(93, 30);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 10;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 92;
            this.kryptonButton2.Values.Text = "Search";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(243, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 91;
            this.textBox1.Text = "enter user";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datais);
            this.Controls.Add(this.da);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datais)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datais;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton adelbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logoutbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton auserbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton adashbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton abookbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox da;
        private System.Windows.Forms.TextBox us;
        private System.Windows.Forms.TextBox bk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton rebtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.TextBox textBox1;
    }
}