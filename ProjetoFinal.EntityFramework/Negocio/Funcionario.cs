using System;

namespace ProjetoFinal.EntityFramework.Negocio
{
    public class Pessoa
    {
        public int CodigoFilial { get; set; }
        public char CodigoSexo { get; set; }
        public int CodigoSituacao { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }

        #region "Váriaveis p/ manipulação pelo Entity Framework"

        public virtual Sexo Sexo { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual Filial Filial { get; set; }

        #endregion "Váriaveis p/ manipulação pelo Entity Framework"
    }
}