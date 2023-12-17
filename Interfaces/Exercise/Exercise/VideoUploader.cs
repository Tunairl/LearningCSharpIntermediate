namespace Exercise
{
    public class VideoUploader : IActivity
    {
        private readonly string _videoPath;

        public VideoUploader(string videoPath)
        {
            _videoPath = videoPath;
        }
        public void Execute()
        {
            Console.WriteLine("Uploading the video from: " + _videoPath);
        }
    }
}