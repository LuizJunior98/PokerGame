using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Cartas
    {
        public enum NAIPE
        {
            COPAS,
            ESPADAS,
            OUROS,
            PAUS
        }

        public enum VALOR
        {
            DOIS = 2, TRES, QUATRO, CINCO, SEIS, SETE, OITO, NOVE, DEZ, VALETE, DAMA, REI, AS 
        }

        // GET SET
        
        public NAIPE MyNaipe { get; set; }
        public VALOR MyValor { get; set; }
    }
}
