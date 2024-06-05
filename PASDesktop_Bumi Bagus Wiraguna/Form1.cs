using System.Data.SqlClient;

namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-38594CU;Initial Catalog=apotek;Integrated Security=True");
            conn.Open();
            string Query = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@username", txtUSERNAME.Text);
            cmd.Parameters.AddWithValue("@password", txtPASSWORD.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Informasi", MessageBoxButtons.OK);
                utama utama = new utama();
                this.Hide();
                utama.Show();

            }
            else
            {
                MessageBox.Show("Login Gagal", "Informasi", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPASSWORD.UseSystemPasswordChar = false;
            }
            else
            {
                txtPASSWORD.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}