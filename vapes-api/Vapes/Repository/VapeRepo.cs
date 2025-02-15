using AutoMapper;
using System.Data.Entity;
using vapes_api.Data.Migrations;
using vapes_api.Vapes.Models;

namespace vapes_api.Vapes.Repository
{
    public class VapeRepo : IVapeRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public VapeRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Vape>> GetVapesAsync()
        {
            return await _appDbContext.Vapes.ToListAsync();
        }
    }
}
