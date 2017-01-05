using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawLine
{
    public class University 
    {
        private string titleUni;
        private string website;
        private string phone;
        private int latitude;
        private int longitude;

        public University()
        {
            this.titleUni = "";
            this.website = "";
            this.phone = "";
            this.latitude = 0;
            this.longitude = 0;
        }


        public University(string titleUni, string website, string phone, int latitude, int longitude)
        {
            this.titleUni = titleUni;
            this.website = website;
            this.phone = phone;
            this.latitude = latitude;
            this.longitude = longitude;

        }


        public string TitleUni { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }

 

    
    }
}
