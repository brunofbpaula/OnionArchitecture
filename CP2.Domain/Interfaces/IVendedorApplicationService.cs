using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        IEnumerable<VendedorEntity> ObterTodos();
        VendedorEntity? ObterPorId(int id);
        VendedorEntity? SalvarDados(VendedorEntity entity);
        VendedorEntity? EditarDados(int id, VendedorEntity entity);
        VendedorEntity? DeletarDados(int id);

    }
}
