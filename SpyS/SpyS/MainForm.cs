using System;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Media;
using System.IO;

namespace SpyS
{
    public partial class MainForm : Form
    {
        ChromeDriver ChromeBrowser;
        SoundPlayer Sound;

        string element;
        string url;
        int interval;


        public MainForm()
        {
            InitializeComponent();
            Sound = new SoundPlayer();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Checker.Interval = interval;
                Checker.Start();
            }
            catch { MessageBox.Show("Имей совесть!", "Урод", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Checker.Stop();
                ChromeBrowser.Quit();
            }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Checker.Stop();
                Sound.Stop();
                ChromeBrowser.Quit();
            }
            catch { }
        }

        private void Checker_Tick(object sender, EventArgs e)
        {
            try
            {
                if(RefreshBox.Checked)
                {
                    ChromeBrowser.Navigate().GoToUrl(url);
                }
                Info_1.Text = ChromeBrowser.FindElementByCssSelector(element).Text;
            }
            catch {}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SoundChange(SpyS.Properties.Resources.soundtrack_1);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                interval = int.Parse(IntervalText.Text);
                url = URLText.Text;
                element = ElementText.Text;
                ChromeBrowser = new ChromeDriver();
                ChromeBrowser.Navigate().GoToUrl(url);
            }
            catch { MessageBox.Show("Имей совесть!", "Урод", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SoundChange(Stream stream)
        {
            Sound.Stop();
            Sound.Stream = stream;
            Sound.Play();
        }

        private void Info_1_TextChanged(object sender, EventArgs e)
        {
            if(RingCheck.Checked)
            {
                SoundChange(SpyS.Properties.Resources.sound_2);
            }
        }
    }
}
