using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A04 RID: 6660
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectTcpFailedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018AFD RID: 101117 RVA: 0x0024687E File Offset: 0x00244A7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectTcpFailedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018AFE RID: 101118 RVA: 0x0024688A File Offset: 0x00244A8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectTcpFailedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectTcpFailedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectTcpFailedDelegate__DelegateSignature");
			}
			return FOnKcpConnectTcpFailedDelegate._FunctionPtr;
		}

		// Token: 0x06018AFF RID: 101119 RVA: 0x002468AD File Offset: 0x00244AAD
		public FOnKcpConnectTcpFailedDelegate()
		{
		}

		// Token: 0x06018B00 RID: 101120 RVA: 0x002468B5 File Offset: 0x00244AB5
		[NullableContext(2)]
		public FOnKcpConnectTcpFailedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B01 RID: 101121 RVA: 0x002468BF File Offset: 0x00244ABF
		public FOnKcpConnectTcpFailedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B02 RID: 101122 RVA: 0x002468CA File Offset: 0x00244ACA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B03 RID: 101123 RVA: 0x002468FC File Offset: 0x00244AFC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnKcpConnectTcpFailedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKcpConnectTcpFailedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKcpConnectTcpFailedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKcpConnectTcpFailedDelegate.OnScriptCallback));
				}
				FOnKcpConnectTcpFailedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKcpConnectTcpFailedDelegate.RegisterId);
		}

		// Token: 0x06018B04 RID: 101124 RVA: 0x00246936 File Offset: 0x00244B36
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018B05 RID: 101125 RVA: 0x0024693F File Offset: 0x00244B3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06018B06 RID: 101126 RVA: 0x0024694C File Offset: 0x00244B4C
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

		// Token: 0x0400D55C RID: 54620
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D55D RID: 54621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectTcpFailedDelegate__DelegateSignature";

		// Token: 0x0400D55E RID: 54622
		private static int RegisterId;

		// Token: 0x020030B5 RID: 12469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E05 RID: 93701
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
