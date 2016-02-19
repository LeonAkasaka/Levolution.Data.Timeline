using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AnimationClock : IAnimationClock
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract TimeSpan CurrentTime { get; }

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CurrentTimeUpdated;

        /// <summary>
        /// 
        /// </summary>
        protected DateTime BeginTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AnimationClock() { Reset(); }

        /// <summary>
        /// 
        /// </summary>
        public void Reset() => BeginTime = DateTime.Now;

        /// <summary>
        ///
        /// </summary>
        public virtual void Update() { CurrentTimeUpdated?.Invoke(this, EventArgs.Empty);  }
    }
}