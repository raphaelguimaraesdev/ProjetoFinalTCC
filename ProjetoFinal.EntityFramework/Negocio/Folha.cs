namespace ProjetoFinal.EntityFramework.Negocio
{
    public class Folha
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CodigoFilial { get; set; }

        #region "Váriaveis p/ manipulação pelo Entity Framework"

        public virtual Filial Filial { get; set; }

        #endregion "Váriaveis p/ manipulação pelo Entity Framework"
    }
}