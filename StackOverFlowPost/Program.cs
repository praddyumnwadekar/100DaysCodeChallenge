using System;
using System.Collections.Generic;

namespace StackOverFlowPost
{
    class Program
    {

        static void Main(string[] args)
        {
            var listOfPost = new List<StackOverFlow>();

            listOfPost.Add(new StackOverFlow()
            {
                Title = "Post Of Recurssion",
                Description = "Just Showing the Working of the recurssion methods",
                Date = new DateTime(2019, 7, 12)
            }
            );
            
            listOfPost.Add(new StackOverFlow()
            {
                Title = "Post Of Tree",
                Description = "Just Showing the Working of the Tree Data Structure",
                Date = new DateTime(2018, 3, 1)
            }
            );

            listOfPost[0].Up_vote();
            listOfPost[0].Up_vote();
            listOfPost[0].Up_vote();
            listOfPost[0].Up_vote();


            listOfPost[1].Up_vote();
            listOfPost[1].Up_vote();
            listOfPost[1].Up_vote();
            listOfPost[1].Up_vote();
            listOfPost[1].Up_vote();
            listOfPost[1].Up_vote();

            listOfPost[0].Down_vote();
            listOfPost[0].Down_vote();


            listOfPost[1].Down_vote();
            listOfPost[1].Down_vote();
            listOfPost[1].Down_vote();
            

            foreach (var post in listOfPost)
            {
                Console.WriteLine($"Title : {post.Title}\n Description: {post.Description}\n Date Of Post: {post.Date}");
                Console.WriteLine($"Votes : {post.GetUp_vote}");
                Console.WriteLine();
            }         
           
        }
    }
}
