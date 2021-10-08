using System;

public class Ejercicio_2_6_2
{
	/*(2.6.2) Crear un programa que descomponga un número (que teclee el usuario) 
	como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5*/
	
	public static void SerUnPrimo()
	{
		int numero = Convert.ToInt32(Console.ReadLine());

		/*Para descomponer en num. primos hay que empezar de menos a más y que al dividir del resto 0.
		El número primo más pequeño es el 2, así que se empieza a divir entre 2 una y otra vez hasta que el resto no sea 0.
		Si el resto no da 0, se pasa al siguiente número primo, el 3 y se repite el mismo proceso. Y así con todos los núm. primos
		hasta conseguir todos los núm. que al multiplicar componen el núm. original.
		*/

		/*Por lo tanto haremos un for donde, partiendo de 2 compruebe si al dividir el primo el resto de 0.
		 La i es el primer primo, siempre será menor a núm que descomponemos y el i++ es para que recorra entre primos*/
		for (int i = 2; i <= numero; i++)
        {
			/*Este if comprueba si el primo da  resto 0, sino se suma 1 hasta que el primo al dividr el núm. de 0*/
			if (numero % i == 0)
            {
			/*Este Console me escribe en la linea el primo para ver el resultado*/
				Console.Write(i);

				/*Con este if me pondrá despues de cada núm. primo el símbolo de múltiplicar. Como el for de los primos ira subiendo
				llegará un momento en el que i valdrá igual al numero del usuario. Por lo tanto para que no salgo el multiplicar en el 
				último numero metemos un if donde ponga el símbolo si i no es igual numero*/
				if (numero != i) Console.Write(" · ");
                {
					/*Con esta división pasamos al siguiente núm. que tenemos que divir por el primo. Ahora mismo i seria 2.*/
					numero = numero / i; // numero/=1;
					/*y como queremos volver a comprobar si el nuevo número lo podemos dividir por el mismo primo, le restamos 1 ya que 
					 hemos acabdo el if y al entrar de nuevo al bucle for nos va a sumar 1. Se repite el ciclo hasta que el primo no entre en 
					el primer if y el primo va ir en aumento*/
					i--;
                }

            }
        }
	}
}
