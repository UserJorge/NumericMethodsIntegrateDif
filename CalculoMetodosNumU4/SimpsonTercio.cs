using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace CalculoMetodosNumU4
{
    public class SimpsonTercio:DatosDeEntrada
    {
		private double resultado;
		public double Resultado
		{
			get { return resultado; }
			set { resultado = value; }
		}
		Calculo calculo;
		public void AplicarMetodo()
		{
			calculo = new Calculo();
			calculo.Sintaxis(Funcion, 'x');
			double h = (B - A) / N;
			Resultado = (h / 3) * (calculo.EvaluaFx(A) + 4 * calculo.EvaluaFx((A + B) / 2) + calculo.EvaluaFx(B));
		}








	}
}
