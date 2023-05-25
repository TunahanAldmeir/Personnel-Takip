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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            DepartmentDal ddal = new DepartmentDal();
            comboBox1.DataSource = ddal.GetAll();
            comboBox1.DisplayMember = "DepartName";
            comboBox1.ValueMember = "DepartId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonDal pdal = new PersonDal();
            pdal.Add(new Person
            {
                PersonAd=textBox1.Text,
                PersonSoyad=textBox2.Text,
                PersonTel=textBox4.Text,
                PersonEmail=textBox6.Text,
                PersonDurum=textBox7.Text,
                PersonMaas=Convert.ToInt32(textBox8.Text),
                PersonGTarihi=textBox9.Text,
                PersonCTarihi=textBox10.Text,
                PersonDepartId=Convert.ToInt32(comboBox1.SelectedValue.ToString()),
                DepartmanAdı=comboBox1.Text,
                PersonAdres=textBox5.Text,
                PersonAcıklama=textBox11.Text
            });
            MessageBox.Show("Personel Eklendi");
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox5.Clear();
            comboBox1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
