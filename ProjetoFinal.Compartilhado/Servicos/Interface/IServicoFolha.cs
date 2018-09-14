using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Compartilhado.Servicos.Interface
{
    public interface IServicoFolha : IServicoBase<Folha>
    {
        List<T> Pro(T dados);
        List<T> Grave(List<T> dados);
        List<T> Autualize(List<T>);
    }
}
