using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F06 RID: 3846
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioMultiEnvelopeValue : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D02C RID: 53292 RVA: 0x0012FCCE File Offset: 0x0012DECE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioMultiEnvelopeValue.StaticFunctionPtr();
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x0012FCDA File Offset: 0x0012DEDA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioMultiEnvelopeValue._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioMultiEnvelopeValue._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature");
			}
			return FOnAudioMultiEnvelopeValue._FunctionPtr;
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x0012FCFD File Offset: 0x0012DEFD
		public FOnAudioMultiEnvelopeValue()
		{
		}

		// Token: 0x0600D02F RID: 53295 RVA: 0x0012FD05 File Offset: 0x0012DF05
		[NullableContext(2)]
		public FOnAudioMultiEnvelopeValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x0012FD0F File Offset: 0x0012DF0F
		public FOnAudioMultiEnvelopeValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x0012FD1A File Offset: 0x0012DF1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, float, int>) ?? ((Action<float, float, int>)Delegate.CreateDelegate(typeof(Action<float, float, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D032 RID: 53298 RVA: 0x0012FD4C File Offset: 0x0012DF4C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float, float, int> Callback)
		{
			if (FOnAudioMultiEnvelopeValue.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioMultiEnvelopeValue.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioMultiEnvelopeValue.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioMultiEnvelopeValue.OnScriptCallback));
				}
				FOnAudioMultiEnvelopeValue.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioMultiEnvelopeValue.RegisterId);
		}

		// Token: 0x0600D033 RID: 53299 RVA: 0x0012FD86 File Offset: 0x0012DF86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, float, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x0012FD90 File Offset: 0x0012DF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances)
		{
			FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams* ptr = stackalloc FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioMultiEnvelopeValue.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AverageEnvelopeValue = AverageEnvelopeValue;
			ptr->MaxEnvelope = MaxEnvelope;
			ptr->NumWaveInstances = NumWaveInstances;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D035 RID: 53301 RVA: 0x0012FDDC File Offset: 0x0012DFDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, float, int> action = target as Action<float, float, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams*)__Parameters)->AverageEnvelopeValue, ((FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams*)__Parameters)->MaxEnvelope, ((FOnAudioMultiEnvelopeValue.__FOnAudioMultiEnvelopeValue_DelegateParams*)__Parameters)->NumWaveInstances);
		}

		// Token: 0x04007027 RID: 28711
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007028 RID: 28712
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature";

		// Token: 0x04007029 RID: 28713
		private static int RegisterId;

		// Token: 0x02002D5B RID: 11611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnAudioMultiEnvelopeValue_DelegateParams
		{
			// Token: 0x0401676F RID: 92015
			[FieldOffset(0)]
			public float AverageEnvelopeValue;

			// Token: 0x04016770 RID: 92016
			[FieldOffset(4)]
			public float MaxEnvelope;

			// Token: 0x04016771 RID: 92017
			[FieldOffset(8)]
			public int NumWaveInstances;
		}

		// Token: 0x02002D5C RID: 11612
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016772 RID: 92018
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
