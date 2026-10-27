using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002074 RID: 8308
	public sealed class FLGUIExtendToggleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F583 RID: 128387 RVA: 0x002E8D18 File Offset: 0x002E6F18
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F584 RID: 128388 RVA: 0x002E8D24 File Offset: 0x002E6F24
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleDynamicDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F585 RID: 128389 RVA: 0x002E8D47 File Offset: 0x002E6F47
		public FLGUIExtendToggleDynamicDelegate()
		{
		}

		// Token: 0x0601F586 RID: 128390 RVA: 0x002E8D4F File Offset: 0x002E6F4F
		[NullableContext(2)]
		public FLGUIExtendToggleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F587 RID: 128391 RVA: 0x002E8D59 File Offset: 0x002E6F59
		public FLGUIExtendToggleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F588 RID: 128392 RVA: 0x002E8D64 File Offset: 0x002E6F64
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleState>) ?? ((Action<EToggleState>)Delegate.CreateDelegate(typeof(Action<EToggleState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F589 RID: 128393 RVA: 0x002E8D96 File Offset: 0x002E6F96
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<EToggleState> Callback)
		{
			if (FLGUIExtendToggleDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleDynamicDelegate.OnScriptCallback));
				}
				FLGUIExtendToggleDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F58A RID: 128394 RVA: 0x002E8DD0 File Offset: 0x002E6FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EToggleState State)
		{
			FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F58B RID: 128395 RVA: 0x002E8E10 File Offset: 0x002E7010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState> action = target as Action<EToggleState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x04010F02 RID: 69378
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F03 RID: 69379
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleDynamicDelegate__DelegateSignature";

		// Token: 0x04010F04 RID: 69380
		private static int RegisterId;

		// Token: 0x02003478 RID: 13432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIExtendToggleDynamicDelegate_DelegateParams
		{
			// Token: 0x04017461 RID: 95329
			[FieldOffset(0)]
			public EToggleState State;
		}

		// Token: 0x02003479 RID: 13433
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017462 RID: 95330
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
