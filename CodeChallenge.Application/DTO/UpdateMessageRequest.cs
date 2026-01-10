
namespace CodeChallenge.Application.DTO
{
    public class UpdateMessageRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }

}
