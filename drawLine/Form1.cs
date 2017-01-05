using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace drawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawLineBtn_Click(object sender, EventArgs e)
        {
            string json;

            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Green);

            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Chocolate);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            Dictionary<string, University> unis = new Dictionary<string, University>();


            // Constructor call Factory Method
            TweetElection te = new TweetElection();
            Tweet t1 = new TweetElection2();
            Tweet t2 = new TweetElection();


            using (System.IO.StreamReader file = File.OpenText("universities.json"))
            {

                json = file.ReadToEnd();
                JsonSerializer serializer = new JsonSerializer();

                dynamic dy = JsonConvert.DeserializeObject(json);

                foreach (var iterator in dy.universities)
                {
                    University uni = new University();
                    uni.TitleUni = iterator.title.ToString();
                    uni.Website = iterator.web.ToString();
                    uni.Phone =  iterator.phone.ToString();
                    uni.Latitude = Int32.Parse((iterator.lat.ToString()));
                    uni.Longitude = Int32.Parse((iterator.lng.ToString()));
                    unis.Add(iterator.title.ToString(), uni);
                    int latU = Int32.Parse((iterator.lat.ToString()));
                    int lonU = Int32.Parse((iterator.lng.ToString()));
                    g.DrawEllipse(pen, latU, lonU, 30, 30);                    
                }
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("student-tweets.xml");

            Dictionary<string, Tweet> values = new Dictionary<string, Tweet>();

            XmlNodeList id = doc.GetElementsByTagName("tw:studentid");
            XmlNodeList text = doc.GetElementsByTagName("tw:text");
            XmlNodeList lat = doc.GetElementsByTagName("tw:lat");
            XmlNodeList lon = doc.GetElementsByTagName("tw:long");


            for (int i = 0; i < id.Count; i++)
            {

                Tweet obj = new Tweet();

                obj.IdTweet = id[i].InnerXml;
                obj.TweetText = text[i].InnerXml;
                obj.Latitude = lat[i].InnerXml;
                obj.Longitude = lon[i].InnerXml;

                string phrase = obj.TweetText;

                values.Add(id[i].InnerXml, obj);
            }

            foreach (var uniIt in unis)
            {
                int latUni = uniIt.Value.Latitude;
                int lonUni = uniIt.Value.Longitude;

                foreach (var it in values)
                {
                    string[] twtWordArray = it.Value.TweetText.Split(' ');

                    foreach (string ite in twtWordArray)
                    {
                        if (uniIt.Value.TitleUni.Equals(ite))
                        {
                            int latit = Int32.Parse((it.Value.Latitude));
                            int longit = Int32.Parse((it.Value.Longitude));
                            RectangleF rectf = new RectangleF(latit, longit, 90, 50);
                            g.FillRectangle(Brushes.Bisque, rectf);
                            g.DrawString(it.Value.TweetText, new Font("Tahoma", 8), Brushes.Black, rectf);

                            Point twtPoint = new Point(latit, longit);
                            Point uniPoint = new Point(latUni, lonUni);

                            g.DrawLine(myPen, twtPoint, uniPoint);
                        }
                    }
                }
            }
      
            myPen.Dispose();
            formGraphics.Dispose();
            pen.Dispose();
            g.Dispose();
        }
    }
}
