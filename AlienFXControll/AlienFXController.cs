using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class AlienFXControl : Form
    {
        bool isClose = false;
        int intTemp = 0;
        bool blnLoop = false;
        Thread tRGB;
        String strMode = "Solid";
        
        

        public AlienFXControl()
        {
            InitializeComponent();
            this.FormClosing += AlienFXControl_FormClosing;
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("AlienFXController");
            if(key!=null)
            {
                if (key.GetValue("Mode").ToString() == "Solid") rbSolid.Select();
                else if (key.GetValue("Mode").ToString() == "Breath") rbBreath.Select();
                else if (key.GetValue("Mode").ToString() == "Rainbow") rbRainbow.Select();
            //tbRed.Value = int.Parse(key.GetValue("Red").ToString());
            txtRed.Text = key.GetValue("Red").ToString();
            //tbGreen.Value = int.Parse(key.GetValue("Green").ToString());
            txtGreen.Text = key.GetValue("Green").ToString();
            //tbBlue.Value = int.Parse(key.GetValue("Blue").ToString());
            txtBlue.Text = key.GetValue("Blue").ToString();
            tbSecond.Value = int.Parse(key.GetValue("Delay").ToString());
            key.Close();
            Apply();
            }
        }

        private void AlienFXControl_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (isClose != true)
            {
                notifyIcon.ShowBalloonTip(5000, "AlienFX Controller Is Still Running", "To Exit, right click this icon and click \"Exit\".", ToolTipIcon.Info);
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                notifyIcon.Visible = false;
                if (tRGB.IsAlive)
                {
                    tRGB.Abort();
                }
            }
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            txtRed.Text = tbRed.Value.ToString();
        }

        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtRed.Text) >= 0 && int.Parse(txtRed.Text) <= 255)
            {
                tbRed.Value = int.Parse(txtRed.Text);
                pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
                intTemp = int.Parse(txtRed.Text);
            }
            else
            {
                txtRed.Text = intTemp.ToString();
                txtRed.SelectAll();
            }
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            txtGreen.Text = tbGreen.Value.ToString();
        }

        private void txtGreen_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtGreen.Text) >= 0 && int.Parse(txtGreen.Text) <= 255)
            {
                tbGreen.Value = int.Parse(txtGreen.Text);
                pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
                intTemp = int.Parse(txtGreen.Text);
            }
            else
            {
                txtGreen.Text = intTemp.ToString();
                txtGreen.SelectAll();
            }
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            txtBlue.Text = tbBlue.Value.ToString();
        }

        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtBlue.Text) >= 0 && int.Parse(txtBlue.Text) <= 255)
            {
                tbBlue.Value = int.Parse(txtBlue.Text);
                pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
                intTemp = int.Parse(txtBlue.Text);
            }
            else
            {
                txtBlue.Text = intTemp.ToString();
                txtBlue.SelectAll();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
         
               
            
        }
        private void Apply()
        {
            if (blnLoop)
            {
                blnLoop = false;
                if (tRGB.IsAlive)
                {
                    tRGB.Abort();
                }
                btnApply.Text = "Apply";
                pic.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
                rbSolid.Enabled = true;
                rbBreath.Enabled = true;
                rbRainbow.Enabled = true;
            }
            else
            {
                String strMode = "Solid";

                if (rbSolid.Checked)
                {
                    strMode = "Solid";
                }
                else if (rbBreath.Checked)
                {

                    tRGB = new Thread(RGBBreathThread);
                    blnLoop = true;
                    btnApply.Text = "Stop";
                    Form.CheckForIllegalCrossThreadCalls = false;
                    tRGB.Start();
                    rbSolid.Enabled = false;
                    rbBreath.Enabled = false;
                    rbRainbow.Enabled = false;
                    strMode = "Breath";
                }
                else if (rbRainbow.Checked)
                {

                    tRGB = new Thread(RGBRainbowThread);
                    blnLoop = true;
                    btnApply.Text = "Stop";
                    Form.CheckForIllegalCrossThreadCalls = false;
                    tRGB.Start();
                    rbSolid.Enabled = false;
                    rbBreath.Enabled = false;
                    rbRainbow.Enabled = false;
                    strMode = "Rainbox";
                }
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("AlienFXController");
                key.SetValue("Mode", strMode);
                key.SetValue("Red", tbRed.Value);
                key.SetValue("Green", tbGreen.Value);
                key.SetValue("Blue", tbBlue.Value);
                key.SetValue("Delay", tbSecond.Value);
                key.Close(); 
            }
        }

        private void RGBBreathThread()
        {
            int oR, oG, oB; 
            int cR, cG, cB;
            int pR, pG, pB;
            cR = tbRed.Value;
            cG = tbGreen.Value;
            cB = tbBlue.Value;
            oR = cR;
            oG = cG;
            oB = cB;
            pR = cR * 10/240;
            pG = cG * 10/240;
            pB = cB * 10/240;
            while (this.blnLoop)
            {
                for (int i = 0; i < 24; i++)
                {
                    if (cR >= 20) cR = cR - pR;
                    if (cG >= 20) cG = cG - pG;
                    if (cB >= 20) cB = cB - pB;
                    this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                    Thread.Sleep(tbSecond.Value);
                }
                Thread.Sleep(tbSecond.Value);
                for (int i = 0; i < 24; i++)
                {
                    if (cR < oR - 20) cR = cR + pR;
                    if (cG < oG - 20) cG = cG + pG;
                    if (cB < oB - 20) cB = cB + pB;
                    this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                    Thread.Sleep(tbSecond.Value);
                }
                Thread.Sleep(tbSecond.Value);
            }
        }
        private void RGBRainbowThread()
        {

            int cR, cG, cB;
            cR = 255;
            cG = 0;
            cB = 0;
           
            while (this.blnLoop)
            {

                    Thread.Sleep(tbSecond.Value);
                    for (int i = 0; i < 25; i++)
                    {
                        cG = cG + 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        cR = cR - 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        cB = cB + 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        cG = cG - 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        cR = cR + 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        cB = cB - 10;
                        this.pic.BackColor = Color.FromArgb(cR, cG, cB);
                        Thread.Sleep(tbSecond.Value);
                    }
                    
            }
        }

     
        private void menuClose_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close(); 
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void tbSecond_Scroll(object sender, EventArgs e)
        {
            ttSecond.SetToolTip(tbSecond, tbSecond.Value.ToString());
        }

        private void rbSolid_CheckedChanged(object sender, EventArgs e)
        {
            tbSecond.Enabled = false;
        }

        private void rbBreath_CheckedChanged(object sender, EventArgs e)
        {
            tbSecond.Enabled = true;
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            tbSecond.Enabled = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setColour(sender.ToString());
        }
        private void setColour(String strColour)
        {
            txtRed.Text = Color.FromName(strColour).R.ToString();
            txtGreen.Text = Color.FromName(strColour).G.ToString();
            txtBlue.Text = Color.FromName(strColour).B.ToString();
            this.pic.BackColor = Color.FromName(strColour);
            if(blnLoop) Apply();
            Apply();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (blnLoop) Apply();

        }

    }
}
