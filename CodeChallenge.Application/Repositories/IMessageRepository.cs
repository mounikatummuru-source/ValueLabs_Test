
using CodeChallenge.Domain.Models;


namespace CodeChallenge.Application.Repositories
{
  public  interface IMessageRepository
    {
        Task<Message?> GetByIdAsync(Guid organizationId, Guid id);
        Task<IEnumerable<Message>> GetAllByOrganizationAsync(Guid organizationId);
        Task<Message?> GetByTitleAsync(Guid organizationId, string title);
        Task<Message> CreateAsync(Guid organizationId, Message message);
        Task<Message?> UpdateAsync(Guid organizationId, Guid id,Message message);
        Task<bool> DeleteAsync(Guid organizationId, Guid id);
    }
}
