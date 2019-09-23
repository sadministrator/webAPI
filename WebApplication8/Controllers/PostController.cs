using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Services;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/Post")]
    public class PostController : Controller
    {
        private PostService _postService;

        public PostController(PostService postService)
        {
            _postService = postService;
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<PostModel> Get()
        {
            return _postService.GetPosts();
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "GetPosts")]
        public PostModel Get(int id) => _postService.GetPostById(id);

        // POST: api/Post
        [HttpPost]
        public void Post(PostModel post) => _postService.AddPost(post);

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PostModel post) => _postService.PatchPost(id, post);

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id) => _postService.DeletePost(id);
    }
}
