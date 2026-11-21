using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F4 RID: 1524
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIntEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008771 RID: 34673 RVA: 0x000CB412 File Offset: 0x000C9612
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIntEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x000CB41E File Offset: 0x000C961E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnIntEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnIntEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnIntEventTrigger__DelegateSignature");
			}
			return FOnIntEventTrigger._FunctionPtr;
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x000CB441 File Offset: 0x000C9641
		public FOnIntEventTrigger()
		{
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x000CB449 File Offset: 0x000C9649
		[NullableContext(2)]
		public FOnIntEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x000CB453 File Offset: 0x000C9653
		public FOnIntEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x000CB45E File Offset: 0x000C965E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x000CB490 File Offset: 0x000C9690
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (FOnIntEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIntEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIntEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIntEventTrigger.OnScriptCallback));
				}
				FOnIntEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIntEventTrigger.RegisterId);
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x000CB4CA File Offset: 0x000C96CA
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x000CB4D4 File Offset: 0x000C96D4
		[SkipLocalsInit]
		public unsafe void Broadcast(int Number)
		{
			FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams* ptr = stackalloc FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnIntEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Number = Number;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x000CB510 File Offset: 0x000C9710
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnIntEventTrigger.__FOnIntEventTrigger_DelegateParams*)__Parameters)->Number);
		}

		// Token: 0x04003AE7 RID: 15079
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AE8 RID: 15080
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnIntEventTrigger__DelegateSignature";

		// Token: 0x04003AE9 RID: 15081
		private static int RegisterId;

		// Token: 0x02000E03 RID: 3587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnIntEventTrigger_DelegateParams
		{
			// Token: 0x04006197 RID: 24983
			[FieldOffset(0)]
			public int Number;
		}

		// Token: 0x02000E04 RID: 3588
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006198 RID: 24984
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
