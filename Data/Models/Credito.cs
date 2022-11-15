using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColmadosAPP.Data.Models;

public class Credito
{
    [Key]
    public int IdCredito { get; set; }
    public int IdCliente{ get; set; }
    [ForeignKey(nameof(IdCliente))]
    public virtual Cliente? Cliente {get;set;}
    public int IdColmado { get; set; }
    [ForeignKey(nameof(IdColmado))]
    public virtual Colmado? Colmado {get;set;}
    public Double Monto { get; set; }
    public DateTime Fecha { get; set;}

}
