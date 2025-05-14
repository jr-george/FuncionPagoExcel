using System;
namespace FuncionPagoExcel
{
	public class Finanzas
	{
		public static double Pago(double tasa, int nper, double va, double vf)
        {
            double valorActual = (va * tasa) / (1 - Math.Pow((1 + tasa), -nper));
            double valorFuturo = (vf * tasa) / (Math.Pow((1 + tasa), nper) - 1);
            return valorActual + valorFuturo;
        }
    }
}

