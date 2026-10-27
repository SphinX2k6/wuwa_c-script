using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1A RID: 7706
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_RenderEntityMaterialInterface")]
	public interface IKSC_RenderEntityMaterialInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D65B RID: 120411
		int InterfaceOffset();

		// Token: 0x0601D65C RID: 120412 RVA: 0x002B69B8 File Offset: 0x002B4BB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveMaterial(in int EntityId, int HandleId)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_RemoveMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_RemoveMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D65D RID: 120413 RVA: 0x002B6A08 File Offset: 0x002B4C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_RemoveMaterial_Implementation(in int EntityId, int HandleId)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_RemoveMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_RemoveMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->HandleId = HandleId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_RemoveMaterial_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D65E RID: 120414 RVA: 0x002B6A58 File Offset: 0x002B4C58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_DelayAddMaterial(in int EntityId, float Delay, UKuroMaterialControllerDataAsset DataAsset)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_DelayAddMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Delay = Delay;
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_DelayAddMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D65F RID: 120415 RVA: 0x002B6ABC File Offset: 0x002B4CBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_DelayAddMaterial_Implementation(in int EntityId, float Delay, UKuroMaterialControllerDataAsset DataAsset)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_DelayAddMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_DelayAddMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Delay = Delay;
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_DelayAddMaterial_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D660 RID: 120416 RVA: 0x002B6B24 File Offset: 0x002B4D24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_ApplyBeHitMaterial(in int EntityId)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_ApplyBeHitMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_ApplyBeHitMaterial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D661 RID: 120417 RVA: 0x002B6B6C File Offset: 0x002B4D6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void KSC_ApplyBeHitMaterial_Implementation(in int EntityId)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_ApplyBeHitMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_ApplyBeHitMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_ApplyBeHitMaterial_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601D662 RID: 120418 RVA: 0x002B6BB4 File Offset: 0x002B4DB4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int KSC_AddMaterial(in int EntityId, UKuroMaterialControllerDataAsset DataAsset, bool bLoop)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_AddMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			ptr->bLoop = bLoop;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_AddMaterial_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601D663 RID: 120419 RVA: 0x002B6C20 File Offset: 0x002B4E20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int KSC_AddMaterial_Implementation(in int EntityId, UKuroMaterialControllerDataAsset DataAsset, bool bLoop)
		{
			IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams* ptr = stackalloc IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IKSC_RenderEntityMaterialInterface.__KSC_AddMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_AddMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->DataAsset = ((DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
			ptr->bLoop = bLoop;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKSC_RenderEntityMaterialInterface_ReflectionImplementationFields.__KSC_AddMaterial_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400FF0B RID: 65291
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_RenderEntityMaterialInterface";

		// Token: 0x020032A8 RID: 12968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __KSC_RemoveMaterial_FunctionParams
		{
			// Token: 0x04017143 RID: 94531
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017144 RID: 94532
			[FieldOffset(4)]
			public int HandleId;
		}

		// Token: 0x020032A9 RID: 12969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __KSC_DelayAddMaterial_FunctionParams
		{
			// Token: 0x04017145 RID: 94533
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04017146 RID: 94534
			[FieldOffset(4)]
			public float Delay;

			// Token: 0x04017147 RID: 94535
			[FieldOffset(8)]
			public IntPtr DataAsset;
		}

		// Token: 0x020032AA RID: 12970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __KSC_ApplyBeHitMaterial_FunctionParams
		{
			// Token: 0x04017148 RID: 94536
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020032AB RID: 12971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __KSC_AddMaterial_FunctionParams
		{
			// Token: 0x04017149 RID: 94537
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0401714A RID: 94538
			[FieldOffset(8)]
			public IntPtr DataAsset;

			// Token: 0x0401714B RID: 94539
			[FieldOffset(16)]
			public bool bLoop;

			// Token: 0x0401714C RID: 94540
			[FieldOffset(20)]
			public int __Result;
		}
	}
}
