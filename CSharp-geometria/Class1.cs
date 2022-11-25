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
            Console.WriteLine("Area: "+altezza * larghezza+" cm²");
        }
        public void perimetro() {
            Console.WriteLine("Perimetro: "+(altezza + larghezza) * 2+" cm");
        }

        public void stampaRettangolo() {
            Console.WriteLine($"---Informazioni Rettangolo {this.nomeoggetto}---");
            Console.WriteLine($"Altezza: {this.altezza}");
            Console.WriteLine($"Larghezza: {this.larghezza}");
            area();
            perimetro();
            stamparVideoRettangolo();
        }

        public void stamparVideoRettangolo() { 
        
            for(int i = 0; i < larghezza; i++) {
                Console.Write("--");
            }
            Console.WriteLine();
            for(int h=0;h< altezza; h++) {
                Console.Write("|");
                for (int j = 0; j < larghezza-1; j++) {
                    Console.Write("  ");
                }
                Console.WriteLine("|");
            }
            for(int l = 0; l < larghezza; l++) {
                Console.Write("--");
            }
            Console.WriteLine() ;
        
        }
    }



}