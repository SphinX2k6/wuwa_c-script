using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001984 RID: 6532
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroCheckComplete : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601842C RID: 99372 RVA: 0x0023C972 File Offset: 0x0023AB72
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroCheckComplete.StaticFunctionPtr();
		}

		// Token: 0x0601842D RID: 99373 RVA: 0x0023C97E File Offset: 0x0023AB7E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroCheckComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroCheckComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroCheckComplete__DelegateSignature");
			}
			return FKuroCheckComplete._FunctionPtr;
		}

		// Token: 0x0601842E RID: 99374 RVA: 0x0023C9A1 File Offset: 0x0023ABA1
		public FKuroCheckComplete()
		{
		}

		// Token: 0x0601842F RID: 99375 RVA: 0x0023C9A9 File Offset: 0x0023ABA9
		[NullableContext(2)]
		public FKuroCheckComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018430 RID: 99376 RVA: 0x0023C9B3 File Offset: 0x0023ABB3
		public FKuroCheckComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018431 RID: 99377 RVA: 0x0023C9BE File Offset: 0x0023ABBE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018432 RID: 99378 RVA: 0x0023C9F0 File Offset: 0x0023ABF0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FKuroCheckComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroCheckComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroCheckComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroCheckComplete.OnScriptCallback));
				}
				FKuroCheckComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroCheckComplete.RegisterId);
		}

		// Token: 0x06018433 RID: 99379 RVA: 0x0023CA2A File Offset: 0x0023AC2A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018434 RID: 99380 RVA: 0x0023CA33 File Offset: 0x0023AC33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06018435 RID: 99381 RVA: 0x0023CA40 File Offset: 0x0023AC40
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

		// Token: 0x0400D238 RID: 53816
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D239 RID: 53817
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckComplete__DelegateSignature";

		// Token: 0x0400D23A RID: 53818
		private static int RegisterId;

		// Token: 0x0200307D RID: 12413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D58 RID: 93528
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
