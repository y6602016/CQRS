using Post.Query.Domain.Entities;

namespace Post.Query.Domain.Repositories
{
  public interface ICommentRepository
  {
    Task CreateAsync(CommentEntity comment);
    Task UpdateAsync(CommentEntity comment);
    Task<CommentEntity> GetByIdAsync(CommentEntity comment);
    Task DeleteAsync(Guid commentId);
  }
}