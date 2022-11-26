using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndApp.DAL
{
    internal interface ICRUD<T> where T:class
    {
        void Ekle(T entity);
        List<T> Listele();
        void Guncelle(T entity);
        void Sil(int id);
        T Ara(int id);
        
    }
}
