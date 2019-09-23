using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class CommentService
    {
        private CommentRepository _commentRepository;

        public CommentService(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public List<CommentModel> GetComments()
        {
            return _commentRepository.GetComments();
        }

        public CommentModel GetCommentById(int id)
        {
            return _commentRepository.GetCommentById(id);
        }

        public void AddComment(CommentModel comment) => _commentRepository.AddComment(comment);

        public void PatchComment(int id, CommentModel comment) => _commentRepository.PatchComment(id, comment);

        public void DeleteComment(int id) => _commentRepository.DeleteComment(id);
    }
}
