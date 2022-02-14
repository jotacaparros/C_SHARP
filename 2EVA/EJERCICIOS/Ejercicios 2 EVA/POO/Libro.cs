using System;
/*(6.2.3) Para guardar información sobre libros, vamos a comenzar por crear una clase "Libro", 
que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos strings) y métodos Get y Set
adecuados para leer su valor y cambiarlo. Prepara también un Main (en la misma clase), que cree un 
objeto de la clase Libro, dé valores a sus tres atributos y luego los muestre.*/
public class Libro : Documento
{
	int paginas;

	public void SetPaginas(int pag)
    {
        paginas = pag;
    }

    public int GetPaginas()
    {
        return paginas;
    }
}
