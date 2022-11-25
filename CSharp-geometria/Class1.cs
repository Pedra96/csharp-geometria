using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasseRettangolo {

    public class Rettangolo {
        public int larghezza;
        public int altezza;

        public void area() {
            Console.WriteLine("Area: "+altezza * larghezza+"cm2");
        }
        public void perimetro() {
            Console.WriteLine("Perimetro: "+ (altezza + larghezza) * 2+"cm");
        }
    }



}