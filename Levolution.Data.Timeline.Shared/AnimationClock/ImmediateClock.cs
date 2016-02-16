using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Timeline
{
    public class ImmediateClock : AnimationClock
    {
        public override TimeSpan CurrentTime => DateTime.Now - BeginTime;

        public override void Update()
        {
            // In this class, not need to implement this method.
        }
    }
}
