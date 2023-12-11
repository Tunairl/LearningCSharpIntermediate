namespace Stopwatch
{
    public class Stopwatch
    {
        DateTime _startingPoint = DateTime.MinValue;

        public void Start()
        {
            if (_startingPoint != DateTime.MinValue)
            {
                throw new InvalidOperationException("Cannot be started twice! fuck you");
            }
            _startingPoint = DateTime.Now;
        }


        public TimeSpan Stop()
        {
            if (_startingPoint == DateTime.MinValue)
            {
                throw new InvalidOperationException("Cannot be stopped without starting! fuck you");
            }
            var endingPoint = DateTime.Now;

            var duration = endingPoint - _startingPoint;

            _startingPoint = DateTime.MinValue;

            return duration;
        }

    }
}