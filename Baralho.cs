using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Baralho : Cartas
    {
        const int NUMERO_DE_CARTAS = 52; // cartas do baralho
        private Cartas[] baralho; // cartas dos jogadores


        public Baralho()
        {
            baralho = new Cartas[NUMERO_DE_CARTAS];
        }

        public Cartas[] getBaralho { get { return baralho; } } // atualiza o baralho


        // cria o baralho com as 13 cartas de cada naipe
        public void setUpBaralho()
        {
            for(int i = 0; i < NUMERO_DE_CARTAS;)
            { 

            foreach ( NAIPE n in Enum.GetValues(typeof(NAIPE)))
            {
                foreach ( VALOR v in Enum.GetValues(typeof(VALOR)))
                {
                    baralho[i] = new Cartas { MyNaipe = n, MyValor = v } ;
                    i++;
                }
            }
            }
            EmbaralharCartas();
        }

        // embaralhar
        public void EmbaralharCartas()
        {
            Random random = new Random();
            Cartas carta;

            // embaralhar 1000x
            for (int i = 0; i < 1000; i++)
            {
                for(int j = 0; j < NUMERO_DE_CARTAS; j++)
                {
                    int indiceCarta = random.Next(13);
                    carta = baralho[j];
                    baralho[j] = baralho[indiceCarta];
                    baralho[indiceCarta] = carta;

                }
            }
        }
    }
}
