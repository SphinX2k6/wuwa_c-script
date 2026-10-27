using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F09 RID: 3849
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioSingleEnvelopeValue : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D04A RID: 53322 RVA: 0x001300E6 File Offset: 0x0012E2E6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioSingleEnvelopeValue.StaticFunctionPtr();
		}

		// Token: 0x0600D04B RID: 53323 RVA: 0x001300F2 File Offset: 0x0012E2F2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioSingleEnvelopeValue._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioSingleEnvelopeValue._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature");
			}
			return FOnAudioSingleEnvelopeValue._FunctionPtr;
		}

		// Token: 0x0600D04C RID: 53324 RVA: 0x00130115 File Offset: 0x0012E315
		public FOnAudioSingleEnvelopeValue()
		{
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x0013011D File Offset: 0x0012E31D
		[NullableContext(2)]
		public FOnAudioSingleEnvelopeValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x00130127 File Offset: 0x0012E327
		public FOnAudioSingleEnvelopeValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D04F RID: 53327 RVA: 0x00130132 File Offset: 0x0012E332
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USoundWave, float>) ?? ((Action<USoundWave, float>)Delegate.CreateDelegate(typeof(Action<USoundWave, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D050 RID: 53328 RVA: 0x00130164 File Offset: 0x0012E364
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave, float> Callback)
		{
			if (FOnAudioSingleEnvelopeValue.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioSingleEnvelopeValue.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioSingleEnvelopeValue.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioSingleEnvelopeValue.OnScriptCallback));
				}
				FOnAudioSingleEnvelopeValue.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioSingleEnvelopeValue.RegisterId);
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x0013019E File Offset: 0x0012E39E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x001301A8 File Offset: 0x0012E3A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USoundWave PlayingSoundWave, float EnvelopeValue)
		{
			FOnAudioSingleEnvelopeValue.__FOnAudioSingleEnvelopeValue_DelegateParams* ptr = stackalloc FOnAudioSingleEnvelopeValue.__FOnAudioSingleEnvelopeValue_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAudioSingleEnvelopeValue.__FOnAudioSingleEnvelopeValue_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioSingleEnvelopeValue.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PlayingSoundWave = ((PlayingSoundWave != null) ? PlayingSoundWave.NativePtr : IntPtr.Zero);
			ptr->EnvelopeValue = EnvelopeValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x001301FC File Offset: 0x0012E3FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USoundWave, float> action = target as Action<USoundWave, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USoundWave orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundWave>(((FOnAudioSingleEnvelopeValue.__FOnAudioSingleEnvelopeValue_DelegateParams*)__Parameters)->PlayingSoundWave);
			action(orCreateUObjectByNativePointer, ((FOnAudioSingleEnvelopeValue.__FOnAudioSingleEnvelopeValue_DelegateParams*)__Parameters)->EnvelopeValue);
		}

		// Token: 0x04007030 RID: 28720
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007031 RID: 28721
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature";

		// Token: 0x04007032 RID: 28722
		private static int RegisterId;

		// Token: 0x02002D61 RID: 11617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnAudioSingleEnvelopeValue_DelegateParams
		{
			// Token: 0x04016778 RID: 92024
			[FieldOffset(0)]
			public IntPtr PlayingSoundWave;

			// Token: 0x04016779 RID: 92025
			[FieldOffset(8)]
			public float EnvelopeValue;
		}

		// Token: 0x02002D62 RID: 11618
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401677A RID: 92026
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
