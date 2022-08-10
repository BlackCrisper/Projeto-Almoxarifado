using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmoxarifadoMVC.Models
{
    public class Produtoestoque : IEstoque
    {
        public bool verificarestoque(Produto produto, int qtd)
        {
            if (qtd<= produto.ProEstoque)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}