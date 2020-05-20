using System;
using System.Runtime.InteropServices;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _duration;

        public string Start()
        {
            _start = DateTime.Now;
            return _start.ToLongTimeString();
        }

        public string Stop()
        {
            _stop = DateTime.Now;
            return _stop.ToLongTimeString();
        }

        public string Duration()
        {
            _duration = _stop - _start;
            return _duration.TotalSeconds.ToString("N");
        }
    }
}