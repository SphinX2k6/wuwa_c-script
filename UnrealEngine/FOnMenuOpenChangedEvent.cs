using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029AE RID: 10670
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMenuOpenChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027756 RID: 161622 RVA: 0x003C32EF File Offset: 0x003C14EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMenuOpenChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x06027757 RID: 161623 RVA: 0x003C32FB File Offset: 0x003C14FB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMenuOpenChangedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnMenuOpenChangedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature");
			}
			return FOnMenuOpenChangedEvent._FunctionPtr;
		}

		// Token: 0x06027758 RID: 161624 RVA: 0x003C331E File Offset: 0x003C151E
		public FOnMenuOpenChangedEvent()
		{
		}

		// Token: 0x06027759 RID: 161625 RVA: 0x003C3326 File Offset: 0x003C1526
		[NullableContext(2)]
		public FOnMenuOpenChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602775A RID: 161626 RVA: 0x003C3330 File Offset: 0x003C1530
		public FOnMenuOpenChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602775B RID: 161627 RVA: 0x003C333B File Offset: 0x003C153B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602775C RID: 161628 RVA: 0x003C336D File Offset: 0x003C156D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnMenuOpenChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMenuOpenChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMenuOpenChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMenuOpenChangedEvent.OnScriptCallback));
				}
				FOnMenuOpenChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMenuOpenChangedEvent.RegisterId);
		}

		// Token: 0x0602775D RID: 161629 RVA: 0x003C33A7 File Offset: 0x003C15A7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602775E RID: 161630 RVA: 0x003C33B0 File Offset: 0x003C15B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsOpen)
		{
			FOnMenuOpenChangedEvent.__FOnMenuOpenChangedEvent_DelegateParams* ptr = stackalloc FOnMenuOpenChangedEvent.__FOnMenuOpenChangedEvent_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnMenuOpenChangedEvent.__FOnMenuOpenChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMenuOpenChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsOpen = bIsOpen;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602775F RID: 161631 RVA: 0x003C33EC File Offset: 0x003C15EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMenuOpenChangedEvent.__FOnMenuOpenChangedEvent_DelegateParams*)__Parameters)->bIsOpen);
		}

		// Token: 0x04015A68 RID: 88680
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A69 RID: 88681
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnMenuOpenChangedEvent__DelegateSignature";

		// Token: 0x04015A6A RID: 88682
		private static int RegisterId;

		// Token: 0x02003BB3 RID: 15283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnMenuOpenChangedEvent_DelegateParams
		{
			// Token: 0x04017D96 RID: 97686
			[FieldOffset(0)]
			public bool bIsOpen;
		}

		// Token: 0x02003BB4 RID: 15284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D97 RID: 97687
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
