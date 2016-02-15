using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Timeline : ITimeline, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public double Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Duration Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Play() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Pause() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Stop() { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Update()
        {

        }
    }
}
