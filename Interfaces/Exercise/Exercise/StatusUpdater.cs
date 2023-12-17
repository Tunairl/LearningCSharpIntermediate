namespace Exercise
{
    public class StatusUpdater : IActivity
    {
        public StatusUpdater()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Video is processing.");
        }
    }
}