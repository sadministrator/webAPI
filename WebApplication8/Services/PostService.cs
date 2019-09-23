using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class PostService
    {
        private PostRepository _postRepository;

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public List<PostModel> GetPosts()
        {
            return _postRepository.GetPosts();
        }

        public PostModel GetPostById(int id)
        {
            return _postRepository.GetPostById(id);
        }

        public void AddPost(PostModel post) => _postRepository.AddPost(post);

        public void PatchPost(int id, PostModel post) => _postRepository.PatchPost(id, post);

        public void DeletePost(int id) => _postRepository.DeletePost(id);
    }
}
