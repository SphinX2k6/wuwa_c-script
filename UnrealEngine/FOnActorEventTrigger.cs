using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE0 RID: 7904
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnActorEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E0E5 RID: 123109 RVA: 0x002C9AEF File Offset: 0x002C7CEF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnActorEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0601E0E6 RID: 123110 RVA: 0x002C9AFB File Offset: 0x002C7CFB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnActorEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnActorEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnActorEventTrigger__DelegateSignature");
			}
			return FOnActorEventTrigger._FunctionPtr;
		}

		// Token: 0x0601E0E7 RID: 123111 RVA: 0x002C9B1E File Offset: 0x002C7D1E
		public FOnActorEventTrigger()
		{
		}

		// Token: 0x0601E0E8 RID: 123112 RVA: 0x002C9B26 File Offset: 0x002C7D26
		[NullableContext(2)]
		public FOnActorEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0E9 RID: 123113 RVA: 0x002C9B30 File Offset: 0x002C7D30
		public FOnActorEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0EA RID: 123114 RVA: 0x002C9B3B File Offset: 0x002C7D3B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, bool>) ?? ((Action<AActor, bool>)Delegate.CreateDelegate(typeof(Action<AActor, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E0EB RID: 123115 RVA: 0x002C9B6D File Offset: 0x002C7D6D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E0EC RID: 123116 RVA: 0x002C9BA7 File Offset: 0x002C7DA7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E0ED RID: 123117 RVA: 0x002C9BB0 File Offset: 0x002C7DB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor Actor, bool bContent)
		{
			FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams* ptr = stackalloc FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnActorEventTrigger.__FOnActorEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnActorEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->bContent = bContent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E0EE RID: 123118 RVA: 0x002C9C04 File Offset: 0x002C7E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040103FA RID: 66554
		internal static IntPtr _FunctionPtr;

		// Token: 0x040103FB RID: 66555
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnActorEventTrigger__DelegateSignature";

		// Token: 0x040103FC RID: 66556
		private static int RegisterId;

		// Token: 0x020033A8 RID: 13224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnActorEventTrigger_DelegateParams
		{
			// Token: 0x0401735C RID: 95068
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0401735D RID: 95069
			[FieldOffset(8)]
			public bool bContent;
		}

		// Token: 0x020033A9 RID: 13225
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401735E RID: 95070
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
