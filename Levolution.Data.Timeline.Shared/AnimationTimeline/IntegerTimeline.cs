using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public class IntegerTimeline : AnimationTimeline<int>
    {
        /// <summary>
        /// 
        /// </summary>
        public override int Value => (int)(From + (To - From) * Progress);
    }
}
