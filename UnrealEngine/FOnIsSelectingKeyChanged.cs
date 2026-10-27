using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029A5 RID: 10661
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIsSelectingKeyChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276FC RID: 161532 RVA: 0x003C2652 File Offset: 0x003C0852
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIsSelectingKeyChanged.StaticFunctionPtr();
		}

		// Token: 0x060276FD RID: 161533 RVA: 0x003C265E File Offset: 0x003C085E
		private static IntPtr StaticFunctionPtr()
		{
			if (UInputKeySelector.__OnIsSelectingKeyChanged__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInputKeySelector.__OnIsSelectingKeyChanged__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature");
			}
			return UInputKeySelector.__OnIsSelectingKeyChanged__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060276FE RID: 161534 RVA: 0x003C2681 File Offset: 0x003C0881
		public FOnIsSelectingKeyChanged()
		{
		}

		// Token: 0x060276FF RID: 161535 RVA: 0x003C2689 File Offset: 0x003C0889
		[NullableContext(2)]
		public FOnIsSelectingKeyChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027700 RID: 161536 RVA: 0x003C2693 File Offset: 0x003C0893
		public FOnIsSelectingKeyChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027701 RID: 161537 RVA: 0x003C269E File Offset: 0x003C089E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027702 RID: 161538 RVA: 0x003C26D0 File Offset: 0x003C08D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnIsSelectingKeyChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIsSelectingKeyChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIsSelectingKeyChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIsSelectingKeyChanged.OnScriptCallback));
				}
				FOnIsSelectingKeyChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIsSelectingKeyChanged.RegisterId);
		}

		// Token: 0x06027703 RID: 161539 RVA: 0x003C270A File Offset: 0x003C090A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027704 RID: 161540 RVA: 0x003C2713 File Offset: 0x003C0913
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027705 RID: 161541 RVA: 0x003C2720 File Offset: 0x003C0920
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04015A4F RID: 88655
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.InputKeySelector:OnIsSelectingKeyChanged__DelegateSignature";

		// Token: 0x04015A50 RID: 88656
		private static int RegisterId;

		// Token: 0x02003BA2 RID: 15266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D80 RID: 97664
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
