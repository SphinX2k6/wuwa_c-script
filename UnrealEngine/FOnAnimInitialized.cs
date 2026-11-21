using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200024D RID: 589
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAnimInitialized : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032BB RID: 12987 RVA: 0x0004864A File Offset: 0x0004684A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAnimInitialized.StaticFunctionPtr();
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x00048656 File Offset: 0x00046856
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAnimInitialized._FunctionPtr == IntPtr.Zero)
			{
				FOnAnimInitialized._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAnimInitialized__DelegateSignature");
			}
			return FOnAnimInitialized._FunctionPtr;
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x00048679 File Offset: 0x00046879
		public FOnAnimInitialized()
		{
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00048681 File Offset: 0x00046881
		[NullableContext(2)]
		public FOnAnimInitialized(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x0004868B File Offset: 0x0004688B
		public FOnAnimInitialized(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00048696 File Offset: 0x00046896
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000486C8 File Offset: 0x000468C8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnAnimInitialized.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAnimInitialized.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAnimInitialized.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAnimInitialized.OnScriptCallback));
				}
				FOnAnimInitialized.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAnimInitialized.RegisterId);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00048702 File Offset: 0x00046902
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x0004870B File Offset: 0x0004690B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00048718 File Offset: 0x00046918
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

		// Token: 0x040011B5 RID: 4533
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011B6 RID: 4534
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAnimInitialized__DelegateSignature";

		// Token: 0x040011B7 RID: 4535
		private static int RegisterId;

		// Token: 0x020009C5 RID: 2501
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005952 RID: 22866
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
