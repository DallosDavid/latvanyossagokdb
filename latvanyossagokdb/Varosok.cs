﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latvanyossagokdb
{
    class Varosok
    {
        int id;
        string nev;
        int lakossag;

        public Varosok(int id, string nev, int lakossag)
        {
            this.id = id;
            this.Nev = nev;
            this.Lakossag = lakossag;
        }

        public int Id { get => id;}
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }

        public override string ToString()
        {
            return nev + " Lakosság:" + lakossag;
        }
    }
}
