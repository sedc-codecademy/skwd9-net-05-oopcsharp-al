using SEDC.Webinar.PostsApp.DataLayer.Database;
using SEDC.Webinar.PostsApp.Domain.Models;
using SEDC.Webinar.PostsApp.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.PostsApp.Services
{
    public class PostsService
    {
        public List<Post> GetAllPosts()
        {
            return Database.GetPosts();
        }

        public void AddPost(string title, string content, string createdBy)
        {
            if (string.IsNullOrEmpty(title)) //title == null || title == ""
            {
                throw new Exception("Title must not be empty");
            }

            if(title.Length < 5)
            {
                throw new TitleLengthException("Length of tthe title must be at least 5");
            }

            Post newPost = new Post(title, content, createdBy);
            Database.AddPost(newPost);
        }
    }
}
