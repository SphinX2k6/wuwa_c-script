using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050C RID: 1292
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldNoteInputReleased : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007922 RID: 31010 RVA: 0x000B1A24 File Offset: 0x000AFC24
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldNoteInputReleased.StaticFunctionPtr();
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x000B1A30 File Offset: 0x000AFC30
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldNoteInputReleased._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldNoteInputReleased._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldNoteInputReleased__DelegateSignature");
			}
			return FOnHoldNoteInputReleased._FunctionPtr;
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x000B1A53 File Offset: 0x000AFC53
		public FOnHoldNoteInputReleased()
		{
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x000B1A5B File Offset: 0x000AFC5B
		[NullableContext(2)]
		public FOnHoldNoteInputReleased(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x000B1A65 File Offset: 0x000AFC65
		public FOnHoldNoteInputReleased(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x000B1A70 File Offset: 0x000AFC70
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x000B1AA2 File Offset: 0x000AFCA2
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnHoldNoteInputReleased.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldNoteInputReleased.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldNoteInputReleased.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldNoteInputReleased.OnScriptCallback));
				}
				FOnHoldNoteInputReleased.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldNoteInputReleased.RegisterId);
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x000B1ADC File Offset: 0x000AFCDC
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x000B1AE5 File Offset: 0x000AFCE5
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x000B1AF0 File Offset: 0x000AFCF0
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

		// Token: 0x04003381 RID: 13185
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003382 RID: 13186
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldNoteInputReleased__DelegateSignature";

		// Token: 0x04003383 RID: 13187
		private static int RegisterId;

		// Token: 0x02000C71 RID: 3185
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ECC RID: 24268
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
