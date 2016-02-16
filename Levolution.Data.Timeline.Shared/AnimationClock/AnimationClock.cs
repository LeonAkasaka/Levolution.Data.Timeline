using Levolution.Core.Component;
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
        public abstract void Update();
    }
}