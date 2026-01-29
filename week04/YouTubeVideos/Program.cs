using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful video!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Charlie", "Thanks for this tutorialS."));

        Video video2 = new Video("OOP Concepts Explained", "DevSimplified", 850);
        video2.AddComment(new Comment("Diana", "Great examples."));
        video2.AddComment(new Comment("Ethan", "Now I understand abstraction."));
        video2.AddComment(new Comment("Fiona", "Well explained."));

        Video video3 = new Video("C# Collections Overview", "ProgrammingHub", 720);
        video3.AddComment(new Comment("George", "Nice overview."));
        video3.AddComment(new Comment("Hannah", "Very useful."));
        video3.AddComment(new Comment("Ivan", "Good pace and clarity."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetAuthorName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
