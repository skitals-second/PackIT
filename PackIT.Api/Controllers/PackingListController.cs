using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackIT.Application.Commands;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Commands;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Api.Controllers
{
    public class PackingListController : BaseController
    {
        private readonly ICommandDispatcher  _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public PackingListController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet("{Id:guid}")]
        public async Task<ActionResult<PackingListDto>> Get([FromRoute] GetPackingList query)
        {
            var result = await _queryDispatcher.QueryAsync(query);

            return OkOrNotFound(result);
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PackingListDto>>> Get([FromRoute] SearchPackingLists query)
        {
            var result = await _queryDispatcher.QueryAsync(query);

            return OkOrNotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePackingListWithItems command)
        {
            await _commandDispatcher.DispatchAsync(command);
            
            return CreatedAtAction(nameof(Get), new { id = command.Id }, null);
        }
        
        [HttpPut("{PackingListId:guid}/items")]
        public async Task<IActionResult> Put([FromBody] AddPackingItem command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Ok();
        }
        
        [HttpPut("{PackingListId:guid}/items/{Name}/pack")]
        public async Task<IActionResult> Put([FromBody] PackItem command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Ok();
        }
        
        [HttpDelete("{PackingListId:guid}/items/{Name}")]
        public async Task<IActionResult> Delete([FromBody] RemovePackingItem command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Ok();
        }
        
        [HttpDelete("{Id:guid}")]
        public async Task<IActionResult> Delete([FromBody] RemovePackingList command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Ok();
        }
    }
}