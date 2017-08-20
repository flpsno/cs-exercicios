using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    enum TipoCliente 
    {
        PF, PJ, ONG
    }

    public interface IImposto
    {
        double Calcular(double liquido);
    }

    class ImpostoPF : IImposto
    {

        public double Calcular(double liquido)
        {
            return liquido *= 1.1;
        }
    }

    class ImpostoPJ : IImposto
    {

        public double Calcular(double liquido)
        {
            return liquido *= 1.2;
        }
    }

    class ImpostoONG : IImposto
    {

        public double Calcular(double liquido)
        {
            return liquido;
        }
    }

}
