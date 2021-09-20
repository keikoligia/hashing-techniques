using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text;
using System.IO;

class SondagemQuadratica
{
    private int tamanho = 23;
    Pessoa[] dados;
    private string[] colisoes;
    private int qtsPessoas = 0;

    public int Tamanho { get => tamanho; }
    public int GetQtdPessoa { get => qtsPessoas;  }
    public Pessoa this[int posicao]
    {
        get => dados[posicao];
    }
    public SondagemQuadratica(int tamanho)
    {
        this.tamanho = tamanho;
        dados = new Pessoa[tamanho];
        colisoes = new string[tamanho];
    }

    public int Hash(string chave)
    {
        long tot = 0;
        for (int j = 0; j < chave.Length; j++)
            tot += 37 * tot + (char)chave[j];

        tot = tot % dados.Length;
        if (tot < 0)
            tot += dados.Length;

        return (int)tot;   // retorna o índice do vetor dados onde um registro será armazenado
    }

    public Pessoa GetPessoa(int chave)
    {
        return dados[chave];
    }

    public bool Inserir(Pessoa item)
    {
        int valHash;
        if (!Existe(item.Chave, out valHash))
        {
            int pos = 1;
            int qtdColisao = 0;

            while (valHash <= this.Tamanho - 1)
            {
                if (this.dados[valHash] == null)
                {
                    this.dados[valHash] = item;      // não existe, portanto inclui
                    qtsPessoas++;
                    return true;            // informa que conseguiu incluir o novo item na tabela de hash
                }
                else
                {
                    qtdColisao++;
                    valHash = valHash + (pos * pos);
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

        for(int i = ondeDados; i < Tamanho - 1; i += (j * j))
        {
            if(this.dados[j] != null)
            {
                if (this.dados[j].Chave.CompareTo(chaveProcurada) == 0)
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
            foreach (Pessoa umaPessoa in dados[numeroLinha])
                arquivo.WriteLine(umaPessoa.ParaArquivo());
        }
        arquivo.Close();
    }
}
