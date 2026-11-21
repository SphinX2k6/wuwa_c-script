using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000085 RID: 133
	public abstract class UnrealScriptDelegate : UnrealProxyObject
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x00013BA6 File Offset: 0x00011DA6
		protected UnrealScriptDelegate()
		{
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00013BAE File Offset: 0x00011DAE
		[NullableContext(2)]
		protected UnrealScriptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00013BB8 File Offset: 0x00011DB8
		protected UnrealScriptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00013BC3 File Offset: 0x00011DC3
		[NullableContext(1)]
		protected static int RegisterDelegate(UnrealScriptDelegate.CallbackType Callback)
		{
			UnrealScriptDelegate.Registered.Add(Callback);
			return UnrealScriptDelegate.Registered.Count - 1;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00013BDC File Offset: 0x00011DDC
		private unsafe static void OnNativeCallback_RuntimeInvoke2(IntPtr Handle, int Delegate, byte* Parameters)
		{
			UnrealScriptDelegate.Registered[Delegate](Handle, Parameters);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00013BF0 File Offset: 0x00011DF0
		private static void FreeHandle(IntPtr Handle)
		{
			GCHandle.FromIntPtr(Handle).Free();
		}

		// Token: 0x06000C27 RID: 3111
		[NullableContext(1)]
		public abstract void DynamicBind(Delegate Callback);

		// Token: 0x040001E7 RID: 487
		[Nullable(1)]
		private static readonly List<UnrealScriptDelegate.CallbackType> Registered = new List<UnrealScriptDelegate.CallbackType>();

		// Token: 0x020008D6 RID: 2262
		// (Invoke) Token: 0x0600BEDB RID: 48859
		protected unsafe delegate void CallbackType(IntPtr Handle, byte* Parameters);
	}
}
