using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200086B RID: 2155
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnOpeningEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB24 RID: 47908 RVA: 0x0012BBB3 File Offset: 0x00129DB3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnOpeningEvent.StaticFunctionPtr();
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x0012BBBF File Offset: 0x00129DBF
		private static IntPtr StaticFunctionPtr()
		{
			if (UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature");
			}
			return UComboBoxString.__OnOpeningEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x0012BBE2 File Offset: 0x00129DE2
		public FOnOpeningEvent()
		{
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x0012BBEA File Offset: 0x00129DEA
		[NullableContext(2)]
		public FOnOpeningEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x0012BBF4 File Offset: 0x00129DF4
		public FOnOpeningEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x0012BBFF File Offset: 0x00129DFF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x0012BC31 File Offset: 0x00129E31
		[NullableContext(1)]
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

		// Token: 0x0600BB2B RID: 47915 RVA: 0x0012BC6B File Offset: 0x00129E6B
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x0012BC74 File Offset: 0x00129E74
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x0012BC80 File Offset: 0x00129E80
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040054CB RID: 21707
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.ComboBoxString:OnOpeningEvent__DelegateSignature";

		// Token: 0x040054CC RID: 21708
		private static int RegisterId;

		// Token: 0x0200140B RID: 5131
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068B9 RID: 26809
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
