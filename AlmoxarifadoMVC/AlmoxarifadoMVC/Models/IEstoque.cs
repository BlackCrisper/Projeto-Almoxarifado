using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoMVC.Models
{
    public interface IEstoque
    {

        bool verificarestoque(Produto produto, int qtd);
    }
}