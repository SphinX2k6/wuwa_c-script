using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299B RID: 10651
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEditableTextBoxChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602769B RID: 161435 RVA: 0x003C1859 File Offset: 0x003BFA59
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditableTextBoxChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x0602769C RID: 161436 RVA: 0x003C1865 File Offset: 0x003BFA65
		private static IntPtr StaticFunctionPtr()
		{
			if (UEditableTextBox.__OnEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UEditableTextBox.__OnEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature");
			}
			return UEditableTextBox.__OnEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602769D RID: 161437 RVA: 0x003C1888 File Offset: 0x003BFA88
		public FOnEditableTextBoxChangedEvent()
		{
		}

		// Token: 0x0602769E RID: 161438 RVA: 0x003C1890 File Offset: 0x003BFA90
		[NullableContext(2)]
		public FOnEditableTextBoxChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602769F RID: 161439 RVA: 0x003C189A File Offset: 0x003BFA9A
		public FOnEditableTextBoxChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276A0 RID: 161440 RVA: 0x003C18A5 File Offset: 0x003BFAA5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText>) ?? ((Action<FText>)Delegate.CreateDelegate(typeof(Action<FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276A1 RID: 161441 RVA: 0x003C18D7 File Offset: 0x003BFAD7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FText> Callback)
		{
			if (FOnEditableTextBoxChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEditableTextBoxChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEditableTextBoxChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEditableTextBoxChangedEvent.OnScriptCallback));
				}
				FOnEditableTextBoxChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEditableTextBoxChangedEvent.RegisterId);
		}

		// Token: 0x060276A2 RID: 161442 RVA: 0x003C1911 File Offset: 0x003BFB11
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060276A3 RID: 161443 RVA: 0x003C191C File Offset: 0x003BFB1C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text)
		{
			FOnEditableTextBoxChangedEvent.__FOnEditableTextBoxChangedEvent_DelegateParams* ptr = stackalloc FOnEditableTextBoxChangedEvent.__FOnEditableTextBoxChangedEvent_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnEditableTextBoxChangedEvent.__FOnEditableTextBoxChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditableTextBoxChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditableTextBox.__OnEditableTextBoxChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060276A4 RID: 161444 RVA: 0x003C1978 File Offset: 0x003BFB78
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
			FText obj = new FText(&((FOnEditableTextBoxChangedEvent.__FOnEditableTextBoxChangedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(obj);
		}

		// Token: 0x04015A36 RID: 88630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.EditableTextBox:OnEditableTextBoxChangedEvent__DelegateSignature";

		// Token: 0x04015A37 RID: 88631
		private static int RegisterId;

		// Token: 0x02003B8F RID: 15247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnEditableTextBoxChangedEvent_DelegateParams
		{
			// Token: 0x04017D69 RID: 97641
			[FieldOffset(0)]
			public byte Text;
		}

		// Token: 0x02003B90 RID: 15248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D6A RID: 97642
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
