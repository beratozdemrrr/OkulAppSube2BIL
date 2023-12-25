using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogrt)
        {
            var hlp = new Helper();
            var p = new SqlParameter[] {
                new SqlParameter("@Ad", ogrt.OgretmenAd),
                new SqlParameter("@Soyad", ogrt.OgretmenSoyad),
                new SqlParameter("@TcNo", ogrt.OgretmenTc)
            };
            return hlp.ExecuteNonQuery("Insert into OgretmenlerTable values(@Ad,@Soyad,@TcNo)", p) > 0;
        }
    }
}
