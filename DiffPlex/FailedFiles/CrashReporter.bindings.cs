using System;
using UnityEngine.Bindings;

#if ENABLE_CLOUD_SERVICES_CRASH_REPORTING
namespace UnityEngine.CrashReportHandler
{
    [NativeHeader("Modules/CrashReporting/Public/CrashReporter.h")]
    [StaticAccessor("CrashReporting::CrashReporter::Get()", StaticAccessorType.Dot)]
    public partial class CrashReportHandler
    {
        private CrashReportHandler()
        {
        }

        [NativeProperty("Enabled")]
        public static extern bool enableCaptureExceptions { get; set; }

        [NativeThrows]
        public static extern UInt32 logBufferSize { get; set; }

        [NativeThrows]
        public static extern string GetUserMetadata(string key);

        [NativeThrows]
        public static extern void SetUserMetadata(string key, string value);
    }
}
#endif
