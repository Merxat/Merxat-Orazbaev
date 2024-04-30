namespace Uyga_vazifa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string UserPath = @"C:\Asosiy kurs. 06.02.2024\3-Modul\Uyga vazifa\Uyga vazifa\UserList.txt";
            string[] Id=File.ReadAllLines(UserPath);
            File.AppendAllText(UserPath,Id.Length.ToString()
                                         +","+t1Name.Text
                                         +","+t2UserName.Text
                                         +","+t3Passwoed.Text
                                         +"\n");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
