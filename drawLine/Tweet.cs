using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawLine
{
    public class Tweet
    {
        private string idTweet; 
        private string tweetText; 
        private string latitude; 
        private string longitude; 

        public Tweet()
        {
            this.idTweet = "";
            this.tweetText = "";
            this.latitude = "";
            this.longitude = "";
        }

        public Tweet(string idTweet, string tweetText, string latitude, string longitude) 
        {
            this.idTweet = idTweet;
            this.tweetText = tweetText;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public string IdTweet { get; set; }
        public string TweetText { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
