using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001927 RID: 6439
	public sealed class FOnSystemPausedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017E08 RID: 97800 RVA: 0x0022FDA9 File Offset: 0x0022DFA9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemPausedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06017E09 RID: 97801 RVA: 0x0022FDB5 File Offset: 0x0022DFB5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemPausedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemPausedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.OnSystemPausedDelegate__DelegateSignature");
			}
			return FOnSystemPausedDelegate._FunctionPtr;
		}

		// Token: 0x06017E0A RID: 97802 RVA: 0x0022FDD8 File Offset: 0x0022DFD8
		public FOnSystemPausedDelegate()
		{
		}

		// Token: 0x06017E0B RID: 97803 RVA: 0x0022FDE0 File Offset: 0x0022DFE0
		[NullableContext(2)]
		public FOnSystemPausedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E0C RID: 97804 RVA: 0x0022FDEA File Offset: 0x0022DFEA
		public FOnSystemPausedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E0D RID: 97805 RVA: 0x0022FDF5 File Offset: 0x0022DFF5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UNiagaraComponent, bool>) ?? ((Action<UNiagaraComponent, bool>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017E0E RID: 97806 RVA: 0x0022FE27 File Offset: 0x0022E027
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent, bool> Callback)
		{
			if (FOnSystemPausedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSystemPausedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSystemPausedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSystemPausedDelegate.OnScriptCallback));
				}
				FOnSystemPausedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSystemPausedDelegate.RegisterId);
		}

		// Token: 0x06017E0F RID: 97807 RVA: 0x0022FE64 File Offset: 0x0022E064
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UNiagaraComponent NiagaraComponent, bool IsPaused)
		{
			FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams* ptr = stackalloc FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemPausedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NiagaraComponent = ((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
			ptr->IsPaused = IsPaused;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017E10 RID: 97808 RVA: 0x0022FEB8 File Offset: 0x0022E0B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UNiagaraComponent, bool> action = target as Action<UNiagaraComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UNiagaraComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(((FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams*)__Parameters)->NiagaraComponent);
			action(orCreateUObjectByNativePointer, ((FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams*)__Parameters)->IsPaused);
		}

		// Token: 0x0400CEEA RID: 52970
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEEB RID: 52971
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.OnSystemPausedDelegate__DelegateSignature";

		// Token: 0x0400CEEC RID: 52972
		private static int RegisterId;

		// Token: 0x02002FF5 RID: 12277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSystemPausedDelegate_DelegateParams
		{
			// Token: 0x04016BF9 RID: 93177
			[FieldOffset(0)]
			public IntPtr NiagaraComponent;

			// Token: 0x04016BFA RID: 93178
			[FieldOffset(8)]
			public bool IsPaused;
		}

		// Token: 0x02002FF6 RID: 12278
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BFB RID: 93179
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
