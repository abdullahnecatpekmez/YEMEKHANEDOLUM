using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Yemekhane_Dolum
{
    
    class DB
    {
        private static DatabaseDataContext db = new DatabaseDataContext();
        public DB()
        {
            
        }

        public ArrayList katalog(int tur)
        {
            ArrayList l = new ArrayList();
            var v = from y in db.YEMEK
                    where y.ogunTur.Equals(tur)
                    select y;
            foreach(YEMEK x in v)
            {
                Yemek e = new Yemek();
                e.setId(x.yemekNO);
                e.setAd(x.yemekAdi.ToString());
                e.setTur(Convert.ToInt32(x.ogunTur));
                l.Add(e);
            }
            return l;
        }
        public void menügöster(DataGridView d,Ogun ogn)
        {
            var v = from o in db.OGUN
                    where o.tarih.Value.Day == ogn.gettarih().Day && o.tarih.Value.Month == ogn.gettarih().Month && o.tarih.Value.Year == ogn.gettarih().Year && o.ogunTuru.Equals(ogn.gettur())
                    select o;
            foreach(OGUN x in v)
            {
                d.DataSource = from m in db.MENU
                               from y in db.YEMEK
                               where m.ogunNO.Equals(x.ogunNO) && m.yemekNO == y.yemekNO
                               select new { MENÜ_İÇERİĞİ = y.yemekAdi };
                d.Columns[0].Width = 200;
            }
        }
        public void ogunekle(Ogun o)
        {
            OGUN yeni=new OGUN();
            yeni.ogunNO = o.getId();
            yeni.ogunTuru = o.gettur();
            yeni.tarih = o.gettarih();
            db.OGUN.InsertOnSubmit(yeni);
            db.SubmitChanges();
            menüekle(o);
        }
        public void menüekle(Ogun o)
        {
            foreach(Yemek x in o.getmenu().getlist())
            {
                MENU yeni = new MENU();
                yeni.ogunNO = o.getId();
                yeni.yemekNO = x.getId();
                db.MENU.InsertOnSubmit(yeni);
            }
            db.SubmitChanges();
        }

    }

}
