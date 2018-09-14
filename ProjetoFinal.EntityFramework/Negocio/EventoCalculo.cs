using System;

namespace ProjetoFinal.EntityFramework.Negocio
{
    public class EventoCalculo
    {
        public int CodigoEvento { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoFolha { get; set; }
        public int CodigoPessoa { get; set; }
        public DateTime DataReferencia { get; set; }
        public decimal Valor { get; set; }

        #region "Váriaveis p/ manipulação pelo Entity Framework"

        public virtual Evento Evento { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual Folha Folha { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        #endregion "Váriaveis p/ manipulação pelo Entity Framework"
    }
}