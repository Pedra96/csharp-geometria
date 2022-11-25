

using CSharpClasseRettangolo;

Rettangolo rettangolo2 = new Rettangolo();
Console.WriteLine("Inserire nome del rettangolo");
rettangolo2.nomeoggetto = Console.ReadLine();
Console.WriteLine("Inserire altezza del rettangolo");
rettangolo2.altezza = int.Parse(Console.ReadLine());
Console.WriteLine("Inserire larghezza del rettangolo");
rettangolo2.larghezza = int.Parse(Console.ReadLine());
rettangolo2.stampaRettangolo();


Rettangolo rettangolo1 = new Rettangolo();
rettangolo1.nomeoggetto = "precompilato";
rettangolo1.altezza = 10;
rettangolo1.larghezza = 20;
rettangolo1.stampaRettangolo();