namespace ReservaHotel.Classes;

internal class Quarto
{
    public int Numero { get; set; }

    private double valorDiaria;
    public double ValorDiaria 
    {   
        get { return valorDiaria; } 
        
        set 
        { if (value > 0) 
          {
             valorDiaria = value;
          }
        }
    }
    public Quarto(int numero)
    {
        Numero = numero;
    }
}
