using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A3 RID: 931
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroWaterDetectedInterface")]
	public interface IKuroWaterDetectedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06005C30 RID: 23600
		int InterfaceOffset();

		// Token: 0x06005C31 RID: 23601 RVA: 0x00081E7C File Offset: 0x0008007C
		[SkipLocalsInit]
		unsafe void BroadcastWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams* ptr = stackalloc IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00081ED8 File Offset: 0x000800D8
		[SkipLocalsInit]
		unsafe void BroadcastWaterDetectedTick_Implementation(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams* ptr = stackalloc IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IKuroWaterDetectedInterface.__BroadcastWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00081F31 File Offset: 0x00080131
		[SkipLocalsInit]
		void BroadcastWaterDetectedStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00081F45 File Offset: 0x00080145
		[SkipLocalsInit]
		void BroadcastWaterDetectedStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00081F59 File Offset: 0x00080159
		[SkipLocalsInit]
		void BroadcastWaterDetectedEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00081F6D File Offset: 0x0008016D
		[SkipLocalsInit]
		void BroadcastWaterDetectedEnd_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroWaterDetectedInterface_ReflectionImplementationFields.__BroadcastWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0400266A RID: 9834
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayInterface.KuroWaterDetectedInterface";

		// Token: 0x02000AA4 RID: 2724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BroadcastWaterDetectedTick_FunctionParams
		{
			// Token: 0x04005AFC RID: 23292
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04005AFD RID: 23293
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x04005AFE RID: 23294
			[FieldOffset(8)]
			public FVectorDouble Location;
		}
	}
}
