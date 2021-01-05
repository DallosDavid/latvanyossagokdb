using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latvanyossagokdb
{
    class Latvanyossagok
    {
        int id;
        int varos_id;
        string nev;
        string leiras;
        int ar;

        public Latvanyossagok(int id, int varos_id, string nev, string leiras, int ar)
        {
            this.id = id;
            this.Varos_id = varos_id;
            this.Nev = nev;
            this.Leiras = leiras;
            this.Ar = ar;
        }

        public int Id { get => id;}
        public int Varos_id { get => varos_id; set => varos_id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            if (ar==0)
            {
                return  nev + "--" + leiras + " Ingyenes";
            }
            return nev + "--" + leiras + "--" +ar + "Ft ";
        }
    }
}
