using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    internal class Niz
    {
        public int Pocetna_suma(int n)
        {
            int suma = 0;
            for (int i = 0; i < Math.Min(n,elementi.Count); i++)
                suma += elementi[i];
            return suma;
        }
        //public delegate int Generiraj(Niz n);
        public Func<Niz,int>? generiraj;
        //public delegate void IspisInfo(Niz n);
        public Action<Niz>? ispisInfo;
        public List<int> elementi;
        public Niz(List<int> elementi)
            => this.elementi = elementi;
        public void Azuriraj()
        {
            if (generiraj is not null)
                elementi.Add(generiraj(this));
            ispisInfo?.Invoke(this);
        }
    }
    internal class AritmetickiNiz : Niz
    {
        int diferencija;
        public AritmetickiNiz(List<int> elementi, int d)
            : base(elementi)
        {
            diferencija = d;
            generiraj = (Niz n) => (n is AritmetickiNiz a) ?
                a.elementi[^1] + a.diferencija : 0;
        }
    }
}

