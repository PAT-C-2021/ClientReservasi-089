using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140089
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();

            TampilData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxIDReservasi.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelepon = textBoxNoTelp.Text;
            int JumlahPemesanan = int.Parse(textBoxJml.Text);
            string IdLokasi = textBoxIDLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelepon, JumlahPemesanan, IdLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxIDReservasi.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelepon = textBoxNoTelp.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelepon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxIDReservasi.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        public void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }

        public void Clear()
        {
            textBoxIDReservasi.Clear();
            textBoxNama.Clear();
            textBoxNoTelp.Clear();
            textBoxJml.Clear();
            textBoxIDLokasi.Clear();

            textBoxJml.Enabled = true;
            textBoxIDReservasi.Enabled = true;
            textBoxIDLokasi.Enabled = true;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void dtPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDReservasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBoxNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBoxNoTelp.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);
            textBoxJml.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBoxIDLokasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);

            textBoxJml.Enabled = false;
            textBoxIDLokasi.Enabled = false;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            btnSimpan.Enabled = false;
            textBoxIDReservasi.Enabled = false;
        }
    }
}
