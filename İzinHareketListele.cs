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
    public partial class İzinHareketListele : Form
    {
        public İzinHareketListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İzinTürleri frmi = new İzinTürleri();
            frmi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PermissionMoveDal pmmovedal = new PermissionMoveDal();
        PermissionTypeDal pmtydal = new PermissionTypeDal();
        private void İzinHareketListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pmmovedal.GetAll();
            comboBox1.DataSource = pmtydal.GetAll();
            comboBox1.DisplayMember = "İzinTürü";
            comboBox1.ValueMember = "İzinTürId";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text !="")
            {
                PersonDal pdall = new PersonDal();
                foreach (var item in pdall.GetAll().Where(p => p.PersonAd == textBox3.Text))
                {
                    textBox4.Text = item.PersonSoyad;
                    textBox2.Text = item.PersonId.ToString();

                }
            }
            else
            {
                textBox4.Clear();
                textBox2.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pmmovedal.Add(new PermissionMove
            {
                Aciklama=textBox5.Text,
                PersonelId=Convert.ToInt32(textBox2.Text),
                İzinTürü=comboBox1.Text,
                İzinTürId=Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                İzinBasla=Convert.ToDateTime(dateTimePicker1.Value.ToString()),
                İzinBitis=Convert.ToDateTime(dateTimePicker2.Value.ToString()),
            });
            MessageBox.Show("İzin Eklendi..");
            dataGridView1.DataSource = pmmovedal.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pmmovedal.Update(new PermissionMove
            {
                İzinId=Convert.ToInt32(textBox1.Text),
                Aciklama = textBox5.Text,
                PersonelId = Convert.ToInt32(textBox2.Text),
                İzinTürü = comboBox1.Text,
                İzinTürId = Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                İzinBasla = Convert.ToDateTime(dateTimePicker1.Value.ToString()),
                İzinBitis = Convert.ToDateTime(dateTimePicker2.Value.ToString()),
            });
            MessageBox.Show("Seçilen Kayıt Güncellendi..");
            dataGridView1.DataSource = pmmovedal.GetAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pmmovedal.Delete(new PermissionMove
            {
                İzinId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value)
            }) ;
            MessageBox.Show("Seçilen Kayıt Silindi..");
            dataGridView1.DataSource = pmmovedal.GetAll();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
