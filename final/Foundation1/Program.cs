using System;

public class Program
{
    public static void Main(string[] args)
    {
        Video videoOne = new Video("Abstraction examples", "C#tutor", 752); //Tracks the Title, Author, and Length in Seconds
        Video videoTwo = new Video("Roadtrip ideas", "Travel101", 1030);
        Video videoThree = new Video("Is the Joker the best Villain of all time?", "BatmanLover89", 2483);

        videoOne.AddComment(new Comment("Smith99", "Thanks for the explanation!")); //Commenter and Text
        videoOne.AddComment(new Comment("Codclips07", "Super Helpful!"));
        videoOne.AddComment(new Comment("HankHert67", "This helped me at work!"));

        videoTwo.AddComment(new Comment("StacysMom", "Any ideas for Idaho?"));
        videoTwo.AddComment(new Comment("Cupcakelover", "Great food recommendations!"));
        videoTwo.AddComment(new Comment("Pandaz", "Well done!!"));

        videoThree.AddComment(new Comment("DCh8ter", "Thanos is way better than the Joker >:("));
        videoThree.AddComment(new Comment("TimDrake4Lyfe", "The Joker is such a great character!"));
        videoThree.AddComment(new Comment("TotallyNotBruceWayne", "I just think he should be put in Gotham Asylum."));

        List<Video> videos = new List<Video> {videoOne, videoTwo, videoThree};

        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine();
        }
    }
}