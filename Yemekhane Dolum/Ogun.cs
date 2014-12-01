using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yemekhane_Dolum
{
    class Ogun
    {
        private int ogunID;
        private string ogunAdi;
        private DateTime tarih;
        private int otur;
        private Menu menü;
        //private
        public Ogun()
        {
            menü = new Menu();
        }
        public int getId()
        {
            return ogunID;
        }
        public int gettur()
        {
            return otur;
        }
        public void settur(int t)
        {
            otur = t;
        }
        public void setId(int id)
        {
            ogunID = id;
        }
        public string getAd()
        {
            return ogunAdi;
        }
        public void setAd(string s)
        {
            ogunAdi = s;
        }
        public DateTime gettarih()
        {
            return tarih;
        }
        public void setTarih(DateTime t)
        {
            tarih = t;
        }
        public bool haftasec(DateTime tr)
        {
            setTarih(tr);
            return true;
        }
        public bool ogun()
        {
            return true;
        }
        public bool ogunsec(string s,int t,Yemek_Katalogu kat)
        {
            setAd(s);
            setId(t);
            kat.katalogtanal(t);
            return true;
        }
        public Menu getmenu()
        {
            return menü;
        }
        public void setmenu(Menu m)
        {
            menü = m;
        }
        public void yemekSec(Yemek y)
        {
            getmenu().ekle(y);
        }
    }
}
