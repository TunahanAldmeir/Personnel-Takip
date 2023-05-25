using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerdonelTakip
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departmanlar frm = new Departmanlar();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelEkle frm = new PersonelEkle();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelListele pfrm = new PersonelListele();
            pfrm.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            //Kullanıcılar frmk = new Kullanıcılar();
            //frmk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YapılanZamlar frmy = new YapılanZamlar();
            frmy.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HareketEkle frme = new HareketEkle();
            frme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            İzinHareketListele frmizin = new İzinHareketListele();
            frmizin.ShowDialog();
        }
    }
}
