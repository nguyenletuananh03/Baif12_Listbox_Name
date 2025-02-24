using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baif12_Listbox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex < 0)
            {
                return;
            }
            txtName.Text = lstName.Items[lstName.SelectedIndex].ToString();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            lstName.Items.Add ("meo meo");
            lstName.Items.Add ("meo meo");
            lstName.Items.Add ("meo meo");
            lstName.Items.Add ("meo meo");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstName .Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex < 0)
            {
                MessageBox.Show("hãy chọn tên trong danh sách ", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstName.Items[lstName.SelectedIndex] = txtName.Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex >= 0) 
            {
                lstName.Items.Remove(lstName.SelectedIndex);
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            lstName.Items.Insert(Convert.ToInt32(txtindext.Text), txtName.Text);
        }
    }
}
