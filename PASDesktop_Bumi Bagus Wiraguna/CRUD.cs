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
    public partial class CRUD : Form
    {
        public CRUD()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txID.Text))
            {
                MessageBox.Show("Please select an ID to delete.");
                return;
            }

            SqlCommand cmd4 = new SqlCommand("DELETE FROM Table_1 WHERE noid = @noid", conn);
            cmd4.Parameters.AddWithValue("@noid", txID.Text);
            DialogResult resk = MessageBox.Show("Delete selected row?", "Confirm", MessageBoxButtons.YesNo);
            if (resk == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    bind_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult resk = MessageBox.Show("Update selected row?", "Confirm", MessageBoxButtons.YesNo);
            if (resk == DialogResult.Yes)
            {
                try
                {
                    DataTable dataTable = (DataTable)dataGridView1.DataSource;

                    dataGridView1.EndEdit();

                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-38594CU;Initial Catalog=apotek;Integrated Security=True"))
                    {
                        conn.Open();

                        foreach (DataGridViewRow dataGridViewRow in dataGridView1.SelectedRows)
                        {
                            DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;
                            string noid = dataRow["ID"].ToString();
                            DataRow[] rowsToUpdate = dataTable.Select($"ID = '{noid}'");
                            foreach (DataRow rowToUpdate in rowsToUpdate)
                            {
                                rowToUpdate["Obat"] = txObat.Text;
                                rowToUpdate["Dosis"] = txdosis.Text;
                                rowToUpdate["Jenis Obat"] = txjenisobat.Text;
                                rowToUpdate["Produsen"] = txprodusen.Text;
                                rowToUpdate["BPJS"] = rdYA.Checked ? "Ya" : "Tidak";
                                rowToUpdate["Tanggal Kadaluarsa"] = dtpick.Value.ToString("dd-MM-yyyy");
                            }
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter("Select noid as ID,obat AS Obat,dosis Dosis,jenisobat As [Jenis Obat],produsen As Produsen, bpjs As BPJS,tanggalkadaluarsa as [Tanggal Kadaluarsa] from Table_1", conn);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                        adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                        adapter.Update(dataTable);

                        MessageBox.Show("Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Table_1", conn);
            DialogResult resk = MessageBox.Show("Clear?", "Confirm", MessageBoxButtons.YesNo);
            if (resk == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
                bind_data();
                conn.Close();
            }
        }

        private void btnCREATE_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Table_1(noid,obat,dosis,jenisobat,produsen,bpjs,tanggalkadaluarsa)Values(@noid,@obat,@dosis,@jenisobat,@produsen,@bpjs,@tanggalkadaluarsa)", conn);
            cmd2.Parameters.AddWithValue("noid", txID.Text);
            cmd2.Parameters.AddWithValue("obat", txObat.Text);
            cmd2.Parameters.AddWithValue("dosis", txdosis.Text);
            cmd2.Parameters.AddWithValue("jenisobat", txjenisobat.Text);
            cmd2.Parameters.AddWithValue("produsen", txprodusen.Text);
            if (rdYA.Checked)
            {
                cmd2.Parameters.AddWithValue("bpjs", "Ya");
            }
            else
            {
                cmd2.Parameters.AddWithValue("bpjs", "Tidak");
            }
            cmd2.Parameters.AddWithValue("tanggalkadaluarsa", dtpick.Value.ToString("dd-MM-yyyy"));
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                txID.Text = dataGridViewRow.Cells["ID"].Value.ToString();
                txObat.Text = dataGridViewRow.Cells["Obat"].Value.ToString();
                txdosis.Text = dataGridViewRow.Cells["Dosis"].Value.ToString();
                txjenisobat.Text = dataGridViewRow.Cells["Jenis Obat"].Value.ToString();
                txprodusen.Text = dataGridViewRow.Cells["Produsen"].Value.ToString();

                // Set the date-time picker
                if (DateTime.TryParse(dataGridViewRow.Cells["Tanggal Kadaluarsa"].Value.ToString(), out DateTime dateValue))
                {
                    dtpick.Value = dateValue;
                }
                else
                {
                    dtpick.Value = DateTime.Now; // Default value if parsing fails
                }
            }

        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void txprodusen_TextChanged(object sender, EventArgs e)
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

        private void txID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.8;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 30, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resk = MessageBox.Show("Apakah anda ingin keluar?", "konfirmasi", MessageBoxButtons.YesNo);
            utama utama = new utama();
            if (resk == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
