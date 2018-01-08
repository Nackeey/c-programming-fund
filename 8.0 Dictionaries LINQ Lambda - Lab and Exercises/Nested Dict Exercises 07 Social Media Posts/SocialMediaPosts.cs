using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, Dictionary<string, string>> postData = new Dictionary<string, Dictionary<string, string>>();
    static Dictionary<string, int> postLikes = new Dictionary<string, int>();
    static Dictionary<string, int> postDislikes = new Dictionary<string, int>();

    static void Main()
    {
        
        string input = Console.ReadLine();
        while (input != "drop the media")
        {
            string[] inputText = input.Split(' ');
            string command = inputText[0];
            string postName = inputText[1];

            switch (command)
            {
                case "post":
                    {
                        CreatePost(postName);
                    }
                    break;
                case "like":
                    {
                        LikedPosts(postName);
                    }
                    break;
                case "dislike":
                    {
                        DisLikedPosts(postName);
                    }
                    break;
                case "comment":
                    {
                        string commentatorName = inputText[2];
                        string content = string.Join(" ", inputText.Skip(3));
                        CommentPost(postName, commentatorName, content);
                    }
                    break;
                default:
                    break;
            }

            input = Console.ReadLine();
        }
        foreach (var post in postData)
        {
            string postName = post.Key;
            int likes = postLikes[postName];
            int dislikes = postDislikes[postName];
            Dictionary<string, string> commentsData = post.Value;

            Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, likes, dislikes);
            Console.WriteLine("Comments:");
            foreach (var commentData in commentsData)
            {
                string commentatorName = commentData.Key;
                string commentContent = commentData.Value;
                Console.WriteLine("*  {0}: {1}", commentatorName, commentContent);
            }
        }
    }
    static void CreatePost(string postName)
    {
        postData.Add(postName, new Dictionary<string, string>());
        postLikes.Add(postName, 0);
        postDislikes.Add(postName, 0);
    }
    static void LikedPosts(string postName)
    {
        postLikes[postName]++;
    }
    static void DisLikedPosts(string PostName)
    {
        postDislikes[PostName]++; 
    }
    static void CommentPost(string postName, string commentatorName, string content)
    {
        postData[postName].Add(commentatorName, content);
    }
}

