using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
        public enum Mao
        {
            MaiorCarta,
            UmPar,
            DoisPares,
            Trinca,
            Sequencia,
            Flush,
            FullHouse,
            Quadra,
            StraightFlush,
            RoyalFlush
        }

        public struct ValorMao
        {
            public int Total { get; set; }
            public int CartaAlta { get; set; }
        }

        class AvaliadorMao : Cartas
        {
            private int copas;
            private int paus;
            private int ouros;
            private int espadas;
            private Cartas[] cartas;
            private ValorMao valor;

            public AvaliadorMao(Cartas[] sorteioMaoJogador)
            {
                copas = 0;
                paus = 0;
                ouros = 0;
                espadas = 0;
                cartas = new Cartas[5];
                valor = new ValorMao();
            }

            public ValorMao valores
            {
                get { return valor; }
                set { valor = value; }
            }

            public Cartas[] Cartas
            {
                get { return cartas; }
                set
                {
                    cartas[0] = value[0];
                    cartas[1] = value[1];
                    cartas[2] = value[2];
                    cartas[3] = value[3];
                    cartas[4] = value[4];
                }
            }

            public Mao ValorJogo()
            {
                //Obtenha o número de cada terno em mãos
                getNumberOfSuit();
                if (RoyalFlush())
                    return Mao.RoyalFlush;
                else if (StraightFlush())
                    return Mao.StraightFlush;
                else if (Quadra())
                    return Mao.Quadra;
                else if (FullHouse())
                    return Mao.FullHouse;
                else if (Flush())
                    return Mao.Flush;
                else if (Sequencia())
                    return Mao.Sequencia;
                else if (Trinca())
                    return Mao.Trinca;
                else if (DoisPares())
                    return Mao.DoisPares;
                else if (UmPar())
                    return Mao.UmPar;
                else
                    return Mao.MaiorCarta;

            }

            private void getNumberOfSuit()
            {
                foreach (var elemento in Cartas)
                {
                    if (elemento.MyNaipe == AdiministrarCartas.NAIPE.COPAS)
                        copas++;
                    else if (elemento.MyNaipe == AdiministrarCartas.NAIPE.ESPADAS)
                        espadas++;
                    else if (elemento.MyNaipe == AdiministrarCartas.NAIPE.OUROS)
                        ouros++;
                    else if (elemento.MyNaipe == AdiministrarCartas.NAIPE.PAUS)
                        paus++;
                }
            }

            // IMPLEMENTAR LOGICA
            //

            //

            // JR

            //
            private bool RoyalFlush()
            {
                //sequencia de mesmo naipe de 10 a as
                if (cartas[0].MyNaipe == cartas[1].MyNaipe && cartas[0].MyNaipe == cartas[2].MyNaipe && cartas[0].MyNaipe == cartas[3].MyNaipe && cartas[0].MyNaipe == cartas[4].MyNaipe)
                {
                    int[] vetor = new int [5];
                    for(int i = 0; i < cartas.Length; i++)
                    {
                        for(int j = 0; j < cartas.Length; j++)
                        {
                            vetor[j] = (int)cartas[i].MyValor;
                        }

                    }
                    Array.Sort<int>(vetor);
                
                    if ( (int) cartas[0].MyValor == 10 && (int)cartas[1].MyValor == 11 && (int)cartas[2].MyValor == 12 && (int)cartas[3].MyValor == 13 && (int)cartas[4].MyValor == 14)
                    return true;
                }
                
                    return false;
            }

            private bool StraightFlush()
            {
                //sequencia do mesmo naipe fora do intervalo

                if (cartas[0].MyNaipe == cartas[1].MyNaipe && cartas[0].MyNaipe == cartas[2].MyNaipe && cartas[0].MyNaipe == cartas[3].MyNaipe && 
                    cartas[0].MyNaipe == cartas[4].MyNaipe)
                {
                    //verificar se estar em sequencia
                    if (cartas[0].MyValor + 1 == cartas[1].MyValor && 
                        cartas[1].MyValor + 1 == cartas[2].MyValor && 
                        cartas[2].MyValor + 1 == cartas[3].MyValor &&
                        cartas[3].MyValor + 1 == cartas[4].MyValor)

                        return true;
                }
                  
                return false;
            }

            private bool Quadra()
            {
                //quatro cartas iguais

                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

                if( vetor[0] == vetor[1] && vetor[0] == vetor[2] && vetor[0]== vetor[3] && vetor[0] != vetor[4]||
                    vetor[4] == vetor[3] && vetor[3] == vetor[2] && vetor[2] == vetor[1] && vetor[4] != vetor[0])
                    return true;
                

                return false;
            }


            private bool FullHouse()
            {
                //2 cartas iguais junto com outras 3 iguais
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

                if (vetor[1] == vetor[2])
                {
                if (vetor[0] == vetor[1])
                    if (vetor[3] == vetor[4])
                        return true;
                } else if (vetor[1] != vetor[2])
                    {
                        if (vetor[0] == vetor[1])
                            if (vetor[2] == vetor[3] && vetor[3] == vetor[4])
                                return true;
                    }

                return false;
            }

            private bool Flush()
            {

            //5 cartas diferentes do mesmo naipe
            if (cartas[0].MyNaipe == cartas[1].MyNaipe &&
                    cartas[0].MyNaipe == cartas[2].MyNaipe && cartas[0].MyNaipe == cartas[3].MyNaipe && cartas[0].MyNaipe == cartas[4].MyNaipe)
                return true;

            return false;

            }

            private bool Sequencia()
            {
                // 5 cartas em sequencia de naipes diferentes
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

            if (vetor[0] + 1 == vetor[1] &&
                vetor[1] + 1 == vetor[2] &&
                vetor[2] + 1 == vetor[3] &&
                vetor[3] + 1 == vetor[4])
                 return true;

            return false;
            }

            private bool Trinca()
            {
                // 3 cartas iguais
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

                if (vetor[0] == vetor[1] && vetor[0] == vetor[2] && vetor[0] != vetor[3] && vetor[0] != vetor[3] ||
                    vetor[4] == vetor[3] && vetor[4] == vetor[2] && vetor[4] != vetor[1] && vetor[4] != vetor[0])
                    return true;


                return false;
            }

            private bool DoisPares()
            {
                //2 pares de cartas iguais
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

            if (vetor[0] == vetor[1] && vetor[2] == vetor[4] && vetor[3] != vetor[4])
                return true;
            else if (vetor[0] != vetor[1] && vetor[1] == vetor[2] && vetor[3] == vetor[4])
                    return true;
            else if (vetor[0] == vetor[1] && vetor[1] != vetor[2] && vetor[2] != vetor[3] && vetor[3] == vetor[4])
                return true;



            return false;

            }

            private bool UmPar()
            {

                //1 par de cartas iguais
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

                if (vetor[0] == vetor[1] && vetor[0] != vetor[2] && vetor[0] != vetor[3] && vetor[0] != vetor[4])
                    return true;
                else if (vetor[0] != vetor[1] && vetor[1] == vetor[2] && vetor[1] != vetor[3] && vetor[1] != vetor[4])
                    return true;
                else if (vetor[2] != vetor[0] && vetor[2] != vetor[1] && vetor[2] == vetor[3] && vetor[2] != vetor[4])
                    return true;
                else if (vetor[3] != vetor[0] && vetor[3] != vetor[1] && vetor[3] != vetor[2] && vetor[3] == vetor[4])
                    return true;


                return false;

            }

            private bool MaiorCarta()
            {
                int[] vetor = new int[5];

                for (int i = 0; i < cartas.Length; i++)
                {
                    for (int j = 0; j < cartas.Length; j++)
                    {
                        vetor[j] = (int)cartas[i].MyValor;
                    }

                }
                Array.Sort<int>(vetor);

                return true;
            }

        }
}

