﻿/*Nel progetto csharp-geometria creare le seguenti classi :
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono,
rispettivamente, l’area e il perimetro del rettangolo.Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console,
i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza 
(come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.Provate ad istanziare tanti rettangoli con 
nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il 
vostro rettangolo ad esempio cosi:
—— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
BONUS: Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali 
quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/
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






