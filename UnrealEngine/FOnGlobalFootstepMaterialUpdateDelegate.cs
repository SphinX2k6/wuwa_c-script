using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F3 RID: 1267
	public sealed class FOnGlobalFootstepMaterialUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007736 RID: 30518 RVA: 0x000AE3D2 File Offset: 0x000AC5D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalFootstepMaterialUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x000AE3DE File Offset: 0x000AC5DE
		private static IntPtr StaticFunctionPtr()
		{
			if (AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature");
			}
			return AKuroGlobalGI.__OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x000AE401 File Offset: 0x000AC601
		public FOnGlobalFootstepMaterialUpdateDelegate()
		{
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x000AE409 File Offset: 0x000AC609
		[NullableContext(2)]
		public FOnGlobalFootstepMaterialUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x000AE413 File Offset: 0x000AC613
		public FOnGlobalFootstepMaterialUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x000AE41E File Offset: 0x000AC61E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UPhysicalMaterial>) ?? ((Action<UPhysicalMaterial>)Delegate.CreateDelegate(typeof(Action<UPhysicalMaterial>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x000AE450 File Offset: 0x000AC650
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

		// Token: 0x0600773D RID: 30525 RVA: 0x000AE48C File Offset: 0x000AC68C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UPhysicalMaterial Material)
		{
			FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams* ptr = stackalloc FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnGlobalFootstepMaterialUpdateDelegate.__FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalFootstepMaterialUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003240 RID: 12864
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnGlobalFootstepMaterialUpdateDelegate__DelegateSignature";

		// Token: 0x04003241 RID: 12865
		private static int RegisterId;

		// Token: 0x02000C34 RID: 3124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnGlobalFootstepMaterialUpdateDelegate_DelegateParams
		{
			// Token: 0x04005E81 RID: 24193
			[FieldOffset(0)]
			public IntPtr Material;
		}

		// Token: 0x02000C35 RID: 3125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E82 RID: 24194
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
