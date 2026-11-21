using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000486 RID: 1158
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectSuccessDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D3D RID: 27965 RVA: 0x0009FA6E File Offset: 0x0009DC6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectSuccessDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x0009FA7A File Offset: 0x0009DC7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectSuccessDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectSuccessDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectSuccessDelegate__DelegateSignature");
			}
			return FOnKcpConnectSuccessDelegate._FunctionPtr;
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x0009FA9D File Offset: 0x0009DC9D
		public FOnKcpConnectSuccessDelegate()
		{
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x0009FAA5 File Offset: 0x0009DCA5
		[NullableContext(2)]
		public FOnKcpConnectSuccessDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x0009FAAF File Offset: 0x0009DCAF
		public FOnKcpConnectSuccessDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x0009FABA File Offset: 0x0009DCBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x0009FAEC File Offset: 0x0009DCEC
		[NullableContext(1)]
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

		// Token: 0x06006D44 RID: 27972 RVA: 0x0009FB26 File Offset: 0x0009DD26
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0009FB2F File Offset: 0x0009DD2F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x0009FB3C File Offset: 0x0009DD3C
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

		// Token: 0x04002EA3 RID: 11939
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EA4 RID: 11940
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectSuccessDelegate__DelegateSignature";

		// Token: 0x04002EA5 RID: 11941
		private static int RegisterId;

		// Token: 0x02000B91 RID: 2961
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D0A RID: 23818
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
