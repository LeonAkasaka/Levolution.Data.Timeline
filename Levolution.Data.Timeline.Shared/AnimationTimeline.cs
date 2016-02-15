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
        public virtual TValue Value { get; protected set; }
        
        public AnimationClock Clock { get; protected set; }


        protected override void Update()
        {
            base.Update();

        }
    }
}
