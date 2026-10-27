using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A03 RID: 6659
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectSuccessDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018AF3 RID: 101107 RVA: 0x0024676E File Offset: 0x0024496E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectSuccessDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018AF4 RID: 101108 RVA: 0x0024677A File Offset: 0x0024497A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectSuccessDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectSuccessDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectSuccessDelegate__DelegateSignature");
			}
			return FOnKcpConnectSuccessDelegate._FunctionPtr;
		}

		// Token: 0x06018AF5 RID: 101109 RVA: 0x0024679D File Offset: 0x0024499D
		public FOnKcpConnectSuccessDelegate()
		{
		}

		// Token: 0x06018AF6 RID: 101110 RVA: 0x002467A5 File Offset: 0x002449A5
		[NullableContext(2)]
		public FOnKcpConnectSuccessDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018AF7 RID: 101111 RVA: 0x002467AF File Offset: 0x002449AF
		public FOnKcpConnectSuccessDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018AF8 RID: 101112 RVA: 0x002467BA File Offset: 0x002449BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018AF9 RID: 101113 RVA: 0x002467EC File Offset: 0x002449EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnKcpConnectSuccessDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKcpConnectSuccessDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKcpConnectSuccessDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKcpConnectSuccessDelegate.OnScriptCallback));
				}
				FOnKcpConnectSuccessDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKcpConnectSuccessDelegate.RegisterId);
		}

		// Token: 0x06018AFA RID: 101114 RVA: 0x00246826 File Offset: 0x00244A26
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018AFB RID: 101115 RVA: 0x0024682F File Offset: 0x00244A2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x0024683C File Offset: 0x00244A3C
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

		// Token: 0x0400D559 RID: 54617
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D55A RID: 54618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectSuccessDelegate__DelegateSignature";

		// Token: 0x0400D55B RID: 54619
		private static int RegisterId;

		// Token: 0x020030B4 RID: 12468
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E04 RID: 93700
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
