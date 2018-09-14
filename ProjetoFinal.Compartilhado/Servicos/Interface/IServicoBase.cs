using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Compartilhado.Servicos.Interface
{
    public interface IServicoBase<T>
    {
        List<T> Obtenha(T dados);
        bool Gravar(List<T> dados);
        bool Atualizar(List<T> listaDados);
        bool Excluir(List<T> listaDados);

    }
}
