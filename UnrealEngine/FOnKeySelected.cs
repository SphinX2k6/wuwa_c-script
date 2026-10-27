using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A8 RID: 10664
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKeySelected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602771A RID: 161562 RVA: 0x003C2A3B File Offset: 0x003C0C3B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKeySelected.StaticFunctionPtr();
		}

		// Token: 0x0602771B RID: 161563 RVA: 0x003C2A47 File Offset: 0x003C0C47
		private static IntPtr StaticFunctionPtr()
		{
			if (UInputKeySelector.__OnKeySelected__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInputKeySelector.__OnKeySelected__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature");
			}
			return UInputKeySelector.__OnKeySelected__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602771C RID: 161564 RVA: 0x003C2A6A File Offset: 0x003C0C6A
		public FOnKeySelected()
		{
		}

		// Token: 0x0602771D RID: 161565 RVA: 0x003C2A72 File Offset: 0x003C0C72
		[NullableContext(2)]
		public FOnKeySelected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602771E RID: 161566 RVA: 0x003C2A7C File Offset: 0x003C0C7C
		public FOnKeySelected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602771F RID: 161567 RVA: 0x003C2A87 File Offset: 0x003C0C87
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FInputChord>) ?? ((Action<FInputChord>)Delegate.CreateDelegate(typeof(Action<FInputChord>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027720 RID: 161568 RVA: 0x003C2AB9 File Offset: 0x003C0CB9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FInputChord> Callback)
		{
			if (FOnKeySelected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKeySelected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKeySelected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKeySelected.OnScriptCallback));
				}
				FOnKeySelected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKeySelected.RegisterId);
		}

		// Token: 0x06027721 RID: 161569 RVA: 0x003C2AF3 File Offset: 0x003C0CF3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FInputChord> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027722 RID: 161570 RVA: 0x003C2AFC File Offset: 0x003C0CFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FInputChord SelectedKey)
		{
			FOnKeySelected.__FOnKeySelected_DelegateParams* ptr = stackalloc FOnKeySelected.__FOnKeySelected_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FOnKeySelected.__FOnKeySelected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKeySelected.StaticFunctionPtr(), (void*)ptr, 1);
			if (SelectedKey != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputChord.StaticStruct(), &ptr->SelectedKey, SelectedKey.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UInputKeySelector.__OnKeySelected__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027723 RID: 161571 RVA: 0x003C2B64 File Offset: 0x003C0D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FInputChord> action = target as Action<FInputChord>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FInputChord obj = new FInputChord(&((FOnKeySelected.__FOnKeySelected_DelegateParams*)__Parameters)->SelectedKey, true, true);
			action(obj);
		}

		// Token: 0x04015A57 RID: 88663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.InputKeySelector:OnKeySelected__DelegateSignature";

		// Token: 0x04015A58 RID: 88664
		private static int RegisterId;

		// Token: 0x02003BA7 RID: 15271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FOnKeySelected_DelegateParams
		{
			// Token: 0x04017D87 RID: 97671
			[FieldOffset(0)]
			public byte SelectedKey;
		}

		// Token: 0x02003BA8 RID: 15272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D88 RID: 97672
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
