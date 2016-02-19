namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleTimeline : AnimationTimeline<float>
    {
        /// <summary>
        /// 
        /// </summary>
        public override float Value => (float)(From + (To - From) * Progress);
    }
}
