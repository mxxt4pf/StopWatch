namespace Stopwatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        private bool _running;

        public void Start (DateTime start)
        {
            if (_running) 
                throw new InvalidOperationException("Stopwatch is already running!");
            
                _startTime = start;
                _running = true;
        }

        public void Stop (DateTime Stop)
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running!");

                _stopTime = Stop;
                _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _stopTime - _startTime;
        }

    }
       
}
