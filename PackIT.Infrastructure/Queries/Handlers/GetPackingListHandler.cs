using System.Threading.Tasks;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Domain.Repositories;
using PackIT.Infrastructure.EF.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListReadModel>
    {
        private readonly IPackingListRepository  _repository;

        public GetPackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }
        public async Task<PackingListReadModel> HandlerAsync(GetPackingList query)
        {
            return null;
        }
    }
}