using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public class FrameSyncClock : AnimationClock
    {
        /// <summary>
        /// 
        /// </summary>
        public override TimeSpan CurrentTime => _currentTime;
        private TimeSpan _currentTime;

        /// <summary>
        /// 
        /// </summary>
        public override void Update()
        {
            _currentTime = DateTime.Now - BeginTime;
        }
    }
}
