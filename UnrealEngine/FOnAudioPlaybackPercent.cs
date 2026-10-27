using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F07 RID: 3847
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioPlaybackPercent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D036 RID: 53302 RVA: 0x0012FE32 File Offset: 0x0012E032
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioPlaybackPercent.StaticFunctionPtr();
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x0012FE3E File Offset: 0x0012E03E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioPlaybackPercent._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioPlaybackPercent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioPlaybackPercent__DelegateSignature");
			}
			return FOnAudioPlaybackPercent._FunctionPtr;
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x0012FE61 File Offset: 0x0012E061
		public FOnAudioPlaybackPercent()
		{
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x0012FE69 File Offset: 0x0012E069
		[NullableContext(2)]
		public FOnAudioPlaybackPercent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x0012FE73 File Offset: 0x0012E073
		public FOnAudioPlaybackPercent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D03B RID: 53307 RVA: 0x0012FE7E File Offset: 0x0012E07E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USoundWave, float>) ?? ((Action<USoundWave, float>)Delegate.CreateDelegate(typeof(Action<USoundWave, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D03C RID: 53308 RVA: 0x0012FEB0 File Offset: 0x0012E0B0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave, float> Callback)
		{
			if (FOnAudioPlaybackPercent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioPlaybackPercent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioPlaybackPercent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioPlaybackPercent.OnScriptCallback));
				}
				FOnAudioPlaybackPercent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioPlaybackPercent.RegisterId);
		}

		// Token: 0x0600D03D RID: 53309 RVA: 0x0012FEEA File Offset: 0x0012E0EA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D03E RID: 53310 RVA: 0x0012FEF4 File Offset: 0x0012E0F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USoundWave PlayingSoundWave, float PlaybackPercent)
		{
			FOnAudioPlaybackPercent.__FOnAudioPlaybackPercent_DelegateParams* ptr = stackalloc FOnAudioPlaybackPercent.__FOnAudioPlaybackPercent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAudioPlaybackPercent.__FOnAudioPlaybackPercent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioPlaybackPercent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PlayingSoundWave = ((PlayingSoundWave != null) ? PlayingSoundWave.NativePtr : IntPtr.Zero);
			ptr->PlaybackPercent = PlaybackPercent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x0012FF48 File Offset: 0x0012E148
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
			USoundWave orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundWave>(((FOnAudioPlaybackPercent.__FOnAudioPlaybackPercent_DelegateParams*)__Parameters)->PlayingSoundWave);
			action(orCreateUObjectByNativePointer, ((FOnAudioPlaybackPercent.__FOnAudioPlaybackPercent_DelegateParams*)__Parameters)->PlaybackPercent);
		}

		// Token: 0x0400702A RID: 28714
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400702B RID: 28715
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioPlaybackPercent__DelegateSignature";

		// Token: 0x0400702C RID: 28716
		private static int RegisterId;

		// Token: 0x02002D5D RID: 11613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnAudioPlaybackPercent_DelegateParams
		{
			// Token: 0x04016773 RID: 92019
			[FieldOffset(0)]
			public IntPtr PlayingSoundWave;

			// Token: 0x04016774 RID: 92020
			[FieldOffset(8)]
			public float PlaybackPercent;
		}

		// Token: 0x02002D5E RID: 11614
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016775 RID: 92021
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
