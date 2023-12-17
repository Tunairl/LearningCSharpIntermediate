namespace Exercise
{
    public class MailNotificationChannel : IActivity
    {
        private readonly string _message;

        public MailNotificationChannel(string message)
        {
            _message = message;
        }
        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }
}