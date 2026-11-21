using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000343 RID: 835
	[UnrealObjectPath("/Script/KuroComponent.KuroCharacterAnimationComponent")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UKuroCharacterAnimationComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060055FD RID: 22013 RVA: 0x000787DC File Offset: 0x000769DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterAnimationComponent._ClassPtr;
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x000787E8 File Offset: 0x000769E8
		public UKuroCharacterAnimationComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterAnimationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00078810 File Offset: 0x00076A10
		[NullableContext(1)]
		public UKuroCharacterAnimationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterAnimationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x00078843 File Offset: 0x00076A43
		// (set) Token: 0x06005601 RID: 22017 RVA: 0x00078853 File Offset: 0x00076A53
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

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x00078864 File Offset: 0x00076A64
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x00078874 File Offset: 0x00076A74
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

		// Token: 0x06005604 RID: 22020 RVA: 0x00078885 File Offset: 0x00076A85
		[SkipLocalsInit]
		public void StopModelBuffer()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__StopModelBuffer_NativeFunctionPtr, null);
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x0007889C File Offset: 0x00076A9C
		[SkipLocalsInit]
		public unsafe void SetOriginLocation(FVector Location)
		{
			UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__SetOriginLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__SetOriginLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__SetOriginLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x000788E2 File Offset: 0x00076AE2
		[SkipLocalsInit]
		public void ResetModelQuat()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__ResetModelQuat_NativeFunctionPtr, null);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x000788F6 File Offset: 0x00076AF6
		[SkipLocalsInit]
		public void ResetModelLocation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__ResetModelLocation_NativeFunctionPtr, null);
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x0007890C File Offset: 0x00076B0C
		[SkipLocalsInit]
		public unsafe void GetTransformOffsetInWorld(FTransform Child, FTransform Parent, bool InUseLocalMode = false)
		{
			UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Child = Child;
			ptr->Parent = Parent;
			ptr->InUseLocalMode = InUseLocalMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00078960 File Offset: 0x00076B60
		[SkipLocalsInit]
		public unsafe void D_GetTransformOffsetInWorld(FTransformDouble Child, FTransformDouble Parent, bool InUseLocalMode = false)
		{
			UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Child = Child;
			ptr->Parent = Parent;
			ptr->InUseLocalMode = InUseLocalMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__D_GetTransformOffsetInWorld_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x000789B8 File Offset: 0x00076BB8
		[SkipLocalsInit]
		public unsafe void AddModelQuat(FQuat Quat, bool LockCenter)
		{
			UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__AddModelQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__AddModelQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Quat = Quat;
			ptr->LockCenter = LockCenter;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__AddModelQuat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00078A08 File Offset: 0x00076C08
		[SkipLocalsInit]
		public unsafe void AddModelLocation(FVector Offset)
		{
			UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams* ptr = stackalloc UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCharacterAnimationComponent.__AddModelLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCharacterAnimationComponent.__AddModelLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCharacterAnimationComponent.__AddModelLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x00078A4E File Offset: 0x00076C4E
		static UKuroCharacterAnimationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroCharacterAnimationComponent");
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00078A5C File Offset: 0x00076C5C
		protected UKuroCharacterAnimationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400233D RID: 9021
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroCharacterAnimationComponent";

		// Token: 0x0400233E RID: 9022
		private static IntPtr _ClassPtr;

		// Token: 0x0400233F RID: 9023
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002340 RID: 9024
		internal static int __PropertyOffset_BufferTimeLength;

		// Token: 0x04002341 RID: 9025
		internal static int __PropertyOffset_BufferNowTime;

		// Token: 0x04002342 RID: 9026
		private static IntPtr __StopModelBuffer_NativeFunctionPtr;

		// Token: 0x04002343 RID: 9027
		private static IntPtr __SetOriginLocation_NativeFunctionPtr;

		// Token: 0x04002344 RID: 9028
		private static IntPtr __ResetModelQuat_NativeFunctionPtr;

		// Token: 0x04002345 RID: 9029
		private static IntPtr __ResetModelLocation_NativeFunctionPtr;

		// Token: 0x04002346 RID: 9030
		private static IntPtr __GetTransformOffsetInWorld_NativeFunctionPtr;

		// Token: 0x04002347 RID: 9031
		private static IntPtr __D_GetTransformOffsetInWorld_NativeFunctionPtr;

		// Token: 0x04002348 RID: 9032
		private static IntPtr __AddModelQuat_NativeFunctionPtr;

		// Token: 0x04002349 RID: 9033
		private static IntPtr __AddModelLocation_NativeFunctionPtr;

		// Token: 0x02000A3A RID: 2618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetOriginLocation_FunctionParams
		{
			// Token: 0x04005A18 RID: 23064
			[FieldOffset(0)]
			public FVector Location;
		}

		// Token: 0x02000A3B RID: 2619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __GetTransformOffsetInWorld_FunctionParams
		{
			// Token: 0x04005A19 RID: 23065
			[FieldOffset(0)]
			public FTransform Child;

			// Token: 0x04005A1A RID: 23066
			[FieldOffset(48)]
			public FTransform Parent;

			// Token: 0x04005A1B RID: 23067
			[FieldOffset(96)]
			public bool InUseLocalMode;
		}

		// Token: 0x02000A3C RID: 2620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __D_GetTransformOffsetInWorld_FunctionParams
		{
			// Token: 0x04005A1C RID: 23068
			[FieldOffset(0)]
			public FTransformDouble Child;

			// Token: 0x04005A1D RID: 23069
			[FieldOffset(64)]
			public FTransformDouble Parent;

			// Token: 0x04005A1E RID: 23070
			[FieldOffset(128)]
			public bool InUseLocalMode;
		}

		// Token: 0x02000A3D RID: 2621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __AddModelQuat_FunctionParams
		{
			// Token: 0x04005A1F RID: 23071
			[FieldOffset(0)]
			public FQuat Quat;

			// Token: 0x04005A20 RID: 23072
			[FieldOffset(16)]
			public bool LockCenter;
		}

		// Token: 0x02000A3E RID: 2622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AddModelLocation_FunctionParams
		{
			// Token: 0x04005A21 RID: 23073
			[FieldOffset(0)]
			public FVector Offset;
		}
	}
}
