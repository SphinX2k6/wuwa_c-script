using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C67 RID: 7271
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldNoteTimeout : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C330 RID: 115504 RVA: 0x0029915A File Offset: 0x0029735A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldNoteTimeout.StaticFunctionPtr();
		}

		// Token: 0x0601C331 RID: 115505 RVA: 0x00299166 File Offset: 0x00297366
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldNoteTimeout._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldNoteTimeout._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldNoteTimeout__DelegateSignature");
			}
			return FOnHoldNoteTimeout._FunctionPtr;
		}

		// Token: 0x0601C332 RID: 115506 RVA: 0x00299189 File Offset: 0x00297389
		public FOnHoldNoteTimeout()
		{
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x00299191 File Offset: 0x00297391
		[NullableContext(2)]
		public FOnHoldNoteTimeout(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C334 RID: 115508 RVA: 0x0029919B File Offset: 0x0029739B
		public FOnHoldNoteTimeout(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C335 RID: 115509 RVA: 0x002991A6 File Offset: 0x002973A6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C336 RID: 115510 RVA: 0x002991D8 File Offset: 0x002973D8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C337 RID: 115511 RVA: 0x00299212 File Offset: 0x00297412
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C338 RID: 115512 RVA: 0x0029921B File Offset: 0x0029741B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C339 RID: 115513 RVA: 0x00299228 File Offset: 0x00297428
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

		// Token: 0x0400F2B9 RID: 62137
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2BA RID: 62138
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldNoteTimeout__DelegateSignature";

		// Token: 0x0400F2BB RID: 62139
		private static int RegisterId;

		// Token: 0x020031FD RID: 12797
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017059 RID: 94297
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
