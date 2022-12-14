using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace felhasznal_keppel
{
    internal class felhasznalo
    {
        int id;
        string nev;
        string szuletesidatum;
        string profilkep;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Profilkep { get => profilkep; set => profilkep = value; }

        public felhasznalo(int id, string nev, string szuletesidatum, string profilkep)
        {
            Id = id;
            Nev = nev;
            Szuletesidatum = szuletesidatum;
            Profilkep = profilkep;
        }
        public override string ToString()
        {
            return $"{nev} - {szuletesidatum} - {profilkep}";
        }
    }
}
