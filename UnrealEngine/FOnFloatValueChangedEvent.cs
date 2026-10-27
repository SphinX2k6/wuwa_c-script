using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A0 RID: 10656
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnFloatValueChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276CD RID: 161485 RVA: 0x003C1FB7 File Offset: 0x003C01B7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFloatValueChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x060276CE RID: 161486 RVA: 0x003C1FC3 File Offset: 0x003C01C3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFloatValueChangedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnFloatValueChangedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnFloatValueChangedEvent__DelegateSignature");
			}
			return FOnFloatValueChangedEvent._FunctionPtr;
		}

		// Token: 0x060276CF RID: 161487 RVA: 0x003C1FE6 File Offset: 0x003C01E6
		public FOnFloatValueChangedEvent()
		{
		}

		// Token: 0x060276D0 RID: 161488 RVA: 0x003C1FEE File Offset: 0x003C01EE
		[NullableContext(2)]
		public FOnFloatValueChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276D1 RID: 161489 RVA: 0x003C1FF8 File Offset: 0x003C01F8
		public FOnFloatValueChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276D2 RID: 161490 RVA: 0x003C2003 File Offset: 0x003C0203
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276D3 RID: 161491 RVA: 0x003C2035 File Offset: 0x003C0235
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnFloatValueChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFloatValueChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFloatValueChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFloatValueChangedEvent.OnScriptCallback));
				}
				FOnFloatValueChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnFloatValueChangedEvent.RegisterId);
		}

		// Token: 0x060276D4 RID: 161492 RVA: 0x003C206F File Offset: 0x003C026F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060276D5 RID: 161493 RVA: 0x003C2078 File Offset: 0x003C0278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Value)
		{
			FOnFloatValueChangedEvent.__FOnFloatValueChangedEvent_DelegateParams* ptr = stackalloc FOnFloatValueChangedEvent.__FOnFloatValueChangedEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnFloatValueChangedEvent.__FOnFloatValueChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFloatValueChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Value = Value;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060276D6 RID: 161494 RVA: 0x003C20B4 File Offset: 0x003C02B4
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
			action(((FOnFloatValueChangedEvent.__FOnFloatValueChangedEvent_DelegateParams*)__Parameters)->Value);
		}

		// Token: 0x04015A41 RID: 88641
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A42 RID: 88642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnFloatValueChangedEvent__DelegateSignature";

		// Token: 0x04015A43 RID: 88643
		private static int RegisterId;

		// Token: 0x02003B99 RID: 15257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnFloatValueChangedEvent_DelegateParams
		{
			// Token: 0x04017D76 RID: 97654
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x02003B9A RID: 15258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D77 RID: 97655
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
