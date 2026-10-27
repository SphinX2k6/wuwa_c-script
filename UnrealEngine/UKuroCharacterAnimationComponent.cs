using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175A RID: 5978
	[UnrealObjectPath("/Script/KuroComponent.KuroCharacterAnimationComponent")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UKuroCharacterAnimationComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060157E5 RID: 88037 RVA: 0x001F94FA File Offset: 0x001F76FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterAnimationComponent._ClassPtr;
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x001F9508 File Offset: 0x001F7708
		public UKuroCharacterAnimationComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterAnimationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060157E7 RID: 88039 RVA: 0x001F9530 File Offset: 0x001F7730
		[NullableContext(1)]
		public UKuroCharacterAnimationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterAnimationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x060157E8 RID: 88040 RVA: 0x001F9563 File Offset: 0x001F7763
		// (set) Token: 0x060157E9 RID: 88041 RVA: 0x001F9573 File Offset: 0x001F7773
		public unsafe float BufferTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterAnimationComponent.__PropertyOffset_BufferTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterAnimationComponent.__PropertyOffset_BufferTimeLength) = value;
			}
		}

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x060157EA RID: 88042 RVA: 0x001F9584 File Offset: 0x001F7784
		// (set) Token: 0x060157EB RID: 88043 RVA: 0x001F9594 File Offset: 0x001F7794
		public unsafe float BufferNowTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterAnimationComponent.__PropertyOffset_BufferNowTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterAnimationComponent.__PropertyOffset_BufferNowTime) = value;
			}
		}

		// Token: 0x060157EC RID: 88044 RVA: 0x001F95A5 File Offset: 0x001F77A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopModelBuffer()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__StopModelBuffer_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x001F95BC File Offset: 0x001F77BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetOriginLocation(FVector Location)
		{
			UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__SetOriginLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__SetOriginLocation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x001F9603 File Offset: 0x001F7803
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetModelQuat()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__ResetModelQuat_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x001F9618 File Offset: 0x001F7818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetModelLocation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__ResetModelLocation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x001F9630 File Offset: 0x001F7830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetTransformOffsetInWorld(FTransform Child, FTransform Parent, bool InUseLocalMode = false)
		{
			UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Child = Child;
			ptr->Parent = Parent;
			ptr->InUseLocalMode = InUseLocalMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060157F1 RID: 88049 RVA: 0x001F9688 File Offset: 0x001F7888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void D_GetTransformOffsetInWorld(FTransformDouble Child, FTransformDouble Parent, bool InUseLocalMode = false)
		{
			UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Child = Child;
			ptr->Parent = Parent;
			ptr->InUseLocalMode = InUseLocalMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x001F96E0 File Offset: 0x001F78E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddModelQuat(FQuat Quat, bool LockCenter)
		{
			UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__AddModelQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Quat = Quat;
			ptr->LockCenter = LockCenter;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__AddModelQuat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060157F3 RID: 88051 RVA: 0x001F9730 File Offset: 0x001F7930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddModelLocation(FVector Offset)
		{
			UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__AddModelLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__AddModelLocation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060157F4 RID: 88052 RVA: 0x001F9777 File Offset: 0x001F7977
		static UKuroCharacterAnimationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroCharacterAnimationComponent");
		}

		// Token: 0x060157F5 RID: 88053 RVA: 0x001F9785 File Offset: 0x001F7985
		protected UKuroCharacterAnimationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBA1 RID: 48033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroCharacterAnimationComponent";

		// Token: 0x0400BBA2 RID: 48034
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBA3 RID: 48035
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBA4 RID: 48036
		internal static int __PropertyOffset_BufferTimeLength;

		// Token: 0x0400BBA5 RID: 48037
		internal static int __PropertyOffset_BufferNowTime;

		// Token: 0x0400BBA6 RID: 48038
		private static IntPtr __StopModelBuffer_NativeFunctionPtr;

		// Token: 0x0400BBA7 RID: 48039
		private static IntPtr __SetOriginLocation_NativeFunctionPtr;

		// Token: 0x0400BBA8 RID: 48040
		private static IntPtr __ResetModelQuat_NativeFunctionPtr;

		// Token: 0x0400BBA9 RID: 48041
		private static IntPtr __ResetModelLocation_NativeFunctionPtr;

		// Token: 0x0400BBAA RID: 48042
		private static IntPtr __GetTransformOffsetInWorld_NativeFunctionPtr;

		// Token: 0x0400BBAB RID: 48043
		private static IntPtr __D_GetTransformOffsetInWorld_NativeFunctionPtr;

		// Token: 0x0400BBAC RID: 48044
		private static IntPtr __AddModelQuat_NativeFunctionPtr;

		// Token: 0x0400BBAD RID: 48045
		private static IntPtr __AddModelLocation_NativeFunctionPtr;

		// Token: 0x02002F05 RID: 12037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetOriginLocation_FunctionParams
		{
			// Token: 0x04016A44 RID: 92740
			[FieldOffset(0)]
			public FVector Location;
		}

		// Token: 0x02002F06 RID: 12038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetTransformOffsetInWorld_FunctionParams
		{
			// Token: 0x04016A45 RID: 92741
			[FieldOffset(0)]
			public FTransform Child;

			// Token: 0x04016A46 RID: 92742
			[FieldOffset(48)]
			public FTransform Parent;

			// Token: 0x04016A47 RID: 92743
			[FieldOffset(96)]
			public bool InUseLocalMode;
		}

		// Token: 0x02002F07 RID: 12039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __D_GetTransformOffsetInWorld_FunctionParams
		{
			// Token: 0x04016A48 RID: 92744
			[FieldOffset(0)]
			public FTransformDouble Child;

			// Token: 0x04016A49 RID: 92745
			[FieldOffset(64)]
			public FTransformDouble Parent;

			// Token: 0x04016A4A RID: 92746
			[FieldOffset(128)]
			public bool InUseLocalMode;
		}

		// Token: 0x02002F08 RID: 12040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __AddModelQuat_FunctionParams
		{
			// Token: 0x04016A4B RID: 92747
			[FieldOffset(0)]
			public FQuat Quat;

			// Token: 0x04016A4C RID: 92748
			[FieldOffset(16)]
			public bool LockCenter;
		}

		// Token: 0x02002F09 RID: 12041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AddModelLocation_FunctionParams
		{
			// Token: 0x04016A4D RID: 92749
			[FieldOffset(0)]
			public FVector Offset;
		}
	}
}
