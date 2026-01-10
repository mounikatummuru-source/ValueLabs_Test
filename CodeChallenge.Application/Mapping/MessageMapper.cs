using CodeChallenge.Application.DTO;
using CodeChallenge.Domain.Models;

namespace CodeChallenge.Application.Mapping
{
    public static class MessageMapper
    {
        public static MessageDTO ToDto(this Message message)

        {
            MessageDTO messageDTO = new MessageDTO();
            messageDTO.Id = message.Id;
            messageDTO.OrganizationId = message.OrganizationId;
            messageDTO.Title = message.Title;
            messageDTO.Content = message.Content;
            messageDTO.IsActive = message.IsActive;
            messageDTO.CreatedAt = message.CreatedAt;
            messageDTO.UpdatedAt = message.UpdatedAt;

            return messageDTO;
        }
        public static List<MessageDTO> ToDtos(this IEnumerable<Message> messages)

        {
            return messages.Select(ToDto).ToList();
        }

        public static Message FromCreate(this CreateMessageRequest createMessageRequest)

        {
            Message message = new Message();
            message.Title = createMessageRequest.Title;
            message.Content = createMessageRequest.Content;

            return message;
        }
        public static Message FromUpdate(this UpdateMessageRequest updateMessageRequest, Guid organizationId, Guid id)

        {
            Message message = new Message();
            message.Id = id;
            message.OrganizationId = organizationId;
            message.Title = updateMessageRequest.Title;
            message.Content = updateMessageRequest.Content;
            message.IsActive = updateMessageRequest.IsActive;

            return message;
        }

    }
}
