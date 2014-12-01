using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yemekhane_Dolum
{
    class Hafta
    {
        private DateTime tarih;

        public Hafta(DateTime t)
        {
            setTarih(t);
        }
        public DateTime getTarih()
        {
            return tarih;
        }
        public void setTarih(DateTime tr)
        {
            tarih = tr;
        }
    }
}
