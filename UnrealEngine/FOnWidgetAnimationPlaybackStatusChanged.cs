using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029BD RID: 10685
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnWidgetAnimationPlaybackStatusChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277EB RID: 161771 RVA: 0x003C471A File Offset: 0x003C291A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWidgetAnimationPlaybackStatusChanged.StaticFunctionPtr();
		}

		// Token: 0x060277EC RID: 161772 RVA: 0x003C4726 File Offset: 0x003C2926
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWidgetAnimationPlaybackStatusChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnWidgetAnimationPlaybackStatusChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature");
			}
			return FOnWidgetAnimationPlaybackStatusChanged._FunctionPtr;
		}

		// Token: 0x060277ED RID: 161773 RVA: 0x003C4749 File Offset: 0x003C2949
		public FOnWidgetAnimationPlaybackStatusChanged()
		{
		}

		// Token: 0x060277EE RID: 161774 RVA: 0x003C4751 File Offset: 0x003C2951
		[NullableContext(2)]
		public FOnWidgetAnimationPlaybackStatusChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277EF RID: 161775 RVA: 0x003C475B File Offset: 0x003C295B
		public FOnWidgetAnimationPlaybackStatusChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277F0 RID: 161776 RVA: 0x003C4766 File Offset: 0x003C2966
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277F1 RID: 161777 RVA: 0x003C4798 File Offset: 0x003C2998
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnWidgetAnimationPlaybackStatusChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWidgetAnimationPlaybackStatusChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWidgetAnimationPlaybackStatusChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWidgetAnimationPlaybackStatusChanged.OnScriptCallback));
				}
				FOnWidgetAnimationPlaybackStatusChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnWidgetAnimationPlaybackStatusChanged.RegisterId);
		}

		// Token: 0x060277F2 RID: 161778 RVA: 0x003C47D2 File Offset: 0x003C29D2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277F3 RID: 161779 RVA: 0x003C47DB File Offset: 0x003C29DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060277F4 RID: 161780 RVA: 0x003C47E8 File Offset: 0x003C29E8
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

		// Token: 0x04015A8B RID: 88715
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A8C RID: 88716
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnWidgetAnimationPlaybackStatusChanged__DelegateSignature";

		// Token: 0x04015A8D RID: 88717
		private static int RegisterId;

		// Token: 0x02003BCD RID: 15309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DB6 RID: 97718
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
