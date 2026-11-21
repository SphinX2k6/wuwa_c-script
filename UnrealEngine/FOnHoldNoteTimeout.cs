using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050D RID: 1293
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldNoteTimeout : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600792C RID: 31020 RVA: 0x000B1B32 File Offset: 0x000AFD32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldNoteTimeout.StaticFunctionPtr();
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x000B1B3E File Offset: 0x000AFD3E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldNoteTimeout._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldNoteTimeout._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldNoteTimeout__DelegateSignature");
			}
			return FOnHoldNoteTimeout._FunctionPtr;
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x000B1B61 File Offset: 0x000AFD61
		public FOnHoldNoteTimeout()
		{
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x000B1B69 File Offset: 0x000AFD69
		[NullableContext(2)]
		public FOnHoldNoteTimeout(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x000B1B73 File Offset: 0x000AFD73
		public FOnHoldNoteTimeout(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x000B1B7E File Offset: 0x000AFD7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x000B1BB0 File Offset: 0x000AFDB0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnHoldNoteTimeout.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldNoteTimeout.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldNoteTimeout.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldNoteTimeout.OnScriptCallback));
				}
				FOnHoldNoteTimeout.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldNoteTimeout.RegisterId);
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x000B1BEA File Offset: 0x000AFDEA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x000B1BF3 File Offset: 0x000AFDF3
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x000B1C00 File Offset: 0x000AFE00
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

		// Token: 0x04003384 RID: 13188
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003385 RID: 13189
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldNoteTimeout__DelegateSignature";

		// Token: 0x04003386 RID: 13190
		private static int RegisterId;

		// Token: 0x02000C72 RID: 3186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ECD RID: 24269
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
