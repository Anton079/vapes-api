using vapes_api.Vapes.Models;

namespace vapes_api.Vapes.Repository
{
    public interface IVapeRepo
    {
        Task<List<Vape>> GetVapesAsync();
    }
}
