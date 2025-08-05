using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities(); // instantiate the Entity Framework context

            var post = new Post() // creating a new post object
            {
                PostID = 1,
                Title = "First Post",
                Body = "This is my new first post",
                DatePublished = DateTime.Now
            };

            context.Posts.Add(post); // adding the post to the context (changes are only tracked in memory)
            
            context.SaveChanges(); // saving changes to the actual database
        }
    }
}
