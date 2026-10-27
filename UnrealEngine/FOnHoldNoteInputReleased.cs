using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C66 RID: 7270
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldNoteInputReleased : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C326 RID: 115494 RVA: 0x0029904C File Offset: 0x0029724C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldNoteInputReleased.StaticFunctionPtr();
		}

		// Token: 0x0601C327 RID: 115495 RVA: 0x00299058 File Offset: 0x00297258
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldNoteInputReleased._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldNoteInputReleased._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldNoteInputReleased__DelegateSignature");
			}
			return FOnHoldNoteInputReleased._FunctionPtr;
		}

		// Token: 0x0601C328 RID: 115496 RVA: 0x0029907B File Offset: 0x0029727B
		public FOnHoldNoteInputReleased()
		{
		}

		// Token: 0x0601C329 RID: 115497 RVA: 0x00299083 File Offset: 0x00297283
		[NullableContext(2)]
		public FOnHoldNoteInputReleased(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x0029908D File Offset: 0x0029728D
		public FOnHoldNoteInputReleased(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x00299098 File Offset: 0x00297298
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C32C RID: 115500 RVA: 0x002990CA File Offset: 0x002972CA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C32D RID: 115501 RVA: 0x00299104 File Offset: 0x00297304
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C32E RID: 115502 RVA: 0x0029910D File Offset: 0x0029730D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C32F RID: 115503 RVA: 0x00299118 File Offset: 0x00297318
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

		// Token: 0x0400F2B6 RID: 62134
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2B7 RID: 62135
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldNoteInputReleased__DelegateSignature";

		// Token: 0x0400F2B8 RID: 62136
		private static int RegisterId;

		// Token: 0x020031FC RID: 12796
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017058 RID: 94296
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
