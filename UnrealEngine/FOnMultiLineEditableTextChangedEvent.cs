using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B3 RID: 10675
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMultiLineEditableTextChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027788 RID: 161672 RVA: 0x003C394E File Offset: 0x003C1B4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMultiLineEditableTextChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x06027789 RID: 161673 RVA: 0x003C395A File Offset: 0x003C1B5A
		private static IntPtr StaticFunctionPtr()
		{
			if (UMultiLineEditableText.__OnMultiLineEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMultiLineEditableText.__OnMultiLineEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature");
			}
			return UMultiLineEditableText.__OnMultiLineEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602778A RID: 161674 RVA: 0x003C397D File Offset: 0x003C1B7D
		public FOnMultiLineEditableTextChangedEvent()
		{
		}

		// Token: 0x0602778B RID: 161675 RVA: 0x003C3985 File Offset: 0x003C1B85
		[NullableContext(2)]
		public FOnMultiLineEditableTextChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602778C RID: 161676 RVA: 0x003C398F File Offset: 0x003C1B8F
		public FOnMultiLineEditableTextChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602778D RID: 161677 RVA: 0x003C399A File Offset: 0x003C1B9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText>) ?? ((Action<FText>)Delegate.CreateDelegate(typeof(Action<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602778E RID: 161678 RVA: 0x003C39CC File Offset: 0x003C1BCC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FText> Callback)
		{
			if (FOnMultiLineEditableTextChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMultiLineEditableTextChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMultiLineEditableTextChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMultiLineEditableTextChangedEvent.OnScriptCallback));
				}
				FOnMultiLineEditableTextChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMultiLineEditableTextChangedEvent.RegisterId);
		}

		// Token: 0x0602778F RID: 161679 RVA: 0x003C3A06 File Offset: 0x003C1C06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027790 RID: 161680 RVA: 0x003C3A10 File Offset: 0x003C1C10
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text)
		{
			FOnMultiLineEditableTextChangedEvent.__FOnMultiLineEditableTextChangedEvent_DelegateParams* ptr = stackalloc FOnMultiLineEditableTextChangedEvent.__FOnMultiLineEditableTextChangedEvent_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMultiLineEditableTextChangedEvent.__FOnMultiLineEditableTextChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMultiLineEditableTextChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UMultiLineEditableText.__OnMultiLineEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027791 RID: 161681 RVA: 0x003C3A6C File Offset: 0x003C1C6C
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
			FText obj = new FText(&((FOnMultiLineEditableTextChangedEvent.__FOnMultiLineEditableTextChangedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(obj);
		}

		// Token: 0x04015A75 RID: 88693
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MultiLineEditableText:OnMultiLineEditableTextChangedEvent__DelegateSignature";

		// Token: 0x04015A76 RID: 88694
		private static int RegisterId;

		// Token: 0x02003BBB RID: 15291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMultiLineEditableTextChangedEvent_DelegateParams
		{
			// Token: 0x04017D9F RID: 97695
			[FieldOffset(0)]
			public byte Text;
		}

		// Token: 0x02003BBC RID: 15292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DA0 RID: 97696
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
