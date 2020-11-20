using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using EasyTabs;

namespace new_browser
{
    public partial class Form1 : Form
    {
        int spanelSize;
        bool Hided;
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        public Form1()
        {
            InitializeComponent();
            spanelSize = Spanel.Width;
            
            
            
            //Hided = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            SettingBox.Hide();
            groupBoxMail.Hide();
            
        }


        private void btnforward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Text.StartsWith("http://") &&
                !comboBox1.Text.StartsWith("https://") &&
                !comboBox1.Text.EndsWith(".com"))
            {
                webBrowser.Navigate("http://" + comboBox1.Text + ".com");
            }
            
            srtcutgrpbox.Hide();

        }

        



        private void btnHome_Click(object sender, EventArgs e)
        {
            
            this.webBrowser.Navigate("http://www.google.com");
            srtcutgrpbox.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                if (!comboBox1.Text.StartsWith("http://") &&
                    !comboBox1.Text.StartsWith("https://") &&
                    !comboBox1.Text.EndsWith(".com"))

                    webBrowser.Navigate("http://" + comboBox1.Text + ".com");
                srtcutgrpbox.Hide();
            }
        }

        private void Addressbar_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == (char)Keys.Enter)
            {
               // this.webBrowser1.Navigate("http://"+Addressbar.Text);
                pictureBox1.Hide();
                comboBox1.Hide();
                btnVoice.Hide();
                btnSearch.Hide();
            }*/
        }

        

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    this.webBrowser1.Navigate("http://"+comboBox1.Text);
        //    pictureBox1.Hide();
        //}

        private void backbtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            //pictureBoxSearch.Hide();
            if (comboBox1.Text == "Search here")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.DarkGray;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //pictureBoxSearch.Show();
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Search here";
                comboBox1.ForeColor = Color.DarkGray;
            }
        }

        //private void Navigate(String address)
        //{
        //    if (String.IsNullOrEmpty(address)) return;
        //    if (address.Equals("about:blank")) return;
        //    if (!address.StartsWith("http://") &&
        //        !address.StartsWith("https://") &&
        //        !address.EndsWith(".com"))
        //    {
        //        address = "http://" + address + ".com";
        //    }
        //    try
        //    {
        //        webBrowser.Navigate(new Uri(address));
        //    }
        //    catch (System.UriFormatException)
        //    {
        //        return;
        //    }
        //}

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            comboBox1.Text =webBrowser.Url.ToString();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            if (SettingBox.Visible)
            {
                SettingBox.Hide();
            }

            else
            {
                SettingBox.Show();
            }
        }

 
        private void apps_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Hided)
            {
                Spanel.Width = Spanel.Width + 22;

                if (Spanel.Width >= spanelSize)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }

            else
            {
                Spanel.Width = Spanel.Width - 20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMail.Hide();
            webBrowser.Navigate("www.gmail.com");
            srtcutgrpbox.Hide();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (groupBoxMail.Visible)
            {
                groupBoxMail.Hide();
            }

            else
            {
                groupBoxMail.Show();
            }
        }

        private void btnYahoo_Click(object sender, EventArgs e)
        {
            groupBoxMail.Hide();
            webBrowser.Navigate("www.yahoo.com");
            srtcutgrpbox.Hide();
        }

        private void btnOutlook_Click(object sender, EventArgs e)
        {
            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("www.outlook.com");
        }

        private void btnGMX_Click(object sender, EventArgs e)
        {
            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("www.gmx.com");
        }

        private void btnIcould_Click(object sender, EventArgs e)
        {
            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("www.icloud.com");
        }

        private void btnAol_Click(object sender, EventArgs e)
        {
            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("www.aol.com");
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {

        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("www.google.com/maps");
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {

            srtcutgrpbox.Hide();
            groupBoxMail.Hide();
            webBrowser.Navigate("https://www.bing.com/search?q=https:%2F%2Fgoogletranslate.com&PC=IENEPB");
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
