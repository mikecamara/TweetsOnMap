using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using drawLine;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            University uni = new University();

            uni.TitleUni = "UCLA";
            uni.Website = "ucla.com";
            uni.Phone = "1-2344-5555";
            uni.Latitude = 100;
            uni.Longitude = 200;

            Assert.AreEqual("UCLA", uni.TitleUni);
            Assert.AreEqual("ucla.com", uni.Website);
            Assert.AreEqual("1-2344-5555", uni.Phone);
            Assert.AreEqual(100, uni.Latitude);
            Assert.AreEqual(200, uni.Longitude);           
        }

        [TestMethod]
        public void TestMethod2()
        {
            Tweet tw = new Tweet();
            
            tw.IdTweet = "33";
            tw.TweetText = "Hard to believe Trump is winning so far.";
            tw.Latitude = "200";
            tw.Longitude = "400";

            Assert.AreEqual("33", tw.IdTweet);
            Assert.AreEqual("Hard to believe Trump is winning so far.", tw.TweetText);
            Assert.AreEqual("200", tw.Latitude);
            Assert.AreEqual("400", tw.Longitude);
          
        }
        
    }
}
