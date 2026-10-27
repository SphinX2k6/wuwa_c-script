using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B7 RID: 10679
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSelectionChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277AF RID: 161711 RVA: 0x003C3F5D File Offset: 0x003C215D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSelectionChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060277B0 RID: 161712 RVA: 0x003C3F69 File Offset: 0x003C2169
		private static IntPtr StaticFunctionPtr()
		{
			if (UComboBoxString.__OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UComboBoxString.__OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature");
			}
			return UComboBoxString.__OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060277B1 RID: 161713 RVA: 0x003C3F8C File Offset: 0x003C218C
		public FOnSelectionChangedEvent()
		{
		}

		// Token: 0x060277B2 RID: 161714 RVA: 0x003C3F94 File Offset: 0x003C2194
		[NullableContext(2)]
		public FOnSelectionChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277B3 RID: 161715 RVA: 0x003C3F9E File Offset: 0x003C219E
		public FOnSelectionChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277B4 RID: 161716 RVA: 0x003C3FA9 File Offset: 0x003C21A9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, TEnumAsByte<ESelectInfo>>) ?? ((Action<string, TEnumAsByte<ESelectInfo>>)Delegate.CreateDelegate(typeof(Action<string, TEnumAsByte<ESelectInfo>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277B5 RID: 161717 RVA: 0x003C3FDB File Offset: 0x003C21DB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<ESelectInfo>> Callback)
		{
			if (FOnSelectionChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSelectionChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSelectionChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSelectionChangedEvent.OnScriptCallback));
				}
				FOnSelectionChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSelectionChangedEvent.RegisterId);
		}

		// Token: 0x060277B6 RID: 161718 RVA: 0x003C4015 File Offset: 0x003C2215
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<ESelectInfo>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277B7 RID: 161719 RVA: 0x003C4020 File Offset: 0x003C2220
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string SelectedItem, ESelectInfo SelectionType)
		{
			FOnSelectionChangedEvent.__FOnSelectionChangedEvent_DelegateParams* ptr = stackalloc FOnSelectionChangedEvent.__FOnSelectionChangedEvent_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnSelectionChangedEvent.__FOnSelectionChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSelectionChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UComboBoxString.__OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060277B8 RID: 161720 RVA: 0x003C4080 File Offset: 0x003C2280
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, TEnumAsByte<ESelectInfo>> action = target as Action<string, TEnumAsByte<ESelectInfo>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnSelectionChangedEvent.__FOnSelectionChangedEvent_DelegateParams*)__Parameters)->SelectedItem));
			action(arg, ((FOnSelectionChangedEvent.__FOnSelectionChangedEvent_DelegateParams*)__Parameters)->SelectionType);
		}

		// Token: 0x04015A7D RID: 88701
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.ComboBoxString:OnSelectionChangedEvent__DelegateSignature";

		// Token: 0x04015A7E RID: 88702
		private static int RegisterId;

		// Token: 0x02003BC2 RID: 15298
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnSelectionChangedEvent_DelegateParams
		{
			// Token: 0x04017DA9 RID: 97705
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04017DAA RID: 97706
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x02003BC3 RID: 15299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DAB RID: 97707
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
