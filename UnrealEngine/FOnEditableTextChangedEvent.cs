using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299D RID: 10653
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEditableTextChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276AF RID: 161455 RVA: 0x003C1B52 File Offset: 0x003BFD52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditableTextChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060276B0 RID: 161456 RVA: 0x003C1B5E File Offset: 0x003BFD5E
		private static IntPtr StaticFunctionPtr()
		{
			if (UEditableText.__OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UEditableText.__OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature");
			}
			return UEditableText.__OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060276B1 RID: 161457 RVA: 0x003C1B81 File Offset: 0x003BFD81
		public FOnEditableTextChangedEvent()
		{
		}

		// Token: 0x060276B2 RID: 161458 RVA: 0x003C1B89 File Offset: 0x003BFD89
		[NullableContext(2)]
		public FOnEditableTextChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276B3 RID: 161459 RVA: 0x003C1B93 File Offset: 0x003BFD93
		public FOnEditableTextChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276B4 RID: 161460 RVA: 0x003C1B9E File Offset: 0x003BFD9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText>) ?? ((Action<FText>)Delegate.CreateDelegate(typeof(Action<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276B5 RID: 161461 RVA: 0x003C1BD0 File Offset: 0x003BFDD0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FText> Callback)
		{
			if (FOnEditableTextChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEditableTextChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEditableTextChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEditableTextChangedEvent.OnScriptCallback));
				}
				FOnEditableTextChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEditableTextChangedEvent.RegisterId);
		}

		// Token: 0x060276B6 RID: 161462 RVA: 0x003C1C0A File Offset: 0x003BFE0A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060276B7 RID: 161463 RVA: 0x003C1C14 File Offset: 0x003BFE14
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text)
		{
			FOnEditableTextChangedEvent.__FOnEditableTextChangedEvent_DelegateParams* ptr = stackalloc FOnEditableTextChangedEvent.__FOnEditableTextChangedEvent_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnEditableTextChangedEvent.__FOnEditableTextChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditableTextChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditableText.__OnEditableTextChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060276B8 RID: 161464 RVA: 0x003C1C70 File Offset: 0x003BFE70
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
			FText obj = new FText(&((FOnEditableTextChangedEvent.__FOnEditableTextChangedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(obj);
		}

		// Token: 0x04015A3A RID: 88634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.EditableText:OnEditableTextChangedEvent__DelegateSignature";

		// Token: 0x04015A3B RID: 88635
		private static int RegisterId;

		// Token: 0x02003B93 RID: 15251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnEditableTextChangedEvent_DelegateParams
		{
			// Token: 0x04017D6E RID: 97646
			[FieldOffset(0)]
			public byte Text;
		}

		// Token: 0x02003B94 RID: 15252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D6F RID: 97647
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
