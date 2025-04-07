using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        Video video1 = new Video("Dancing 101", "Dance Academy", 59);
        Comment comment1 = new Comment("Jane", "this is cool");
        Comment comment2 = new Comment("Olivia", "will be a pro soon");
        Comment comment3 = new Comment("Adams", "finally!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("daily workout", "Your fitness Coach", 30);
        Comment comment4 = new Comment("Ben", "let's go!");
        Comment comment5 = new Comment("Derrick", "Yes! lets get the muscles");
        Comment comment6 = new Comment("Sam", "staying fit is the goal");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Ministering", "ChurchofJesusChrist", 30);
        Comment comment7 = new Comment("Berla", "Learnt soo much in a few secs");
        Comment comment8 = new Comment("Kasim", "Christlike love, this is beautiful");
        Comment comment9 = new Comment("Catherine", "Emulating the Saviour, nice");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine($"{video._title}, {video._author}, 0:{video._videoLength}secs");
            Console.WriteLine($"number of comments : {video.NumberOfComments()}");
            video.DisplayComment();
        }

    

        


    }
}