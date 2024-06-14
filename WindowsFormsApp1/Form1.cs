using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demooDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demooDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.demooDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demooDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.demooDataSet.Users);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demooDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text;
            try
            {
                usersBindingSource.Filter = $"fio LIKE '%{searchText}%'";
                if (usersBindingSource.Count == 0)
                {
                    throw new Exception("No matching records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show("Поле 'Логин' не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Поле 'Телефон' не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(fioTextBox.Text))
            {
                MessageBox.Show("Поле 'ФИО' не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Поле 'Пароль' не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(typeTextBox.Text))
            {
                MessageBox.Show("Поле 'Тип' не может быть пустым");
                return;
            }

            usersBindingSource.EndEdit();
            usersTableAdapter.Update(demooDataSet);
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usersBindingSource.RemoveCurrent();
                usersTableAdapter.Update(demooDataSet);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            this.Hide(); // Hide the current form instead of closing it
            formRequest.Show();
            formRequest.FormClosed += (s, args) => Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormComments formComments = new FormComments();
            this.Hide(); // Hide the current form instead of closing it
            formComments.Show();
            formComments.FormClosed += (s, args) => Application.Exit();
        }
    }
}
