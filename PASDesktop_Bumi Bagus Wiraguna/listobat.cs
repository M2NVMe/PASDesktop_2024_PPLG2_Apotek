using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    public partial class listobat : Form
    {
        public listobat()
        {
            InitializeComponent();
            bind_data();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-38594CU;Initial Catalog=apotek;Integrated Security=True");
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select noid as ID,obat AS Obat,dosis Dosis,jenisobat As [Jenis Obat],produsen As Produsen, bpjs As BPJS,tanggalkadaluarsa as [Tanggal Kadaluarsa] from Table_1", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult resk = MessageBox.Show("Apakah anda ingin kembali ke menu utama?", "konfirmasi", MessageBoxButtons.YesNo);
            utama utama = new utama();
            if (resk == DialogResult.Yes)
            {
                utama.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT noid as [ID], obat AS [Obat], dosis as [Dosis], jenisobat As [Jenis Obat], produsen As [Produsen], bpjs As [BPJS], tanggalkadaluarsa as [Tanggal Kadaluarsa] FROM Table_1 WHERE obat LIKE @obat + '%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@obat", txtSEARCH.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
