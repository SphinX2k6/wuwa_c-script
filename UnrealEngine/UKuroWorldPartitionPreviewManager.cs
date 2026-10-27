using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE8 RID: 7144
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldPartitionPreviewManager")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UKuroWorldPartitionPreviewManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B7B9 RID: 112569 RVA: 0x002877FB File Offset: 0x002859FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldPartitionPreviewManager._ClassPtr;
		}

		// Token: 0x0601B7BA RID: 112570 RVA: 0x00287808 File Offset: 0x00285A08
		public UKuroWorldPartitionPreviewManager() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldPartitionPreviewManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B7BB RID: 112571 RVA: 0x00287830 File Offset: 0x00285A30
		[NullableContext(1)]
		public UKuroWorldPartitionPreviewManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldPartitionPreviewManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B7BC RID: 112572 RVA: 0x00287864 File Offset: 0x00285A64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPreviewMobile(bool PreviewMobile)
		{
			UKuroWorldPartitionPreviewManager.__SetPreviewMobile_FunctionParams* ptr = stackalloc UKuroWorldPartitionPreviewManager.__SetPreviewMobile_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroWorldPartitionPreviewManager.__SetPreviewMobile_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroWorldPartitionPreviewManager.__SetPreviewMobile_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PreviewMobile = PreviewMobile;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroWorldPartitionPreviewManager.__SetPreviewMobile_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B7BD RID: 112573 RVA: 0x002878AC File Offset: 0x00285AAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void RemovePreviewActorType([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class)
		{
			UKuroWorldPartitionPreviewManager.__RemovePreviewActorType_FunctionParams* ptr = stackalloc UKuroWorldPartitionPreviewManager.__RemovePreviewActorType_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroWorldPartitionPreviewManager.__RemovePreviewActorType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroWorldPartitionPreviewManager.__RemovePreviewActorType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroWorldPartitionPreviewManager.__RemovePreviewActorType_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B7BE RID: 112574 RVA: 0x002878F4 File Offset: 0x00285AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddPreviewActorType([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class)
		{
			UKuroWorldPartitionPreviewManager.__AddPreviewActorType_FunctionParams* ptr = stackalloc UKuroWorldPartitionPreviewManager.__AddPreviewActorType_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroWorldPartitionPreviewManager.__AddPreviewActorType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroWorldPartitionPreviewManager.__AddPreviewActorType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroWorldPartitionPreviewManager.__AddPreviewActorType_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B7BF RID: 112575 RVA: 0x0028793B File Offset: 0x00285B3B
		static UKuroWorldPartitionPreviewManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldPartitionPreviewManager");
		}

		// Token: 0x0601B7C0 RID: 112576 RVA: 0x00287949 File Offset: 0x00285B49
		protected UKuroWorldPartitionPreviewManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC96 RID: 60566
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldPartitionPreviewManager";

		// Token: 0x0400EC97 RID: 60567
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC98 RID: 60568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC99 RID: 60569
		private static IntPtr __SetPreviewMobile_NativeFunctionPtr;

		// Token: 0x0400EC9A RID: 60570
		private static IntPtr __RemovePreviewActorType_NativeFunctionPtr;

		// Token: 0x0400EC9B RID: 60571
		private static IntPtr __AddPreviewActorType_NativeFunctionPtr;

		// Token: 0x02003188 RID: 12680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPreviewMobile_FunctionParams
		{
			// Token: 0x04016FC6 RID: 94150
			[FieldOffset(0)]
			public bool PreviewMobile;
		}

		// Token: 0x02003189 RID: 12681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemovePreviewActorType_FunctionParams
		{
			// Token: 0x04016FC7 RID: 94151
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<AActor> Class;
		}

		// Token: 0x0200318A RID: 12682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AddPreviewActorType_FunctionParams
		{
			// Token: 0x04016FC8 RID: 94152
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<AActor> Class;
		}
	}
}
