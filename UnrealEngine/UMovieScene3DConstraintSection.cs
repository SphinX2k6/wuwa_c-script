using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002328 RID: 9000
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DConstraintSection")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UMovieScene3DConstraintSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060220C8 RID: 139464 RVA: 0x003254E6 File Offset: 0x003236E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DConstraintSection._ClassPtr;
		}

		// Token: 0x060220C9 RID: 139465 RVA: 0x003254F4 File Offset: 0x003236F4
		public UMovieScene3DConstraintSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DConstraintSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220CA RID: 139466 RVA: 0x0032551C File Offset: 0x0032371C
		public UMovieScene3DConstraintSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DConstraintSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700838B RID: 33675
		// (get) Token: 0x060220CB RID: 139467 RVA: 0x0032554F File Offset: 0x0032374F
		// (set) Token: 0x060220CC RID: 139468 RVA: 0x00325563 File Offset: 0x00323763
		public unsafe FGuid ConstraintId_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DConstraintSection.__PropertyOffset_ConstraintId_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DConstraintSection.__PropertyOffset_ConstraintId_DEPRECATED) = value;
			}
		}

		// Token: 0x1700838C RID: 33676
		// (get) Token: 0x060220CD RID: 139469 RVA: 0x00325578 File Offset: 0x00323778
		// (set) Token: 0x060220CE RID: 139470 RVA: 0x003255B1 File Offset: 0x003237B1
		public FMovieSceneObjectBindingID ConstraintBindingID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._ConstraintBindingID) == null)
				{
					result = (this._ConstraintBindingID = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)UMovieScene3DConstraintSection.__PropertyOffset_ConstraintBindingID, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene3DConstraintSection.__PropertyOffset_ConstraintBindingID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060220CF RID: 139471 RVA: 0x003255D4 File Offset: 0x003237D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetConstraintBindingID(in FMovieSceneObjectBindingID InConstraintBindingID)
		{
			UMovieScene3DConstraintSection.__SetConstraintBindingID_FunctionParams* ptr = stackalloc UMovieScene3DConstraintSection.__SetConstraintBindingID_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMovieScene3DConstraintSection.__SetConstraintBindingID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieScene3DConstraintSection.__SetConstraintBindingID_NativeFunctionPtr, (void*)ptr, 1);
			if (InConstraintBindingID != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), &ptr->InConstraintBindingID, InConstraintBindingID.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieScene3DConstraintSection.__SetConstraintBindingID_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060220D0 RID: 139472 RVA: 0x00325638 File Offset: 0x00323838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMovieSceneObjectBindingID GetConstraintBindingID()
		{
			UMovieScene3DConstraintSection.__GetConstraintBindingID_FunctionParams* ptr = stackalloc UMovieScene3DConstraintSection.__GetConstraintBindingID_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMovieScene3DConstraintSection.__GetConstraintBindingID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieScene3DConstraintSection.__GetConstraintBindingID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieScene3DConstraintSection.__GetConstraintBindingID_NativeFunctionPtr, (void*)ptr, 0);
			return new FMovieSceneObjectBindingID(&ptr->__Result, true, true);
		}

		// Token: 0x060220D1 RID: 139473 RVA: 0x00325686 File Offset: 0x00323886
		static UMovieScene3DConstraintSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DConstraintSection");
		}

		// Token: 0x060220D2 RID: 139474 RVA: 0x00325694 File Offset: 0x00323894
		protected UMovieScene3DConstraintSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122AF RID: 74415
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DConstraintSection";

		// Token: 0x040122B0 RID: 74416
		private static IntPtr _ClassPtr;

		// Token: 0x040122B1 RID: 74417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122B2 RID: 74418
		internal static int __PropertyOffset_ConstraintId_DEPRECATED;

		// Token: 0x040122B3 RID: 74419
		internal static int __PropertyOffset_ConstraintBindingID;

		// Token: 0x040122B4 RID: 74420
		[Nullable(2)]
		private FMovieSceneObjectBindingID _ConstraintBindingID;

		// Token: 0x040122B5 RID: 74421
		private static IntPtr __SetConstraintBindingID_NativeFunctionPtr;

		// Token: 0x040122B6 RID: 74422
		private static IntPtr __GetConstraintBindingID_NativeFunctionPtr;

		// Token: 0x02003648 RID: 13896
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetConstraintBindingID_FunctionParams
		{
			// Token: 0x04017712 RID: 96018
			[FieldOffset(0)]
			public byte InConstraintBindingID;
		}

		// Token: 0x02003649 RID: 13897
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConstraintBindingID_FunctionParams
		{
			// Token: 0x04017713 RID: 96019
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
