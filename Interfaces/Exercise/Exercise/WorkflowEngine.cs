namespace Exercise
{
    public class WorkflowEngine
    {
        public void Run(IEnumerable<IActivity> activities)
        {

            foreach (var activity in activities)
            {
                activity.Execute();
            }
        }


    }
}