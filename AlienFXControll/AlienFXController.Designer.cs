namespace WindowsFormsApplication1
{
    partial class AlienFXControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlienFXControl));
            this.cbAera = new System.Windows.Forms.ComboBox();
            this.lbRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbBreath = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbRainbow = new System.Windows.Forms.RadioButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbSecond = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.ttSecond = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAera
            // 
            this.cbAera.BackColor = System.Drawing.Color.Black;
            this.cbAera.ForeColor = System.Drawing.Color.White;
            this.cbAera.FormattingEnabled = true;
            this.cbAera.Location = new System.Drawing.Point(5, 5);
            this.cbAera.Name = "cbAera";
            this.cbAera.Size = new System.Drawing.Size(450, 20);
            this.cbAera.TabIndex = 0;
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.ForeColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(5, 29);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(27, 12);
            this.lbRed.TabIndex = 1;
            this.lbRed.Text = "Red:";
            // 
            // tbRed
            // 
            this.tbRed.AutoSize = false;
            this.tbRed.BackColor = System.Drawing.Color.Black;
            this.tbRed.Location = new System.Drawing.Point(50, 29);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(261, 28);
            this.tbRed.SmallChange = 5;
            this.tbRed.TabIndex = 2;
            this.tbRed.TickFrequency = 5;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.Black;
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRed.ForeColor = System.Drawing.Color.White;
            this.txtRed.Location = new System.Drawing.Point(316, 38);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(70, 22);
            this.txtRed.TabIndex = 3;
            this.txtRed.Text = "0";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.Black;
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGreen.ForeColor = System.Drawing.Color.White;
            this.txtGreen.Location = new System.Drawing.Point(317, 71);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(70, 22);
            this.txtGreen.TabIndex = 6;
            this.txtGreen.Text = "0";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGreen.TextChanged += new System.EventHandler(this.txtGreen_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.AutoSize = false;
            this.tbGreen.BackColor = System.Drawing.Color.Black;
            this.tbGreen.Location = new System.Drawing.Point(50, 62);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(261, 28);
            this.tbGreen.SmallChange = 5;
            this.tbGreen.TabIndex = 5;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green:";
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.Black;
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlue.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBlue.Location = new System.Drawing.Point(317, 104);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(70, 22);
            this.txtBlue.TabIndex = 9;
            this.txtBlue.Text = "0";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.AutoSize = false;
            this.tbBlue.BackColor = System.Drawing.Color.Black;
            this.tbBlue.Location = new System.Drawing.Point(50, 95);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(261, 28);
            this.tbBlue.SmallChange = 5;
            this.tbBlue.TabIndex = 8;
            this.tbBlue.TickFrequency = 5;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blue:";
            // 
            // rbSolid
            // 
            this.rbSolid.AutoSize = true;
            this.rbSolid.Checked = true;
            this.rbSolid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbSolid.Location = new System.Drawing.Point(5, 128);
            this.rbSolid.Name = "rbSolid";
            this.rbSolid.Size = new System.Drawing.Size(47, 16);
            this.rbSolid.TabIndex = 10;
            this.rbSolid.TabStop = true;
            this.rbSolid.Text = "Solid";
            this.rbSolid.UseVisualStyleBackColor = true;
            this.rbSolid.CheckedChanged += new System.EventHandler(this.rbSolid_CheckedChanged);
            // 
            // rbBreath
            // 
            this.rbBreath.AutoSize = true;
            this.rbBreath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbBreath.Location = new System.Drawing.Point(59, 128);
            this.rbBreath.Name = "rbBreath";
            this.rbBreath.Size = new System.Drawing.Size(54, 16);
            this.rbBreath.TabIndex = 11;
            this.rbBreath.Text = "Breath";
            this.rbBreath.UseVisualStyleBackColor = true;
            this.rbBreath.CheckedChanged += new System.EventHandler(this.rbBreath_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApply.Location = new System.Drawing.Point(381, 128);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(74, 19);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rbRainbow
            // 
            this.rbRainbow.AutoSize = true;
            this.rbRainbow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbRainbow.Location = new System.Drawing.Point(121, 128);
            this.rbRainbow.Name = "rbRainbow";
            this.rbRainbow.Size = new System.Drawing.Size(65, 16);
            this.rbRainbow.TabIndex = 12;
            this.rbRainbow.Text = "Rainbow";
            this.rbRainbow.UseVisualStyleBackColor = true;
            this.rbRainbow.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Black;
            this.pic.Location = new System.Drawing.Point(392, 29);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(63, 94);
            this.pic.TabIndex = 14;
            this.pic.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AlienFX Controller";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.menuClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Go Dark";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.customToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem2.Text = "Breath";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(120, 22);
            this.menuClose.Text = "Exit";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // tbSecond
            // 
            this.tbSecond.AutoSize = false;
            this.tbSecond.BackColor = System.Drawing.Color.Black;
            this.tbSecond.Enabled = false;
            this.tbSecond.LargeChange = 50;
            this.tbSecond.Location = new System.Drawing.Point(242, 128);
            this.tbSecond.Maximum = 1000;
            this.tbSecond.Minimum = 100;
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(133, 19);
            this.tbSecond.TabIndex = 15;
            this.tbSecond.TickFrequency = 100;
            this.tbSecond.Value = 250;
            this.tbSecond.Scroll += new System.EventHandler(this.tbSecond_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.Color.White;
            this.lblDelay.Location = new System.Drawing.Point(195, 132);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(35, 12);
            this.lblDelay.TabIndex = 13;
            this.lblDelay.Text = "Delay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Speed:";
            // 
            // AlienFXControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(460, 159);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.rbRainbow);
            this.Controls.Add(this.rbBreath);
            this.Controls.Add(this.rbSolid);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.cbAera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlienFXControl";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlienFX Controller";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAera;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSolid;
        private System.Windows.Forms.RadioButton rbBreath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbRainbow;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar tbSecond;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.ToolTip ttSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
    }
}

