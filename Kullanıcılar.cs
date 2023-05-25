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
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartContext context = new DepartContext();

            User m = context.Users.Where(x => x.KullanıcıAdı == textBox1.Text && x.KullanıcıSifre == textBox2.Text).SingleOrDefault();

            if (m==null)
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Bilgilerine Sahip Kullanıcı Bulunamadı!!");
            }
            else
            {
                this.Hide();
                Anasayfa a = new Anasayfa();
                a.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
