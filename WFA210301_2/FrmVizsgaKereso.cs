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

namespace WFA210301_2
{
    public partial class FrmVizsgaKereso : Form
    {
        SqlConnection conn;
        public FrmVizsgaKereso(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void tbKereso_TextChanged(object sender, EventArgs e)
        {
            Szures(tbKereso.Text);
        }
        private void FrmVizsgaKereso_Load(object sender, EventArgs e)
        {
            Szures("");
        }

        private void Szures(string kulcsszo)
        {
            dgvVizsgak.Rows.Clear();
            conn.Open();

            var r = new SqlCommand(
                "SELECT idopont, nyelv, szint FROM vizsgak " +
                "INNER JOIN nyelvek ON id = nyelvid " +
                $"WHERE nyelv LIKE '{kulcsszo}%';",
                conn).ExecuteReader();

            while (r.Read())
            {
                dgvVizsgak.Rows.Add(
                    r.GetDateTime(0).ToString("yyyy. MM. dd. (dddd) HH:mm"), 
                    r[1], r[2]);
            }
            conn.Close();
        }
    }
}
