using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/Comment")]
    public class CommentController : Controller
    {
        private CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<CommentModel> Get()
        {
            return _commentService.GetComments();
        }

        // GET: api/Comment/5
        [HttpGet("{id}", Name = "GetComments")]
        public CommentModel Get(int id) => _commentService.GetCommentById(id);

        // POST: api/Comment
        [HttpPost]
        public void Comment(CommentModel comment) => _commentService.AddComment(comment);

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CommentModel comment) => _commentService.PatchComment(id, comment);

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id) => _commentService.DeleteComment(id);
    }
}
