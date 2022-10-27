namespace ColmadosAPP.Data.Models;

public class Credito
{
    public int Idcredito { get; set; }
    public string IdCliente{ get; set; } = null!;
    public int IdColmado { get; set; }
    public Double Monto { get; set; }
    public DateTime Fecha { get; set;}

}
