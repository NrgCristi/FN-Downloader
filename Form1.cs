using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace FN_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Path successfully Selected");
            MessageBox.Show("Starting To Downlaod");
            string url = "https://drive.google.com/u/0/uc?id=1FL2Bdo_J9oS6uJbu6_abX3Rz1B5Z7dIG&export=download&confirm=t&uuid=8c649a1f-e949-4271-a1da-f877394fc29b";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.GetResponseStream();


        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Download Completed");
                this.Close();
            }
            else
            {
                MessageBox.Show("an error occurred, please try again later");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Just press the download button to download fortnite 20.40");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
