
using ColmadosAPP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ColmadosAPP.Data.Context;

public class ColmadoDbContext : DbContext,IColmadoDbContext
{
    public ColmadoDbContext(DbContextOptions options) : base(options)
    {

    }
    public virtual DbSet<Cliente> Clientes {get;set;} = null!;
    public virtual DbSet<Colmado> Colmados {get;set;} = null!;
    public virtual DbSet<Credito> Creditos {get;set;} = null!;
    public virtual DbSet<Debito> Debitos   {get;set;} = null!;
    public virtual DbSet<Usuario> Usuarios {get;set;} = null!;

    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
public interface IColmadoDbContext
{
    public DbSet<Cliente> Clientes  {get;set;}
    public DbSet<Colmado> Colmados  {get;set;}
    public DbSet<Credito> Creditos  {get;set;}
    public DbSet<Debito> Debitos    {get;set;}
    public DbSet<Usuario> Usuarios  {get;set;}

    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}