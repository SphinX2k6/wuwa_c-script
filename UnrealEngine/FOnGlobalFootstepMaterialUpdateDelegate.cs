using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C19 RID: 7193
	public sealed class FOnGlobalFootstepMaterialUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBE6 RID: 113638 RVA: 0x0028D3F6 File Offset: 0x0028B5F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalFootstepMaterialUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601BBE7 RID: 113639 RVA: 0x0028D402 File Offset: 0x0028B602
		private static IntPtr StaticFunctionPtr()
		{
			if (AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature");
			}
			return AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601BBE8 RID: 113640 RVA: 0x0028D425 File Offset: 0x0028B625
		public FOnGlobalFootstepMaterialUpdateDelegate()
		{
		}

		// Token: 0x0601BBE9 RID: 113641 RVA: 0x0028D42D File Offset: 0x0028B62D
		[NullableContext(2)]
		public FOnGlobalFootstepMaterialUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBEA RID: 113642 RVA: 0x0028D437 File Offset: 0x0028B637
		public FOnGlobalFootstepMaterialUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBEB RID: 113643 RVA: 0x0028D442 File Offset: 0x0028B642
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UPhysicalMaterial>) ?? ((Action<UPhysicalMaterial>)Delegate.CreateDelegate(typeof(Action<UPhysicalMaterial>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBEC RID: 113644 RVA: 0x0028D474 File Offset: 0x0028B674
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPhysicalMaterial> Callback)
		{
			if (FOnGlobalFootstepMaterialUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGlobalFootstepMaterialUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGlobalFootstepMaterialUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGlobalFootstepMaterialUpdateDelegate.OnScriptCallback));
				}
				FOnGlobalFootstepMaterialUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnGlobalFootstepMaterialUpdateDelegate.RegisterId);
		}

		// Token: 0x0601BBED RID: 113645 RVA: 0x0028D4B0 File Offset: 0x0028B6B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UPhysicalMaterial Material)
		{
			FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams* ptr = stackalloc FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalFootstepMaterialUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601BBEE RID: 113646 RVA: 0x0028D4FC File Offset: 0x0028B6FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPhysicalMaterial> action = target as Action<UPhysicalMaterial>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPhysicalMaterial orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPhysicalMaterial>(((FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams*)__Parameters)->Material);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE9B RID: 61083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature";

		// Token: 0x0400EE9C RID: 61084
		private static int RegisterId;

		// Token: 0x0200319E RID: 12702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams
		{
			// Token: 0x04016FDC RID: 94172
			[FieldOffset(0)]
			public IntPtr Material;
		}

		// Token: 0x0200319F RID: 12703
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FDD RID: 94173
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
