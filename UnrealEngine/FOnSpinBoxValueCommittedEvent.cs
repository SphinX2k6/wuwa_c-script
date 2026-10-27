using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029BA RID: 10682
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSpinBoxValueCommittedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277CD RID: 161741 RVA: 0x003C432E File Offset: 0x003C252E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSpinBoxValueCommittedEvent.StaticFunctionPtr();
		}

		// Token: 0x060277CE RID: 161742 RVA: 0x003C433A File Offset: 0x003C253A
		private static IntPtr StaticFunctionPtr()
		{
			if (USpinBox.__OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				USpinBox.__OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature");
			}
			return USpinBox.__OnSpinBoxValueCommittedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060277CF RID: 161743 RVA: 0x003C435D File Offset: 0x003C255D
		public FOnSpinBoxValueCommittedEvent()
		{
		}

		// Token: 0x060277D0 RID: 161744 RVA: 0x003C4365 File Offset: 0x003C2565
		[NullableContext(2)]
		public FOnSpinBoxValueCommittedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277D1 RID: 161745 RVA: 0x003C436F File Offset: 0x003C256F
		public FOnSpinBoxValueCommittedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277D2 RID: 161746 RVA: 0x003C437A File Offset: 0x003C257A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, TEnumAsByte<ETextCommit>>) ?? ((Action<float, TEnumAsByte<ETextCommit>>)Delegate.CreateDelegate(typeof(Action<float, TEnumAsByte<ETextCommit>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277D3 RID: 161747 RVA: 0x003C43AC File Offset: 0x003C25AC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<float, TEnumAsByte<ETextCommit>> Callback)
		{
			if (FOnSpinBoxValueCommittedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSpinBoxValueCommittedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSpinBoxValueCommittedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSpinBoxValueCommittedEvent.OnScriptCallback));
				}
				FOnSpinBoxValueCommittedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSpinBoxValueCommittedEvent.RegisterId);
		}

		// Token: 0x060277D4 RID: 161748 RVA: 0x003C43E6 File Offset: 0x003C25E6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<float, TEnumAsByte<ETextCommit>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277D5 RID: 161749 RVA: 0x003C43F0 File Offset: 0x003C25F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float InValue, ETextCommit CommitMethod)
		{
			FOnSpinBoxValueCommittedEvent.__FOnSpinBoxValueCommittedEvent_DelegateParams* ptr = stackalloc FOnSpinBoxValueCommittedEvent.__FOnSpinBoxValueCommittedEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSpinBoxValueCommittedEvent.__FOnSpinBoxValueCommittedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSpinBoxValueCommittedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InValue = InValue;
			ptr->CommitMethod = CommitMethod;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060277D6 RID: 161750 RVA: 0x003C4438 File Offset: 0x003C2638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, TEnumAsByte<ETextCommit>> action = target as Action<float, TEnumAsByte<ETextCommit>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSpinBoxValueCommittedEvent.__FOnSpinBoxValueCommittedEvent_DelegateParams*)__Parameters)->InValue, ((FOnSpinBoxValueCommittedEvent.__FOnSpinBoxValueCommittedEvent_DelegateParams*)__Parameters)->CommitMethod);
		}

		// Token: 0x04015A83 RID: 88707
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SpinBox:OnSpinBoxValueCommittedEvent__DelegateSignature";

		// Token: 0x04015A84 RID: 88708
		private static int RegisterId;

		// Token: 0x02003BC7 RID: 15303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnSpinBoxValueCommittedEvent_DelegateParams
		{
			// Token: 0x04017DAF RID: 97711
			[FieldOffset(0)]
			public float InValue;

			// Token: 0x04017DB0 RID: 97712
			[FieldOffset(4)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x02003BC8 RID: 15304
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DB1 RID: 97713
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
