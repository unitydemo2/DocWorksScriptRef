using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    /// <summary>
    /// Container for holding a list of preload objects for a Scene to be built.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@latest/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class PreloadInfo
    {
        [NativeName("preloadObjects")]
        internal List<ObjectIdentifier> m_PreloadObjects;
        /// <summary>
        /// List of Objects for a serialized Scene that need to be preloaded.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.PreloadInfo]].
        /// </description>
        public List<ObjectIdentifier> preloadObjects
        {
            get { return m_PreloadObjects; }
            set { m_PreloadObjects = value; }
        }
    }

    /// <!-- Badly formed XML comment ignored for member "T:UnityEditor.Build.Content.AssetLoadInfo" -->
            [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class AssetLoadInfo
    {
        [NativeName("asset")]
        internal GUID m_Asset;
        ///     <summary>
                ///     GUID for the given asset.
                ///     </summary>
                ///     <description>
                ///     Internal use only. See [[AssetLoadInfo]].
                ///     </description>
                        public GUID asset
        {
            get { return m_Asset; }
            set { m_Asset = value; }
        }

        [NativeName("address")]
        internal string m_Address;
        ///     <summary>
                ///     Friendly name used to load the built asset.
                ///     </summary>
                ///     <description>
                ///     Internal use only. See [[AssetLoadInfo]].
                ///     </description>
                        public string address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }

        [NativeName("includedObjects")]
        internal List<ObjectIdentifier> m_IncludedObjects;
        ///     <summary>
                ///     List of objects that an asset contains in its source file.
                ///     </summary>
                ///     <description>
                ///     Internal use only. See [[AssetLoadInfo]].
                ///     </description>
                        public List<ObjectIdentifier> includedObjects
        {
            get { return m_IncludedObjects; }
            set { m_IncludedObjects = value; }
        }

        [NativeName("referencedObjects")]
        internal List<ObjectIdentifier> m_ReferencedObjects;
        ///     <summary>
                ///     List of objects that an asset references.
                ///     </summary>
                ///     <description>
                ///     Internal use only. See [[AssetLoadInfo]].
                ///     </description>
                        public List<ObjectIdentifier> referencedObjects
        {
            get { return m_ReferencedObjects; }
            set { m_ReferencedObjects = value; }
        }
    }

    /// <summary>
    /// Container for holding asset loading information for an AssetBundle to be built.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@0.0-preview/manual/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@1.8/manual/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class AssetBundleInfo
    {
        [NativeName("bundleName")]
        private string m_BundleName;
        /// <summary>
        /// Friendly AssetBundle name.
        /// </summary>
        /// <description>
        /// Internal use only. See [[AssetBundleInfo]].
        /// </description>
        public string bundleName
        {
            get { return m_BundleName; }
            set { m_BundleName = value; }
        }

        [NativeName("bundleAssets")]
        private List<AssetLoadInfo> m_BundleAssets;
        /// <summary>
        /// List of asset loading information for an AssetBundle.
        /// </summary>
        /// <description>
        /// Internal use only. See [[AssetBundleInfo]].
        /// </description>
        public List<AssetLoadInfo> bundleAssets
        {
            get { return m_BundleAssets; }
            set { m_BundleAssets = value; }
        }
    }


    /// <summary>
    /// Container for holding preload information for a given serialized Scene in an AssetBundle.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@latest/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class SceneLoadInfo
    {
        [NativeName("asset")]
        private GUID m_Asset;
        /// <summary>
        /// GUID for the given Scene.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SceneLoadInfo]].
        /// </description>
        public GUID asset
        {
            get { return m_Asset; }
            set { m_Asset = value; }
        }

        [NativeName("address")]
        private string m_Address;
        /// <summary>
        /// Friendly name used to load the built Scene from an asset bundle.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SceneLoadInfo]].
        /// </description>
        public string address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }

        [NativeName("internalName")]
        private string m_InternalName;
        /// <summary>
        /// Internal name used to load the built Scene from an asset bundle.
        /// </summary>
        /// <description>
        /// Internal names are used for loading to avoid collision if Scenes with similar file names are added to the same AssetBundle.
        /// Internal use only. See [[Build.Content.SceneLoadInfo]].
        /// </description>
        public string internalName
        {
            get { return m_InternalName; }
            set { m_InternalName = value; }
        }
    }

    /// <summary>
    /// Container for holding asset loading information for a streamed Scene AssetBundle to be built.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@latest/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class SceneBundleInfo
    {
        [NativeName("bundleName")]
        private string m_BundleName;
        /// <summary>
        /// Friendly AssetBundle name.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SceneBundleInfo]].
        /// </description>
        public string bundleName
        {
            get { return m_BundleName; }
            set { m_BundleName = value; }
        }

        [NativeName("bundleScenes")]
        private List<SceneLoadInfo> m_BundleScenes;
        /// <summary>
        /// List of Scene loading information for an AssetBundle.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SceneBundleInfo]].
        /// </description>
        public List<SceneLoadInfo> bundleScenes
        {
            get { return m_BundleScenes; }
            set { m_BundleScenes = value; }
        }
    }


    /// <summary>
    /// Container for holding object serialization order information for a build.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@latest/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    public class SerializationInfo
    {
        [NativeName("serializationObject")]
        internal ObjectIdentifier m_SerializationObject;
        /// <summary>
        /// Source object to be serialzied to disk.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SerializationInfo]].
        /// </description>
        public ObjectIdentifier serializationObject
        {
            get { return m_SerializationObject; }
            set { m_SerializationObject = value; }
        }

        [NativeName("serializationIndex")]
        internal long m_SerializationIndex;
        /// <summary>
        /// Order in which the object will be serialized to disk.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.SerializationInfo]].
        /// </description>
        public long serializationIndex
        {
            get { return m_SerializationIndex; }
            set { m_SerializationIndex = value; }
        }
    }

    /// <summary>
    /// Container for holding information about a serialized file to be written.
    /// </summary>
    /// <description>
    /// Note: this class and its members exist to provide low-level support for the __Scriptable Build Pipeline__ package. This is intended for internal use only; use the <a href="https://docs.unity3d.com/Packages/com.unity.scriptablebuildpipeline@latest/index.html">Scriptable Build Pipeline package</a> to implement a fully featured build pipeline. You can install this via the <a href="https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html">Unity Package Manager</a>.
    /// </description>
    [Serializable]
    [UsedByNativeCode]
    [NativeAsStruct]
    [StructLayout(LayoutKind.Sequential)]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    public class WriteCommand
    {
        [NativeName("fileName")]
        private string m_FileName;
        /// <summary>
        /// Final file name on disk of the serialized file.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.WriteCommand]].
        /// </description>
        public string fileName
        {
            get { return m_FileName; }
            set { m_FileName = value; }
        }

        [NativeName("internalName")]
        private string m_InternalName;
        /// <summary>
        /// Internal name used by the loading system for a serialized file.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.WriteCommand]].
        /// </description>
        public string internalName
        {
            get { return m_InternalName; }
            set { m_InternalName = value; }
        }

        [NativeName("serializeObjects")]
        private List<SerializationInfo> m_SerializeObjects;
        /// <summary>
        /// List of objects and their order contained inside a serialized file.
        /// </summary>
        /// <description>
        /// Internal use only. See [[Build.Content.WriteCommand]].
        /// </description>
        public List<SerializationInfo> serializeObjects
        {
            get { return m_SerializeObjects; }
            set { m_SerializeObjects = value; }
        }
    }
}
