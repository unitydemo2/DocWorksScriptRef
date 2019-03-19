using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.CrashReporting
{
#if ENABLE_CLOUD_SERVICES_CRASH_REPORTING

    
    /// <summary>
    /// Hey I am summary
    /// </summary>
    /// <description>
    /// [5c80ec3b68a5942b842dbcd8](test File_5c80ec3b68a5942b842dbcd8.cs)
    /// </description>
    [NativeHeader("Modules/UnityConnect/CrashReporting/CrashReportingSettings.h")]
    [StaticAccessor("GetCrashReportingSettings()")]
    public static partial class CrashReportingSettings
    {
        
        
        public static extern bool enabled
        {
            [ThreadSafe] get;
            [ThreadSafe] set;
        }

        
        
        public static extern bool captureEditorExceptions { get; set; }

        
        
        [NativeThrows]
        public static extern UInt32 logBufferSize { get; set; }

        internal static extern void SetEnabledServiceWindow(bool enabled);

        internal static extern string GetEventUrl();
        internal static extern void SetEventUrl(string eventUrl);
    }

#endif
}
