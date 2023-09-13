// See https://aka.ms/new-console-template for more information

using csharp_abstract_animals;


Cane cane = new Cane();
Console.WriteLine("CANE");
cane.CosaMangi();
cane.Dormi();
cane.Verso();
Console.WriteLine("--------");


Passerotto passerotto = new Passerotto();
Console.WriteLine("PASSEROTTO");
passerotto.CosaMangi();
passerotto.Dormi();
passerotto.Verso();
passerotto.Vola();
Console.WriteLine("--------");


Aquila aquila = new Aquila();
Console.WriteLine("AQUILA");
aquila.CosaMangi();
aquila.Dormi();
aquila.Verso();
aquila.Vola();
Console.WriteLine("--------");


Delfino delfino = new Delfino();
Console.WriteLine("DELFINO");
delfino.CosaMangi();
delfino.Dormi();
delfino.Verso();
delfino.Nuota();
Console.WriteLine("--------");

IAnimaliCheNuotano pesci;
IAnimaliCheVolano volatili;

pesci = new Delfino();
volatili = new Passerotto();
volatili = new Aquila();
