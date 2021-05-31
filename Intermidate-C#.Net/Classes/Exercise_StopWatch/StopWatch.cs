using System;

namespace Exercise_StopWatch
{
    public class StopWatch
    {
        private bool _isFinish = true;
        private DateTime _start;
        private TimeSpan _duration;

        public void Start()
        {
            if (!_isFinish)
            {
                throw new Exception("Can not start 2 times in a row");
            }
            _start = DateTime.Now;
            _isFinish = false;
        }

        public void Stop()
        {
            _duration = DateTime.Now - _start;
            _isFinish = true;
            Console.WriteLine(_duration);
        }
    }
}