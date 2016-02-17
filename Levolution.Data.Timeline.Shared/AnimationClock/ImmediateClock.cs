using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public class ImmediateClock : AnimationClock
    {
        /// <summary>
        /// 
        /// </summary>
        public override TimeSpan CurrentTime => DateTime.Now - BeginTime;

        /// <summary>
        /// 
        /// </summary>
        public override void Update()
        {
            // In this class, not need to implement this method.
            base.Update();
        }
    }
}
