using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E17 RID: 7703
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RenderEntityAnimInterface")]
	public interface IKSC_RenderEntityAnimInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D63E RID: 120382
		int InterfaceOffset();

		// Token: 0x0601D63F RID: 120383 RVA: 0x002B61A8 File Offset: 0x002B43A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_UpdateAnimState(in int EntityId, in EKSC_GPUNPCAnimState EnemyState)
		{
			IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_UpdateAnimState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->EnemyState = (EKSC_GPUNPCAnimState)EnemyState;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_UpdateAnimState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D640 RID: 120384 RVA: 0x002B61F8 File Offset: 0x002B43F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_UpdateAnimState_Implementation(in int EntityId, in EKSC_GPUNPCAnimState EnemyState)
		{
			IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_UpdateAnimState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_UpdateAnimState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->EnemyState = (EKSC_GPUNPCAnimState)EnemyState;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_UpdateAnimState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D641 RID: 120385 RVA: 0x002B6248 File Offset: 0x002B4448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_ResumeAnim(in int EntityId)
		{
			IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_ResumeAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_ResumeAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D642 RID: 120386 RVA: 0x002B6290 File Offset: 0x002B4490
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_ResumeAnim_Implementation(in int EntityId)
		{
			IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_ResumeAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_ResumeAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_ResumeAnim_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D643 RID: 120387 RVA: 0x002B62D8 File Offset: 0x002B44D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_PauseAnim(in int EntityId)
		{
			IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_PauseAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_PauseAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D644 RID: 120388 RVA: 0x002B6320 File Offset: 0x002B4520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_PauseAnim_Implementation(in int EntityId)
		{
			IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams* ptr = stackalloc IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityAnimInterface.__KSC_PauseAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_PauseAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityAnimInterface_ReflectionImplementationFields.__KSC_PauseAnim_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0400FF08 RID: 65288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RenderEntityAnimInterface";

		// Token: 0x0200329B RID: 12955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __KSC_UpdateAnimState_FunctionParams
		{
			// Token: 0x0401712E RID: 94510
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0401712F RID: 94511
			[FieldOffset(4)]
			public EKSC_GPUNPCAnimState EnemyState;
		}

		// Token: 0x0200329C RID: 12956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_ResumeAnim_FunctionParams
		{
			// Token: 0x04017130 RID: 94512
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x0200329D RID: 12957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_PauseAnim_FunctionParams
		{
			// Token: 0x04017131 RID: 94513
			[FieldOffset(0)]
			public int EntityId;
		}
	}
}
