using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("C# Tutorial for Beginners", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# Design Patterns", "James Brown", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Excellent explanations."));
        video2.AddComment(new Comment("Eve", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Loved the advanced topics."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Design patterns are so important."));
        video3.AddComment(new Comment("Heidi", "This was a great overview."));
        video3.AddComment(new Comment("Ivan", "Thanks for the detailed examples."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }    
    }
}