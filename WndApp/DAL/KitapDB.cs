using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WndApp.Model;

namespace WndApp.DAL
{
    internal class KitapDB
    {
         public static SqlConnection _conn;

        public KitapDB()
        {
             _conn=new SqlConnection(  ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);

            Kitaplar = new KitapYonetici();
            Yazarlar = new YazarYonetici();
            Kategoriler = new KategoriYonetici();
        }

        public KitapYonetici Kitaplar { get; set; }
        public YazarYonetici Yazarlar { get; set; }
        public KategoriYonetici Kategoriler { get; set; }
    }
}
