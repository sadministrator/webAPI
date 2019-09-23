using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class CommentRepository
    {
        private List<CommentModel> Comments = new List<CommentModel>();
        public List<CommentModel> GetComments()
        {
            return Comments;
        }

        public CommentModel GetCommentById(int id)
        {
            return Comments.Find(comment => comment.Id.Equals(id));
        }

        public void AddComment(CommentModel comment) => Comments.Add(comment);

        public void PatchComment(int id, CommentModel comment)
        {
            var patchedComment = GetCommentById(id);
            patchedComment.Id = comment.Id;
            patchedComment.Content = comment.Content;
            patchedComment.Date = comment.Date;
        }

        public void DeleteComment(int id) => Comments.Remove(GetCommentById(id));
    }
}
