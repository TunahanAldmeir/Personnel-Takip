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
    public partial class Departmanlar : Form
    {
        public Departmanlar()
        {
            InitializeComponent();
        }

        DepartmentDal dedal = new DepartmentDal();
        private void Departmanlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dedal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dedal.Add(new Department
            {
                DepartName = textBox2.Text,
                DepartDescription = textBox3.Text
            });
            MessageBox.Show("Depatrmant Eklendi");
            dataGridView1.DataSource = dedal.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dedal.Delete(new Department
            {
                DepartId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            });
            MessageBox.Show("Silindi");
            dataGridView1.DataSource = dedal.GetAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dedal.Update(new Department
            {
                DepartId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                DepartName=textBox2.Text,
                DepartDescription=textBox3.Text
            });
            MessageBox.Show("Departman Güncellendi!!");
            dataGridView1.DataSource = dedal.GetAll();
        }
    }
}
