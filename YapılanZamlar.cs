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
    public partial class YapılanZamlar : Form
    {
        PersonDal pdal = new PersonDal();
        public YapılanZamlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZamDal zdal = new ZamDal();
            if (radioButton1.Checked == false)
            {
                zdal.Add(new Zam
                {
                    PersonelName = comboBox2.Text,
                    Donem = comboBox1.Text,
                    Fiyat = Convert.ToDecimal(textBox2.Text),
                    Açıklama = textBox3.Text,
                    Tarih = comboBox3.Text
                });
                pdal.ZamYap(Convert.ToInt32(comboBox2.SelectedValue.ToString()), (Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(textBox2.Text)));
            }
            else
            {
                zdal.Add(new Zam
                {
                    PersonelName = comboBox2.Text,
                    Donem = comboBox1.Text,
                    Yuzde = Convert.ToDecimal(textBox1.Text),
                    Açıklama = textBox3.Text,
                    Tarih = comboBox3.Text
                });
                pdal.ZamYap(Convert.ToInt32(comboBox2.SelectedValue.ToString()), (Convert.ToInt32(comboBox4.Text) + Convert.ToInt32(comboBox4.Text)%Convert.ToInt32(textBox1.Text)));
            }

            MessageBox.Show("Seçilen Personele Zam Yapıldı");
        }

        private void YapılanZamlar_Load(object sender, EventArgs e)
        {
            comboBox4.Enabled = false;
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil-5); i--)
            {
                comboBox3.Items.Add(i);
            }
            comboBox2.SelectedIndex = 0;
            comboBox2.DataSource = pdal.GetAll();
            comboBox2.DisplayMember = "PersonAd";
            comboBox2.ValueMember = "PersonId";
            comboBox4.DataSource = pdal.GetAll();
            comboBox4.DisplayMember = "PersonMaas";
            comboBox4.ValueMember = "PersonId";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedValue = comboBox2.SelectedValue;
        }
    }
}
