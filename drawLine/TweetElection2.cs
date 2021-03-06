﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawLine
{
    class TweetElection2 : Tweet
    {
        private string candidate;

        public TweetElection2()
        {
            this.candidate = "";
        }

        public TweetElection2(string idTweet, string tweetText, string latitude, string longitude, string candidate)
            : base(idTweet, tweetText, latitude, longitude)
        {
            this.candidate = candidate;
        }

        public string IdTweet { get; set; }
        public string TweetText { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Candidate { get; set; }
    }
}
