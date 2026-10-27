using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200207E RID: 8318
	public sealed class FLGUIHitDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F621 RID: 128545 RVA: 0x002E9B98 File Offset: 0x002E7D98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIHitDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F622 RID: 128546 RVA: 0x002E9BA4 File Offset: 0x002E7DA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIHitDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIHitDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIHitDynamicDelegate__DelegateSignature");
			}
			return FLGUIHitDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F623 RID: 128547 RVA: 0x002E9BC7 File Offset: 0x002E7DC7
		public FLGUIHitDynamicDelegate()
		{
		}

		// Token: 0x0601F624 RID: 128548 RVA: 0x002E9BCF File Offset: 0x002E7DCF
		[NullableContext(2)]
		public FLGUIHitDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F625 RID: 128549 RVA: 0x002E9BD9 File Offset: 0x002E7DD9
		public FLGUIHitDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F626 RID: 128550 RVA: 0x002E9BE4 File Offset: 0x002E7DE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, FHitResult, USceneComponent>) ?? ((Action<bool, FHitResult, USceneComponent>)Delegate.CreateDelegate(typeof(Action<bool, FHitResult, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F627 RID: 128551 RVA: 0x002E9C16 File Offset: 0x002E7E16
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F628 RID: 128552 RVA: 0x002E9C50 File Offset: 0x002E7E50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F629 RID: 128553 RVA: 0x002E9CCC File Offset: 0x002E7ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010F42 RID: 69442
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F43 RID: 69443
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIHitDynamicDelegate__DelegateSignature";

		// Token: 0x04010F44 RID: 69444
		private static int RegisterId;

		// Token: 0x02003481 RID: 13441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __FLGUIHitDynamicDelegate_DelegateParams
		{
			// Token: 0x0401746D RID: 95341
			[FieldOffset(0)]
			public bool isHit;

			// Token: 0x0401746E RID: 95342
			[FieldOffset(4)]
			public byte hitResult;

			// Token: 0x0401746F RID: 95343
			[FieldOffset(152)]
			public IntPtr hitComponent;
		}

		// Token: 0x02003482 RID: 13442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017470 RID: 95344
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
