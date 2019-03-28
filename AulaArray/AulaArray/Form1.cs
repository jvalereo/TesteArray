using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            // Aula Teste de Array 
            // Jonas Valereo Técnico em Informática 

            //Declarando o codigo  do array e  instaciar o vetor

            int [] vetor = new int [4];

            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;

            //Declarando a variavel valor
            int valor = vetor[1];

            System.Array.Sort(vetor);

            //Declarando o codido loop 
            for (int index = 0; index < 4; index++) 
            MessageBox.Show(vetor[index].ToString(), "Array");


            //Fim do programa 
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair

            Close();

        }
    }
}
