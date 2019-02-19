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
using Newtonsoft.Json;

namespace translete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string cevirilecek = "";
        public string ceviri = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            string kelime = textBox2.Text;
            
            string jsontext = Ceviri(kelime, cevirilecek, ceviri);
            Translate t = JsonConvert.DeserializeObject<Translate>(jsontext);
            string result = "";
            for(int i = 0; i < t.text.Length; i++)
            {
                result += t.text[i];

            }
            textBox1.Text = result;
            
           
        }
        public string Ceviri(string word,string sourceLang,string targetLang)
        {
            string url = "https://translate.yandex.net/api/v1.5/tr.json/translate?";
            url += "key=trnsl.1.1.20181115T183009Z.461233cd483b8036.d30b77b2e8e96b8c4c586a786ca79d8562a03438";
            url += "&lang=" + sourceLang + "-" + targetLang;
            url += "&text=" + word;
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string json = wc.DownloadString(url);
            return json;
        }

        private void en1_CheckedChanged(object sender, EventArgs e)
        {
            if (en1.Checked)
            {
                cevirilecek = "en";
            }
        }

        private void tr1_CheckedChanged(object sender, EventArgs e)
        {
            if (tr1.Checked)
            {
                cevirilecek = "tr";
            }
        }

        private void de1_CheckedChanged(object sender, EventArgs e)
        {
            if (de1.Checked)
            {
                cevirilecek = "de";
            }
        }

        private void en2_CheckedChanged(object sender, EventArgs e)
        {
            if (en2.Checked)
            {
                ceviri = "en";
            }
        }

        private void tr2_CheckedChanged(object sender, EventArgs e)
        {
            if (tr2.Checked)
            {
                ceviri = "tr";
            }
        }

        private void de2_CheckedChanged(object sender, EventArgs e)
        {
            if (de2.Checked)
            {
                ceviri = "de";
            }
        }
    }
}
