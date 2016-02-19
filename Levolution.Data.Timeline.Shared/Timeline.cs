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
            set { ProgressChanged?.Invoke(this, EventArgs.Empty); }
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
        protected virtual void Play() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Pause() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Stop() { }
    }
}
