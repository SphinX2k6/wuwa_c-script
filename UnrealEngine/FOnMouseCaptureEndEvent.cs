using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029B0 RID: 10672
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMouseCaptureEndEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602776A RID: 161642 RVA: 0x003C3546 File Offset: 0x003C1746
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMouseCaptureEndEvent.StaticFunctionPtr();
		}

		// Token: 0x0602776B RID: 161643 RVA: 0x003C3552 File Offset: 0x003C1752
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMouseCaptureEndEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMouseCaptureEndEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature");
			}
			return FOnMouseCaptureEndEvent._FunctionPtr;
		}

		// Token: 0x0602776C RID: 161644 RVA: 0x003C3575 File Offset: 0x003C1775
		public FOnMouseCaptureEndEvent()
		{
		}

		// Token: 0x0602776D RID: 161645 RVA: 0x003C357D File Offset: 0x003C177D
		[NullableContext(2)]
		public FOnMouseCaptureEndEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602776E RID: 161646 RVA: 0x003C3587 File Offset: 0x003C1787
		public FOnMouseCaptureEndEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602776F RID: 161647 RVA: 0x003C3592 File Offset: 0x003C1792
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027770 RID: 161648 RVA: 0x003C35C4 File Offset: 0x003C17C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnMouseCaptureEndEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMouseCaptureEndEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMouseCaptureEndEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMouseCaptureEndEvent.OnScriptCallback));
				}
				FOnMouseCaptureEndEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMouseCaptureEndEvent.RegisterId);
		}

		// Token: 0x06027771 RID: 161649 RVA: 0x003C35FE File Offset: 0x003C17FE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027772 RID: 161650 RVA: 0x003C3607 File Offset: 0x003C1807
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027773 RID: 161651 RVA: 0x003C3614 File Offset: 0x003C1814
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

		// Token: 0x04015A6E RID: 88686
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A6F RID: 88687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnMouseCaptureEndEvent__DelegateSignature";

		// Token: 0x04015A70 RID: 88688
		private static int RegisterId;

		// Token: 0x02003BB6 RID: 15286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D99 RID: 97689
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
