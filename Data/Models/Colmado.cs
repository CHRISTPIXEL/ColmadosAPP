using System.ComponentModel.DataAnnotations;

namespace ColmadosAPP.Data.Models;

public class Colmado
{
    [Key]
    public int IdColmado { get; set; }
    [Required(ErrorMessage ="No se puede dejar ningun campo vacio")]
    public string Nombre { get; set; } =null!;
     [Required(ErrorMessage ="No se puede dejar ningun campo vacio")]
    public string Telefono { get; set;} =null!; 
     [Required(ErrorMessage ="No se puede dejar ningun campo vacio")]
    public string Direccion { get; set;} =null!; 
     [Required(ErrorMessage ="No se puede dejar ningun campo vacio")]
    public string Propietario { get; set;} =null!; 
     [Required(ErrorMessage ="No se puede dejar ningun campo vacio")]
    public DateTime Fecha { get; set;}
     [Required(ErrorMessage ="La cedula es obligatoria")]
     public string Cedula { get; set; } = null!;
      [Required(ErrorMessage ="No te puedes registrar sin contraseña")]
    public string Password { get; set; } = null!;

    public void Modificar(string nombre, string telefono, string direccion,string propietario, DateTime fecha, string cedula, string password){
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Propietario = propietario;
        Fecha = fecha;
        Cedula = cedula;
        Password = password;
    }
}
