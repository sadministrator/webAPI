using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class PostRepository
    {
        private List<PostModel> Posts = new List<PostModel>();
        public List<PostModel> GetPosts()
        {
            return Posts;
        }

        public PostModel GetPostById(int id)
        {
            return Posts.Find(post => post.Id.Equals(id));
        }

        public void AddPost(PostModel post) => Posts.Add(post);

        public void PatchPost(int id, PostModel post)
        {
            var patchedPost = GetPostById(id);
            patchedPost.Id = post.Id;
            patchedPost.Content = post.Content;
            patchedPost.Date = post.Date;
        }

        public void DeletePost(int id) => Posts.Remove(GetPostById(id));
    }
}
