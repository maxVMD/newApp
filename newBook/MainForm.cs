using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newBook
{
    public partial class MainForm : Form
    {
        string xmdDatasource = "NewXMLDillersDataset2.xml";
        string xmdSchemaSource = "newXMLdatabaseShema.xsd";
        dilBooksDataSet ds; 
     

        public MainForm()
        {
            InitializeComponent();
            ds = new dilBooksDataSet();
        }


        private void dillersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            ds.EndInit();
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(xmdDatasource))
            {
                ds.ReadXmlSchema(xmdSchemaSource);
                ds.ReadXml(xmdDatasource);             
            }
            else
                MessageBox.Show("Data not found!");

            

            dataGridView1.DataSource = ds.Tables["Dillers"];
            dataGridView1.CellEnter += DataGridView1_CellEnter;

            dataGridView1.Columns[1].HeaderText = "Имя диллера";
            dataGridView1.Columns[2].HeaderText = "Телефон";
            dataGridView1.Columns[0].Visible = false;         
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = ds.Tables["Notebooks"].Select("[dillerID] = '" + dataGridView1.CurrentRow.Cells[0].Value + "'");

            dataGridView2.Columns[2].HeaderText = "Модель ноутбука";
            dataGridView2.Columns[3].HeaderText = "Описание поломки";

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "Dillersss", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                e.Cancel = false;               
            }
            else
                e.Cancel = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьНовыйНоутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            if (addBook.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Новый Ноутбук успешно добавлен!", "Новый бук", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
                MessageBox.Show("Не проканало!!!", "Dillersss", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }    
     
        private void отметитьКакНеСогласованToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridView2.CurrentRow.Cells[5].Value = 0;
            
            
        }    
        private void отметитьКакСогласованToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView2.CurrentRow.Cells[5].Value = 1;
           
        }
        private void отметитьКакОтказникToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView2.CurrentRow.Cells[5].Value = 2;


        }
        private void отметитьКакГорящийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[5].Value = 3;
       
        }
        private void отметитьКакГотовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[5].Value = 4;
        }

        private void notebooksDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                ((DataGridView)sender).CurrentCell = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];        

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string query = string.Format("{0} LIKE '{1}%'", Convert.ToString("model"), Convert.ToString(tbx_search.Text)); 
            try
            {
                dataGridView2.DataSource = this.ds.Tables["Notebooks"].Select(query);
            }
            catch (Exception) { MessageBox.Show("Введите хоть что нибудь!"); }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            ds.WriteXml(xmdDatasource);
                     
        }

        private void notebooksDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Int32.Parse(row.Cells["status"].Value.ToString()) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                    {                      
                        cell.Style.BackColor = Color.Silver;                       
                    }

                if (Int32.Parse(row.Cells["status"].Value.ToString()) == 1)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightBlue;
                    }

                if (Int32.Parse(row.Cells["status"].Value.ToString()) == 2)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightCoral;
                    }

                if (Int32.Parse(row.Cells["status"].Value.ToString()) == 3)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }

                if (Int32.Parse(row.Cells["status"].Value.ToString()) == 4)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.YellowGreen;
                    }
            }

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Refreshall();

        }

        private void удалитьХлопцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowCollection dr_Dillers = this.ds.Tables["Dillers"].Rows;
            DataRow dr_diller = dr_Dillers.Find(dataGridView1.CurrentRow.Cells[0].Value);
            DataRow[] dr_notebooks = dr_diller.GetChildRows(ds.Relations[1]);
            foreach(DataRow nbook in dr_notebooks)
            {
                DataRow[] dr_dones = nbook.GetChildRows(this.ds.Relations[1]);
                foreach (DataRow d in dr_dones)
                   d.Delete();

                nbook.Delete();
            }

            dr_diller.Delete();
           
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.DataSource = ds.Tables["Done"].Select("[bookID] = '" + dataGridView2.CurrentRow.Cells[0].Value + "'");
            discriptionTextBox.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            dataGridView3.Columns[2].HeaderText = "Описание ремонта";
            dataGridView3.Columns[3].HeaderText = "Дата готовности";

            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[5].Visible = false;
            dataGridView3.Columns[6].Visible = false;
            dataGridView3.Columns[7].Visible = false;
            dataGridView3.Columns[8].Visible = false;
        }

        public void Refreshall ()
        {
            ds = new dilBooksDataSet();
            ds.ReadXml(xmdDatasource);

            dataGridView2.DataSource = ds.Tables["Notebooks"].Select("[dillerID] = '" + dataGridView1.CurrentRow.Cells[0].Value + "'");

            dataGridView2.Columns[2].HeaderText = "Модель ноутбука";
            dataGridView2.Columns[3].HeaderText = "Описание поломки";

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
        }

      
    }
}
