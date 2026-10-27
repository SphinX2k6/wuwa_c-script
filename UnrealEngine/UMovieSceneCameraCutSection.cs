using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002349 RID: 9033
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraCutSection")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UMovieSceneCameraCutSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022254 RID: 139860 RVA: 0x00327C8A File Offset: 0x00325E8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraCutSection._ClassPtr;
		}

		// Token: 0x06022255 RID: 139861 RVA: 0x00327C96 File Offset: 0x00325E96
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneCameraCutSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x00327CA0 File Offset: 0x00325EA0
		public UMovieSceneCameraCutSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022257 RID: 139863 RVA: 0x00327CC8 File Offset: 0x00325EC8
		[NullableContext(1)]
		public UMovieSceneCameraCutSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083E2 RID: 33762
		// (get) Token: 0x06022258 RID: 139864 RVA: 0x00327CFB File Offset: 0x00325EFB
		// (set) Token: 0x06022259 RID: 139865 RVA: 0x00327D0B File Offset: 0x00325F0B
		public unsafe bool bLockPreviousCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_bLockPreviousCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_bLockPreviousCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170083E3 RID: 33763
		// (get) Token: 0x0602225A RID: 139866 RVA: 0x00327D1C File Offset: 0x00325F1C
		// (set) Token: 0x0602225B RID: 139867 RVA: 0x00327D30 File Offset: 0x00325F30
		public unsafe FGuid CameraGuid_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_CameraGuid_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_CameraGuid_DEPRECATED) = value;
			}
		}

		// Token: 0x170083E4 RID: 33764
		// (get) Token: 0x0602225C RID: 139868 RVA: 0x00327D48 File Offset: 0x00325F48
		// (set) Token: 0x0602225D RID: 139869 RVA: 0x00327D81 File Offset: 0x00325F81
		[Nullable(1)]
		public FMovieSceneObjectBindingID CameraBindingID
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._CameraBindingID) == null)
				{
					result = (this._CameraBindingID = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_CameraBindingID, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_CameraBindingID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083E5 RID: 33765
		// (get) Token: 0x0602225E RID: 139870 RVA: 0x00327DA2 File Offset: 0x00325FA2
		// (set) Token: 0x0602225F RID: 139871 RVA: 0x00327DB6 File Offset: 0x00325FB6
		public unsafe FTransform InitialCameraCutTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_InitialCameraCutTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_InitialCameraCutTransform) = value;
			}
		}

		// Token: 0x170083E6 RID: 33766
		// (get) Token: 0x06022260 RID: 139872 RVA: 0x00327DCB File Offset: 0x00325FCB
		// (set) Token: 0x06022261 RID: 139873 RVA: 0x00327DDB File Offset: 0x00325FDB
		public unsafe bool bHasInitialCameraCutTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_bHasInitialCameraCutTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraCutSection.__PropertyOffset_bHasInitialCameraCutTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022262 RID: 139874 RVA: 0x00327DEC File Offset: 0x00325FEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCameraBindingID(in FMovieSceneObjectBindingID InCameraBindingID)
		{
			UMovieSceneCameraCutSection.__SetCameraBindingID_FunctionParams* ptr = stackalloc UMovieSceneCameraCutSection.__SetCameraBindingID_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMovieSceneCameraCutSection.__SetCameraBindingID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneCameraCutSection.__SetCameraBindingID_NativeFunctionPtr, (void*)ptr, 1);
			if (InCameraBindingID != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), &ptr->InCameraBindingID, InCameraBindingID.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneCameraCutSection.__SetCameraBindingID_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022263 RID: 139875 RVA: 0x00327E50 File Offset: 0x00326050
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMovieSceneObjectBindingID GetCameraBindingID()
		{
			UMovieSceneCameraCutSection.__GetCameraBindingID_FunctionParams* ptr = stackalloc UMovieSceneCameraCutSection.__GetCameraBindingID_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMovieSceneCameraCutSection.__GetCameraBindingID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneCameraCutSection.__GetCameraBindingID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneCameraCutSection.__GetCameraBindingID_NativeFunctionPtr, (void*)ptr, 0);
			return new FMovieSceneObjectBindingID(&ptr->__Result, true, true);
		}

		// Token: 0x06022264 RID: 139876 RVA: 0x00327E9E File Offset: 0x0032609E
		static UMovieSceneCameraCutSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraCutSection");
		}

		// Token: 0x06022265 RID: 139877 RVA: 0x00327EAC File Offset: 0x003260AC
		protected UMovieSceneCameraCutSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012398 RID: 74648
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x04012399 RID: 74649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraCutSection";

		// Token: 0x0401239A RID: 74650
		private static IntPtr _ClassPtr;

		// Token: 0x0401239B RID: 74651
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401239C RID: 74652
		internal static int __PropertyOffset_bLockPreviousCamera;

		// Token: 0x0401239D RID: 74653
		internal static int __PropertyOffset_CameraGuid_DEPRECATED;

		// Token: 0x0401239E RID: 74654
		internal static int __PropertyOffset_CameraBindingID;

		// Token: 0x0401239F RID: 74655
		[Nullable(2)]
		private FMovieSceneObjectBindingID _CameraBindingID;

		// Token: 0x040123A0 RID: 74656
		internal static int __PropertyOffset_InitialCameraCutTransform;

		// Token: 0x040123A1 RID: 74657
		internal static int __PropertyOffset_bHasInitialCameraCutTransform;

		// Token: 0x040123A2 RID: 74658
		private static IntPtr __SetCameraBindingID_NativeFunctionPtr;

		// Token: 0x040123A3 RID: 74659
		private static IntPtr __GetCameraBindingID_NativeFunctionPtr;

		// Token: 0x0200364A RID: 13898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetCameraBindingID_FunctionParams
		{
			// Token: 0x04017714 RID: 96020
			[FieldOffset(0)]
			public byte InCameraBindingID;
		}

		// Token: 0x0200364B RID: 13899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetCameraBindingID_FunctionParams
		{
			// Token: 0x04017715 RID: 96021
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
