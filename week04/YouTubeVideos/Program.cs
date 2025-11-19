using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("Exploring Temple Square", "Bryton Palmer", 420);
        Video video2 = new Video("Scripture Journal DIY", "Elena Rivera", 315);
        Video video3 = new Video("Utah Hiking Trails", "Jordan Smith", 560);
        Video video4 = new Video("Missionary Prep Tips", "Sister Taylor", 390);

        
        video1.AddComment(new Comment("Alice", "This was so peaceful to watch."));
        video1.AddComment(new Comment("Mark", "I love the architecture!"));
        video1.AddComment(new Comment("Sophie", "Thanks for sharing this tour."));

        
        video2.AddComment(new Comment("Daniel", "This journal idea is amazing."));
        video2.AddComment(new Comment("Rachel", "Can you share the template?"));
        video2.AddComment(new Comment("Tom", "Very creative and helpful."));

        
        video3.AddComment(new Comment("Emma", "I’ve hiked that trail! Beautiful views."));
        video3.AddComment(new Comment("Liam", "Great drone shots."));
        video3.AddComment(new Comment("Noah", "Adding this to my bucket list."));
        video3.AddComment(new Comment("Olivia", "Loved the editing style!"));

        
        video4.AddComment(new Comment("Mia", "This helped me feel more confident."));
        video4.AddComment(new Comment("Lucas", "Great advice for new missionaries."));
        video4.AddComment(new Comment("Grace", "Thank you for this!"));

        
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine("\n==============================\n");
        }

    }
}