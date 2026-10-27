using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B2 RID: 10674
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMultiLineEditableTextBoxCommittedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602777E RID: 161662 RVA: 0x003C37C8 File Offset: 0x003C19C8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMultiLineEditableTextBoxCommittedEvent.StaticFunctionPtr();
		}

		// Token: 0x0602777F RID: 161663 RVA: 0x003C37D4 File Offset: 0x003C19D4
		private static IntPtr StaticFunctionPtr()
		{
			if (UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature");
			}
			return UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027780 RID: 161664 RVA: 0x003C37F7 File Offset: 0x003C19F7
		public FOnMultiLineEditableTextBoxCommittedEvent()
		{
		}

		// Token: 0x06027781 RID: 161665 RVA: 0x003C37FF File Offset: 0x003C19FF
		[NullableContext(2)]
		public FOnMultiLineEditableTextBoxCommittedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027782 RID: 161666 RVA: 0x003C3809 File Offset: 0x003C1A09
		public FOnMultiLineEditableTextBoxCommittedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027783 RID: 161667 RVA: 0x003C3814 File Offset: 0x003C1A14
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText, TEnumAsByte<ETextCommit>>) ?? ((Action<FText, TEnumAsByte<ETextCommit>>)Delegate.CreateDelegate(typeof(Action<FText, TEnumAsByte<ETextCommit>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027784 RID: 161668 RVA: 0x003C3846 File Offset: 0x003C1A46
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FText, TEnumAsByte<ETextCommit>> Callback)
		{
			if (FOnMultiLineEditableTextBoxCommittedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMultiLineEditableTextBoxCommittedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMultiLineEditableTextBoxCommittedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMultiLineEditableTextBoxCommittedEvent.OnScriptCallback));
				}
				FOnMultiLineEditableTextBoxCommittedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMultiLineEditableTextBoxCommittedEvent.RegisterId);
		}

		// Token: 0x06027785 RID: 161669 RVA: 0x003C3880 File Offset: 0x003C1A80
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

		// Token: 0x06027786 RID: 161670 RVA: 0x003C388C File Offset: 0x003C1A8C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text, ETextCommit CommitMethod)
		{
			FOnMultiLineEditableTextBoxCommittedEvent.__FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams* ptr = stackalloc FOnMultiLineEditableTextBoxCommittedEvent.__FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnMultiLineEditableTextBoxCommittedEvent.__FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMultiLineEditableTextBoxCommittedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			ptr->CommitMethod = CommitMethod;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027787 RID: 161671 RVA: 0x003C38F4 File Offset: 0x003C1AF4
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
			FText arg = new FText(&((FOnMultiLineEditableTextBoxCommittedEvent.__FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(arg, ((FOnMultiLineEditableTextBoxCommittedEvent.__FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams*)__Parameters)->CommitMethod);
		}

		// Token: 0x04015A73 RID: 88691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxCommittedEvent__DelegateSignature";

		// Token: 0x04015A74 RID: 88692
		private static int RegisterId;

		// Token: 0x02003BB9 RID: 15289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnMultiLineEditableTextBoxCommittedEvent_DelegateParams
		{
			// Token: 0x04017D9C RID: 97692
			[FieldOffset(0)]
			public byte Text;

			// Token: 0x04017D9D RID: 97693
			[FieldOffset(24)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x02003BBA RID: 15290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D9E RID: 97694
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
