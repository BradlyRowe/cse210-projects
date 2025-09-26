using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create sample videos and add comments
        Video video1 = new Video("How to Bake Bread", "Chef Emma", 420);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "I love the step-by-step instructions."));
        video1.AddComment(new Comment("Charlie", "Can you do sourdough next?"));
        videos.Add(video1);

        Video video2 = new Video("Intro to SQL", "TechTutor", 900);
        video2.AddComment(new Comment("Dave", "Clear and concise. Thanks!"));
        video2.AddComment(new Comment("Eva", "Loved the examples."));
        video2.AddComment(new Comment("Frank", "Can you cover joins in the next video?"));
        videos.Add(video2);

        Video video3 = new Video("Epic Fantasy Trailer", "Mythic Studios", 180);
        video3.AddComment(new Comment("Gwen", "Chills! Can't wait for the release."));
        video3.AddComment(new Comment("Henry", "The visuals are stunning."));
        video3.AddComment(new Comment("Isla", "Who's the narrator? Voice is amazing."));
        videos.Add(video3);

        Video video4 = new Video("Guitar Basics", "StrumMaster", 600);
        video4.AddComment(new Comment("Jack", "Perfect for beginners."));
        video4.AddComment(new Comment("Kira", "Loved the chord breakdown."));
        video4.AddComment(new Comment("Leo", "Can you do fingerpicking next?"));
        videos.Add(video4);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}