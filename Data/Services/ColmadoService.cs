using ColmadosAPP.Data.Context;
using ColmadosAPP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ColmadosAPP.Data.Service;

public class ColmadoService:IColmadoService
{
    private readonly IColmadoDbContext context;

    public ColmadoService(IColmadoDbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Crear(Colmado data)
    {
        try
        {
            context.Colmados.Add(data);
            await context.SaveChangesAsync(new());
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> Editar(int IdColmado, string nombre, string telefono, string direccion,string propietario, DateTime fecha, string cedula, string password)
    {
        try
        {
            var colmado = await context.Colmados.FirstOrDefaultAsync(c=>c.IdColmado == IdColmado);
            if(colmado!=null){
                colmado.Modificar(nombre,telefono,direccion,propietario,fecha,cedula,password);
            await context.SaveChangesAsync(new());
            return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}

public interface IColmadoService{
    public Task<bool> Crear(Colmado data);
}
