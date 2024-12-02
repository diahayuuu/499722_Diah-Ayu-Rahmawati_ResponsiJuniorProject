using System;
using System.Windows.Forms;
using Npgsql;

namespace Responsi2
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Username=diahayuuu;Password=Diahayu1234_;Database=Responsi";
        private string sql;
        private NpgsqlCommand cmd;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Apakah benar Anda akan menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (conn = new NpgsqlConnection(connstring))
                    {
                        conn.Open();
                        sql = "SELECT st_delete(@_nama, @_dep)";
                        using (cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@_nama", tbNama.Text);
                            cmd.Parameters.AddWithValue("@_dep", tbDep.Text);

                            if ((int)cmd.ExecuteScalar() == 1)
                            {
                                MessageBox.Show("Data user berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnLoadData.PerformClick();
                                tbNama.Text = tbDep.Text = null;
                                r = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Hapus Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT st_insert(@_nama, @_dep)";
                    using (cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("@_dep", tbDep.Text);

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data user berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoadData.PerformClick();
                            tbNama.Text = tbDep.Text = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Tambah Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT st_edit(@_nama, @_dep)";
                    using (cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("@_dep", tbDep.Text);

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data user berhasil diedit", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLoadData.PerformClick();
                            tbNama.Text = tbDep.Text = null;
                            r = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Edit Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                tbDep.Text = r.Cells["_dep"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data when the form loads
            btnLoadData.PerformClick();
        }
    }
}
