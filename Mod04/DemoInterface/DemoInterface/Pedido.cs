using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Pedido
    {
        private IImposto _imposto;

        public Pedido(int codCli, int codProduto, double liquido, TipoCliente tipoCli)
        {
            CodCliente = codCli;
            CodProduto = codProduto;
            ValorLiquido = liquido;

            switch (tipoCli)
            {
                case TipoCliente.PF:
                    _imposto = new ImpostoPF();
                    break;
                case TipoCliente.PJ:
                    _imposto = new ImpostoPJ();
                    break;
                case TipoCliente.ONG:
                default:
                    _imposto = new ImpostoONG();
                    break;
            }
            
        }

        public int CodCliente { get; private set; }
        public int CodProduto { get; private set; }
        public double ValorLiquido { get; private set; }
        public double ValorBruto
        {
            get
            {
                return _imposto.Calcular(ValorLiquido);
            }
        }

    }
}
