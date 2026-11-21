using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F0 RID: 1520
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnActorEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600874B RID: 34635 RVA: 0x000CAED5 File Offset: 0x000C90D5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnActorEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x000CAEE1 File Offset: 0x000C90E1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnActorEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnActorEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnActorEventTrigger__DelegateSignature");
			}
			return FOnActorEventTrigger._FunctionPtr;
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x000CAF04 File Offset: 0x000C9104
		public FOnActorEventTrigger()
		{
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x000CAF0C File Offset: 0x000C910C
		[NullableContext(2)]
		public FOnActorEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x000CAF16 File Offset: 0x000C9116
		public FOnActorEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x000CAF21 File Offset: 0x000C9121
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, bool>) ?? ((Action<AActor, bool>)Delegate.CreateDelegate(typeof(Action<AActor, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x000CAF53 File Offset: 0x000C9153
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> Callback)
		{
			if (FOnActorEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnActorEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnActorEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnActorEventTrigger.OnScriptCallback));
				}
				FOnActorEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnActorEventTrigger.RegisterId);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x000CAF8D File Offset: 0x000C918D
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x000CAF98 File Offset: 0x000C9198
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor Actor, bool bContent)
		{
			FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams* ptr = stackalloc FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnActorEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->bContent = bContent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x000CAFEC File Offset: 0x000C91EC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, bool> action = target as Action<AActor, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer, ((FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams*)__Parameters)->bContent);
		}

		// Token: 0x04003ADB RID: 15067
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003ADC RID: 15068
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnActorEventTrigger__DelegateSignature";

		// Token: 0x04003ADD RID: 15069
		private static int RegisterId;

		// Token: 0x02000DFB RID: 3579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnActorEventTrigger_DelegateParams
		{
			// Token: 0x0400618E RID: 24974
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0400618F RID: 24975
			[FieldOffset(8)]
			public bool bContent;
		}

		// Token: 0x02000DFC RID: 3580
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006190 RID: 24976
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
