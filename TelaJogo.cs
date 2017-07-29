using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    public partial class TelaJogo : Form
    {
        public TelaJogo()
        {
            InitializeComponent();
        }


        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void DistCartas_Click(object sender, EventArgs e)
        {

            AdiministrarCartas adm = new AdiministrarCartas();

            adm.Administrar();

            Cartas c1 = adm.exibeCartas(1, 1);
            Cartas c2 = adm.exibeCartas(2, 1);
            Cartas c3 = adm.exibeCartas(3, 1);
            Cartas c4 = adm.exibeCartas(4, 1);
            Cartas c5 = adm.exibeCartas(5, 1);


            Cartas c6 = adm.exibeCartas(1, 2);
            Cartas c7 = adm.exibeCartas(2, 2);
            Cartas c8 = adm.exibeCartas(3, 2);
            Cartas c9 = adm.exibeCartas(4, 2);
            Cartas c10 = adm.exibeCartas(5, 2);
          


            exibe(c1, 1);
            exibe(c2, 2);
            exibe(c3, 3);
            exibe(c4, 4);
            exibe(c5, 5);

            exibe(c6, 6);
            exibe(c7, 7);
            exibe(c8, 8);
            exibe(c9, 9);
            exibe(c10, 10);

            int n = adm.aux();

            if(n > 5)
            {
                TelaFinal1 fim = new TelaFinal1();
                fim.ShowDialog();
            }
            else
            {
                TelaFInal2 fim = new TelaFInal2();
                fim.ShowDialog();
            }

        }

            // n é a posição que vai receber a imagem

        private int naipe( Cartas c)
        {
            return (int)c.MyNaipe;
        }
        private int valor(Cartas c)
        {
            return (int)c.MyValor;
        }


        private void exibe(Cartas c, int n)
        {
            int i = (int)c.MyNaipe;

            if (n == 1)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta1.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta1.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta1.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta1.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 2)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta2.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta2.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta2.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta2.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 3)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta3.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta3.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta3.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta3.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 4)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta4.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta4.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta4.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta4.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 5)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta5.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta5.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta5.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta5.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 6)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta6.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta6.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta6.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta6.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 7)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta7.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta7.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta7.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta7.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 8)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta8.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta8.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta8.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta8.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 9)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta9.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta9.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta9.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta9.BackgroundImage = naipe3.Images[j - 2];
                }
            }

            if (n == 10)
            {

                if (i == 0)
                {
                    int j = (int)c.MyValor;
                    carta10.BackgroundImage = naipe0.Images[j - 2];
                }

                if (i == 1)
                {
                    int j = (int)c.MyValor;
                    carta10.BackgroundImage = naipe1.Images[j - 2];
                }

                if (i == 2)
                {
                    int j = (int)c.MyValor;
                    carta10.BackgroundImage = naipe2.Images[j - 2];
                }

                if (i == 3)
                {
                    int j = (int)c.MyValor;
                    carta10.BackgroundImage = naipe3.Images[j - 2];
                }
            }
        }


        //******

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void TelaJogo_Load(object sender, EventArgs e)
        {

        }
    }
}
