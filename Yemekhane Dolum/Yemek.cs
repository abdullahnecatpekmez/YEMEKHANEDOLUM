using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yemekhane_Dolum
{
    class Yemek
    {
        private int yemekID;
        private string yemekAdi;
        private int ogunTur;
        
        public Yemek()
        {
            
        }
        public int getId()
        {
            return yemekID;
        }
        public void setId(int id)
        {
            yemekID = id;
        }
        public string getAd()
        {
            return yemekAdi;
        }
        public void setAd(string s)
        {
            yemekAdi = s;
        }
        public int gettur()
        {
            return ogunTur;
        }
        public void setTur(int t)
        {
            ogunTur = t;
        }
    }
}
