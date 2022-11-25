using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasseRettangolo {

    public class Rettangolo {
        public int larghezza;
        public int altezza;
        public string nomeoggetto;

        public void area() {
            Console.WriteLine("Area: " + altezza * larghezza + " cm²");
        }
        public void perimetro() {
            Console.WriteLine("Perimetro: " + (altezza + larghezza) * 2 + " cm");
        }

        public void stampaRettangolo() {
            Console.WriteLine($"---Informazioni Rettangolo {this.nomeoggetto}---");
            Console.WriteLine($"Altezza: {this.altezza}");
            Console.WriteLine($"Larghezza: {this.larghezza}");
            area();
            perimetro();
        }
    }



}