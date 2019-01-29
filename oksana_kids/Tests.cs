using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class Tests : Form
    {
        public int tabIndex;

        List<string> fio = new List<string>();
        Dictionary<int, string> fio_dict = new Dictionary<int, string>();

        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();

        public Tests(int index)
        {
            tabIndex = index;
            InitializeComponent();


        }

        private void Tests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet5.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter.Fill(this.bd_kidsDataSet5.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet4.T01_personalities". При необходимости она может быть перемещена или удалена.
            this.t01_personalitiesTableAdapter.Fill(this.bd_kidsDataSet4.T01_personalities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet3.T02_view_tests". При необходимости она может быть перемещена или удалена.
            this.t02_view_testsTableAdapter.Fill(this.bd_kidsDataSet3.T02_view_tests);
            tabControl1.SelectTab(tabIndex);

            
        }

        private void test_construct_button_Click(object sender, EventArgs e)
        {
            AdaptiveTestConstructor a = new AdaptiveTestConstructor();
            a.Show();
        }
    }
}
