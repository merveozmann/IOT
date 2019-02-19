using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace TwitterApi
{
    public partial class Form1 : Form
    {
        public string kullaniciApiKey = "";
        public string ApiKeySecret = "";
        public string Erisim = "";
        public string ErisimSecret = "";
        public TwitterService service;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            service = new TwitterService(kullaniciApiKey, ApiKeySecret);
            service.AuthenticateWith(Erisim, ErisimSecret);
            IEnumerable<TwitterStatus> tweets;
            ListTweetsOnUserTimelineOptions ops = new ListTweetsOnUserTimelineOptions();
            
            ops.ScreenName = textBox1.Text;
            ops.Count = 10;
            
            tweets = service.ListTweetsOnUserTimeline(ops);
            List<Tweet> tweetlist = new List<Tweet>();
            tweetlist.Clear();

            for(int i=0; i< tweets.Count()-1; i++)
            {
                DateTime gun = tweets.ToList()[i].CreatedDate;
                long twitterid = tweets.ToList()[i].Id;
                string kullaniciadi = tweets.ToList()[i].User.ScreenName;
                string tweet = tweets.ToList()[i].Text;
                tweetlist.Add(new Tweet(gun, twitterid, kullaniciadi, tweet));
            }
            verilerList(tweetlist);
            verikayıt(tweetlist);
    

        }
        public void verilerList(List<Tweet> tweetlist)
        {
            dataGridView1.Rows.Clear();
            foreach(Tweet t in tweetlist)
            {
                string[] row = new string[]
                {
                   t.gun.ToString(),t.twitterid.ToString(),t.kullaniciadi,t.tweettext};
                dataGridView1.Rows.Add(row);
            }

        }
        public void verikayıt(List<Tweet> tweetlist)
        {
            string baglantiyolu = @"Data Source=DESKTOP-KE75FSJ;Initial Catalog=Dagitik;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            foreach (Tweet t in tweetlist)
            {
                SqlConnection baglanti = new SqlConnection(baglantiyolu);
                string sql = "insert into Tweet(tarih,id,kullaniciadi,tweet) values(@ptrh,@pid,@pkuladi,@ptweet)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@ptrh", t.gun);
                komut.Parameters.AddWithValue("@pid",t.twitterid);
                komut.Parameters.AddWithValue("@pkuladi", t.kullaniciadi);
                komut.Parameters.AddWithValue("@ptweet", t.tweettext);
               
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

    }
}
