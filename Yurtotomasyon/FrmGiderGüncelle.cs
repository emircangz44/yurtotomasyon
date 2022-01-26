using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurtotomasyon
{
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, doğalgaz, gıda, diğer, internet, personel, id;

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4," +
              "Gıda=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", TxtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDoğalgaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiğer.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme yapıldı");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz");
            }
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtGıda.Text = gıda;
            Txtİnternet.Text = internet;
            TxtSu.Text = su;
            TxtPersonel.Text = personel;
            TxtDoğalgaz.Text = doğalgaz;
            TxtDiğer.Text = diğer;
        }

        private void TxtSu_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
