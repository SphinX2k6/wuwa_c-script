using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F2 RID: 1522
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBooleanEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600875E RID: 34654 RVA: 0x000CB186 File Offset: 0x000C9386
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBooleanEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x000CB192 File Offset: 0x000C9392
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBooleanEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnBooleanEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnBooleanEventTrigger__DelegateSignature");
			}
			return FOnBooleanEventTrigger._FunctionPtr;
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x000CB1B5 File Offset: 0x000C93B5
		public FOnBooleanEventTrigger()
		{
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x000CB1BD File Offset: 0x000C93BD
		[NullableContext(2)]
		public FOnBooleanEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x000CB1C7 File Offset: 0x000C93C7
		public FOnBooleanEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x000CB1D2 File Offset: 0x000C93D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x000CB204 File Offset: 0x000C9404
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FOnBooleanEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBooleanEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBooleanEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBooleanEventTrigger.OnScriptCallback));
				}
				FOnBooleanEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBooleanEventTrigger.RegisterId);
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x000CB23E File Offset: 0x000C943E
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x000CB248 File Offset: 0x000C9448
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bContent)
		{
			FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams* ptr = stackalloc FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBooleanEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bContent = bContent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x000CB284 File Offset: 0x000C9484
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnBooleanEventTrigger.__FOnBooleanEventTrigger_DelegateParams*)__Parameters)->bContent);
		}

		// Token: 0x04003AE1 RID: 15073
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AE2 RID: 15074
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnBooleanEventTrigger__DelegateSignature";

		// Token: 0x04003AE3 RID: 15075
		private static int RegisterId;

		// Token: 0x02000DFF RID: 3583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnBooleanEventTrigger_DelegateParams
		{
			// Token: 0x04006193 RID: 24979
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x02000E00 RID: 3584
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006194 RID: 24980
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
