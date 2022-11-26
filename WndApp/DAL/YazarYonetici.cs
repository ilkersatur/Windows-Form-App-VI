using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndApp.Model;

namespace WndApp.DAL
{
    internal class YazarYonetici : ICRUD<Yazar>
    {
        public Yazar Ara(int id)
        {
            KitapDB._conn.Open();
            throw new NotImplementedException();
            KitapDB._conn.Close();
        }

        public void Ekle(Yazar entity)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Yazar entity)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> Listele()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
