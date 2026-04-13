using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration; // App.config'i okumak için bu kütüphane şart!

namespace Proje_Hastane
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            // Bağlantı cümlesini artık elimizle yazmıyoruz, 
            // App.config içindeki "HastaneBaglantisi" isimli ayardan çekiyoruz.
            string baglantiAdresi = ConfigurationManager.ConnectionStrings["HastaneBaglantisi"].ConnectionString;

            SqlConnection baglan = new SqlConnection(baglantiAdresi);
            baglan.Open();
            return baglan;
        }
    }
}