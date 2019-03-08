using JamSharp.Runtime;
using NiceIO;

namespace Runtime.AR
{
    class ARModule : ConvertedJamFile
    {
        internal static void TopLevel()
        {
            RegisterRuleWithReturnValue("ARModule_ReportCpp", ARModule_ReportCpp);
            RegisterRuleWithReturnValue("ARModule_ReportCs", ARModule_ReportCs);
            RegisterRuleWithReturnValue("ARModule_ReportBaseDirectory", ARModule_ReportBaseDirectory);
            RegisterRuleWithReturnValue("ARModule_ReportIncludes", ARModule_ReportIncludes);
            RegisterRuleWithReturnValue("ARModule_ReportDependencies", ARModule_ReportDependencies);
            RegisterRule("ARModule_ReportPrebuiltLibraries", ARModule_ReportPrebuiltLibraries);
            RegisterRule("ARModule_ReportLinkFlags", ARModule_ReportLinkFlags);
        }

        static JamList ARModule_ReportCpp()
        {
            return JamList(
                JamExtensions.AllSourceFilesFrom("Modules/AR"),
                JamExtensions.AllSourceFilesFrom(
                    "Modules/AR/Tango"),
                new JamList("External/Tango/builds/gen/ApiFuncARCoreUnity.cpp"));
        }

        static JamList ARModule_ReportCs()
        {
            JamList csFiles = JamList();
            csFiles.Append(new NPath("Modules/AR/Tango/ScriptBindings").Files("*.cs"));
            csFiles.Append(new NPath("Modules/AR/ScriptBindings").Files("*.cs"));
            return csFiles;
        }

        static JamList ARModule_ReportBaseDirectory()
        {
            return JamList("Modules/AR");
        }

        static JamList ARModule_ReportIncludes()
        {
            return JamList("External/PhysX3/builds/Include", "External/Tango/builds/include");
        }

        static JamList ARModule_ReportDependencies()
        {
            return JamList(Projects.Jam.SetupRuntimeModules2.DefaultModuleDependencies(), "Physics", "Input", "JSONSerialize");
        }

        static void ARModule_ReportPrebuiltLibraries()
        {
        }

        static void ARModule_ReportLinkFlags()
        {
        }
    }
}
