using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200090E RID: 2318
	[UnrealObjectPath("/Script/Engine.CameraModifier")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UCameraModifier : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F84 RID: 32644 RVA: 0x000B6CD0 File Offset: 0x000B4ED0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraModifier._ClassPtr;
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x000B6CDC File Offset: 0x000B4EDC
		public UCameraModifier() : this(BuiltinUtils.AllocNativeUObject(UCameraModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x000B6D04 File Offset: 0x000B4F04
		[NullableContext(1)]
		public UCameraModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x000B6D37 File Offset: 0x000B4F37
		// (set) Token: 0x06007F88 RID: 32648 RVA: 0x000B6D50 File Offset: 0x000B4F50
		public unsafe bool bDebug
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) & UCameraModifier.__PropertyMask_bDebug) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) = ((*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) & ~UCameraModifier.__PropertyMask_bDebug) | (value ? UCameraModifier.__PropertyMask_bDebug : 0));
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06007F89 RID: 32649 RVA: 0x000B6D80 File Offset: 0x000B4F80
		// (set) Token: 0x06007F8A RID: 32650 RVA: 0x000B6D99 File Offset: 0x000B4F99
		public unsafe bool bExclusive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) & UCameraModifier.__PropertyMask_bExclusive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) = ((*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) & ~UCameraModifier.__PropertyMask_bExclusive) | (value ? UCameraModifier.__PropertyMask_bExclusive : 0));
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x000B6DC9 File Offset: 0x000B4FC9
		// (set) Token: 0x06007F8C RID: 32652 RVA: 0x000B6DD9 File Offset: 0x000B4FD9
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x000B6DEA File Offset: 0x000B4FEA
		// (set) Token: 0x06007F8E RID: 32654 RVA: 0x000B6DFE File Offset: 0x000B4FFE
		[Nullable(2)]
		public unsafe APlayerCameraManager CameraOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraModifier.__PropertyOffset_CameraOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraModifier.__PropertyOffset_CameraOwner, value);
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x000B6E13 File Offset: 0x000B5013
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x000B6E23 File Offset: 0x000B5023
		public unsafe float AlphaInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaInTime) = value;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x000B6E34 File Offset: 0x000B5034
		// (set) Token: 0x06007F92 RID: 32658 RVA: 0x000B6E44 File Offset: 0x000B5044
		public unsafe float AlphaOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaOutTime) = value;
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06007F93 RID: 32659 RVA: 0x000B6E55 File Offset: 0x000B5055
		// (set) Token: 0x06007F94 RID: 32660 RVA: 0x000B6E65 File Offset: 0x000B5065
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x000B6E76 File Offset: 0x000B5076
		public bool IsDisabled()
		{
			return UCameraModifier.__IsDisabled_Internal(base.NativePtr);
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x000B6E83 File Offset: 0x000B5083
		[NullableContext(2)]
		public AActor GetViewTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UCameraModifier.__GetViewTarget_Internal(base.NativePtr));
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x000B6E95 File Offset: 0x000B5095
		public void EnableModifier()
		{
			UCameraModifier.__EnableModifier_Internal(base.NativePtr);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x000B6EA2 File Offset: 0x000B50A2
		public void DisableModifier(bool bImmediate = false)
		{
			UCameraModifier.__DisableModifier_Internal(base.NativePtr, bImmediate);
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x000B6EB0 File Offset: 0x000B50B0
		[NullableContext(2)]
		public unsafe virtual void BlueprintModifyPostProcess(float DeltaTime, ref float PostProcessBlendWeight, ref FPostProcessSettings PostProcessSettings)
		{
			fixed (float* ptr = &PostProcessBlendWeight)
			{
				void* ptr2 = (void*)ptr;
				UCameraModifier.__BlueprintModifyPostProcess_Internal(base.NativePtr, DeltaTime, ref PostProcessBlendWeight, (PostProcessSettings ?? new FPostProcessSettings()).NativePtr);
			}
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x000B6EE4 File Offset: 0x000B50E4
		public unsafe virtual void BlueprintModifyCamera(float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, ref FVector NewViewLocation, ref FRotator NewViewRotation, ref float NewFOV)
		{
			fixed (FVector* ptr = &NewViewLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &NewViewRotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &NewFOV)
					{
						void* ptr6 = (void*)ptr5;
						UCameraModifier.__BlueprintModifyCamera_Internal(base.NativePtr, DeltaTime, ViewLocation, ViewRotation, FOV, ref NewViewLocation, ref NewViewRotation, ref NewFOV);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x06007F9B RID: 32667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDisabled_Internal(IntPtr @this);

		// Token: 0x06007F9C RID: 32668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewTarget_Internal(IntPtr @this);

		// Token: 0x06007F9D RID: 32669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableModifier_Internal(IntPtr @this);

		// Token: 0x06007F9E RID: 32670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableModifier_Internal(IntPtr @this, bool bImmediate);

		// Token: 0x06007F9F RID: 32671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintModifyPostProcess_Internal(IntPtr @this, float DeltaTime, ref float PostProcessBlendWeight, IntPtr PostProcessSettings);

		// Token: 0x06007FA0 RID: 32672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintModifyCamera_Internal(IntPtr @this, float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, ref FVector NewViewLocation, ref FRotator NewViewRotation, ref float NewFOV);

		// Token: 0x06007FA1 RID: 32673 RVA: 0x000B6F28 File Offset: 0x000B5128
		static UCameraModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraModifier");
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x000B6F36 File Offset: 0x000B5136
		protected UCameraModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D23 RID: 15651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraModifier";

		// Token: 0x04003D24 RID: 15652
		private static IntPtr _ClassPtr;

		// Token: 0x04003D25 RID: 15653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D26 RID: 15654
		internal static int __PropertyOffset_bDebug;

		// Token: 0x04003D27 RID: 15655
		internal static byte __PropertyMask_bDebug;

		// Token: 0x04003D28 RID: 15656
		internal static int __PropertyOffset_bExclusive;

		// Token: 0x04003D29 RID: 15657
		internal static byte __PropertyMask_bExclusive;

		// Token: 0x04003D2A RID: 15658
		internal static int __PropertyOffset_Priority;

		// Token: 0x04003D2B RID: 15659
		internal static int __PropertyOffset_CameraOwner;

		// Token: 0x04003D2C RID: 15660
		internal static int __PropertyOffset_AlphaInTime;

		// Token: 0x04003D2D RID: 15661
		internal static int __PropertyOffset_AlphaOutTime;

		// Token: 0x04003D2E RID: 15662
		internal static int __PropertyOffset_Alpha;

		// Token: 0x02002CAE RID: 11438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2608)]
		protected ref struct __BlueprintModifyPostProcess_FunctionParams
		{
			// Token: 0x04016628 RID: 91688
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016629 RID: 91689
			[FieldOffset(4)]
			public float PostProcessBlendWeight;

			// Token: 0x0401662A RID: 91690
			[FieldOffset(16)]
			public byte PostProcessSettings;
		}

		// Token: 0x02002CAF RID: 11439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __BlueprintModifyCamera_FunctionParams
		{
			// Token: 0x0401662B RID: 91691
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x0401662C RID: 91692
			[FieldOffset(4)]
			public FVector ViewLocation;

			// Token: 0x0401662D RID: 91693
			[FieldOffset(16)]
			public FRotator ViewRotation;

			// Token: 0x0401662E RID: 91694
			[FieldOffset(28)]
			public float FOV;

			// Token: 0x0401662F RID: 91695
			[FieldOffset(32)]
			public FVector NewViewLocation;

			// Token: 0x04016630 RID: 91696
			[FieldOffset(44)]
			public FRotator NewViewRotation;

			// Token: 0x04016631 RID: 91697
			[FieldOffset(56)]
			public float NewFOV;
		}
	}
}
