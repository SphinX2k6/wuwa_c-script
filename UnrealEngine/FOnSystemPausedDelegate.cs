using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000415 RID: 1045
	public sealed class FOnSystemPausedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600657E RID: 25982 RVA: 0x000913A9 File Offset: 0x0008F5A9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemPausedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x000913B5 File Offset: 0x0008F5B5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemPausedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemPausedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.OnSystemPausedDelegate__DelegateSignature");
			}
			return FOnSystemPausedDelegate._FunctionPtr;
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x000913D8 File Offset: 0x0008F5D8
		public FOnSystemPausedDelegate()
		{
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x000913E0 File Offset: 0x0008F5E0
		[NullableContext(2)]
		public FOnSystemPausedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x000913EA File Offset: 0x0008F5EA
		public FOnSystemPausedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x000913F5 File Offset: 0x0008F5F5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UNiagaraComponent, bool>) ?? ((Action<UNiagaraComponent, bool>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x00091427 File Offset: 0x0008F627
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

		// Token: 0x06006585 RID: 25989 RVA: 0x00091464 File Offset: 0x0008F664
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UNiagaraComponent NiagaraComponent, bool IsPaused)
		{
			FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams* ptr = stackalloc FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSystemPausedDelegate.__FOnSystemPausedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemPausedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NiagaraComponent = ((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
			ptr->IsPaused = IsPaused;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x000914B8 File Offset: 0x0008F6B8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AAF RID: 10927
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AB0 RID: 10928
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.OnSystemPausedDelegate__DelegateSignature";

		// Token: 0x04002AB1 RID: 10929
		private static int RegisterId;

		// Token: 0x02000B09 RID: 2825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnSystemPausedDelegate_DelegateParams
		{
			// Token: 0x04005BA2 RID: 23458
			[FieldOffset(0)]
			public IntPtr NiagaraComponent;

			// Token: 0x04005BA3 RID: 23459
			[FieldOffset(8)]
			public bool IsPaused;
		}

		// Token: 0x02000B0A RID: 2826
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BA4 RID: 23460
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
