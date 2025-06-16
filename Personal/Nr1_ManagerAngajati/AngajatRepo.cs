using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nr1_ManagerAngajati
{
    public class AngajatRepo
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bogdan\\Desktop\\Practica\\PAW\\WindowsForms.NetProjects\\Personal\\Nr1_ManagerAngajati\\bazadate.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Angajat> GetAngajati()
        {
            ///BD -> conexiune >-> deschid -> comanda sql sa citeasca angajati -> parcurg data setul -> transform in lista
            var list = new List<Angajat>();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand("SELECT Cod, Nume, Salariu, CodManager FROM Angajati", connection);
            //command.ExecuteNonQuery(); -> vrem sa avem o comanda la care nu ne intoarce niciun rezultat(insert,update)
            //command.ExecuteReader(); -> se asteapta sa returneze date; poate citi tot rezultatul tabelar
            //command.ExecuteScalar(); -> se asteapta sa returneze date; pt a apela functii din sql, returneaza doar o celula

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var angajat = new Angajat();
                angajat.Cod = reader.GetInt32(reader.GetOrdinal("Cod"));
                angajat.Nume = reader["Nume"].ToString();
                angajat.Salariu = reader.GetDouble(reader.GetOrdinal("Salariu"));

                int index = reader.GetOrdinal("CodManager");
                if (!reader.IsDBNull(index))//valoare null in bd
                {
                    angajat.CodManager = reader.GetInt32(index);
                }
                //else
                //{
                   //int?  -> nullable la declarare
                //}
                list.Add(angajat);
            }
            return list;
        }
    }
}
