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
    public partial class AskToLeaveForm : Form
    {
        public AskToLeaveForm()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
