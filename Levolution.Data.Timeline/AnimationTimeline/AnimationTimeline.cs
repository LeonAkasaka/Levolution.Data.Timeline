using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AnimationTimeline<TValue> : Timeline
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract TValue Value { get; }

        /// <summary>
        /// 
        /// </summary>
        public TValue From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TValue To { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public IAnimationClock Clock
        {
            get { return _clock; }
            set
            {
                if (_clock != null) _clock.CurrentTimeUpdated -= Clock_CurrentTimeUpdated;
                _clock = value;
                if (_clock != null) _clock.CurrentTimeUpdated += Clock_CurrentTimeUpdated;
            }
        }
        private IAnimationClock _clock;

        private void Clock_CurrentTimeUpdated(object sender, EventArgs e)
        {
            var p = Clock.CurrentTime.Ticks / (double)Duration.Value.Ticks;
            if (Progress > 1)
            {
                Progress = 1;
                Stop();
            }
            else
            {
                Progress = p;
            }
        }

    }
}
