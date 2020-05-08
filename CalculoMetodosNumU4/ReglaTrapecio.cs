using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;


namespace CalculoMetodosNumU4
{

	public class ReglaTrapecio:DatosDeEntrada
    {
		
		private double resultado;

		public double Resultado
		{
			get { return resultado; }
			set { resultado = value; }
		}
		private double errorR;

		public double ErrorRelativo
		{
			get { return errorR; }
			set { errorR = value; }
		}


		Calculo calculo;
		double numeroAux = 0d;
		public void AplicarMetodo()
		{
			numeroAux = 0d;
			calculo = new Calculo();
			
			calculo.Sintaxis(Funcion, 'x');
			
			if (N==1)
			{
				Resultado = (B - A) * ((calculo.EvaluaFx(A) + calculo.EvaluaFx(B)) / 2);
			}
			else
			{
				for (int i = 1; i < N; i++)
				{

					numeroAux += calculo.EvaluaFx(i / N);
				}
				Resultado = ((B - A) / 4) * (calculo.EvaluaFx(A) + numeroAux + calculo.EvaluaFx(B));
			//	ErrorRelativo = ((-(Math.Pow(B - A, 3))) / (12 * Math.Pow(N, 2))) * calculo.Dx(calculo.Dx((A + B)/2 ));
			}



		}



	}
}
