using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B1 RID: 10673
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMultiLineEditableTextBoxChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027774 RID: 161652 RVA: 0x003C3656 File Offset: 0x003C1856
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMultiLineEditableTextBoxChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x06027775 RID: 161653 RVA: 0x003C3662 File Offset: 0x003C1862
		private static IntPtr StaticFunctionPtr()
		{
			if (UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature");
			}
			return UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027776 RID: 161654 RVA: 0x003C3685 File Offset: 0x003C1885
		public FOnMultiLineEditableTextBoxChangedEvent()
		{
		}

		// Token: 0x06027777 RID: 161655 RVA: 0x003C368D File Offset: 0x003C188D
		[NullableContext(2)]
		public FOnMultiLineEditableTextBoxChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027778 RID: 161656 RVA: 0x003C3697 File Offset: 0x003C1897
		public FOnMultiLineEditableTextBoxChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027779 RID: 161657 RVA: 0x003C36A2 File Offset: 0x003C18A2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText>) ?? ((Action<FText>)Delegate.CreateDelegate(typeof(Action<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602777A RID: 161658 RVA: 0x003C36D4 File Offset: 0x003C18D4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FText> Callback)
		{
			if (FOnMultiLineEditableTextBoxChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMultiLineEditableTextBoxChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMultiLineEditableTextBoxChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMultiLineEditableTextBoxChangedEvent.OnScriptCallback));
				}
				FOnMultiLineEditableTextBoxChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMultiLineEditableTextBoxChangedEvent.RegisterId);
		}

		// Token: 0x0602777B RID: 161659 RVA: 0x003C370E File Offset: 0x003C190E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602777C RID: 161660 RVA: 0x003C3718 File Offset: 0x003C1918
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text)
		{
			FOnMultiLineEditableTextBoxChangedEvent.__FOnMultiLineEditableTextBoxChangedEvent_DelegateParams* ptr = stackalloc FOnMultiLineEditableTextBoxChangedEvent.__FOnMultiLineEditableTextBoxChangedEvent_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMultiLineEditableTextBoxChangedEvent.__FOnMultiLineEditableTextBoxChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMultiLineEditableTextBoxChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UMultiLineEditableTextBox.__OnMultiLineEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602777D RID: 161661 RVA: 0x003C3774 File Offset: 0x003C1974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FText> action = target as Action<FText>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText obj = new FText(&((FOnMultiLineEditableTextBoxChangedEvent.__FOnMultiLineEditableTextBoxChangedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(obj);
		}

		// Token: 0x04015A71 RID: 88689
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MultiLineEditableTextBox:OnMultiLineEditableTextBoxChangedEvent__DelegateSignature";

		// Token: 0x04015A72 RID: 88690
		private static int RegisterId;

		// Token: 0x02003BB7 RID: 15287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMultiLineEditableTextBoxChangedEvent_DelegateParams
		{
			// Token: 0x04017D9A RID: 97690
			[FieldOffset(0)]
			public byte Text;
		}

		// Token: 0x02003BB8 RID: 15288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D9B RID: 97691
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
