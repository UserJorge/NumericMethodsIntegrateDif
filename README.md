# NumericMethodsIntegrateDif
Este repositorio es para la integración y diferenciación a través de métodos numéricos.

Los siguientes métodos son Trapecio (simple y compuesto), simpson 1/3 y simpson 3/8.
Este proyecto actualmente puede realizar una integral definida a partir de sus limites a y b además de colocar el numero
de subintervalos.

Las siguientes instrucciones se presentan con el objetivo de que los datos sean ingrasados 
de una manera correcta, así que la siguiente orientación se dividirá en la siguente lista 
de pasos:

1. Colocar la función F(x).
Para esto vamos a tener que indagar como colocar correctamente la sintaxis, para que 
nos de el resultado esperado...

Por ejemplo:
 si establecemos en el textbox lo siguiente: x^3/(x+sqr(x))
Sera correctamente aceptado, ya que trabaja con parantesís para señalar el 
grado de importancia para resolver lo de adentro del parentesís, más sin embargo
el parentesís no funciona como multiplicador, así que si quisieramos hacer algo como
esto: (x+1)(x+2), se tendría que colocar (x+1)*(x+2), es muy importante colocar 
el operador matemático, para poder ser leída correctamente la función.

adicionalmente acepta funciones trascendentales tales como:

seno=sin(x) ó sen(x)
Asen=asn(x)
Acos=acs(x)
Atan=atn(x)
coseno= cos(x)
tangente=tan(x)
absoluto=abs(x)
logaritmo natural=Ln=log(x)
exponencial=e=exp(x)
raíz cuadrada=sqr(x)

2. los limites superior e inferior de la integración.
con respecto a los dos límites A es el inferior y B el superior, solo se aceptan 
tipos de datos double.

3. N se refiere al número de subdivisiones en un rango determinado y con una función 
determinada. este número, igualmente, es de tipo double.

4. Se elige cualquiera de los tres métodos presentados en la aplicación.
/////Trapecio/////
/////Simpson un tercio////
/////Simpson tres octavos////

5. se presiona el click calcular.

6. el resultado aparece en la parte inferior del botón, ese es el area aproximada
de la curva.
