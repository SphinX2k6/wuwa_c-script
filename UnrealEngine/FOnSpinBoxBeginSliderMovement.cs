using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029B8 RID: 10680
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSpinBoxBeginSliderMovement : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277B9 RID: 161721 RVA: 0x003C40D8 File Offset: 0x003C22D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSpinBoxBeginSliderMovement.StaticFunctionPtr();
		}

		// Token: 0x060277BA RID: 161722 RVA: 0x003C40E4 File Offset: 0x003C22E4
		private static IntPtr StaticFunctionPtr()
		{
			if (USpinBox.__OnSpinBoxBeginSliderMovement__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				USpinBox.__OnSpinBoxBeginSliderMovement__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature");
			}
			return USpinBox.__OnSpinBoxBeginSliderMovement__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060277BB RID: 161723 RVA: 0x003C4107 File Offset: 0x003C2307
		public FOnSpinBoxBeginSliderMovement()
		{
		}

		// Token: 0x060277BC RID: 161724 RVA: 0x003C410F File Offset: 0x003C230F
		[NullableContext(2)]
		public FOnSpinBoxBeginSliderMovement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277BD RID: 161725 RVA: 0x003C4119 File Offset: 0x003C2319
		public FOnSpinBoxBeginSliderMovement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277BE RID: 161726 RVA: 0x003C4124 File Offset: 0x003C2324
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277BF RID: 161727 RVA: 0x003C4156 File Offset: 0x003C2356
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnSpinBoxBeginSliderMovement.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSpinBoxBeginSliderMovement.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSpinBoxBeginSliderMovement.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSpinBoxBeginSliderMovement.OnScriptCallback));
				}
				FOnSpinBoxBeginSliderMovement.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSpinBoxBeginSliderMovement.RegisterId);
		}

		// Token: 0x060277C0 RID: 161728 RVA: 0x003C4190 File Offset: 0x003C2390
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277C1 RID: 161729 RVA: 0x003C4199 File Offset: 0x003C2399
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060277C2 RID: 161730 RVA: 0x003C41A4 File Offset: 0x003C23A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04015A7F RID: 88703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SpinBox:OnSpinBoxBeginSliderMovement__DelegateSignature";

		// Token: 0x04015A80 RID: 88704
		private static int RegisterId;

		// Token: 0x02003BC4 RID: 15300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DAC RID: 97708
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
