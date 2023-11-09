using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio_analise_dese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load; // Adicione um manipulador para o evento Load do formulário
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Limpar conteúdo textbox
            textBoxResult.Clear();

            // Frase para acompanhar o resultado
            textBoxResult.AppendText("a) Os números ímpares de 0 a 40 são: " + Environment.NewLine);

            // Apresentar os valores numéricos ímpares de 0 a 40 com espaço entre eles
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 != 0)
                {
                    textBoxResult.AppendText(i + ", "); // Número seguido de espaço
                }
            }

            // Calcular a soma dos 100 primeiros números inteiros
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            // Exibir a soma nesse textbox
            textBoxSum.Clear();
            textBoxSum.AppendText("b) A soma dos 100 primeiros números inteiros é: " + soma);

            // Apresentar os números divisíveis por 4 menores que 40
            textBoxDivisiveisPor4.Clear();
            textBoxDivisiveisPor4.AppendText("c) Números divisíveis por 4 que são menores que 40 são: " + Environment.NewLine);
            for (int i = 1; i < 40; i++)
            {
                if (i % 4 == 0)
                {
                    textBoxDivisiveisPor4.AppendText(i + ", ");
                }
            }

            // Apresentar os quadrados dos números inteiros de 15 a 200
            textBoxQuadrados.Clear();
            textBoxQuadrados.AppendText("d) Quadrados dos números inteiros de 15 a 200 são: " + Environment.NewLine);
            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                textBoxQuadrados.AppendText(quadrado + ", ");
            }

            // Calcular a soma de todos os valores pares de 1 a 50
            int somaPares = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    somaPares += i;
                }
            }

            // Apresentar a soma dos valores nesse textbox
            textBoxSomaValoresPares.Clear();
            textBoxSomaValoresPares.AppendText("e) Soma de valores pares de 1 a 50 é: " + somaPares);

        }
    }
}
