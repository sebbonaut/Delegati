using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    //public delegate T Transformator<T>(T argument);
    internal class Pomocna
    {
        public static void Transformiraj<T>(List<T> lista, Func<T,T> t)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                lista[i] = t(lista[i]);
            }
        }
    }
}
