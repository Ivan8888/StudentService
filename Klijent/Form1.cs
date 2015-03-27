using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Sesija;

namespace Klijent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            napuniKomboSviStudenti();
            napuniKomboSviPredmeti();
            napuniKomboIzborStudenta();
            napuniKomboAktivniRok();
            azurirajSifruPrijave();
        }

        Student student;
        Predmet predmet;
        Prijava prijava;
        Rok rok;

        private void napuniKomboSviStudenti()
        {
            cmbSviStudenti.DataSource = Broker.dajBrokera().vratiSveStudente();
            cmbSviStudenti.DisplayMember = "BrojIndeksa";
        }

        private void cmbSviStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            student = cmbSviStudenti.SelectedItem as Student;
            txtImeIPrezime.Text = student.ToString();
            dgvPrijaveStudenata.DataSource = Broker.dajBrokera().vratiPrijaveStudenta(student);
            dgvPrijaveStudenata.Columns[2].Visible = false;
        }

        private void txtDatum_MouseClick(object sender, MouseEventArgs e)
        {
            txtDatum.Text = "dd.mm.yyyy";
        }

        private void napuniKomboSviPredmeti()
        {
            cmbSviPredmeti.DataSource = Broker.dajBrokera().vratiSvePredmete();
        }

        private void napuniKomboIzborStudenta()
        {
            cmbIzborStudenta.DataSource = Broker.dajBrokera().vratiSveStudente();
        }

        private void azurirajSifruPrijave()
        {
            txtSifraPrijave.Text = Convert.ToString(Broker.dajBrokera().vratiBrojPrijave());
        }

        private void napuniKomboAktivniRok()
        {
            List<Rok> aktivniRok = new List<Rok>();
            aktivniRok.Add(Broker.dajBrokera().vratiAktivanRok());
            if (aktivniRok.Count == 1)
            {
                cmbAktivanRok.DataSource = aktivniRok;
            }
            else
            {
                MessageBox.Show("Nijedan ispitni rok u bazi podataka nije oznacen kao AKTIVNI!", "Aktivni rok");
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                prijava = new Prijava();
                student = cmbIzborStudenta.SelectedItem as Student;
                predmet = cmbSviPredmeti.SelectedItem as Predmet;
                rok = cmbAktivanRok.SelectedItem as Rok;

                prijava.BrojPrijave = Convert.ToInt32(txtSifraPrijave.Text);
                prijava.Student = student;
                prijava.Rok = rok;
                prijava.Predmet = predmet;
                prijava.Datum = DateTime.ParseExact(txtDatum.Text, "dd.MM.yyyy", null);
                prijava.Ocena = Int32.Parse(txtOcena.Text);

                if (prijava.Ocena >= 6 && prijava.Ocena <= 10)
                {
                    int pozicija = Broker.dajBrokera().proveraDuplikata(prijava);
                    bool duplikat = Convert.ToBoolean(pozicija);

                    if (!duplikat)
                    {

                        if (Broker.dajBrokera().unesiPrijavuUBazu(prijava) == 1)
                        {
                            MessageBox.Show("Prijava je uspesno uneta u bazu", "Sacuvaj");
                            Broker.dajBrokera().azuzirajBrojPrijave();
                            txtSifraPrijave.Text = Convert.ToString(Broker.dajBrokera().vratiBrojPrijave());
                        }
                        else
                        {
                            MessageBox.Show("Prijava nije uneta u bazu", "Sacuvaj");
                        }
                    }
                    else
                    {
                        DialogResult odgovor = MessageBox.Show("U bazi vec postoji uneta prijava. Da li zelite da je azurirate", "Sacuvaj", MessageBoxButtons.YesNo);
                        if (odgovor == DialogResult.Yes)
                        {
                            if (Broker.dajBrokera().azurirajPrijavu(prijava, pozicija) == 1)
                            {
                                MessageBox.Show("Prijava je uspesno azurirana", "Sacuvaj");
                            }
                            else
                            {
                                MessageBox.Show("Prijava nije azurirana", "Sacuvaj");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Unesite validnu ocenu", "Sacuvaj");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom unosa prijave: " + ex.Message , "Greska");
            }
        }

     
    }
}
