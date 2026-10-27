using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F1E RID: 3870
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageStartedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D10D RID: 53517 RVA: 0x00131B73 File Offset: 0x0012FD73
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageStartedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D10E RID: 53518 RVA: 0x00131B7F File Offset: 0x0012FD7F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageStartedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageStartedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature");
			}
			return FOnMontageStartedMCDelegate._FunctionPtr;
		}

		// Token: 0x0600D10F RID: 53519 RVA: 0x00131BA2 File Offset: 0x0012FDA2
		public FOnMontageStartedMCDelegate()
		{
		}

		// Token: 0x0600D110 RID: 53520 RVA: 0x00131BAA File Offset: 0x0012FDAA
		[NullableContext(2)]
		public FOnMontageStartedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D111 RID: 53521 RVA: 0x00131BB4 File Offset: 0x0012FDB4
		public FOnMontageStartedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D112 RID: 53522 RVA: 0x00131BBF File Offset: 0x0012FDBF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage>) ?? ((Action<UAnimMontage>)Delegate.CreateDelegate(typeof(Action<UAnimMontage>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D113 RID: 53523 RVA: 0x00131BF1 File Offset: 0x0012FDF1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage> Callback)
		{
			if (FOnMontageStartedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageStartedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageStartedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageStartedMCDelegate.OnScriptCallback));
				}
				FOnMontageStartedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageStartedMCDelegate.RegisterId);
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x00131C2B File Offset: 0x0012FE2B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x00131C34 File Offset: 0x0012FE34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UAnimMontage Montage)
		{
			FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageStartedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x00131C80 File Offset: 0x0012FE80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAnimMontage> action = target as Action<UAnimMontage>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAnimMontage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(((FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams*)__Parameters)->Montage);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04007068 RID: 28776
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007069 RID: 28777
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature";

		// Token: 0x0400706A RID: 28778
		private static int RegisterId;

		// Token: 0x02002D84 RID: 11652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnMontageStartedMCDelegate_DelegateParams
		{
			// Token: 0x040167A7 RID: 92071
			[FieldOffset(0)]
			public IntPtr Montage;
		}

		// Token: 0x02002D85 RID: 11653
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167A8 RID: 92072
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
