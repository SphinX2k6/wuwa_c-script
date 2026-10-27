using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001926 RID: 6438
	public sealed class FOnSystemFinishedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DFF RID: 97791 RVA: 0x0022FC52 File Offset: 0x0022DE52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemFinishedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06017E00 RID: 97792 RVA: 0x0022FC5E File Offset: 0x0022DE5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemFinishedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemFinishedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.OnSystemFinishedDelegate__DelegateSignature");
			}
			return FOnSystemFinishedDelegate._FunctionPtr;
		}

		// Token: 0x06017E01 RID: 97793 RVA: 0x0022FC81 File Offset: 0x0022DE81
		public FOnSystemFinishedDelegate()
		{
		}

		// Token: 0x06017E02 RID: 97794 RVA: 0x0022FC89 File Offset: 0x0022DE89
		[NullableContext(2)]
		public FOnSystemFinishedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E03 RID: 97795 RVA: 0x0022FC93 File Offset: 0x0022DE93
		public FOnSystemFinishedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x0022FC9E File Offset: 0x0022DE9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UNiagaraComponent>) ?? ((Action<UNiagaraComponent>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x0022FCD0 File Offset: 0x0022DED0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent> Callback)
		{
			if (FOnSystemFinishedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSystemFinishedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSystemFinishedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSystemFinishedDelegate.OnScriptCallback));
				}
				FOnSystemFinishedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSystemFinishedDelegate.RegisterId);
		}

		// Token: 0x06017E06 RID: 97798 RVA: 0x0022FD0C File Offset: 0x0022DF0C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UNiagaraComponent NiagaraComponent)
		{
			FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams* ptr = stackalloc FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemFinishedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NiagaraComponent = ((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017E07 RID: 97799 RVA: 0x0022FD58 File Offset: 0x0022DF58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UNiagaraComponent> action = target as Action<UNiagaraComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UNiagaraComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(((FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams*)__Parameters)->NiagaraComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400CEE7 RID: 52967
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CEE8 RID: 52968
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.OnSystemFinishedDelegate__DelegateSignature";

		// Token: 0x0400CEE9 RID: 52969
		private static int RegisterId;

		// Token: 0x02002FF3 RID: 12275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnSystemFinishedDelegate_DelegateParams
		{
			// Token: 0x04016BF7 RID: 93175
			[FieldOffset(0)]
			public IntPtr NiagaraComponent;
		}

		// Token: 0x02002FF4 RID: 12276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BF8 RID: 93176
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
