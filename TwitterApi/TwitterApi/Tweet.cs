using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApi
{
    public class Tweet
    {
        public DateTime gun;
        public Int64 twitterid;
        public string kullaniciadi;
        public string tweettext;

        public Tweet(DateTime gn, Int64 tid, string kuladi, string text)
        {
            gun = gn;
            twitterid = tid;
            kullaniciadi = kuladi;
            tweettext = text;
        }
    }
}
