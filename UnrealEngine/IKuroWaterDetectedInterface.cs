using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001879 RID: 6265
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroWaterDetectedInterface")]
	public interface IKuroWaterDetectedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06017126 RID: 94502
		int InterfaceOffset();

		// Token: 0x06017127 RID: 94503 RVA: 0x00219F5C File Offset: 0x0021815C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BroadcastWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams* ptr = stackalloc IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06017128 RID: 94504 RVA: 0x00219FB8 File Offset: 0x002181B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BroadcastWaterDetectedTick_Implementation(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams* ptr = stackalloc IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017129 RID: 94505 RVA: 0x0021A012 File Offset: 0x00218212
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BroadcastWaterDetectedStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601712A RID: 94506 RVA: 0x0021A026 File Offset: 0x00218226
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BroadcastWaterDetectedStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601712B RID: 94507 RVA: 0x0021A03B File Offset: 0x0021823B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BroadcastWaterDetectedEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0601712C RID: 94508 RVA: 0x0021A04F File Offset: 0x0021824F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BroadcastWaterDetectedEnd_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedEnd_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0400C853 RID: 51283
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.KuroWaterDetectedInterface";

		// Token: 0x02002F7F RID: 12159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BroadcastWaterDetectedTick_FunctionParams
		{
			// Token: 0x04016B3D RID: 92989
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016B3E RID: 92990
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x04016B3F RID: 92991
			[FieldOffset(8)]
			public FVectorDouble Location;
		}
	}
}
