using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Timeline
{
    public class TimelineGroup : Timeline
    {
        public ICollection<Timeline> Children { get; protected set; } = new List<Timeline>();
    }
}
