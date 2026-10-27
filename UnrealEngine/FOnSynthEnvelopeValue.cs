using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037A RID: 890
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSynthEnvelopeValue : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x0004B703 File Offset: 0x00049903
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSynthEnvelopeValue.StaticFunctionPtr();
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0004B70F File Offset: 0x0004990F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSynthEnvelopeValue._FunctionPtr == IntPtr.Zero)
			{
				FOnSynthEnvelopeValue._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature");
			}
			return FOnSynthEnvelopeValue._FunctionPtr;
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0004B732 File Offset: 0x00049932
		public FOnSynthEnvelopeValue()
		{
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0004B73A File Offset: 0x0004993A
		[NullableContext(2)]
		public FOnSynthEnvelopeValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0004B744 File Offset: 0x00049944
		public FOnSynthEnvelopeValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0004B74F File Offset: 0x0004994F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0004B781 File Offset: 0x00049981
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnSynthEnvelopeValue.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSynthEnvelopeValue.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSynthEnvelopeValue.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSynthEnvelopeValue.OnScriptCallback));
				}
				FOnSynthEnvelopeValue.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSynthEnvelopeValue.RegisterId);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0004B7BB File Offset: 0x000499BB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0004B7C4 File Offset: 0x000499C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float EnvelopeValue)
		{
			FOnSynthEnvelopeValue.__FOnSynthEnvelopeValue_DelegateParams* ptr = stackalloc FOnSynthEnvelopeValue.__FOnSynthEnvelopeValue_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnSynthEnvelopeValue.__FOnSynthEnvelopeValue_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSynthEnvelopeValue.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EnvelopeValue = EnvelopeValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0004B800 File Offset: 0x00049A00
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
			action(((FOnSynthEnvelopeValue.__FOnSynthEnvelopeValue_DelegateParams*)__Parameters)->EnvelopeValue);
		}

		// Token: 0x04001545 RID: 5445
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001546 RID: 5446
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature";

		// Token: 0x04001547 RID: 5447
		private static int RegisterId;

		// Token: 0x02002C01 RID: 11265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnSynthEnvelopeValue_DelegateParams
		{
			// Token: 0x04016502 RID: 91394
			[FieldOffset(0)]
			public float EnvelopeValue;
		}

		// Token: 0x02002C02 RID: 11266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016503 RID: 91395
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
