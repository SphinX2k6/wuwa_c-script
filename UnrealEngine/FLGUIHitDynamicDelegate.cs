using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200069D RID: 1693
	public sealed class FLGUIHitDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060091EB RID: 37355 RVA: 0x000DB8C5 File Offset: 0x000D9AC5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIHitDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x000DB8D1 File Offset: 0x000D9AD1
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIHitDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIHitDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIHitDynamicDelegate__DelegateSignature");
			}
			return FLGUIHitDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x000DB8F4 File Offset: 0x000D9AF4
		public FLGUIHitDynamicDelegate()
		{
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x000DB8FC File Offset: 0x000D9AFC
		[NullableContext(2)]
		public FLGUIHitDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x000DB906 File Offset: 0x000D9B06
		public FLGUIHitDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x000DB911 File Offset: 0x000D9B11
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, FHitResult, USceneComponent>) ?? ((Action<bool, FHitResult, USceneComponent>)Delegate.CreateDelegate(typeof(Action<bool, FHitResult, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x000DB943 File Offset: 0x000D9B43
		public void Bind([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<bool, FHitResult, USceneComponent> Callback)
		{
			if (FLGUIHitDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIHitDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIHitDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIHitDynamicDelegate.OnScriptCallback));
				}
				FLGUIHitDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIHitDynamicDelegate.RegisterId);
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x000DB980 File Offset: 0x000D9B80
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(bool isHit, in FHitResult hitResult, USceneComponent hitComponent)
		{
			FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams[(UIntPtr)175] + 15L / (long)sizeof(FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIHitDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->isHit = isHit;
			if (hitResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->hitResult, hitResult.NativePtr, 1, false);
			}
			ptr->hitComponent = ((hitComponent != null) ? hitComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x000DB9FC File Offset: 0x000D9BFC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, FHitResult, USceneComponent> action = target as Action<bool, FHitResult, USceneComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FHitResult arg = new FHitResult(&((FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams*)__Parameters)->hitResult, true, true);
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams*)__Parameters)->hitComponent);
			action(((FLGUIHitDynamicDelegate.__FLGUIHitDynamicDelegate_DelegateParams*)__Parameters)->isHit, arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003F98 RID: 16280
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F99 RID: 16281
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIHitDynamicDelegate__DelegateSignature";

		// Token: 0x04003F9A RID: 16282
		private static int RegisterId;

		// Token: 0x02000EC4 RID: 3780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		private ref struct __FLGUIHitDynamicDelegate_DelegateParams
		{
			// Token: 0x0400627C RID: 25212
			[FieldOffset(0)]
			public bool isHit;

			// Token: 0x0400627D RID: 25213
			[FieldOffset(4)]
			public byte hitResult;

			// Token: 0x0400627E RID: 25214
			[FieldOffset(152)]
			public IntPtr hitComponent;
		}

		// Token: 0x02000EC5 RID: 3781
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400627F RID: 25215
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
