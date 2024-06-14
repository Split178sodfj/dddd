using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAuth : Form
    {
        private string login = "admin";
        private string password = "admin";

        public FormAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredLogin == login && enteredPassword == password)
            {
                MessageBox.Show("Авторизация успешна!");
                // Здесь можно открыть новый форм или выполнить другие действия после авторизации
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}