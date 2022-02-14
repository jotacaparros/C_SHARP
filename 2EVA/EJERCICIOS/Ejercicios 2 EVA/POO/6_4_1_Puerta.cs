using System;

public class Puertaprueba
{
    int ancho; 
    int alto; 
    int color;
    bool abierta; 

    public void Abrir() 
    { 
     abierta = true; 
    } 
    public void Cerrar()
    { 
        abierta = false; 
    } 
    public int GetAncho()
    {
        return ancho;
    }
    public void SetAncho(int nuevoValor) 
    {
        ancho = nuevoValor;
    } 
    public void MostrarEstado() 
    {
        Console.WriteLine("Ancho: {0}", ancho); 
        Console.WriteLine("Alto: {0}", alto); 
        Console.WriteLine("Color: {0}", color); 
        Console.WriteLine("Abierta: {0}", abierta);
    }
}
