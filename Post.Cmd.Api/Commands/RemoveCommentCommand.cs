using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; } = Guid.Empty;
    public string Username { get; set; } = string.Empty;
}
