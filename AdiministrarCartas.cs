using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    class AdiministrarCartas : Baralho
    {
       
            private Cartas[] maoJogador1;
            private Cartas[] maoJogador2;
            private Cartas[] sorteioMaoJogador1;
            private Cartas[] sorteioMaoJogador2;
        public int total1;
        public int cartaAlta1;
        public int total2;
        public int cartaAlta2;


        public AdiministrarCartas()
            {
                maoJogador1 = new Cartas[5];
                sorteioMaoJogador1 = new Cartas[5];
                maoJogador2 = new Cartas[5];
                sorteioMaoJogador2 = new Cartas[5];
            }

            public void Administrar()
            {
                setUpBaralho(); //cria um baralho de cartas e embaralha
                getMao();
                sorteiaCartas();
             //   exibeCartas();
            //    avaliarMaos();
            }

            public void getMao()
            {
                //5 cartas para o jogador 1
                for (int i = 0; i < 5; i++)
                    maoJogador1[i] = getBaralho[i];

                //5 cartas para o jogador 2
                for (int i = 5; i < 10; i++)
                    maoJogador2[i - 5] = getBaralho[i];
            }

            public void sorteiaCartas()
            {
                var perguntarJogador1 = from Mao in maoJogador1
                                  orderby Mao.MyValor
                                  select Mao;

                var perguntarJogador2 = from Mao in maoJogador2
                                    orderby Mao.MyValor
                                    select Mao;

                var indice = 0;
                foreach (var elemento in perguntarJogador1.ToList())
                {
                    sorteioMaoJogador1[indice] = elemento;
                    indice++;
                }

                indice = 0;
                foreach (var elemento in perguntarJogador2.ToList())
                {
                    sorteioMaoJogador2[indice] = elemento;
                    indice++;
                }
            }

            public Cartas exibeCartas(int i, int jogador)
            {

                if (jogador == 1)
                {


                    Cartas carta1, carta2, carta3, carta4, carta5;

                    carta1 = maoJogador1[0];
                    carta2 = maoJogador1[1];
                    carta3 = maoJogador1[2];
                    carta4 = maoJogador1[3];
                    carta5 = maoJogador1[4];

                    if (i == 1)
                        return carta1;
                    if (i == 2)
                        return carta2;
                    if (i == 3)
                        return carta3;
                    if (i == 4)
                        return carta4;
                    else
                        return carta5;
                }

                else
                {

                    Cartas card1, card2, card3, card4, card5;

                    card1 = maoJogador2[0];
                    card2 = maoJogador2[1];
                    card3 = maoJogador2[2];
                    card4 = maoJogador2[3];
                    card5 = maoJogador2[4];

                    if (i == 1)
                        return card1;
                    if (i == 2)
                        return card2;
                    if (i == 3)
                        return card3;
                    if (i == 4)
                        return card4;
                    else
                        return card5;

                }
            }
            
            public int avaliarMaos()
            {
                //criar os objetos (sorteio das mãos)
                AvaliadorMao jogador1 = new AvaliadorMao(sorteioMaoJogador1);
                AvaliadorMao Jogador2 = new AvaliadorMao(sorteioMaoJogador2);

           
            //verifica qual o tipo e a mao
            // 1 para jogador 1 vence, 2 para jogador 2 vencce
                if (total1 > total2)
                   return 1;
                else if (total2 == total1)
                {
                    if (cartaAlta2 > cartaAlta1)
                        return 2;
                    else
                        return 1;
                }
                else
                    return 2;

            }

        public int aux()
        {
            Random random = new Random();
            int n = random.Next(10);
            return n;
        }

        public int desempate(int jogador)
        {
            if (jogador == 1)
                return cartaAlta1;
            if (jogador == 2)
                return cartaAlta2;
            else
                return 10; // indica empate (vence quem tiver a carta alta)
        }

        // Avaliar maos
        // n é o jogador
            public int ValorJogo(int n)
            {

                if (n == 1)
                {
                    //Obtenha o número de cada terno em mãos
                    //    getNumberOfSuit();
                    if (RoyalFlush(maoJogador1, 1) >= 0)
                        return 9;
                    else if (StraightFlush(maoJogador1, 1) >= 0)
                        return 8;
                    else if (Quadra(maoJogador1, 1) >= 0)
                        return 7;
                    else if (FullHouse(maoJogador1, 1) >= 0)
                        return 6;
                    else if (Flush(maoJogador1, 1) >= 0)
                        return 5;
                    else if (Sequencia(maoJogador1, 1) >= 0)
                        return 4;
                    else if (Trinca(maoJogador1, 1) >= 0)
                        return 3;
                    else if (DoisPares(maoJogador1, 1) >= 0)
                        return 2;
                    else if (UmPar(maoJogador1, 1) >= 0)
                        return 1;
                    else
                        return 0;
                }

                if (n == 2)
                {
                    if (RoyalFlush(maoJogador2, 2) >= 0)
                        return 9;
                    else if (StraightFlush(maoJogador2, 2) >= 0)
                        return 8;
                    else if (Quadra(maoJogador2, 2) >= 0)
                        return 7;
                    else if (FullHouse(maoJogador2, 2) >= 0)
                        return 6;
                    else if (Flush(maoJogador2, 2) >= 0)
                        return 5;
                    else if (Sequencia(maoJogador2, 2) >= 0)
                        return 4;
                    else if (Trinca(maoJogador2, 2) >= 0)
                        return 3;
                    else if (DoisPares(maoJogador2, 2) >= 0)
                        return 2;
                    else if (UmPar(maoJogador2, 2) >= 0)
                        return 1;
                    else
                        return 0;
                }

                return -1;

            }


        // logica para ver o tipo

            private int RoyalFlush(Cartas[] cartas, int n)
            {
                //sequencia de mesmo naipe de 10 a as
                if (cartas[0].MyNaipe == cartas[1].MyNaipe && cartas[0].MyNaipe == cartas[2].MyNaipe && cartas[0].MyNaipe == cartas[3].MyNaipe 
                    && cartas[0].MyNaipe == cartas[4].MyNaipe)
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

                    if ((int)cartas[0].MyValor == 10 && (int)cartas[1].MyValor == 11 && (int)cartas[2].MyValor == 12 && (int)cartas[3].MyValor == 13 &&
                        (int)cartas[4].MyValor == 14)
                    {
                    if (n == 1)
                    {
                        total1 = 9;
                        cartaAlta1 = (int)cartas[0].MyNaipe;
                        return total1;
                    }
                    else
                    {
                        total2 = 9;
                        cartaAlta2 = (int)cartas[0].MyNaipe;
                        return total2;
                    }
                    }
                }
                
                    return -1;
            }

            private int StraightFlush(Cartas[] cartas, int n)
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
                    {
                    if(n == 1){
                        total1 = 8;
                        cartaAlta1 = (int)cartas[4].MyValor;
                        return total1;
                    }
                    else
                    {
                        total2 = 8;
                        cartaAlta2 = (int)cartas[4].MyValor;
                        return total2;
                    }
                    }
                        
                }
                  
                return -1;
            }

            private int Quadra(Cartas[] cartas, int n)
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
                {
                if (n == 1) {
                    total1 = 7;
                    if (vetor[4] != vetor[0])
                        cartaAlta1 = vetor[4];
                    else
                        cartaAlta1 = vetor[0];
                    return total1;
                } else
                {
                    total2 = 7;
                    if (vetor[4] != vetor[0])
                        cartaAlta2 = vetor[4];
                    else
                        cartaAlta2 = vetor[0];
                    return total2;
                }
                }


            return -1;
            }
        
            private int FullHouse(Cartas[] cartas, int n)
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
                        return 6;
                } else if (vetor[1] != vetor[2])
                    {
                        if (vetor[0] == vetor[1])
                            if (vetor[2] == vetor[3] && vetor[3] == vetor[4])
                            {
                                if(n == 1)
                                {
                                total1 = 6;
                                cartaAlta1 = vetor[4];
                                return total1;
                            }
                            else
                            {
                                total2 = 6;
                                cartaAlta2 = vetor[4];
                                return total2;
                            }
                                
                            }
                    }

                return -1;
            }

            private int Flush(Cartas[] cartas, int n)
            {

            //5 cartas diferentes do mesmo naipe
            if (cartas[0].MyNaipe == cartas[1].MyNaipe &&
                    cartas[0].MyNaipe == cartas[2].MyNaipe && cartas[0].MyNaipe == cartas[3].MyNaipe && cartas[0].MyNaipe == cartas[4].MyNaipe)
                {
                if(n == 1)
                {
                    total1 = 5;
                    cartaAlta1 = (int)cartas[0].MyValor + (int)cartas[1].MyValor + (int)cartas[2].MyValor + (int)cartas[3].MyValor + (int)cartas[4].MyValor;
                    return total1;
                }
                else
                {
                    total2 = 5;
                    cartaAlta2 = (int)cartas[0].MyValor + (int)cartas[1].MyValor + (int)cartas[2].MyValor + (int)cartas[3].MyValor + (int)cartas[4].MyValor;
                    return total2;
                }
                    
                }

            return -1;

            }

            private int Sequencia(Cartas[] cartas, int n)
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
            {
                if(n == 1)
                {
                    total1 = 4;
                    cartaAlta1 = vetor[4];
                    return total1;
                } else
                {
                total2 = 4;
                cartaAlta2 = vetor[4];
                return total2;
                }
                
            }

            return -1;
            }

            private int Trinca(Cartas[] cartas, int n)
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
                {
                    if(n == 2)
                {
                    total1 = 3;
                    cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return total1;
                } else
                {
                    total2 = 3;
                    cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return total2;
                }
                    
                }



                return -1;
            }

            private int DoisPares(Cartas[] cartas, int n)
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
            {
                if(n == 1)
                {
                    total1 = 2;
                    cartaAlta1 = vetor[4];
                    return 2;
                }
                else
                {
                    cartaAlta2 = vetor[4];
                    total2 = 2;
                    return 2;
                }

            }
                
            else if (vetor[0] != vetor[1] && vetor[1] == vetor[2] && vetor[3] == vetor[4])
            {
                if (n == 1)
                {
                    cartaAlta1 = vetor[0];
                    total1 = 1;
                    return 2;
                }
                else
                {
                    cartaAlta2 = vetor[0];
                    total2 = 1;
                    return 2;
                }
            }
            else if (vetor[0] == vetor[1] && vetor[1] != vetor[2] && vetor[2] != vetor[3] && vetor[3] == vetor[4])
            {
                if (n == 1)
                {
                    cartaAlta1 = vetor[2];
                    total1 = 0;
                    return 2;
                }
                else
                {
                    cartaAlta2 = vetor[2];
                    total2 = 0;
                    return 2;
                }
            }


            return -1;

            }

            private int UmPar(Cartas[] cartas, int n)
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
                {
                if(n == 1)
                {
                    total1 = 8;
                    cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
                else
                {
                    total2 = 8;
                    cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
                    
                }
                else if (vetor[0] != vetor[1] && vetor[1] == vetor[2] && vetor[1] != vetor[3] && vetor[1] != vetor[4])
                {
                if (n == 1)
                {
                    total1 = 8;
                    cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
                else
                {
                    total2 = 8;
                    cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
            }
                else if (vetor[2] != vetor[0] && vetor[2] != vetor[1] && vetor[2] == vetor[3] && vetor[2] != vetor[4])
                {
                if (n == 1)
                {
                    total1 = 8;
                    cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
                else
                {
                    total2 = 8;
                    cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
            }
                else if (vetor[3] != vetor[0] && vetor[3] != vetor[1] && vetor[3] != vetor[2] && vetor[3] == vetor[4])
                {
                if (n == 1)
                {
                    total1 = 8;
                    cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
                else
                {
                    total2 = 8;
                    cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                    return 1;
                }
            }


            return -1;

            }

            private int MaiorCarta(Cartas[] cartas, int n)
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

            if (n == 1)
            {
                total1 = 9;
                cartaAlta1 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                return 0;
            }
            else
            {
                total2 = 9;
                cartaAlta2 = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
                return 0;
            }

        }

    }
}
