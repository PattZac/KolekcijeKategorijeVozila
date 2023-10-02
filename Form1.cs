using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KolekcijeKategorijeVozila
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                txtGodinaProizvodnje.Items.Add(i);
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try {
                if (Convert.ToInt16(txtBrojKotaca.Text) % 2 == 1)
                {
                    MessageBox.Show("Broj kotača nije paran! Unesi paran broj kotača", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Vozilo vz = new Vozilo(txtModel.Text, Convert.ToInt16(txtGodinaProizvodnje.Text), Convert.ToInt16( txtBrojKotaca.Text ));
                    voziloList.Add(vz);
                    txtModel.Clear();
                    txtGodinaProizvodnje.Text = "";
                    txtBrojKotaca.Text = "";
                    txtModel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška\r\n"+ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach(Vozilo i in voziloList) {
                i.Obradi();
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            string n = "";
            foreach (Vozilo i in voziloList)
            {
                n += i.toXml().ToString();
            }
            txtIspis.Text = n;
        }
    }
}
