using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        public string AddWebsite
        {
            set { HistoryDataGridView.Rows.Add(value); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Очистка истории
            HistoryDataGridView.Rows.Clear();
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            HistoryDataGridView.Rows.Clear();
        }
    }
}
