using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColmadosAPP.Data.Models;

public class Debito
{
    [Key]
    public int IdDebito { get; set; }
    public int IdCliente{ get; set; }
    [ForeignKey(nameof(IdCliente))]
    public virtual Cliente? Cliente {get;set;}
    public int IdColmado { get; set; }
    [ForeignKey(nameof(IdColmado))]
    public virtual Colmado? Colmado {get;set;}
    public Double Monto { get; set; }
    public DateTime Fecha { get; set;}

}

