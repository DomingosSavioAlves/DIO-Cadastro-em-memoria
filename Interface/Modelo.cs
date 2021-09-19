using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO.Interface
{
    public interface Modelo<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Inserir(T objeto);
        void Excluir(int id);
        void Alterar(int id, T objeto);
        int ProximoId();
    }
}
