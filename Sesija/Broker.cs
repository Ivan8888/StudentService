using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;

        void konektujSe()
        {
            konekcija = new SqlConnection("Data Source=(local);Initial Catalog=PrimerKolokvijuma;Integrated Security=SSPI;");
            komanda = konekcija.CreateCommand();
        }

        public Broker()
        {
            konektujSe();
        }

        static Broker broker;

        public static Broker dajBrokera()
        {
            if (broker == null)
            {
                broker = new Broker();
            }
            return broker;
        }

        public List<Student> vratiSveStudente()
        {
            List<Student> studenti = new List<Student>();
            Student s;

            try
            {
                komanda.CommandText = "SELECT * FROM TStudent";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    s = new Student();
                    s.BrojIndeksa = reader.GetInt32(0);
                    s.Ime = reader.GetString(1);
                    s.Prezime = reader.GetString(2);
                    studenti.Add(s);
                }
                return studenti;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }

        }

        public List<Predmet> vratiSvePredmete()
        {
            List<Predmet> predmeti = new List<Predmet>();
            Predmet p;

            try
            {
                komanda.CommandText = "SELECT * FROM TPredmet";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    p = new Predmet();
                    p.PredmetID = reader.GetInt32(0);
                    p.Naziv = reader.GetString(1);
                    predmeti.Add(p);

                }
                return predmeti;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }

        }

        public Rok vratiAktivanRok()
        {
            Rok r = new Rok();

            try
            {
                komanda.CommandText = "SELECT * FROM TRok WHERE AktivanRok = 1";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                if (reader.Read())
                {
                    r.RokID = reader.GetInt32(0);
                    r.Naziv = reader.GetString(1);
                    r.AktivanRok = reader.GetBoolean(2);
                }
                else
                {
                    r = null;
                }
                return r;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public int unesiPrijavuUBazu(Prijava p)
        {
            int rezultat = 0;
            try
            {
                komanda.CommandText = "INSERT INTO TPrijava VALUES('" + p.BrojPrijave + "','" + p.Rok.RokID + "','" + p.Student.BrojIndeksa + "', '" + p.Predmet.PredmetID + "','" + p.Datum.ToString("yyyy-MM-dd") + "','" + p.Ocena + "')";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                rezultat = komanda.ExecuteNonQuery();
                return rezultat;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }

        }

        public List<Prijava> vratiPrijaveStudenta(Student s)
        {
            List<Prijava> prijave = new List<Prijava>();

            try
            {
                komanda.CommandText = "SELECT TPrijava.BrPrijaveID, TPredmet.Naziv, TRok.Naziv, TPRIJAVA.Datum, TPRIJAVA.Ocena FROM TRok INNER JOIN ((TPrijava INNER JOIN TPredmet ON TPrijava.PredmetID = TPredmet.PredmetID)) ON TPrijava.RokID = TRok.RokID WHERE TPrijava.BrIndID ='" + s.BrojIndeksa + "'";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    Rok rok = new Rok();
                    Predmet predmet = new Predmet();
                    Prijava prijava = new Prijava();
                    Student student = new Student();

                    prijava.BrojPrijave = reader.GetInt32(0);
                    predmet.Naziv = reader.GetString(1);
                    rok.Naziv = reader.GetString(2);
                    prijava.Datum = Convert.ToDateTime(reader[3]);
                    prijava.Ocena = reader.GetInt32(4);
                    prijava.Rok = rok;
                    prijava.Predmet = predmet;
                    prijava.Student = student;

                    prijave.Add(prijava);
                }
                return prijave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }

        }

        public int vratiBrojPrijave()
        {
            int rezultat = 0;

            try
            {
                komanda.CommandText = "SELECT Brojac FROM TSifarnik WHERE IDDokumenta = 'PR' ";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    rezultat = reader.GetInt32(0);
                }
                return rezultat;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public void azuzirajBrojPrijave()
        {
            int rez;
            try
            {
                komanda.CommandText = "UPDATE TSifarnik SET Brojac = Brojac + 1";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                rez = komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public int proveraDuplikata(Prijava p)
        {
            int duplikat = 0;
            try
            {
                komanda.CommandText = "SELECT * FROM TPrijava WHERE BrIndId ='" + p.Student.BrojIndeksa + "' AND PredmetID ='" + p.Predmet.PredmetID + "'";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    duplikat = reader.GetInt32(0);
                }
                return duplikat;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }
        }

        public int azurirajPrijavu(Prijava p, int pozicija)
        {
            int rez = 0;
            try
            {
                komanda.CommandText = "UPDATE TPrijava SET RokID ='" + p.Rok.RokID + "', Datum = '" + p.Datum.ToString("yyyy-MM-dd") + "', Ocena ='" + p.Ocena + "' WHERE BrPrijaveID ='" + pozicija + "'";
                komanda.CommandType = System.Data.CommandType.Text;
                konekcija.Open();
                rez = komanda.ExecuteNonQuery();
                return rez;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (konekcija != null)
                    konekcija.Close();
            }

        }

    }
}
