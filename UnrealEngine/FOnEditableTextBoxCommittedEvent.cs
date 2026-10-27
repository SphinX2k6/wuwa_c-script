using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299C RID: 10652
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEditableTextBoxCommittedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276A5 RID: 161445 RVA: 0x003C19CC File Offset: 0x003BFBCC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditableTextBoxCommittedEvent.StaticFunctionPtr();
		}

		// Token: 0x060276A6 RID: 161446 RVA: 0x003C19D8 File Offset: 0x003BFBD8
		private static IntPtr StaticFunctionPtr()
		{
			if (UEditableTextBox.__OnEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UEditableTextBox.__OnEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature");
			}
			return UEditableTextBox.__OnEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060276A7 RID: 161447 RVA: 0x003C19FB File Offset: 0x003BFBFB
		public FOnEditableTextBoxCommittedEvent()
		{
		}

		// Token: 0x060276A8 RID: 161448 RVA: 0x003C1A03 File Offset: 0x003BFC03
		[NullableContext(2)]
		public FOnEditableTextBoxCommittedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276A9 RID: 161449 RVA: 0x003C1A0D File Offset: 0x003BFC0D
		public FOnEditableTextBoxCommittedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276AA RID: 161450 RVA: 0x003C1A18 File Offset: 0x003BFC18
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText, TEnumAsByte<ETextCommit>>) ?? ((Action<FText, TEnumAsByte<ETextCommit>>)Delegate.CreateDelegate(typeof(Action<FText, TEnumAsByte<ETextCommit>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276AB RID: 161451 RVA: 0x003C1A4A File Offset: 0x003BFC4A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FText, TEnumAsByte<ETextCommit>> Callback)
		{
			if (FOnEditableTextBoxCommittedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEditableTextBoxCommittedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEditableTextBoxCommittedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEditableTextBoxCommittedEvent.OnScriptCallback));
				}
				FOnEditableTextBoxCommittedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEditableTextBoxCommittedEvent.RegisterId);
		}

		// Token: 0x060276AC RID: 161452 RVA: 0x003C1A84 File Offset: 0x003BFC84
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

		// Token: 0x060276AD RID: 161453 RVA: 0x003C1A90 File Offset: 0x003BFC90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text, ETextCommit CommitMethod)
		{
			FOnEditableTextBoxCommittedEvent.__FOnEditableTextBoxCommittedEvent_DelegateParams* ptr = stackalloc FOnEditableTextBoxCommittedEvent.__FOnEditableTextBoxCommittedEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnEditableTextBoxCommittedEvent.__FOnEditableTextBoxCommittedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditableTextBoxCommittedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			ptr->CommitMethod = CommitMethod;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditableTextBox.__OnEditableTextBoxCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060276AE RID: 161454 RVA: 0x003C1AF8 File Offset: 0x003BFCF8
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
			FText arg = new FText(&((FOnEditableTextBoxCommittedEvent.__FOnEditableTextBoxCommittedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(arg, ((FOnEditableTextBoxCommittedEvent.__FOnEditableTextBoxCommittedEvent_DelegateParams*)__Parameters)->CommitMethod);
		}

		// Token: 0x04015A38 RID: 88632
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.EditableTextBox:OnEditableTextBoxCommittedEvent__DelegateSignature";

		// Token: 0x04015A39 RID: 88633
		private static int RegisterId;

		// Token: 0x02003B91 RID: 15249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnEditableTextBoxCommittedEvent_DelegateParams
		{
			// Token: 0x04017D6B RID: 97643
			[FieldOffset(0)]
			public byte Text;

			// Token: 0x04017D6C RID: 97644
			[FieldOffset(24)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x02003B92 RID: 15250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D6D RID: 97645
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
