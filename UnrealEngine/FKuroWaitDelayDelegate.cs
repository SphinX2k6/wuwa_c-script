using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001968 RID: 6504
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroWaitDelayDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060182E6 RID: 99046 RVA: 0x0023A1C6 File Offset: 0x002383C6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroWaitDelayDelegate.StaticFunctionPtr();
		}

		// Token: 0x060182E7 RID: 99047 RVA: 0x0023A1D2 File Offset: 0x002383D2
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroWaitDelayDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroWaitDelayDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.KuroWaitDelayDelegate__DelegateSignature");
			}
			return FKuroWaitDelayDelegate._FunctionPtr;
		}

		// Token: 0x060182E8 RID: 99048 RVA: 0x0023A1F5 File Offset: 0x002383F5
		public FKuroWaitDelayDelegate()
		{
		}

		// Token: 0x060182E9 RID: 99049 RVA: 0x0023A1FD File Offset: 0x002383FD
		[NullableContext(2)]
		public FKuroWaitDelayDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182EA RID: 99050 RVA: 0x0023A207 File Offset: 0x00238407
		public FKuroWaitDelayDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182EB RID: 99051 RVA: 0x0023A212 File Offset: 0x00238412
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060182EC RID: 99052 RVA: 0x0023A244 File Offset: 0x00238444
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FKuroWaitDelayDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroWaitDelayDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroWaitDelayDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroWaitDelayDelegate.OnScriptCallback));
				}
				FKuroWaitDelayDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroWaitDelayDelegate.RegisterId);
		}

		// Token: 0x060182ED RID: 99053 RVA: 0x0023A27E File Offset: 0x0023847E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060182EE RID: 99054 RVA: 0x0023A287 File Offset: 0x00238487
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060182EF RID: 99055 RVA: 0x0023A294 File Offset: 0x00238494
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

		// Token: 0x0400D1AE RID: 53678
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1AF RID: 53679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.KuroWaitDelayDelegate__DelegateSignature";

		// Token: 0x0400D1B0 RID: 53680
		private static int RegisterId;

		// Token: 0x02003053 RID: 12371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D16 RID: 93462
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
