using FloresDormitoryMS;

namespace LiLo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = maskedTextBox1.Text;

            if (Username == "admin" && Password == "password123")
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FloresDormitoryMS.Form1 mainForm = new FloresDormitoryMS.Form1();
                mainForm.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
