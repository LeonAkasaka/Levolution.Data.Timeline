using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public class DoubleTimeline : AnimationTimeline<double>
    {
        /// <summary>
        /// 
        /// </summary>
        public override double Value => From + (To - From) * Progress;
    }
}
