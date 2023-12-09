using Delegati;

List<int> fib = [0, 1];
Niz nizf = new(fib)
{
    generiraj = fib_fja,
    ispisInfo = ispis
};
nizf.generiraj += delegate (Niz niz)
{
    return niz.elementi[^1] *= 2;
};
nizf.generiraj -= fib_fja;
nizf.generiraj += fib_fja;
nizf.Azuriraj();
nizf.Azuriraj();
static void ispis(Niz niz)
{
    for (int i = 1; i <= niz.elementi.Count; i++)
        Console.WriteLine($"{i}. element: {niz.elementi[i - 1]}");
}
//nizf.Azuriraj();
static int fib_fja(Niz niz)
    => niz.elementi[^2] + niz.elementi[^1];
Suma<int> pocetna = nizf.Pocetna_suma;
if(pocetna.Target is Niz niz)
    Console.WriteLine(niz.elementi[0]);
//delegate int Suma(int x);
Pomocna.Transformiraj(nizf.elementi, x => x * x);
nizf.Azuriraj();

AritmetickiNiz ar = new([2], 5)
{
    ispisInfo = ispis
};
ar.Azuriraj();

ZbrojSvih zbrojAritm = zbroj;
Console.WriteLine(zbrojAritm(ar));
int zbroj(Niz niz)
    => niz.elementi.Sum();

StvaranjeNiza stvori = noviAritm;
Console.WriteLine(zbroj(stvori(2, 5)));
AritmetickiNiz noviAritm(int prvi, int drugi)
    => new([prvi], drugi);

Genericki<Niz> f = delegate(Niz a) { };
Genericki<AritmetickiNiz> g = f;
delegate void Genericki<in T>(T a);

delegate Niz StvaranjeNiza(int a, int b);
delegate int ZbrojSvih(AritmetickiNiz niz);

delegate T Suma<T>(T x); 

/*Gen10(fib, geometrijski);
static int geometrijski(int a, int b)
    => b * 5;

static void Gen10(List<int> niz, Generiraj sljedeci)
{
    for (int i = 3; i <= 10; ++i)
        niz.Add(sljedeci(niz[^2], niz[^1]));
    foreach (int i in niz)
        Console.WriteLine(i);
}

delegate int Generiraj(int c, int d);
*/