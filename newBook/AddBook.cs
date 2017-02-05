using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace newBook
{
    public partial class AddBook : Form
    {
        Random r = new Random();
        DataSet ds = new DataSet();
        public AddBook()
        {
            InitializeComponent();
            ds.ReadXml("NewXMLDillersDataset2.xml");

            
            

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            dataGridView1_addbook.DataSource = ds.Tables["Notebooks"];
            dill_dataGridView.DataSource = ds.Tables["Dillers"];
            dataGridView_done.DataSource = ds.Tables["Done"];

            dill_dataGridView.Columns[0].Visible = false;
            dill_dataGridView.Columns[2].Visible = false;
            dill_dataGridView.Columns[1].HeaderText = "Имя диллера";

            dataGridView1_addbook.Columns[0].Visible = false;
            dataGridView1_addbook.Columns[1].Visible = false;
            //dataGridView1_addbook.Columns[4].Visible = false;
            dataGridView1_addbook.Columns[5].Visible = false;
            dataGridView1_addbook.Columns[2].HeaderText = "Модель ноутбука";
            dataGridView1_addbook.Columns[3].HeaderText = "Описание поломки";

            

            dataGridView_done.Columns[0].Visible = false;
            dataGridView_done.Columns[1].Visible = false;
            dataGridView_done.Columns[2].HeaderText = "Описание ремонта";
            dataGridView_done.Columns[3].HeaderText = "Дата готовности";       
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ds.WriteXml("NewXMLDillersDataset2.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.WriteXml("NewXMLDillersDataset2.xml");
        }

        private void добавитьКДиллеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1_addbook.CurrentRow.Cells[0].Value = r.Next(10, 5000);
            }
            catch { MessageBox.Show("Выбери строку!!!"); }

            dataGridView1_addbook.CurrentRow.Cells[1].Value = dill_dataGridView.CurrentRow.Cells[0].Value;

            dataGridView1_addbook.CurrentRow.Cells[4].Value = dateTimePickerNewBook.Value;
            dataGridView1_addbook.CurrentRow.Cells[5].Value = 0;


        }

        private void отметитьКакГотовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_done.CurrentRow.Cells[0].Value = r.Next(10, 5000);

                dataGridView_done.CurrentRow.Cells[1].Value = dataGridView1_addbook.CurrentRow.Cells[0].Value;
                dataGridView_done.CurrentRow.Cells[3].Value = dateTimePickerNewBook.Value;

            }
            catch { MessageBox.Show("Выбери строку!!!"); }

            dataGridView1_addbook.CurrentRow.Cells[5].Value = 4;
        }
    }
}
