using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001692 RID: 5778
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FEnvironmentUpdatedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014F4D RID: 85837 RVA: 0x001ECE5E File Offset: 0x001EB05E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEnvironmentUpdatedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06014F4E RID: 85838 RVA: 0x001ECE6A File Offset: 0x001EB06A
		private static IntPtr StaticFunctionPtr()
		{
			if (UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioEnvironmentSubsystem:EnvironmentUpdatedDelegate__DelegateSignature");
			}
			return UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06014F4F RID: 85839 RVA: 0x001ECE8D File Offset: 0x001EB08D
		public FEnvironmentUpdatedDelegate()
		{
		}

		// Token: 0x06014F50 RID: 85840 RVA: 0x001ECE95 File Offset: 0x001EB095
		[NullableContext(2)]
		public FEnvironmentUpdatedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014F51 RID: 85841 RVA: 0x001ECE9F File Offset: 0x001EB09F
		public FEnvironmentUpdatedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014F52 RID: 85842 RVA: 0x001ECEAA File Offset: 0x001EB0AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014F53 RID: 85843 RVA: 0x001ECEDC File Offset: 0x001EB0DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FEnvironmentUpdatedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEnvironmentUpdatedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEnvironmentUpdatedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEnvironmentUpdatedDelegate.OnScriptCallback));
				}
				FEnvironmentUpdatedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FEnvironmentUpdatedDelegate.RegisterId);
		}

		// Token: 0x06014F54 RID: 85844 RVA: 0x001ECF16 File Offset: 0x001EB116
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06014F55 RID: 85845 RVA: 0x001ECF1F File Offset: 0x001EB11F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06014F56 RID: 85846 RVA: 0x001ECF2C File Offset: 0x001EB12C
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

		// Token: 0x0400B6B8 RID: 46776
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentSubsystem:EnvironmentUpdatedDelegate__DelegateSignature";

		// Token: 0x0400B6B9 RID: 46777
		private static int RegisterId;

		// Token: 0x02002EDD RID: 11997
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169FB RID: 92667
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
