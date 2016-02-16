using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public struct Duration : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly Duration Auto = new Duration() { _isAuto = true };
        private bool _isAuto;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Duration Forever = new Duration() { _isForever = true };
        private bool _isForever;

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Duration(TimeSpan value) { Value = value; _isAuto = false; _isForever = false; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj) => CompareTo((TimeSpan)obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(TimeSpan other)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(TimeSpan other)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}