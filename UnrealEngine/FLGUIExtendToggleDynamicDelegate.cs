using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000696 RID: 1686
	public sealed class FLGUIExtendToggleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009180 RID: 37248 RVA: 0x000DAE40 File Offset: 0x000D9040
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x000DAE4C File Offset: 0x000D904C
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleDynamicDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x000DAE6F File Offset: 0x000D906F
		public FLGUIExtendToggleDynamicDelegate()
		{
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x000DAE77 File Offset: 0x000D9077
		[NullableContext(2)]
		public FLGUIExtendToggleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x000DAE81 File Offset: 0x000D9081
		public FLGUIExtendToggleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x000DAE8C File Offset: 0x000D908C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleState>) ?? ((Action<EToggleState>)Delegate.CreateDelegate(typeof(Action<EToggleState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x000DAEBE File Offset: 0x000D90BE
		[NullableContext(1)]
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

		// Token: 0x06009187 RID: 37255 RVA: 0x000DAEF8 File Offset: 0x000D90F8
		[SkipLocalsInit]
		public unsafe void Execute(EToggleState State)
		{
			FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x000DAF38 File Offset: 0x000D9138
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleState> action = target as Action<EToggleState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIExtendToggleDynamicDelegate.__FLGUIExtendToggleDynamicDelegate_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x04003F6F RID: 16239
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F70 RID: 16240
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleDynamicDelegate__DelegateSignature";

		// Token: 0x04003F71 RID: 16241
		private static int RegisterId;

		// Token: 0x02000EBB RID: 3771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIExtendToggleDynamicDelegate_DelegateParams
		{
			// Token: 0x04006270 RID: 25200
			[FieldOffset(0)]
			public EToggleState State;
		}

		// Token: 0x02000EBC RID: 3772
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006271 RID: 25201
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
