using SEDC.Webinar.PostsApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Webinar.PostsApp.DataLayer.Database
{
    public static class Database
    {
        public static List<Post> Posts { get; set; }

        public static List<Post> GetPosts()
        {
            return Posts;
        }

        public static int AddPost(Post post)
        {
            post.Id = Posts.Last().Id + 1;
            Posts.Add(post);
            return post.Id;
        }

        static Database()
        {
            Posts = new List<Post>();
            Post firstPost = new Post("First post", "First post", "tanjas");
            firstPost.Id = 1;
            Posts.Add(firstPost);

            Post secondPost = new Post("Second post", "Second post content", "martinp");
            secondPost.Id = 2;
            Posts.Add(secondPost);
        }
    }
}
