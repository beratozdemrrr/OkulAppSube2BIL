using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using OkulApp.DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciKaydet(Ogrenci ogr)
        {
            var hlp = new Helper();
            var p = new SqlParameter[] {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.Numara)
            };
            return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara)", p) > 0;
        }
    }
}
