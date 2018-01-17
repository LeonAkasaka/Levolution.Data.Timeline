using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Timeline : ITimeline
    {
        /// <summary>
        /// 
        /// </summary>
        public double Progress
        {
            get { return _progress; }
            set { _progress = value; ProgressChanged?.Invoke(this, EventArgs.Empty); }
        }
        private double _progress;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler ProgressChanged;

        /// <summary>
        /// 
        /// </summary>
        public Duration Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimelineState CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; CurrentStateChanged?.Invoke(this, EventArgs.Empty); }
        }
        private TimelineState _currentState;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CurrentStateChanged;

        /// <summary>
        /// 
        /// </summary>
        public virtual void Play() => CurrentState = TimelineState.Playing;

        /// <summary>
        /// 
        /// </summary>
        public virtual void Pause() => CurrentState = TimelineState.Paused;

        /// <summary>
        /// 
        /// </summary>
        public virtual void Stop() => CurrentState = TimelineState.Stopped;
    }
}
