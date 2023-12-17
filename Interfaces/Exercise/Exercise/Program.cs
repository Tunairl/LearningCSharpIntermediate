namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activities = new List<IActivity>()
            {
                new VideoUploader("someVideoPath.avi"),
                new WebServiceCaller(),
                new MailNotificationChannel("Mail sent."),
                new StatusUpdater()
            };

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(activities);
        }
    }
}