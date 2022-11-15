using System.ComponentModel.DataAnnotations;

namespace ColmadosAPP.Data.Models;

public class Cliente
{
    public Cliente()
    {
        Creditos = new List<Credito>();
        Debitos = new List<Debito>();
    }
    [Key]
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = null!;
    public String Direccion { get; set; } = null!;
    public String Telefono { get; set; } = null!;
    public double LimiteDeCredito { get; set; } 

    public virtual ICollection<Credito> Creditos {get; set;}
    public virtual ICollection<Debito> Debitos {get; set;}
    
}

