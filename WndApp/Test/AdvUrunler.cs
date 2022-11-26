using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndApp.Test
{

    internal class UrunDB {

        public List<AdvUrunler> UrunBul(string kelime)
        {

            SqlConnection conn = new SqlConnection("Data source=.;initial catalog=Calisma;integrated security=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM AdvUrunler WHERE UrunAdi LIKE '%" + @kelime + "%'", conn);

            //SqlCommand cmd = new SqlCommand("SELECT * FROM AdvUrunler WHERE UrunAdi LIKE @kelime", conn);

            cmd.Parameters.AddWithValue("@kelime", kelime);

            SqlDataReader dr = cmd.ExecuteReader();

           
            List<AdvUrunler> urunler = new List<AdvUrunler>();
            while (dr.Read())
            {
                AdvUrunler urun = new AdvUrunler();
                urun.UrunID = Convert.ToInt32(dr[0]);
                urun.UrunAdi = dr["UrunAdi"].ToString();
                urun.Renk = dr["Renk"].ToString();

                urunler.Add(urun);
            }

            conn.Close();
            return urunler;

        }
    }

    internal class AdvUrunler
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }

        public string Renk { get; set; }
    }
}
