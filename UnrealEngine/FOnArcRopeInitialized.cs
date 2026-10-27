using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C74 RID: 7284
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnArcRopeInitialized : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C427 RID: 115751 RVA: 0x0029A7D8 File Offset: 0x002989D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnArcRopeInitialized.StaticFunctionPtr();
		}

		// Token: 0x0601C428 RID: 115752 RVA: 0x0029A7E4 File Offset: 0x002989E4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnArcRopeInitialized._FunctionPtr == IntPtr.Zero)
			{
				FOnArcRopeInitialized._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRopeEffect.OnArcRopeInitialized__DelegateSignature");
			}
			return FOnArcRopeInitialized._FunctionPtr;
		}

		// Token: 0x0601C429 RID: 115753 RVA: 0x0029A807 File Offset: 0x00298A07
		public FOnArcRopeInitialized()
		{
		}

		// Token: 0x0601C42A RID: 115754 RVA: 0x0029A80F File Offset: 0x00298A0F
		[NullableContext(2)]
		public FOnArcRopeInitialized(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C42B RID: 115755 RVA: 0x0029A819 File Offset: 0x00298A19
		public FOnArcRopeInitialized(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C42C RID: 115756 RVA: 0x0029A824 File Offset: 0x00298A24
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C42D RID: 115757 RVA: 0x0029A856 File Offset: 0x00298A56
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnArcRopeInitialized.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnArcRopeInitialized.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnArcRopeInitialized.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnArcRopeInitialized.OnScriptCallback));
				}
				FOnArcRopeInitialized.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnArcRopeInitialized.RegisterId);
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x0029A890 File Offset: 0x00298A90
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C42F RID: 115759 RVA: 0x0029A899 File Offset: 0x00298A99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C430 RID: 115760 RVA: 0x0029A8A4 File Offset: 0x00298AA4
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

		// Token: 0x0400F321 RID: 62241
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F322 RID: 62242
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.OnArcRopeInitialized__DelegateSignature";

		// Token: 0x0400F323 RID: 62243
		private static int RegisterId;

		// Token: 0x0200320B RID: 12811
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401706E RID: 94318
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
