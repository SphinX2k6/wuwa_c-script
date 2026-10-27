using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F1C RID: 3868
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageBlendingOutStartedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0F9 RID: 53497 RVA: 0x0013189A File Offset: 0x0012FA9A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageBlendingOutStartedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0FA RID: 53498 RVA: 0x001318A6 File Offset: 0x0012FAA6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageBlendingOutStartedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageBlendingOutStartedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature");
			}
			return FOnMontageBlendingOutStartedMCDelegate._FunctionPtr;
		}

		// Token: 0x0600D0FB RID: 53499 RVA: 0x001318C9 File Offset: 0x0012FAC9
		public FOnMontageBlendingOutStartedMCDelegate()
		{
		}

		// Token: 0x0600D0FC RID: 53500 RVA: 0x001318D1 File Offset: 0x0012FAD1
		[NullableContext(2)]
		public FOnMontageBlendingOutStartedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x001318DB File Offset: 0x0012FADB
		public FOnMontageBlendingOutStartedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x001318E6 File Offset: 0x0012FAE6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage, bool>) ?? ((Action<UAnimMontage, bool>)Delegate.CreateDelegate(typeof(Action<UAnimMontage, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x00131918 File Offset: 0x0012FB18
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			if (FOnMontageBlendingOutStartedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageBlendingOutStartedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageBlendingOutStartedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageBlendingOutStartedMCDelegate.OnScriptCallback));
				}
				FOnMontageBlendingOutStartedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageBlendingOutStartedMCDelegate.RegisterId);
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x00131952 File Offset: 0x0012FB52
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x0013195C File Offset: 0x0012FB5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UAnimMontage Montage, bool bInterrupted)
		{
			FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageBlendingOutStartedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x001319B0 File Offset: 0x0012FBB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAnimMontage, bool> action = target as Action<UAnimMontage, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAnimMontage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(((FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams*)__Parameters)->Montage);
			action(orCreateUObjectByNativePointer, ((FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams*)__Parameters)->bInterrupted);
		}

		// Token: 0x04007062 RID: 28770
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007063 RID: 28771
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature";

		// Token: 0x04007064 RID: 28772
		private static int RegisterId;

		// Token: 0x02002D80 RID: 11648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnMontageBlendingOutStartedMCDelegate_DelegateParams
		{
			// Token: 0x040167A1 RID: 92065
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x040167A2 RID: 92066
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x02002D81 RID: 11649
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167A3 RID: 92067
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
