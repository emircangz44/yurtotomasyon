﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurtotomasyon
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtotomasyonDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtotomasyonDataSet1.Ogrenci);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
        }

        private void ogrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr=new FrmOgrListe();
            fr.Show();
        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr=new FrmBolumler();
            fr.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr=new FrmOdemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr=new FrmGider();
            fr.Show();
        }

        private void giderİstatisklikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr=new FrmGiderListesi();
            fr.Show();
        }

        private void gelirİstatisklikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik fr=new FrmGelirİstatistik();
            fr.Show();
        }

        private void giderİstatisklikleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr=new FrmYoneticiDuzenle();
            fr.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel fr=new FrmPersonel();
            fr.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle fr = new FrmNotEkle();
            fr.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Yunus Emre Tunç ve Emircan Göz Tarafından Veri Tabanı Projesi Olarak Yapılmıştır.", "Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
