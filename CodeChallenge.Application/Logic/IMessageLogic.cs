using CodeChallenge.Application.DTO;
using CodeChallenge.Domain.Models;

namespace CodeChallenge.Application.Logic;

public interface IMessageLogic
{
    Task<Message> CreateMessageAsync(Guid organizationId, CreateMessageRequest request);
    Task<Message> UpdateMessageAsync(Guid organizationId, Guid id, UpdateMessageRequest request);
    Task<bool> DeleteMessageAsync(Guid organizationId, Guid id);
    Task<Message?> GetMessageAsync(Guid organizationId, Guid id);
    Task<IEnumerable<Message>> GetAllMessagesAsync(Guid organizationId);
}
