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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            TelaJogo inicio = new TelaJogo();
            inicio.ShowDialog();

            this.Close();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
