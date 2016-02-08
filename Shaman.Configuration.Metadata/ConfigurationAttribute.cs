using System;

namespace Shaman.Runtime
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ConfigurationAttribute : Attribute
    {
        public string CommandLineAlias { get; set; }
        public object PerformanceValue
        {
            set
            {
                _performanceValueSet = true;
                _performanceValue = value;
            }
            get
            {
                return _performanceValue;
            }
        }

        internal object _performanceValue;
        internal bool _performanceValueSet;
        
        public bool HasPerformanceValue { get { return _performanceValueSet; } }
    }
}
