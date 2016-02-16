using System;
using System.Collections.Generic;
using System.Text;

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
        public virtual TValue Value { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        public IAnimationClock Clock { get; protected set; }
        
        /// <summary>
        /// 
        /// </summary>
        protected override void Update()
        {
            base.Update();

        }
    }
}
