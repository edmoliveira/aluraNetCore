using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaDeProdutosViewModel
    {
        public IList<Produto> Produtos { get; set; }
        public string Mensagem { get; set; }
        public bool TemMensagem { get
            {
                return Mensagem != null && Mensagem.Trim() != string.Empty;
            }
        }

        public BuscaDeProdutosViewModel(IList<Produto> produtos)
        {
            this.Produtos = produtos;
        }

        public BuscaDeProdutosViewModel(IList<Produto> produtos, string mensagem)
        {
            this.Produtos = produtos;
            this.Mensagem = mensagem;
        }
    }
}
