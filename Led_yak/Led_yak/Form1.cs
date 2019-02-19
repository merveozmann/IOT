using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Led_yak
{
    public partial class Form1 : Form
    {
        public string sunucu = "http://192.168.1.2";
        public string ac = "";
        public string kapat = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                WebRequest request = WebRequest.Create(sunucu + ac);
              request.GetResponse();
                //MessageBox.Show(sunucu + ac);

            }
            else
            {
                WebRequest request = WebRequest.Create(sunucu + kapat);
                request.GetResponse();
                //MessageBox.Show(sunucu + kapat);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String html = client.DownloadString(sunucu);

            string[] body = html.Split(new string[] { "<a", "</a>" }, StringSplitOptions.RemoveEmptyEntries);
            string[] url = body[1].Split(new string[] { "\"", "\"" }, StringSplitOptions.RemoveEmptyEntries);
            string[] url2 = body[4].Split(new string[] { "\"", "\"" }, StringSplitOptions.RemoveEmptyEntries);

           // MessageBox.Show(url2[1]);

            ac = url[1];
            kapat = url2[1];

        }
    }
}
