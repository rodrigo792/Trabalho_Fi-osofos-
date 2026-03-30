
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_filosofos
{

    enum Evento
    {
        Alfa1, // α1
        Beta1, // β1
        Gama1, // γ1
        Alfa2, // α2
        Beta2, // β2
        Gama2  // γ2
    }

    class ProcessoFilosofos
    {
        public static List<Evento> F1Comeu()
        {
            return new List<Evento>
        {
            Evento.Alfa1,
            Evento.Beta1
        };
        }

        public static List<Evento> F2Comeu()
        {
            return new List<Evento>
        {
            Evento.Alfa2,
            Evento.Beta2
        };
        }

        public static List<Evento> F2EF1Comeram()
        {
            return new List<Evento>
        {
            Evento.Alfa2,
            Evento.Beta2,
            Evento.Gama2,
            Evento.Alfa1,
            Evento.Beta1
        };
        }

        public static List<Evento> F1EF2Comeram()
        {
            return new List<Evento>
        {
            Evento.Alfa1,
            Evento.Beta1,
            Evento.Gama1,
            Evento.Alfa2,
            Evento.Beta2
        };
        }

        static void Imprimir(string titulo, List<Evento> eventos)
        {
            Console.WriteLine(titulo + ": " + string.Join(" -> ", eventos));
        }

        static void Main()
        {
            Imprimir("F1 comeu", F1Comeu());
            Imprimir("F2 comeu", F2Comeu());
            Imprimir("F2 e F1 comeram", F2EF1Comeram());
            Imprimir("F1 e F2 comeram", F1EF2Comeram());
        }
    }
}