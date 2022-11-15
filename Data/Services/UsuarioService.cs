using ColmadosAPP.Data.Context;
using ColmadosAPP.Data.Models;

namespace ColmadosAPP.Data.Service;

public class UsuarioService:IUsuarioService
{
    private readonly IColmadoDbContext context;

    public UsuarioService(IColmadoDbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Crear(Usuario data)
    {
        try
        {
            context.Usuarios.Add(data);
            await context.SaveChangesAsync(new());
            return true;
        }
        catch
        {
            return false;
        }
    }
}

public interface IUsuarioService{
    public Task<bool> Crear(Usuario data);
}