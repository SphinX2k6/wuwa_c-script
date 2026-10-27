using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B4 RID: 10676
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMultiLineEditableTextCommittedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027792 RID: 161682 RVA: 0x003C3AC0 File Offset: 0x003C1CC0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMultiLineEditableTextCommittedEvent.StaticFunctionPtr();
		}

		// Token: 0x06027793 RID: 161683 RVA: 0x003C3ACC File Offset: 0x003C1CCC
		private static IntPtr StaticFunctionPtr()
		{
			if (UMultiLineEditableText.__OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMultiLineEditableText.__OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature");
			}
			return UMultiLineEditableText.__OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027794 RID: 161684 RVA: 0x003C3AEF File Offset: 0x003C1CEF
		public FOnMultiLineEditableTextCommittedEvent()
		{
		}

		// Token: 0x06027795 RID: 161685 RVA: 0x003C3AF7 File Offset: 0x003C1CF7
		[NullableContext(2)]
		public FOnMultiLineEditableTextCommittedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027796 RID: 161686 RVA: 0x003C3B01 File Offset: 0x003C1D01
		public FOnMultiLineEditableTextCommittedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027797 RID: 161687 RVA: 0x003C3B0C File Offset: 0x003C1D0C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText, TEnumAsByte<ETextCommit>>) ?? ((Action<FText, TEnumAsByte<ETextCommit>>)Delegate.CreateDelegate(typeof(Action<FText, TEnumAsByte<ETextCommit>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027798 RID: 161688 RVA: 0x003C3B3E File Offset: 0x003C1D3E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FText, TEnumAsByte<ETextCommit>> Callback)
		{
			if (FOnMultiLineEditableTextCommittedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMultiLineEditableTextCommittedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMultiLineEditableTextCommittedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMultiLineEditableTextCommittedEvent.OnScriptCallback));
				}
				FOnMultiLineEditableTextCommittedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMultiLineEditableTextCommittedEvent.RegisterId);
		}

		// Token: 0x06027799 RID: 161689 RVA: 0x003C3B78 File Offset: 0x003C1D78
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FText, TEnumAsByte<ETextCommit>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602779A RID: 161690 RVA: 0x003C3B84 File Offset: 0x003C1D84
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text, ETextCommit CommitMethod)
		{
			FOnMultiLineEditableTextCommittedEvent.__FOnMultiLineEditableTextCommittedEvent_DelegateParams* ptr = stackalloc FOnMultiLineEditableTextCommittedEvent.__FOnMultiLineEditableTextCommittedEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnMultiLineEditableTextCommittedEvent.__FOnMultiLineEditableTextCommittedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMultiLineEditableTextCommittedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			ptr->CommitMethod = CommitMethod;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UMultiLineEditableText.__OnMultiLineEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602779B RID: 161691 RVA: 0x003C3BEC File Offset: 0x003C1DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FText, TEnumAsByte<ETextCommit>> action = target as Action<FText, TEnumAsByte<ETextCommit>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnMultiLineEditableTextCommittedEvent.__FOnMultiLineEditableTextCommittedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(arg, ((FOnMultiLineEditableTextCommittedEvent.__FOnMultiLineEditableTextCommittedEvent_DelegateParams*)__Parameters)->CommitMethod);
		}

		// Token: 0x04015A77 RID: 88695
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextCommittedEvent__DelegateSignature";

		// Token: 0x04015A78 RID: 88696
		private static int RegisterId;

		// Token: 0x02003BBD RID: 15293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnMultiLineEditableTextCommittedEvent_DelegateParams
		{
			// Token: 0x04017DA1 RID: 97697
			[FieldOffset(0)]
			public byte Text;

			// Token: 0x04017DA2 RID: 97698
			[FieldOffset(24)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x02003BBE RID: 15294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DA3 RID: 97699
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
