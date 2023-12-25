using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube2BIL
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnOgrtmnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtblg = new OgretmenBL();
                bool sonuc = ogrtblg.OgretmenKaydet(new Ogretmen { OgretmenAd = txtOgrtmnAd.Text.Trim(), OgretmenSoyad = txtOgrtmnSoyad.Text.Trim(), OgretmenTc = txtOgrtmnTc.Text.Trim() });
            }
            catch (SqlException ex)
            {

                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kaydedilmiş");
                        break;
                    default:
                        MessageBox.Show("VeriTabanı Hatası");
                        break;
                }
            }
            catch(Exception) 
            {
                MessageBox.Show("Bilinmeyen Hata");
            }
        }
    }
}
