using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C60 RID: 7264
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAllNotesFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C2EA RID: 115434 RVA: 0x002988B7 File Offset: 0x00296AB7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAllNotesFinished.StaticFunctionPtr();
		}

		// Token: 0x0601C2EB RID: 115435 RVA: 0x002988C3 File Offset: 0x00296AC3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAllNotesFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnAllNotesFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnAllNotesFinished__DelegateSignature");
			}
			return FOnAllNotesFinished._FunctionPtr;
		}

		// Token: 0x0601C2EC RID: 115436 RVA: 0x002988E6 File Offset: 0x00296AE6
		public FOnAllNotesFinished()
		{
		}

		// Token: 0x0601C2ED RID: 115437 RVA: 0x002988EE File Offset: 0x00296AEE
		[NullableContext(2)]
		public FOnAllNotesFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C2EE RID: 115438 RVA: 0x002988F8 File Offset: 0x00296AF8
		public FOnAllNotesFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C2EF RID: 115439 RVA: 0x00298903 File Offset: 0x00296B03
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C2F0 RID: 115440 RVA: 0x00298935 File Offset: 0x00296B35
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnAllNotesFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAllNotesFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAllNotesFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAllNotesFinished.OnScriptCallback));
				}
				FOnAllNotesFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAllNotesFinished.RegisterId);
		}

		// Token: 0x0601C2F1 RID: 115441 RVA: 0x0029896F File Offset: 0x00296B6F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C2F2 RID: 115442 RVA: 0x00298978 File Offset: 0x00296B78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601C2F3 RID: 115443 RVA: 0x00298984 File Offset: 0x00296B84
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

		// Token: 0x0400F2A4 RID: 62116
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2A5 RID: 62117
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnAllNotesFinished__DelegateSignature";

		// Token: 0x0400F2A6 RID: 62118
		private static int RegisterId;

		// Token: 0x020031F1 RID: 12785
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401704B RID: 94283
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
