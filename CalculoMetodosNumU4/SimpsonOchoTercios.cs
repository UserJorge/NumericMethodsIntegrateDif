using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace CalculoMetodosNumU4
{
    public class SimpsonOchoTercios:DatosDeEntrada
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
			double h =(B-A)/N;
			double X0 = calculo.EvaluaFx(A);
			double X1 = calculo.EvaluaFx(A + h);
			double X2 = calculo.EvaluaFx(A + 2 * h);
			double X3 = calculo.EvaluaFx(A+3*h);
			Resultado = (0.375 * h) * ( X0 + 3 * X1 + 3 * X2 + X3 );
		}
		
	}
}
