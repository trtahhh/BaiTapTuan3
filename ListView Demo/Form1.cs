using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Demo
{
    public partial class lvlDemo : Form
    {
        public lvlDemo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lvlDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLN.Text);
            lvi.SubItems.Add(txtFN.Text);
            lvi.SubItems.Add(txtPN.Text);
            lvInfo.Items.Add(lvi);  
            txtFN.Clear();
            txtPN.Clear();
            txtLN.Clear();
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvInfo.SelectedItems.Count > 0)
            {
                lvInfo.Items.Remove(lvInfo.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lvInfo.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvInfo.SelectedItems[0];
                selectedItem.Text = txtLN.Text;
                selectedItem.SubItems[1].Text = txtFN.Text;
                selectedItem.SubItems[2].Text = txtPN.Text; 
                txtLN.Clear();
                txtFN.Clear();
                txtPN.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.");
            }
        }
    }
}
