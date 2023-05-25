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
    public partial class İzinTürleri : Form
    {
        public İzinTürleri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PermissionTypeDal pytypedal = new PermissionTypeDal();
        private void İzinTürleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pytypedal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pytypedal.Add(new PermissionType
            {
                İzinTürü = textBox1.Text
            });
            MessageBox.Show("İzin Türü Eklendi");
            dataGridView1.DataSource = pytypedal.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pytypedal.Delete(new PermissionType
            {
                İzinTürId =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            });
            MessageBox.Show("Seçilen İzin Türü Silindi...");
            dataGridView1.DataSource = pytypedal.GetAll();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pytypedal.Update(new PermissionType
            {
                İzinTürId=Convert.ToInt32(textBox2.Text),
                İzinTürü =textBox1.Text
            });
            MessageBox.Show("Seçilen İzin Güncellendi");
            dataGridView1.DataSource = pytypedal.GetAll();
        }
    }
}
