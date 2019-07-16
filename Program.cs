using Intro;
using System;

namespace ConsoleBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();
                var blog = new Blog { Url = "http://sample.com" };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }

            using (var db = new BloggingContext())
            {
                var blogs = db.Blogs;

                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Blog item found {blog.BlogId}.");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}