using CodeChallenge.Application.DTO;
using CodeChallenge.Application.Mapping;
using CodeChallenge.Application.Repositories;
using CodeChallenge.Domain.Models;

namespace CodeChallenge.Application.Logic
{
    public class MessageLogic : IMessageLogic
    {
        public readonly IMessageRepository _messageRepository;

        public MessageLogic(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<Message> CreateMessageAsync(Guid organizationId, CreateMessageRequest request)
        {
            var message = await _messageRepository.CreateAsync(organizationId, request.FromCreate());
            return message;
        }

        public async Task<bool> DeleteMessageAsync(Guid organizationId, Guid id)
        {
            bool flag = await _messageRepository.DeleteAsync(organizationId, id);
            return flag;
        }

        public async Task<IEnumerable<Message>> GetAllMessagesAsync(Guid organizationId)
        {
            var messages = await _messageRepository.GetAllByOrganizationAsync(organizationId);
            return messages;
        }

        public async Task<Message?> GetMessageAsync(Guid organizationId, Guid id)
        {
            //Hi;
            throw new NotImplementedException();
        }

        public async Task<Message> UpdateMessageAsync(Guid organizationId, Guid id, UpdateMessageRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

