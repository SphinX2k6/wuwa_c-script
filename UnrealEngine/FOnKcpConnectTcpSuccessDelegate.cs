using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000488 RID: 1160
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectTcpSuccessDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D51 RID: 27985 RVA: 0x0009FC8E File Offset: 0x0009DE8E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectTcpSuccessDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x0009FC9A File Offset: 0x0009DE9A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectTcpSuccessDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectTcpSuccessDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectTcpSuccessDelegate__DelegateSignature");
			}
			return FOnKcpConnectTcpSuccessDelegate._FunctionPtr;
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x0009FCBD File Offset: 0x0009DEBD
		public FOnKcpConnectTcpSuccessDelegate()
		{
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x0009FCC5 File Offset: 0x0009DEC5
		[NullableContext(2)]
		public FOnKcpConnectTcpSuccessDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x0009FCCF File Offset: 0x0009DECF
		public FOnKcpConnectTcpSuccessDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x0009FCDA File Offset: 0x0009DEDA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x0009FD0C File Offset: 0x0009DF0C
		[NullableContext(1)]
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

		// Token: 0x06006D58 RID: 27992 RVA: 0x0009FD46 File Offset: 0x0009DF46
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x0009FD4F File Offset: 0x0009DF4F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x0009FD5C File Offset: 0x0009DF5C
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

		// Token: 0x04002EA9 RID: 11945
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EAA RID: 11946
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectTcpSuccessDelegate__DelegateSignature";

		// Token: 0x04002EAB RID: 11947
		private static int RegisterId;

		// Token: 0x02000B93 RID: 2963
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D0C RID: 23820
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
