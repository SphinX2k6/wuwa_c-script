using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000A0 RID: 160
	public abstract class UnrealScriptDelegate : UnrealProxyObject
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x00018E82 File Offset: 0x00017082
		protected UnrealScriptDelegate()
		{
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00018E8A File Offset: 0x0001708A
		[NullableContext(2)]
		protected UnrealScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00018E94 File Offset: 0x00017094
		protected UnrealScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00018E9F File Offset: 0x0001709F
		[NullableContext(1)]
		protected static int RegisterDelegate(UnrealScriptDelegate.CallbackType Callback)
		{
			UnrealScriptDelegate.Registered.Add(Callback);
			return UnrealScriptDelegate.Registered.Count - 1;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00018EB8 File Offset: 0x000170B8
		private unsafe static void OnNativeCallback_RuntimeInvoke2(IntPtr Handle, int Delegate, byte* Parameters)
		{
			UnrealScriptDelegate.Registered[Delegate](Handle, Parameters);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00018ECC File Offset: 0x000170CC
		private static void FreeHandle(IntPtr Handle)
		{
			GCHandle.FromIntPtr(Handle).Free();
		}

		// Token: 0x06001094 RID: 4244
		[NullableContext(1)]
		public abstract void DynamicBind(Delegate Callback);

		// Token: 0x0400022E RID: 558
		[Nullable(1)]
		private static readonly List<UnrealScriptDelegate.CallbackType> Registered = new List<UnrealScriptDelegate.CallbackType>();

		// Token: 0x02002B28 RID: 11048
		// (Invoke) Token: 0x0602851E RID: 165150
		protected unsafe delegate void CallbackType(IntPtr Handle, byte* Parameters);
	}
}
