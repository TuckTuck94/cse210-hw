using System;

 class Program
    {
        static void Main(string[] args)
        {
            // Create some videos
            Video wowvideo = new Video();
            wowvideo.Title = "Top 10 Tips to getting rich!!";
            wowvideo.Author = "Elon Bezos and Steve Gates";
            wowvideo.Length = 450;
            wowvideo.Comments = new List<Comment>();
            wowvideo.Comments.Add(new Comment("Dave", "Is this even real?"));
            wowvideo.Comments.Add(new Comment("John", "I don't think so."));
            wowvideo.Comments.Add(new Comment("Dave", "If this works, I'm quitting my job!"));
            wowvideo.Comments.Add(new Comment("Austen", "I'm going to try this!"));

            Video videogame = new Video();
            videogame.Title = "Top 10 Upcoming Video Games";
            videogame.Author = "Amazing Productions";
            videogame.Length = 200;
            videogame.Comments = new List<Comment>();
            videogame.Comments.Add(new Comment("Beth", "These games look fake."));
            videogame.Comments.Add(new Comment("John", "I agree!"));
            videogame.Comments.Add(new Comment("Allison", "The 3rd one looks real!"));
            videogame.Comments.Add(new Comment("Joshua", "I'm going to try out 7 when it releases!"));

            Video coolvideobro = new Video();
            coolvideobro.Title = "Pulling off something amazing!";
            coolvideobro.Author = "Ruben Christopher";
            coolvideobro.Length = 60;
            coolvideobro.Comments = new List<Comment>();
            coolvideobro.Comments.Add(new Comment("Dave", "Wow, this is amazing!"));
            coolvideobro.Comments.Add(new Comment("John", "I agree!"));
            coolvideobro.Comments.Add(new Comment("Benson", "I know right?"));
            coolvideobro.Comments.Add(new Comment("John", "100%! I enjoyed this!"));

            Video essay = new Video();
            essay.Title = "Writing Essays in 2023 fast";
            essay.Author = "Meghan Galloway";
            essay.Length = 420;
            essay.Comments = new List<Comment>();
            essay.Comments.Add(new Comment("Richard", "Thanks for the tips, hope I do well!"));
            essay.Comments.Add(new Comment("Timmy", "I only got a 50% on my last essay, I hope this helps! Else my mom will be angry!"));
            essay.Comments.Add(new Comment("Andy", "I still failed :("));
            essay.Comments.Add(new Comment("Mandy", "I got a 90%! Thanks!"));


            // Create a list of videos
            List<Video> videos = new List<Video>();
            videos.Add(wowvideo);
            videos.Add(videogame);
            videos.Add(coolvideobro);
            videos.Add(essay);

            // Iterate through the list of videos and display the title, author, length, number of comments, and all of the comments for each video
            foreach (Video video in videos)
            {
                Console.WriteLine("Title: {0}", video.Title);
                Console.WriteLine("Author: {0}", video.Author);
                Console.WriteLine("Length: {0} seconds", video.Length);
                Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine("Commenter: {0}, Text: {1}", comment.Name, comment.Text);
                }
            }

            Console.ReadLine();
        }
    }