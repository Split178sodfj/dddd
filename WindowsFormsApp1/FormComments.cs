using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.demooDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class FormComments : Form
    {
        public FormComments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide(); // Hide the current form instead of closing it
            form1.Show();
            form1.FormClosed += (s, args) => Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            this.Hide(); // Hide the current form instead of closing it
            formRequest.Show();
            FormClosed += (s, args) => Application.Exit();
        }

        private void комментыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комментыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demooDataSet);

        }

        private void FormComments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demooDataSet.комменты". При необходимости она может быть перемещена или удалена.
            this.комментыTableAdapter.Fill(this.demooDataSet.комменты);

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text;
            try
            {
                комментыBindingSource.Filter = $"message LIKE '%{searchText}%'";
                if (комментыBindingSource.Count == 0)
                {
                    throw new Exception("No matching records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            комментыBindingSource.EndEdit();
            комментыTableAdapter.Update(demooDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            комментыBindingSource.AddNew();
        }
    }
}
