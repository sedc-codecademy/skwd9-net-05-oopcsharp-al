using SEDC.Webinar.PostsApp.Domain.Models;
using SEDC.Webinar.PostsApp.Services;
using SEDC.Webinar.PostsApp.Services.Exceptions;
using System;
using System.Collections.Generic;

namespace SEDC.Webinar.PostsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post newPost = new Post("Test title", "Test content", "tanjas");

            try
            {
                PostsService postsService = new PostsService();

                List<Post> allPosts = postsService.GetAllPosts();
                foreach (Post post in allPosts)
                {
                    Console.WriteLine(post.Title);
                }

                postsService.AddPost("Third post", "Third content", "dejanz");

                List<Post> currentPosts = postsService.GetAllPosts();
                foreach (Post post in currentPosts)
                {
                    Console.WriteLine(post.Title);
                }

                postsService.AddPost("Test", "Third content", "dejanz");
            }
            catch(TitleLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
