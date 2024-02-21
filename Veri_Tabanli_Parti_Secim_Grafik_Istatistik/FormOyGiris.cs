using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanli_Parti_Secim_Grafik_Istatistik
{
    public partial class FormOyGiris : Form
    {
        public FormOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EGOKIAD\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtAParti.Text);
            komut.Parameters.AddWithValue("@P3", TxtBParti.Text);
            komut.Parameters.AddWithValue("@P4", TxtCParti.Text);
            komut.Parameters.AddWithValue("@P5", TxtDParti.Text);
            komut.Parameters.AddWithValue("@P6", TxtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FormGrafik fr = new FormGrafik();
            fr.Show();
        }
    }
}
