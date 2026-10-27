using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029B9 RID: 10681
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSpinBoxValueChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060277C3 RID: 161731 RVA: 0x003C41E6 File Offset: 0x003C23E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSpinBoxValueChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060277C4 RID: 161732 RVA: 0x003C41F2 File Offset: 0x003C23F2
		private static IntPtr StaticFunctionPtr()
		{
			if (USpinBox.__OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				USpinBox.__OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SpinBox:OnSpinBoxValueChangedEvent__DelegateSignature");
			}
			return USpinBox.__OnSpinBoxValueChangedEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060277C5 RID: 161733 RVA: 0x003C4215 File Offset: 0x003C2415
		public FOnSpinBoxValueChangedEvent()
		{
		}

		// Token: 0x060277C6 RID: 161734 RVA: 0x003C421D File Offset: 0x003C241D
		[NullableContext(2)]
		public FOnSpinBoxValueChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060277C7 RID: 161735 RVA: 0x003C4227 File Offset: 0x003C2427
		public FOnSpinBoxValueChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060277C8 RID: 161736 RVA: 0x003C4232 File Offset: 0x003C2432
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060277C9 RID: 161737 RVA: 0x003C4264 File Offset: 0x003C2464
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnSpinBoxValueChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSpinBoxValueChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSpinBoxValueChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSpinBoxValueChangedEvent.OnScriptCallback));
				}
				FOnSpinBoxValueChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSpinBoxValueChangedEvent.RegisterId);
		}

		// Token: 0x060277CA RID: 161738 RVA: 0x003C429E File Offset: 0x003C249E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060277CB RID: 161739 RVA: 0x003C42A8 File Offset: 0x003C24A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float InValue)
		{
			FOnSpinBoxValueChangedEvent.__FOnSpinBoxValueChangedEvent_DelegateParams* ptr = stackalloc FOnSpinBoxValueChangedEvent.__FOnSpinBoxValueChangedEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnSpinBoxValueChangedEvent.__FOnSpinBoxValueChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSpinBoxValueChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InValue = InValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060277CC RID: 161740 RVA: 0x003C42E4 File Offset: 0x003C24E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSpinBoxValueChangedEvent.__FOnSpinBoxValueChangedEvent_DelegateParams*)__Parameters)->InValue);
		}

		// Token: 0x04015A81 RID: 88705
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SpinBox:OnSpinBoxValueChangedEvent__DelegateSignature";

		// Token: 0x04015A82 RID: 88706
		private static int RegisterId;

		// Token: 0x02003BC5 RID: 15301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnSpinBoxValueChangedEvent_DelegateParams
		{
			// Token: 0x04017DAD RID: 97709
			[FieldOffset(0)]
			public float InValue;
		}

		// Token: 0x02003BC6 RID: 15302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DAE RID: 97710
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
