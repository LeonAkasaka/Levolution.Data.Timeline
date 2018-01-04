using Levolution.Core.Component;
using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAnimationClock : IUpdatable
    {
        /// <summary>
        /// 
        /// </summary>
        TimeSpan CurrentTime { get; }

        /// <summary>
        /// 
        /// </summary>
        event EventHandler CurrentTimeUpdated;

        /// <summary>
        /// 
        /// </summary>
        void Reset();
    }
}