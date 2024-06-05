using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    public partial class utama : Form
    {
        public utama()
        {
            InitializeComponent();
        }

        private void utama_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void utama_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form1 form = new Form1();
                this.Close();
                form.Show();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.Show();
            this.Close();
        }

        private void btnTersedia_Click(object sender, EventArgs e)
        {
            listobat listobat = new listobat();
            listobat.Show();
            this.Close();
        }
    }
}
