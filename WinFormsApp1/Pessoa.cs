using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Pessoa : IEnumerable
{
    string chave,
           nome;

    public override string ToString()
    {
      return Chave.Trim()+" "+Nome.Trim();
    }
    public Pessoa(string chave, string nome)
    {
      Chave = chave;
      Nome = nome;
    }

    public Pessoa(string linhaLida)
    {
      Chave = linhaLida.Substring(0, 15);
      Nome = linhaLida.Substring(15);
    }
    public string Chave 
    { 
      get => chave; 
      set => chave = value.ToUpper().PadRight(15,' ').Substring(0,15); 
    }
    public string Nome 
    { 
      get => nome; 
      set => nome = value.PadRight(30, ' ').Substring(0, 30); 
    }

    public string ParaArquivo()
    {
      return Chave + Nome;
    }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

