using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        List<Comment> wowVideoComments = new List<Comment>();
        wowVideoComments.Add(new Comment("Dave", "Wow, this is amazing!"));
        wowVideoComments.Add(new Comment("John", "I agree!"));
        wowVideoComments.Add(new Comment("Benson", "I know, right?"));
        wowVideoComments.Add(new Comment("David", "100%"));

        videos.Add(new Video("Pulling off something amazing!", "Ruben", 60, wowVideoComments));
        
        List<Comment> topTenTipsComments = new List<Comment>();
        topTenTipsComments.Add(new Comment("Dave", "Is this even real?"));
        topTenTipsComments.Add(new Comment("John", "I don't think so."));
        topTenTipsComments.Add(new Comment("Dave", "If this works, I'm quitting my job!"));
        topTenTipsComments.Add(new Comment("Austen", "I'm going to try this!"));

        videos.Add(new Video("Top 10 Tips to getting rich!!", "TotallyRealCompany123", 450, topTenTipsComments));
        
        List<Comment> videoGameComments = new List<Comment>();
        videoGameComments.Add(new Comment("Beth", "These games look fake."));
        videoGameComments.Add(new Comment("John", "I agree!"));
        videoGameComments.Add(new Comment("Allison", "The 3rd one looks real!"));
        videoGameComments.Add(new Comment("Joshua", "I'm going to try out 7 when it releases!"));
        

        videos.Add(new Video("Top 10 Upcomming Video Games", "AmazingProductions", 600, videoGameComments));

        List<Comment> writingAnEssay = new List<Comment>();
        writingAnEssay.Add(new Comment("Richard", "Thanks for the tips, hope I do well!"));
        writingAnEssay.Add(new Comment("Timmy", "I only got a 50% on my last essay, I hope this helps! Else my mom will be angry!"));
        writingAnEssay.Add(new Comment("Andy", "I still failed :("));
        writingAnEssay.Add(new Comment("Richard", "I got a 90%! Thanks!"));
        
        videos.Add(new Video("Writing Essays in 2023 fast", "MeghanTopTips", 420, writingAnEssay));
    }
}