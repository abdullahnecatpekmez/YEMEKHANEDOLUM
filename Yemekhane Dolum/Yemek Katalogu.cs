using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yemekhane_Dolum
{
    class Yemek_Katalogu
    {
        private ArrayList liste;
        private int tür;

        public Yemek_Katalogu()
        {
            liste = new ArrayList();
        }
        public int gettur()
        {
            return tür;
        }
        public void settur(int t)
        {
            tür=t;
        }
        public void setlist(ArrayList l)
        {
            liste = l;
        }
        public ArrayList getlist()
        { return liste; }
        public void katalogtanal(int t)
        {
            settur(t);
        }
    }
}
