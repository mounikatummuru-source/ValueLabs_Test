using CodeChallenge.Application.DTO;
using CodeChallenge.Application.Mapping;
using CodeChallenge.Application.Repositories;
using CodeChallenge.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Api.Controllers.v1;

[ApiController]
[Route("api/v1/organizations/{organizationId}/messages")]
public class MessagesController : ControllerBase
{
    private readonly IMessageRepository _repository;
    private readonly ILogger<MessagesController> _logger;

    public MessagesController(IMessageRepository repository, ILogger<MessagesController> logger)//, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MessageDTO>>> GetAll(Guid organizationId)
    {
       var messages= await _repository.GetAllByOrganizationAsync(organizationId);
        return Ok(messages.ToDtos()); 
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MessageDTO>> GetById(Guid organizationId, Guid id)
    {
        var messages = await _repository.GetByIdAsync(organizationId,id);
        return Ok(messages?.ToDto());
    }

    [HttpPost]
    public async Task<ActionResult<Message>> Create(Guid organizationId, [FromBody] CreateMessageRequest request)
    {
        var messages = await _repository.CreateAsync(organizationId,request.FromCreate());
        return Ok(messages?.ToDto());
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(Guid organizationId, Guid id, [FromBody] UpdateMessageRequest request)
    {
        

        var messages = await _repository.UpdateAsync(organizationId,id, request.FromUpdate(organizationId, id));
        if (messages == null)
            return NotFound();
        return Ok(messages?.ToDto());
        
        }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid organizationId, Guid id)
    {
        bool flag = await _repository.DeleteAsync(organizationId,id);
        if (flag)
        {
            return Ok();
        }
        else
        { return NotFound(); }
      
    }
}
