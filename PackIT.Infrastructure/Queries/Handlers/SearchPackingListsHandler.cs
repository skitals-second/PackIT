using System.Collections.Generic;
using System.Threading.Tasks;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Infrastructure.EF.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers
{
    public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListReadModel>>
    {
        public Task<IEnumerable<PackingListReadModel>> HandlerAsync(SearchPackingLists query)
        {
            return null;
        }
    }
}