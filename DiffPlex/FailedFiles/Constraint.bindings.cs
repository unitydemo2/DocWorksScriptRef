using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    /// <summary>
    /// Represents the axes used in 3D space.
    /// </summary>
    [NativeType("Modules/Animation/Constraints/ConstraintEnums.h")]
    [Flags]
    public enum Axis
    {
        /// <summary>
        /// Represents the case when no axis is specified.
        /// </summary>
        None = 0,
        /// <summary>
        /// Represents the X axis.
        /// </summary>
        X = 1,
        /// <summary>
        /// Represents the Y axis.
        /// </summary>
        Y = 2,
        /// <summary>
        /// Represents the Z axis.
        /// </summary>
        Z = 4
    }

    ///     <summary>
        ///     Represents a source for the constraint.
        ///     </summary>
            [System.Serializable]
    [NativeType(CodegenOptions = CodegenOptions.Custom, Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    [UsedByNativeCode]
    public struct ConstraintSource
    {
        [NativeName("sourceTransform")]
        private Transform m_SourceTransform;
        [NativeName("weight")]
        private float m_Weight;

        ///     <summary>
                ///     The transform component of the source object.
                ///     </summary>
                        public Transform sourceTransform { get { return m_SourceTransform; } set { m_SourceTransform = value; } }
        ///     <summary>
                ///     The weight of the source in the evaluation of the constraint.
                ///     </summary>
                        public float weight { get { return m_Weight; } set { m_Weight = value; } }
    }

    /// <summary>
    /// The common interface for constraint components.
    /// </summary>
    public interface IConstraint
    {
        /// <summary>
        /// The weight of the constraint component.
        /// </summary>
        float weight { get; set; }

        /// <summary>
        /// Activate or deactivate the constraint.
        /// </summary>
        bool constraintActive { get; set; }
        /// <summary>
        /// Lock or unlock the offset and position at rest.
        /// </summary>
        /// <description>
        /// In Edit mode, unlock the constraint to update its offsets. In Play mode, the constraint is always locked.
        /// </description>
        bool locked { get; set; }

        /// <summary>
        /// Gets the number of sources currently set on the component.
        /// </summary>
        int sourceCount { get; }

        /// <summary>
        /// Add a constraint source.
        /// </summary>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <returns>
        /// Returns the index of the added source.
        /// </returns>
        int AddSource(ConstraintSource source);
        /// <summary>
        /// Removes a source from the component.
        /// </summary>
        /// <param name="index">
        /// The index of the source to remove.
        /// </param>
        /// <description>
        /// Throws InvalidOperationException, if the list of sources is empty. Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        void RemoveSource(int index);
        /// <summary>
        /// Gets a constraint source by index.
        /// </summary>
        /// <param name="index">
        /// The index of the source.
        /// </param>
        /// <returns>
        /// The source object and its weight.
        /// </returns>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        ConstraintSource GetSource(int index);
        /// <summary>
        /// Sets a source at a specified index.
        /// </summary>
        /// <param name="index">
        /// The index of the source to set.
        /// </param>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        void SetSource(int index, ConstraintSource source);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void GetSources(List<ConstraintSource> sources);
        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void SetSources(List<ConstraintSource> sources);
    }

    internal interface IConstraintInternal
    {
#if UNITY_EDITOR
        void ActivateAndPreserveOffset();
        void ActivateWithZeroOffset();
        void UserUpdateOffset();
        Transform transform { get; }
#endif // UNITY_EDITOR
    }

    /// <summary>
    /// Constrains the position of an object relative to the position of one or more source objects.
    /// </summary>
    [UsedByNativeCode]
    [RequireComponent(typeof(Transform))]
    [NativeHeader("Modules/Animation/Constraints/PositionConstraint.h")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    public sealed partial class PositionConstraint : Behaviour, IConstraint, IConstraintInternal
    {
        PositionConstraint()
        {
            Internal_Create(this);
        }

        private static extern void Internal_Create([Writable] PositionConstraint self);

        /// <summary>
        /// The weight of the constraint component.
        /// </summary>
        public extern float weight { get; set; }

        /// <summary>
        /// The translation used when the sources have a total weight of 0.
        /// </summary>
        public extern Vector3 translationAtRest { get; set; }

        /// <summary>
        /// The offset from the constrained position.
        /// </summary>
        public extern Vector3 translationOffset { get; set; }

        /// <summary>
        /// The axes affected by the PositionConstraint.
        /// </summary>
        /// <description>
        /// Use this property to restrict the effect of the constraint on a particular axis.
        /// </description>
        /// <dw-legacy-code>
        /// using UnityEngine.Animations;
        /// public class ConstraintAxis
        /// {
        ///     public void ConstrainOnlyOnXY(PositionConstraint component)
        ///     {
        ///         component.translationAxis = Axis.X | Axis.Y;
        ///     }
        /// }
        /// </dw-legacy-code>
        public extern Axis translationAxis { get; set; }

        /// <summary>
        /// Activates or deactivates the constraint.
        /// </summary>
        public extern bool constraintActive { get; set; }
        /// <summary>
        /// Locks the offset and position at rest.
        /// </summary>
        /// <description>
        /// In Edit mode, unlocks the constraint to update its offsets. In Play mode, the constraint is always locked.
        /// </description>
        public extern bool locked { get; set; }

        /// <summary>
        /// The number of sources set on the component (read-only).
        /// </summary>
        public int sourceCount { get { return GetSourceCountInternal(this); } }
        [FreeFunction("ConstraintBindings::GetSourceCount")]
        private static extern int GetSourceCountInternal([NotNull] PositionConstraint self);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        [FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = true)]
        public extern void GetSources([NotNull] List<ConstraintSource> sources);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        public void SetSources(List<ConstraintSource> sources)
        {
            if (sources == null)
                throw new ArgumentNullException("sources");

            SetSourcesInternal(this, sources);
        }

        [FreeFunction("ConstraintBindings::SetSources")]
        private static extern void SetSourcesInternal([NotNull] PositionConstraint self, List<ConstraintSource> sources);

        /// <summary>
        /// Adds a constraint source.
        /// </summary>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <returns>
        /// Returns the index of the added source.
        /// </returns>
        public extern int AddSource(ConstraintSource source);

        /// <summary>
        /// Removes a source from the component.
        /// </summary>
        /// <param name="index">
        /// The index of the source to remove.
        /// </param>
        /// <description>
        /// Throws InvalidOperationException, if the list of sources is empty. Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void RemoveSource(int index)
        {
            ValidateSourceIndex(index);
            RemoveSourceInternal(index);
        }

        [NativeName("RemoveSource")]
        private extern void RemoveSourceInternal(int index);

        /// <summary>
        /// Gets a constraint source by index.
        /// </summary>
        /// <param name="index">
        /// The index of the source.
        /// </param>
        /// <returns>
        /// The source object and its weight.
        /// </returns>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public ConstraintSource GetSource(int index)
        {
            ValidateSourceIndex(index);
            return GetSourceInternal(index);
        }

        [NativeName("GetSource")]
        private extern ConstraintSource GetSourceInternal(int index);

        /// <summary>
        /// Sets a source at a specified index.
        /// </summary>
        /// <param name="index">
        /// The index of the source to set.
        /// </param>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void SetSource(int index, ConstraintSource source)
        {
            ValidateSourceIndex(index);
            SetSourceInternal(index, source);
        }

        [NativeName("SetSource")]
        private extern void SetSourceInternal(int index, ConstraintSource source);

        private void ValidateSourceIndex(int index)
        {
            if (sourceCount == 0)
            {
                throw new InvalidOperationException("The PositionConstraint component has no sources.");
            }

            if (index < 0 || index >= sourceCount)
            {
                throw new ArgumentOutOfRangeException("index", string.Format("Constraint source index {0} is out of bounds (0-{1}).", index, sourceCount));
            }
        }

#if UNITY_EDITOR
        extern void ActivateAndPreserveOffset();
        extern void ActivateWithZeroOffset();
        extern void UserUpdateOffset();

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateAndPreserveOffset()
        {
            ActivateAndPreserveOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateWithZeroOffset()
        {
            ActivateWithZeroOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.UserUpdateOffset()
        {
            UserUpdateOffset();
        }

        Transform IConstraintInternal.transform
        {
            get { return this.transform; }
        }
#endif // UNITY_EDITOR
    }

    /// <summary>
    /// Constrains the rotation of an object relative to the rotation of one or more source objects.
    /// </summary>
    [UsedByNativeCode]
    [RequireComponent(typeof(Transform))]
    [NativeHeader("Modules/Animation/Constraints/RotationConstraint.h")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    public sealed partial class RotationConstraint : Behaviour, IConstraint, IConstraintInternal
    {
        RotationConstraint()
        {
            Internal_Create(this);
        }

        private static extern void Internal_Create([Writable] RotationConstraint self);

        /// <summary>
        /// The weight of the constraint component.
        /// </summary>
        public extern float weight { get; set; }

        /// <summary>
        /// The rotation used when the sources have a total weight of 0.
        /// </summary>
        public extern Vector3 rotationAtRest { get; set; }

        /// <summary>
        /// The offset from the constrained rotation.
        /// </summary>
        public extern Vector3 rotationOffset { get; set; }

        /// <summary>
        /// The axes affected by the RotationConstraint.
        /// </summary>
        /// <description>
        /// Use this property to restrict the effect of the constraint on a particular axis.
        /// </description>
        /// <dw-legacy-code>
        /// using UnityEngine.Animations;
        /// public class ConstraintAxis
        /// {
        ///     public void ConstrainOnlyOnXY(RotationConstraint component)
        ///     {
        ///         component.rotationAxis = Axis.X | Axis.Y;
        ///     }
        /// }
        /// </dw-legacy-code>
        public extern Axis rotationAxis { get; set; }

        /// <summary>
        /// Activates or deactivates the constraint.
        /// </summary>
        public extern bool constraintActive { get; set; }
        /// <summary>
        /// Locks the offset and rotation at rest.
        /// </summary>
        /// <description>
        /// In Edit mode, unlock the constraint to update its offsets. In Play mode, the constraint is always locked.
        /// </description>
        public extern bool locked { get; set; }

        /// <summary>
        /// The number of sources set on the component (read-only).
        /// </summary>
        public int sourceCount { get { return GetSourceCountInternal(this); } }
        [FreeFunction("ConstraintBindings::GetSourceCount")]
        private static extern int GetSourceCountInternal([NotNull] RotationConstraint self);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        [FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = true)]
        public extern void GetSources([NotNull] List<ConstraintSource> sources);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        public void SetSources(List<ConstraintSource> sources)
        {
            if (sources == null)
                throw new ArgumentNullException("sources");

            SetSourcesInternal(this, sources);
        }

        [FreeFunction("ConstraintBindings::SetSources")]
        private static extern void SetSourcesInternal([NotNull] RotationConstraint self, List<ConstraintSource> sources);

        /// <summary>
        /// Adds a constraint source.
        /// </summary>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <returns>
        /// Returns the index of the added source.
        /// </returns>
        public extern int AddSource(ConstraintSource source);

        /// <summary>
        /// Removes a source from the component.
        /// </summary>
        /// <param name="index">
        /// The index of the source to remove.
        /// </param>
        /// <description>
        /// Throws InvalidOperationException, if the list of sources is empty. Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void RemoveSource(int index)
        {
            ValidateSourceIndex(index);
            RemoveSourceInternal(index);
        }

        [NativeName("RemoveSource")]
        private extern void RemoveSourceInternal(int index);

        /// <summary>
        /// Gets a constraint source by index.
        /// </summary>
        /// <param name="index">
        /// The index of the source.
        /// </param>
        /// <returns>
        /// The source object and its weight.
        /// </returns>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public ConstraintSource GetSource(int index)
        {
            ValidateSourceIndex(index);
            return GetSourceInternal(index);
        }

        [NativeName("GetSource")]
        private extern ConstraintSource GetSourceInternal(int index);

        /// <summary>
        /// Sets a source at a specified index.
        /// </summary>
        /// <param name="index">
        /// The index of the source to set.
        /// </param>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void SetSource(int index, ConstraintSource source)
        {
            ValidateSourceIndex(index);
            SetSourceInternal(index, source);
        }

        [NativeName("SetSource")]
        private extern void SetSourceInternal(int index, ConstraintSource source);
        private void ValidateSourceIndex(int index)
        {
            if (sourceCount == 0)
            {
                throw new InvalidOperationException("The RotationConstraint component has no sources.");
            }

            if (index < 0 || index >= sourceCount)
            {
                throw new ArgumentOutOfRangeException("index", string.Format("Constraint source index {0} is out of bounds (0-{1}).", index, sourceCount));
            }
        }

#if UNITY_EDITOR
        extern void ActivateAndPreserveOffset();
        extern void ActivateWithZeroOffset();
        extern void UserUpdateOffset();

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateAndPreserveOffset()
        {
            this.ActivateAndPreserveOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateWithZeroOffset()
        {
            this.ActivateWithZeroOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.UserUpdateOffset()
        {
            this.UserUpdateOffset();
        }

        Transform IConstraintInternal.transform
        {
            get { return this.transform; }
        }
#endif // UNITY_EDITOR
    }

    /// <summary>
    /// Constrains the scale of an object relative to the scale of one or more source objects.
    /// </summary>
    [UsedByNativeCode]
    [RequireComponent(typeof(Transform))]
    [NativeHeader("Modules/Animation/Constraints/ScaleConstraint.h")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    public sealed partial class ScaleConstraint : Behaviour, IConstraint, IConstraintInternal
    {
        ScaleConstraint()
        {
            Internal_Create(this);
        }

        private static extern void Internal_Create([Writable] ScaleConstraint self);

        /// <summary>
        /// The weight of the constraint component.
        /// </summary>
        public extern float weight { get; set; }

        /// <summary>
        /// The scale used when the sources have a total weight of 0.
        /// </summary>
        public extern Vector3 scaleAtRest { get; set; }

        /// <summary>
        /// The offset from the constrained scale.
        /// </summary>
        public extern Vector3 scaleOffset { get; set; }

        /// <summary>
        /// The axes affected by the ScaleConstraint.
        /// </summary>
        /// <description>
        /// Use this property to restrict the effect of the constraint on a particular axis.
        /// </description>
        /// <dw-legacy-code>
        /// using UnityEngine.Animations;
        /// public class ConstraintAxis
        /// {
        ///     public void ConstrainOnlyOnXY(ScaleConstraint component)
        ///     {
        ///         component.scalingAxis = Axis.X | Axis.Y;
        ///     }
        /// }
        /// </dw-legacy-code>
        public extern Axis scalingAxis { get; set; }

        /// <summary>
        /// Activates or deactivates the constraint.
        /// </summary>
        public extern bool constraintActive { get; set; }
        /// <summary>
        /// Locks the offset and scale at rest.
        /// </summary>
        /// <description>
        /// In Edit mode, unlocks the constraint to update its offsets. In Play mode, the constraint is always locked.
        /// </description>
        public extern bool locked { get; set; }

        /// <summary>
        /// The number of sources set on the component (read-only).
        /// </summary>
        public int sourceCount { get { return GetSourceCountInternal(this); } }
        [FreeFunction("ConstraintBindings::GetSourceCount")]
        private static extern int GetSourceCountInternal([NotNull] ScaleConstraint self);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        [FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = true)]
        public extern void GetSources([NotNull] List<ConstraintSource> sources);

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        public void SetSources(List<ConstraintSource> sources)
        {
            if (sources == null)
                throw new ArgumentNullException("sources");

            SetSourcesInternal(this, sources);
        }

        [FreeFunction("ConstraintBindings::SetSources")]
        private static extern void SetSourcesInternal([NotNull] ScaleConstraint self, List<ConstraintSource> sources);

        /// <summary>
        /// Adds a constraint source.
        /// </summary>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <returns>
        /// Returns the index of the added source.
        /// </returns>
        public extern int AddSource(ConstraintSource source);

        /// <summary>
        /// Removes a source from the component.
        /// </summary>
        /// <param name="index">
        /// The index of the source to remove.
        /// </param>
        /// <description>
        /// Throws InvalidOperationException, if the list of sources is empty. Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void RemoveSource(int index)
        {
            ValidateSourceIndex(index);
            RemoveSourceInternal(index);
        }

        [NativeName("RemoveSource")]
        private extern void RemoveSourceInternal(int index);

        /// <summary>
        /// Gets a constraint source by index.
        /// </summary>
        /// <param name="index">
        /// The index of the source.
        /// </param>
        /// <returns>
        /// The source object and its weight.
        /// </returns>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public ConstraintSource GetSource(int index)
        {
            ValidateSourceIndex(index);
            return GetSourceInternal(index);
        }

        [NativeName("GetSource")]
        private extern ConstraintSource GetSourceInternal(int index);

        /// <summary>
        /// Sets a source at a specified index.
        /// </summary>
        /// <param name="index">
        /// The index of the source to set.
        /// </param>
        /// <param name="source">
        /// The source object and its weight.
        /// </param>
        /// <description>
        /// Throws ArgumentOutOfRangeException, if the index is invalid.
        /// </description>
        public void SetSource(int index, ConstraintSource source)
        {
            ValidateSourceIndex(index);
            SetSourceInternal(index, source);
        }

        [NativeName("SetSource")]
        private extern void SetSourceInternal(int index, ConstraintSource source);

        private void ValidateSourceIndex(int index)
        {
            if (sourceCount == 0)
            {
                throw new InvalidOperationException("The ScaleConstraint component has no sources.");
            }

            if (index < 0 || index >= sourceCount)
            {
                throw new ArgumentOutOfRangeException("index", string.Format("Constraint source index {0} is out of bounds (0-{1}).", index, sourceCount));
            }
        }

#if UNITY_EDITOR
        extern void ActivateAndPreserveOffset();
        extern void ActivateWithZeroOffset();
        extern void UserUpdateOffset();

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateAndPreserveOffset()
        {
            this.ActivateAndPreserveOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.ActivateWithZeroOffset()
        {
            this.ActivateWithZeroOffset();
        }

        /// <summary>
        /// There is currently no documentation for this api.
        /// </summary>
        void IConstraintInternal.UserUpdateOffset()
        {
            this.UserUpdateOffset();
        }

        Transform IConstraintInternal.transform
        {
            get { return this.transform; }
        }
#endif // UNITY_EDITOR
    }
}
