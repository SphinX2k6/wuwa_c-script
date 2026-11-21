using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000414 RID: 1044
	public sealed class FOnSystemFinishedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006575 RID: 25973 RVA: 0x00091252 File Offset: 0x0008F452
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemFinishedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x0009125E File Offset: 0x0008F45E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemFinishedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemFinishedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.OnSystemFinishedDelegate__DelegateSignature");
			}
			return FOnSystemFinishedDelegate._FunctionPtr;
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00091281 File Offset: 0x0008F481
		public FOnSystemFinishedDelegate()
		{
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00091289 File Offset: 0x0008F489
		[NullableContext(2)]
		public FOnSystemFinishedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00091293 File Offset: 0x0008F493
		public FOnSystemFinishedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x0009129E File Offset: 0x0008F49E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UNiagaraComponent>) ?? ((Action<UNiagaraComponent>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x000912D0 File Offset: 0x0008F4D0
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

		// Token: 0x0600657C RID: 25980 RVA: 0x0009130C File Offset: 0x0008F50C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UNiagaraComponent NiagaraComponent)
		{
			FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams* ptr = stackalloc FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSystemFinishedDelegate.__FOnSystemFinishedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemFinishedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NiagaraComponent = ((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x00091358 File Offset: 0x0008F558
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AAC RID: 10924
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AAD RID: 10925
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.OnSystemFinishedDelegate__DelegateSignature";

		// Token: 0x04002AAE RID: 10926
		private static int RegisterId;

		// Token: 0x02000B07 RID: 2823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnSystemFinishedDelegate_DelegateParams
		{
			// Token: 0x04005BA0 RID: 23456
			[FieldOffset(0)]
			public IntPtr NiagaraComponent;
		}

		// Token: 0x02000B08 RID: 2824
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BA1 RID: 23457
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
