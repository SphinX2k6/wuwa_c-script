using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029B5 RID: 10677
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnOpeningEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602779C RID: 161692 RVA: 0x003C3C46 File Offset: 0x003C1E46
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnOpeningEvent.StaticFunctionPtr();
		}

		// Token: 0x0602779D RID: 161693 RVA: 0x003C3C52 File Offset: 0x003C1E52
		private static IntPtr StaticFunctionPtr()
		{
			if (UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature");
			}
			return UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602779E RID: 161694 RVA: 0x003C3C75 File Offset: 0x003C1E75
		public FOnOpeningEvent()
		{
		}

		// Token: 0x0602779F RID: 161695 RVA: 0x003C3C7D File Offset: 0x003C1E7D
		[NullableContext(2)]
		public FOnOpeningEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277A0 RID: 161696 RVA: 0x003C3C87 File Offset: 0x003C1E87
		public FOnOpeningEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277A1 RID: 161697 RVA: 0x003C3C92 File Offset: 0x003C1E92
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277A2 RID: 161698 RVA: 0x003C3CC4 File Offset: 0x003C1EC4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnOpeningEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnOpeningEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnOpeningEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnOpeningEvent.OnScriptCallback));
				}
				FOnOpeningEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnOpeningEvent.RegisterId);
		}

		// Token: 0x060277A3 RID: 161699 RVA: 0x003C3CFE File Offset: 0x003C1EFE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277A4 RID: 161700 RVA: 0x003C3D07 File Offset: 0x003C1F07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060277A5 RID: 161701 RVA: 0x003C3D14 File Offset: 0x003C1F14
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

		// Token: 0x04015A79 RID: 88697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature";

		// Token: 0x04015A7A RID: 88698
		private static int RegisterId;

		// Token: 0x02003BBF RID: 15295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DA4 RID: 97700
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
