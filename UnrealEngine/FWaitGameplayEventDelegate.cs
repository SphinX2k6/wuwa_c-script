using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001978 RID: 6520
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitGameplayEventDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018386 RID: 99206 RVA: 0x0023B87A File Offset: 0x00239A7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitGameplayEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018387 RID: 99207 RVA: 0x0023B886 File Offset: 0x00239A86
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitGameplayEventDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitGameplayEventDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.WaitGameplayEventDelegate__DelegateSignature");
			}
			return FWaitGameplayEventDelegate._FunctionPtr;
		}

		// Token: 0x06018388 RID: 99208 RVA: 0x0023B8A9 File Offset: 0x00239AA9
		public FWaitGameplayEventDelegate()
		{
		}

		// Token: 0x06018389 RID: 99209 RVA: 0x0023B8B1 File Offset: 0x00239AB1
		[NullableContext(2)]
		public FWaitGameplayEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601838A RID: 99210 RVA: 0x0023B8BB File Offset: 0x00239ABB
		public FWaitGameplayEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601838B RID: 99211 RVA: 0x0023B8C6 File Offset: 0x00239AC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTag, FGameplayEventData>) ?? ((Action<FGameplayTag, FGameplayEventData>)Delegate.CreateDelegate(typeof(Action<FGameplayTag, FGameplayEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601838C RID: 99212 RVA: 0x0023B8F8 File Offset: 0x00239AF8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayTag, FGameplayEventData> Callback)
		{
			if (FWaitGameplayEventDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitGameplayEventDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitGameplayEventDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitGameplayEventDelegate.OnScriptCallback));
				}
				FWaitGameplayEventDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitGameplayEventDelegate.RegisterId);
		}

		// Token: 0x0601838D RID: 99213 RVA: 0x0023B932 File Offset: 0x00239B32
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayTag, FGameplayEventData> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601838E RID: 99214 RVA: 0x0023B93C File Offset: 0x00239B3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGameplayTag EventTag, FGameplayEventData Payload)
		{
			FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams* ptr = stackalloc FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams[(UIntPtr)215] + 15L / (long)sizeof(FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitGameplayEventDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventTag = EventTag;
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FWaitGameplayEventDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601838F RID: 99215 RVA: 0x0023B9B0 File Offset: 0x00239BB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTag, FGameplayEventData> action = target as Action<FGameplayTag, FGameplayEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayEventData arg = new FGameplayEventData(&((FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams*)__Parameters)->Payload, true, true);
			action(((FWaitGameplayEventDelegate.__FWaitGameplayEventDelegate_DelegateParams*)__Parameters)->EventTag, arg);
		}

		// Token: 0x0400D1DE RID: 53726
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1DF RID: 53727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.WaitGameplayEventDelegate__DelegateSignature";

		// Token: 0x0400D1E0 RID: 53728
		private static int RegisterId;

		// Token: 0x02003072 RID: 12402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __FWaitGameplayEventDelegate_DelegateParams
		{
			// Token: 0x04016D43 RID: 93507
			[FieldOffset(0)]
			public FGameplayTag EventTag;

			// Token: 0x04016D44 RID: 93508
			[FieldOffset(16)]
			public byte Payload;
		}

		// Token: 0x02003073 RID: 12403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D45 RID: 93509
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
