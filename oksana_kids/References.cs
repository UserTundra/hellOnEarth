using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class References : Form
    {
        public int tabIndex;

        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();

        public References(int index)
        {
            tabIndex = index;
            InitializeComponent();
        }

        private void References_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.R01_people_category". При необходимости она может быть перемещена или удалена.
            this.r01_people_categoryTableAdapter.Fill(this.bd_kidsDataSet.R01_people_category);
            tabControl1.SelectTab(tabIndex);
        }

        private void R01addButton_Click(object sender, EventArgs e)
        {
            if (R01_name_category.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                try
                {
                    bd_kidsDataSet.R01_people_categoryRow row;
                    row = bd_kidsDataSet.R01_people_category.NewR01_people_categoryRow();
                    row.name_category = R01_name_category.Text;
                    row.note = R01_note.Text == " " ? " " : R01_note.Text;

                    this.bd_kidsDataSet.R01_people_category.Rows.Add(row);
                    this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Возникли неприятности");
                }
            }

            R01_name_category.Clear();
            R01_note.Clear();
            R01.Refresh();
        }

        private void R01changeButton_Click(object sender, EventArgs e)
        {
            try
            { 
                bd_kidsDataSet.R01_people_categoryRow row;
                row = bd_kidsDataSet.R01_people_category.FindBycode_category((long)R01.CurrentRow.Cells[0].Value);

                row.name_category = R01.CurrentRow.Cells[1].Value.ToString();
                row.note = R01.CurrentRow.Cells[2].Value.ToString();

                this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникли неприятности");
            }
            R01.Refresh();

        }

        private void R01deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                bd_kidsDataSet.R01_people_categoryRow row;
                row = bd_kidsDataSet.R01_people_category.FindBycode_category((long)R01.CurrentRow.Cells[0].Value);
                row.Delete();
                this.r01_people_categoryTableAdapter.Update(this.bd_kidsDataSet.R01_people_category);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Возникли неприятности");
            }
            R01.Refresh();
        }

        private void References_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[1].Show(); 
        }
    }
}
