using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000487 RID: 1159
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKcpConnectTcpFailedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D47 RID: 27975 RVA: 0x0009FB7E File Offset: 0x0009DD7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKcpConnectTcpFailedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x0009FB8A File Offset: 0x0009DD8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKcpConnectTcpFailedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnKcpConnectTcpFailedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnKcpConnectTcpFailedDelegate__DelegateSignature");
			}
			return FOnKcpConnectTcpFailedDelegate._FunctionPtr;
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x0009FBAD File Offset: 0x0009DDAD
		public FOnKcpConnectTcpFailedDelegate()
		{
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x0009FBB5 File Offset: 0x0009DDB5
		[NullableContext(2)]
		public FOnKcpConnectTcpFailedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0009FBBF File Offset: 0x0009DDBF
		public FOnKcpConnectTcpFailedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x0009FBCA File Offset: 0x0009DDCA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x0009FBFC File Offset: 0x0009DDFC
		[NullableContext(1)]
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

		// Token: 0x06006D4E RID: 27982 RVA: 0x0009FC36 File Offset: 0x0009DE36
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x0009FC3F File Offset: 0x0009DE3F
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x0009FC4C File Offset: 0x0009DE4C
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

		// Token: 0x04002EA6 RID: 11942
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EA7 RID: 11943
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnKcpConnectTcpFailedDelegate__DelegateSignature";

		// Token: 0x04002EA8 RID: 11944
		private static int RegisterId;

		// Token: 0x02000B92 RID: 2962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D0B RID: 23819
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
