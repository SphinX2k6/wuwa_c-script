using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002994 RID: 10644
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnButtonHoverEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027655 RID: 161365 RVA: 0x003C1062 File Offset: 0x003BF262
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnButtonHoverEvent.StaticFunctionPtr();
		}

		// Token: 0x06027656 RID: 161366 RVA: 0x003C106E File Offset: 0x003BF26E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnButtonHoverEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnButtonHoverEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnButtonHoverEvent__DelegateSignature");
			}
			return FOnButtonHoverEvent._FunctionPtr;
		}

		// Token: 0x06027657 RID: 161367 RVA: 0x003C1091 File Offset: 0x003BF291
		public FOnButtonHoverEvent()
		{
		}

		// Token: 0x06027658 RID: 161368 RVA: 0x003C1099 File Offset: 0x003BF299
		[NullableContext(2)]
		public FOnButtonHoverEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027659 RID: 161369 RVA: 0x003C10A3 File Offset: 0x003BF2A3
		public FOnButtonHoverEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602765A RID: 161370 RVA: 0x003C10AE File Offset: 0x003BF2AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602765B RID: 161371 RVA: 0x003C10E0 File Offset: 0x003BF2E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnButtonHoverEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnButtonHoverEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnButtonHoverEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnButtonHoverEvent.OnScriptCallback));
				}
				FOnButtonHoverEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnButtonHoverEvent.RegisterId);
		}

		// Token: 0x0602765C RID: 161372 RVA: 0x003C111A File Offset: 0x003BF31A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602765D RID: 161373 RVA: 0x003C1123 File Offset: 0x003BF323
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602765E RID: 161374 RVA: 0x003C1130 File Offset: 0x003BF330
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

		// Token: 0x04015A21 RID: 88609
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A22 RID: 88610
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnButtonHoverEvent__DelegateSignature";

		// Token: 0x04015A23 RID: 88611
		private static int RegisterId;

		// Token: 0x02003B86 RID: 15238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D60 RID: 97632
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
