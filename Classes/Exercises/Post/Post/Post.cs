namespace Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; private init; }

        public int VoteCount { get; private set; }

        public Post()
        {
        }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.DateOfCreation = DateTime.Now;
        }

        public void Upvote()
        {
            VoteCount += 1;
        }
        
        public void Downvote()
        {
            VoteCount -= 1;
        }
    }
}