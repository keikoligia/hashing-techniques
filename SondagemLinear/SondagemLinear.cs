using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SondagemLinear
{
    class SondagemLinear 
    {
        private int qtdColisoes;
        private int tamanho = 23;
        private int qtsPessoas = 0;
        int[] chaves; //auxiliar

        Pessoa[] tabela;

        public int Tamanho { get => tamanho; }

        public Pessoa this[int posicao]
        {
            get => tabela[posicao];
        }

        public SondagemLinear(int tamanhoDesejado)
        {
            tabela = new Pessoa[tamanhoDesejado];
            this.tamanho = tamanhoDesejado;
        }

        public int Hash(string chave)
        {
            long tot = 0;
            for (int i = 0; i < chave.Length; i++)
            tot += 37 * tot + (char)chave[i];

            tot = tot % tabela.Length;
            if (tot < 0)
            tot += tabela.Length;

            return (int)tot;   // retorna o índice do vetor dados onde um registro será armazenado
        }

        public Pessoa GetPessoa(int chave)
        {
            return tabela[chave];
        }

        public bool Inserir(Pessoa item)
        {
            int valHash;
            if (!Existe(item.Chave, out valHash))
            {
                int pos = 1;
                qtdColisoes = 0;

                while (valHash <= this.Tamanho - 1)
                {
                    if (this.tabela[valHash] == null)
                    {
                        this.tabela[valHash] = item; 
                        qtsPessoas++;
                        return true; 
                    }
                    else
                    {
                        qtdColisoes++;
                        valHash = valHash + qtdColisoes;
                        pos++;
                    }
                }
            }
            return false; // já existe, não incluiu
        }
        public bool Existe(string chaveProcurada, out int ondeDados)
        {
            ondeDados = Hash(chaveProcurada);  // posição do vetor onde deveria estar a pessoa com essa chave
            int j = 1;

            for (int i = ondeDados; i < Tamanho - 1; i += j)
            {
                if (this.tabela[j] != null)
                {
                    if (this.tabela[j].Chave.CompareTo(chaveProcurada) == 0)
                    {
                        ondeDados = j;
                        return true;
                    }
                }
            }
            return false;
        }

        public void LerDeArquivo(string nomeArquivo)
        {
            if (!File.Exists(nomeArquivo))
            {
                var novoArq = new StreamWriter(nomeArquivo);
                novoArq.Close();
            }
            var arquivo = new StreamReader(nomeArquivo);
            while (!arquivo.EndOfStream)
            {
                var umaPessoa = new Pessoa(arquivo.ReadLine());
                Inserir(umaPessoa);
            }

            arquivo.Close();
        }
        public void SalvarEmArquivo(string nomeArquivo)
        {
            var arquivo = new StreamWriter(nomeArquivo);
            for (int numeroLinha = 0; numeroLinha < Tamanho; numeroLinha++)
            {
                foreach (Pessoa umaPessoa in tabela[numeroLinha])
                    arquivo.WriteLine(umaPessoa.ParaArquivo());
            }
            arquivo.Close();
        }
    }
}
