using System.Collections.Generic;

namespace Levolution.Data.Timeline
{
    public class TimelineGroup : Timeline
    {
        public ICollection<Timeline> Children { get; protected set; } = new List<Timeline>();
    }
}
