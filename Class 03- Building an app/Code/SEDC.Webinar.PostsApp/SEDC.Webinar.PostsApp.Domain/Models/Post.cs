using SEDC.Webinar.PostsApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.PostsApp.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; }
        public PostStatus Status { get; set; }

        public Post(string title, string content, string createdBy)
        {
            Title = title;
            Content = content;
            CreatedBy = createdBy;
            Status = PostStatus.New;
        }
    }
}
