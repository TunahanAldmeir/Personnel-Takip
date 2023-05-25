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
    public partial class PersonelListele : Form
    {
        PersonDal pdal = new PersonDal();
        DepartmentDal ddal = new DepartmentDal();
        public PersonelListele()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ddal.GetAll();
            comboBox1.DisplayMember = "DepartName";
            comboBox1.ValueMember = "DepartId";
            dataGridView1.DataSource = pdal.GetAll();
            label16.Text = "Toplam Personel Sayısı: " + (dataGridView1.Rows.Count.ToString());
            decimal topmaaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                topmaaas += decimal.Parse(dataGridView1.Rows[i].Cells["PersonMaas"].Value.ToString());
            }
            label17.Text = "Toplam Maaş: " + topmaaas;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox14.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.SelectedValue =Convert.ToInt32( dataGridView1.CurrentRow.Cells[6].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdal.Delete(new Person
            {
                PersonId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString())
            }) ;
            MessageBox.Show("Personel Silindi");
            dataGridView1.DataSource = pdal.GetAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdal.Update(new Person
            {
                PersonId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                PersonAd = textBox14.Text,
                PersonSoyad = textBox13.Text,
                PersonTel = textBox12.Text,
                PersonEmail = textBox6.Text,
                PersonDurum = textBox7.Text,
                PersonMaas = Convert.ToInt32(textBox8.Text),
                PersonGTarihi = textBox9.Text,
                PersonCTarihi = textBox10.Text,
                PersonDepartId = Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                DepartmanAdı = comboBox1.Text,
                PersonAdres = textBox5.Text,
                PersonAcıklama = textBox11.Text
            });
            MessageBox.Show("Personel Bilgileri Güncellendi");
            dataGridView1.DataSource = pdal.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pdal.GetByName(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelEkle pekle = new PersonelEkle();
            pekle.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
