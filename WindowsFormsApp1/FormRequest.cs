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
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            FormClosed += (s, args) => Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormComments formComments = new FormComments();
            this.Hide();
            formComments.Show();
            FormClosed += (s, args) => Application.Exit();

        }

        private void заявкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demooDataSet);

        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demooDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.demooDataSet.Заявки);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            заявкиBindingSource.AddNew();
        }

        private void climateTechTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(climateTechTypeTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void climateTechModelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(climateTechModelTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void problemDescryptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(problemDescryptionTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void requestStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(requestStatusTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void completionDateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(completionDateTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }

        private void repairPartsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(repairPartsTextBox.Text))
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
                заявкиBindingSource.Filter = $"climateTechModel LIKE '%{searchText}%'";
                if (заявкиBindingSource.Count == 0)
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
            заявкиBindingSource.EndEdit();
            заявкиTableAdapter.Update(demooDataSet);
        }

        private void startDateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(startDateTextBox.Text))
            {
                MessageBox.Show("Поле 'message' не может быть пустым");
                return;
            }
        }
    }
}
