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
    public partial class TheFirstForm : Form
    {
        public TheFirstForm()
        {
            InitializeComponent();
        }
        HistoryForm histform = new HistoryForm();

        private void BackTSB_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void ForwardTSB_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
        }

        private void RebootTSB_Click(object sender, EventArgs e)
        {
            WebBrowser.Refresh();
        }

        private void StopTSB_Click(object sender, EventArgs e)
        {
            WebBrowser.Stop();
        }

        private void WebTSB_KeyDown(object sender, KeyEventArgs e)
        {
            //Если нажали Enter, то открывается страница в WebBrowser'e
            if (e.KeyCode == Keys.Enter)
            {
                Uri uri = new Uri(WebTextBox.Text);
                WebBrowser.Url = uri;
                histform.AddWebsite = WebTextBox.Text;
            }
        }

        private void PlusTSB_Click(object sender, EventArgs e)
        {
                Uri uri = WebBrowser.Document.Url;
                BookmarkComboBox.Items.Add(uri.ToString());
        }

        private void BookmarkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser.Navigate(BookmarkComboBox.SelectedItem.ToString());
            WebTextBox.Text = BookmarkComboBox.SelectedItem.ToString();
        }

        private void HistoryTSB_Click(object sender, EventArgs e)
        {
            histform.Show();
        }

        private void SaveTSB_Click(object sender, EventArgs e)
        {
            WebBrowser.ShowSaveAsDialog();
        }

        private void BookmarkComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Работает только если сначала выбрать сайт, а потом уже ПКМ
            if (e.Button == MouseButtons.Right)
            {
                BookmarkComboBox.Items.Remove(BookmarkComboBox.SelectedItem.ToString());
            }
        }
    }
}


