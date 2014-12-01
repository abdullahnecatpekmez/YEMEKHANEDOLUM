using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yemekhane_Dolum
{
    class Menu
    {
        private ArrayList yemeklist;

        public Menu()
        {
            yemeklist = new ArrayList();
        }

        public void ekle(Yemek y)
        {
            yemeklist.Add(y);
        }

        public string yazdır()
        {
            string s = "Menu: ";
            foreach(Yemek x in yemeklist)
            {
                s+=((Yemek)x).getAd()+", ";
            }
            return s;
        }
        public ArrayList getlist()
        {
            return yemeklist;
        }
    }
}
