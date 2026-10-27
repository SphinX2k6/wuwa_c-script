using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A05 RID: 6661
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectTcpSuccessDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018B07 RID: 101127 RVA: 0x0024698E File Offset: 0x00244B8E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectTcpSuccessDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018B08 RID: 101128 RVA: 0x0024699A File Offset: 0x00244B9A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectTcpSuccessDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectTcpSuccessDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectTcpSuccessDelegate__DelegateSignature");
			}
			return FOnKcpConnectTcpSuccessDelegate._FunctionPtr;
		}

		// Token: 0x06018B09 RID: 101129 RVA: 0x002469BD File Offset: 0x00244BBD
		public FOnKcpConnectTcpSuccessDelegate()
		{
		}

		// Token: 0x06018B0A RID: 101130 RVA: 0x002469C5 File Offset: 0x00244BC5
		[NullableContext(2)]
		public FOnKcpConnectTcpSuccessDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018B0B RID: 101131 RVA: 0x002469CF File Offset: 0x00244BCF
		public FOnKcpConnectTcpSuccessDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018B0C RID: 101132 RVA: 0x002469DA File Offset: 0x00244BDA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018B0D RID: 101133 RVA: 0x00246A0C File Offset: 0x00244C0C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnKcpConnectTcpSuccessDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKcpConnectTcpSuccessDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKcpConnectTcpSuccessDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKcpConnectTcpSuccessDelegate.OnScriptCallback));
				}
				FOnKcpConnectTcpSuccessDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKcpConnectTcpSuccessDelegate.RegisterId);
		}

		// Token: 0x06018B0E RID: 101134 RVA: 0x00246A46 File Offset: 0x00244C46
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018B0F RID: 101135 RVA: 0x00246A4F File Offset: 0x00244C4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06018B10 RID: 101136 RVA: 0x00246A5C File Offset: 0x00244C5C
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

		// Token: 0x0400D55F RID: 54623
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D560 RID: 54624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectTcpSuccessDelegate__DelegateSignature";

		// Token: 0x0400D561 RID: 54625
		private static int RegisterId;

		// Token: 0x020030B6 RID: 12470
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E06 RID: 93702
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
