using CompraRapida.Dominio.Entities;

namespace CompraRapida.Dominio.Contracts
{
    public interface IUserRepository : IBaseRepository<Usuario>
    {
        Usuario GetUser(string email, string password);
    }
}
