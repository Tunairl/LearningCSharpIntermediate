namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Post();
            p1.Upvote();
            p1.Upvote();
            p1.Upvote();
            p1.Upvote();
            p1.Downvote();

            Console.WriteLine(p1.VoteCount);

            var p2 = new Post("StackOverflow", "This is my first StackOverflow post. Fuck you.");
            p2.Upvote();
            p2.Upvote();
            p2.Upvote();
        }
    }
}