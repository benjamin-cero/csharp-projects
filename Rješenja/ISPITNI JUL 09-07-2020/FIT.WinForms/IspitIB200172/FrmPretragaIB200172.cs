using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB200172
{
    public partial class FrmPretragaIB200172 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public FrmPretragaIB200172()
        {
            InitializeComponent();
        }

        private void FrmPretragaIB200172_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbSemestar.DataSource = db.Semestri.ToList();
            UcitajSve();
        }

        private void UcitajSve()
        {
            var SviStudenti = db.Studenti.Include("Semestar").ToList();
            if (SviStudenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = SviStudenti;
            }
        }

        private void chbAktivnost_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void UcitajStudente()
        {
            var Aktivnosti = chbAktivnost.Checked;
            var Semestar = cbSemestar.SelectedItem.ToString();
            var filter = txtPretraga.Text.ToLower();

            var studenti = db.Studenti.Include("Semestar").
                Where(x => (x.Aktivan==Aktivnosti) &&
                (x.Semestar.Oznaka == Semestar)&&
                (x.Ime.ToLower().Contains(filter)||x.Prezime.ToLower().Contains(filter) )
                ).ToList();

            if (studenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }
        }
    }
}
