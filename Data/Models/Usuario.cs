using System.ComponentModel.DataAnnotations;

namespace ColmadosAPP.Data.Models;
public class Usuario
{
  public Usuario()
  {
    
  }
  [Key]
    public int IdUsuario { get; set; }
    public string Nombre { get; set; } = null!;
    public string Cedula { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}
