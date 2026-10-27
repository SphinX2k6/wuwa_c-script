using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E19 RID: 7705
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RenderEntityInterface")]
	public interface IKSC_RenderEntityInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D64E RID: 120398
		int InterfaceOffset();

		// Token: 0x0601D64F RID: 120399 RVA: 0x002B65E8 File Offset: 0x002B47E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_UpdateEntity(float DeltaSeconds)
		{
			IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_UpdateEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_UpdateEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D650 RID: 120400 RVA: 0x002B6630 File Offset: 0x002B4830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_UpdateEntity_Implementation(float DeltaSeconds)
		{
			IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_UpdateEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_UpdateEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_UpdateEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D651 RID: 120401 RVA: 0x002B6678 File Offset: 0x002B4878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetActorTransform_AnyThread(in int EntityId, in FTransform InTransform)
		{
			IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_SetActorTransform_AnyThread_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_SetActorTransform_AnyThread_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D652 RID: 120402 RVA: 0x002B66CC File Offset: 0x002B48CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_SetActorTransform_AnyThread_Implementation(in int EntityId, in FTransform InTransform)
		{
			IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_SetActorTransform_AnyThread_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_SetActorTransform_AnyThread_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_SetActorTransform_AnyThread_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D653 RID: 120403 RVA: 0x002B6720 File Offset: 0x002B4920
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveEntity(in int EntityId)
		{
			IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D654 RID: 120404 RVA: 0x002B6768 File Offset: 0x002B4968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveEntity_Implementation(in int EntityId)
		{
			IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_RemoveEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D655 RID: 120405 RVA: 0x002B67B0 File Offset: 0x002B49B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_InitData(UKSC_DA_EntityRender DaEntityRender)
		{
			IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_InitData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DaEntityRender = ((DaEntityRender != null) ? DaEntityRender.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_InitData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D656 RID: 120406 RVA: 0x002B6808 File Offset: 0x002B4A08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_InitData_Implementation(UKSC_DA_EntityRender DaEntityRender)
		{
			IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_InitData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_InitData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DaEntityRender = ((DaEntityRender != null) ? DaEntityRender.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_InitData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D657 RID: 120407 RVA: 0x002B6860 File Offset: 0x002B4A60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_DelayRemoveEntity(in int EntityId, in float DelayTime)
		{
			IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_DelayRemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->DelayTime = DelayTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_DelayRemoveEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D658 RID: 120408 RVA: 0x002B68B0 File Offset: 0x002B4AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_DelayRemoveEntity_Implementation(in int EntityId, in float DelayTime)
		{
			IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_DelayRemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_DelayRemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->DelayTime = DelayTime;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_DelayRemoveEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x002B6900 File Offset: 0x002B4B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_AddEntity(in int EntityId, in FTransform InTransform, bool InIsPreview)
		{
			IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InTransform = InTransform;
			ptr->InIsPreview = InIsPreview;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D65A RID: 120410 RVA: 0x002B695C File Offset: 0x002B4B5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_AddEntity_Implementation(in int EntityId, in FTransform InTransform, bool InIsPreview)
		{
			IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams* ptr = stackalloc IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(IKSC_RenderEntityInterface.__KSC_AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->InTransform = InTransform;
			ptr->InIsPreview = InIsPreview;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityInterface_ReflectionImplementationFields.__KSC_AddEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0400FF0A RID: 65290
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RenderEntityInterface";

		// Token: 0x020032A2 RID: 12962
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_UpdateEntity_FunctionParams
		{
			// Token: 0x04017139 RID: 94521
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x020032A3 RID: 12963
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __KSC_SetActorTransform_AnyThread_FunctionParams
		{
			// Token: 0x0401713A RID: 94522
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0401713B RID: 94523
			[FieldOffset(16)]
			public FTransform InTransform;
		}

		// Token: 0x020032A4 RID: 12964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_RemoveEntity_FunctionParams
		{
			// Token: 0x0401713C RID: 94524
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020032A5 RID: 12965
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __KSC_InitData_FunctionParams
		{
			// Token: 0x0401713D RID: 94525
			[FieldOffset(0)]
			public IntPtr DaEntityRender;
		}

		// Token: 0x020032A6 RID: 12966
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __KSC_DelayRemoveEntity_FunctionParams
		{
			// Token: 0x0401713E RID: 94526
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0401713F RID: 94527
			[FieldOffset(4)]
			public float DelayTime;
		}

		// Token: 0x020032A7 RID: 12967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __KSC_AddEntity_FunctionParams
		{
			// Token: 0x04017140 RID: 94528
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017141 RID: 94529
			[FieldOffset(16)]
			public FTransform InTransform;

			// Token: 0x04017142 RID: 94530
			[FieldOffset(64)]
			public bool InIsPreview;
		}
	}
}
