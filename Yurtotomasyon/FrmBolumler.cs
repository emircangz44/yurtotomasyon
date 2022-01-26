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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumad.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);

            }
            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {

            SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti !");
                this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata,işlem gerçekleşmedi");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad=dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumad.Text = bolumad;


        }

        private void PcbBolumDuzenle_Click_1(object sender, EventArgs e)
        {
            try
            {

            SqlCommand komut2 = new SqlCommand("update Bolumler Set Bolumad=@p1 where Bolumid=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
            komut2.Parameters.AddWithValue("@p1", TxtBolumad.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Düzenleme İşlemi Gerçekleşti !");
            this.bolumlerTableAdapter.Fill(this.yurtotomasyonDataSet.Bolumler);

            }
            catch
            {
                MessageBox.Show("Hata !!!");
            }
        }
    }
}
