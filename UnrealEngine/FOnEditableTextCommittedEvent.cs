using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299E RID: 10654
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEditableTextCommittedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276B9 RID: 161465 RVA: 0x003C1CC4 File Offset: 0x003BFEC4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEditableTextCommittedEvent.StaticFunctionPtr();
		}

		// Token: 0x060276BA RID: 161466 RVA: 0x003C1CD0 File Offset: 0x003BFED0
		private static IntPtr StaticFunctionPtr()
		{
			if (UEditableText.__OnEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UEditableText.__OnEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature");
			}
			return UEditableText.__OnEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060276BB RID: 161467 RVA: 0x003C1CF3 File Offset: 0x003BFEF3
		public FOnEditableTextCommittedEvent()
		{
		}

		// Token: 0x060276BC RID: 161468 RVA: 0x003C1CFB File Offset: 0x003BFEFB
		[NullableContext(2)]
		public FOnEditableTextCommittedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276BD RID: 161469 RVA: 0x003C1D05 File Offset: 0x003BFF05
		public FOnEditableTextCommittedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276BE RID: 161470 RVA: 0x003C1D10 File Offset: 0x003BFF10
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FText, TEnumAsByte<ETextCommit>>) ?? ((Action<FText, TEnumAsByte<ETextCommit>>)Delegate.CreateDelegate(typeof(Action<FText, TEnumAsByte<ETextCommit>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276BF RID: 161471 RVA: 0x003C1D42 File Offset: 0x003BFF42
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FText, TEnumAsByte<ETextCommit>> Callback)
		{
			if (FOnEditableTextCommittedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEditableTextCommittedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEditableTextCommittedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEditableTextCommittedEvent.OnScriptCallback));
				}
				FOnEditableTextCommittedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEditableTextCommittedEvent.RegisterId);
		}

		// Token: 0x060276C0 RID: 161472 RVA: 0x003C1D7C File Offset: 0x003BFF7C
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

		// Token: 0x060276C1 RID: 161473 RVA: 0x003C1D88 File Offset: 0x003BFF88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FText Text, ETextCommit CommitMethod)
		{
			FOnEditableTextCommittedEvent.__FOnEditableTextCommittedEvent_DelegateParams* ptr = stackalloc FOnEditableTextCommittedEvent.__FOnEditableTextCommittedEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnEditableTextCommittedEvent.__FOnEditableTextCommittedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEditableTextCommittedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->Text), Text.NativePtr);
			ptr->CommitMethod = CommitMethod;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UEditableText.__OnEditableTextCommittedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060276C2 RID: 161474 RVA: 0x003C1DF0 File Offset: 0x003BFFF0
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
			FText arg = new FText(&((FOnEditableTextCommittedEvent.__FOnEditableTextCommittedEvent_DelegateParams*)__Parameters)->Text, true, true);
			action(arg, ((FOnEditableTextCommittedEvent.__FOnEditableTextCommittedEvent_DelegateParams*)__Parameters)->CommitMethod);
		}

		// Token: 0x04015A3C RID: 88636
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.EditableText:OnEditableTextCommittedEvent__DelegateSignature";

		// Token: 0x04015A3D RID: 88637
		private static int RegisterId;

		// Token: 0x02003B95 RID: 15253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnEditableTextCommittedEvent_DelegateParams
		{
			// Token: 0x04017D70 RID: 97648
			[FieldOffset(0)]
			public byte Text;

			// Token: 0x04017D71 RID: 97649
			[FieldOffset(24)]
			public TEnumAsByte<ETextCommit> CommitMethod;
		}

		// Token: 0x02003B96 RID: 15254
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D72 RID: 97650
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
