using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E18 RID: 7704
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RenderEntityHeadUIInterface")]
	public interface IKSC_RenderEntityHeadUIInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D645 RID: 120389
		int InterfaceOffset();

		// Token: 0x0601D646 RID: 120390 RVA: 0x002B6368 File Offset: 0x002B4568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetHP(in int EntityId, float Percent)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetHP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Percent = Percent;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetHP_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D647 RID: 120391 RVA: 0x002B63B8 File Offset: 0x002B45B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetHP_Implementation(in int EntityId, float Percent)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_SetHP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetHP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Percent = Percent;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetHP_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D648 RID: 120392 RVA: 0x002B6408 File Offset: 0x002B4608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetActorLocation(in int EntityId, in FVector InLocation)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetActorLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InLocation = InLocation;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetActorLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D649 RID: 120393 RVA: 0x002B645C File Offset: 0x002B465C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetActorLocation_Implementation(in int EntityId, in FVector InLocation)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_SetActorLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetActorLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InLocation = InLocation;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_SetActorLocation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D64A RID: 120394 RVA: 0x002B64B0 File Offset: 0x002B46B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveEntity(in int EntityId)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D64B RID: 120395 RVA: 0x002B64F8 File Offset: 0x002B46F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveEntity_Implementation(in int EntityId)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D64C RID: 120396 RVA: 0x002B6540 File Offset: 0x002B4740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_AddEntity(in int EntityId, in FVector InLocation)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InLocation = InLocation;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D64D RID: 120397 RVA: 0x002B6594 File Offset: 0x002B4794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_AddEntity_Implementation(in int EntityId, in FVector InLocation)
		{
			IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityHeadUIInterface.__KSC_AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InLocation = InLocation;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityHeadUIInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0400FF09 RID: 65289
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RenderEntityHeadUIInterface";

		// Token: 0x0200329E RID: 12958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __KSC_SetHP_FunctionParams
		{
			// Token: 0x04017132 RID: 94514
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017133 RID: 94515
			[FieldOffset(4)]
			public float Percent;
		}

		// Token: 0x0200329F RID: 12959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __KSC_SetActorLocation_FunctionParams
		{
			// Token: 0x04017134 RID: 94516
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017135 RID: 94517
			[FieldOffset(4)]
			public FVector InLocation;
		}

		// Token: 0x020032A0 RID: 12960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_RemoveEntity_FunctionParams
		{
			// Token: 0x04017136 RID: 94518
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020032A1 RID: 12961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __KSC_AddEntity_FunctionParams
		{
			// Token: 0x04017137 RID: 94519
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017138 RID: 94520
			[FieldOffset(4)]
			public FVector InLocation;
		}
	}
}
