using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_expressao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Organização dos dados
        const int MAX = 50;

        //struct pilha
        struct tp_pilha
        {
            public int topo;
            public char[] vetor;
        }
        tp_pilha pilha;

        // Inicialização
        void Inicializa(ref tp_pilha p)
        {
            p.topo = -1;
            p.vetor = new char[MAX];
        }

        // Verificando limites
        bool EstaVazia(tp_pilha p)
        {
            return (p.topo == -1);
        }

        bool EstaCheia(tp_pilha p)
        {
            return (p.topo == MAX - 1);
        }

        // Insere um elemento
        char Insere(ref tp_pilha p, char letra)
        {
            return p.vetor[++p.topo] = letra;
        }

        // Remove um elemento
        int Remove(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        //Concatena a string
        private void Concatena(string resultado)
        {
            throw new NotImplementedException();
        }

        //verifica caracteres
        bool Verifica(ref tp_pilha p, char[] palavra)
        {
            p.vetor = palavra;
            bool res = true;

            foreach (var item in p.vetor)
            {
                if (item.Equals('(') && item.Equals(')') && item.Equals('[') && item.Equals(']') && item.Equals('{') && item.Equals('}'))
                    res = false;
            }
            return res;
        }

        //Método de evento de click do botão
        private void BTProcessa_Click(object sender, EventArgs e)
        {
            string expressao = TBExpressao.Text;
            if (string.IsNullOrWhiteSpace(expressao))
            {
                TBExpressao.Text = "Vazio";
                TBResultado.Text = "Vazio";
            }
            char[] novaExpressao = new char[expressao.Length];
            Inicializa(ref pilha);

            for (int i = 0; i < expressao.Length; i++)
                novaExpressao[i] += Insere(ref pilha, expressao[i]);

            if (Verifica(ref pilha, novaExpressao))
                for (int i = novaExpressao.Length - 1; i >= 0; i--)
                    TBResultado.Text += novaExpressao[i].ToString();
            else
                TBExpressao.Text = "Caracteres invalidos";
        }

        private void BTLimpar_Click(object sender, EventArgs e)
        {
            TBExpressao.Text = "";
            TBResultado.Text = "";
        }
    }
}

