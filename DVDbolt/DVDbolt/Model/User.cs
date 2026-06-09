using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDbolt.Model
{
    public class User
    {
        public User() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string TeljesNev { get; set; }
        public string Jelszo { get; set; }
        public int Szerepkor { get; set; }


        public string SzerepkorNev => Enum.GetName(typeof(Szerepkor), Szerepkor) ?? "Ismeretlen";

        public User(string felhasznaloNev, string teljesNev, int szerepkor)
        {
            FelhasznaloNev = felhasznaloNev;
            TeljesNev = teljesNev;
            Szerepkor = szerepkor;
        }

        public User(string felhasznaloNev, string teljesNev, string jelszo, int szerepkor)
        {
            FelhasznaloNev = felhasznaloNev;
            TeljesNev = teljesNev;
            Jelszo = jelszo;
            Szerepkor = szerepkor;
        }
    }
}
