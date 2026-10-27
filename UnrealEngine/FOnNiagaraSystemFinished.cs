using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200260B RID: 9739
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNiagaraSystemFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060243B4 RID: 148404 RVA: 0x0035A3E1 File Offset: 0x003585E1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNiagaraSystemFinished.StaticFunctionPtr();
		}

		// Token: 0x060243B5 RID: 148405 RVA: 0x0035A3ED File Offset: 0x003585ED
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNiagaraSystemFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnNiagaraSystemFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature");
			}
			return FOnNiagaraSystemFinished._FunctionPtr;
		}

		// Token: 0x060243B6 RID: 148406 RVA: 0x0035A410 File Offset: 0x00358610
		public FOnNiagaraSystemFinished()
		{
		}

		// Token: 0x060243B7 RID: 148407 RVA: 0x0035A418 File Offset: 0x00358618
		[NullableContext(2)]
		public FOnNiagaraSystemFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243B8 RID: 148408 RVA: 0x0035A422 File Offset: 0x00358622
		public FOnNiagaraSystemFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243B9 RID: 148409 RVA: 0x0035A42D File Offset: 0x0035862D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UNiagaraComponent>) ?? ((Action<UNiagaraComponent>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060243BA RID: 148410 RVA: 0x0035A45F File Offset: 0x0035865F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent> Callback)
		{
			if (FOnNiagaraSystemFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnNiagaraSystemFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnNiagaraSystemFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnNiagaraSystemFinished.OnScriptCallback));
				}
				FOnNiagaraSystemFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnNiagaraSystemFinished.RegisterId);
		}

		// Token: 0x060243BB RID: 148411 RVA: 0x0035A499 File Offset: 0x00358699
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060243BC RID: 148412 RVA: 0x0035A4A4 File Offset: 0x003586A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UNiagaraComponent PSystem)
		{
			FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams* ptr = stackalloc FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNiagaraSystemFinished.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PSystem = ((PSystem != null) ? PSystem.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060243BD RID: 148413 RVA: 0x0035A4F0 File Offset: 0x003586F0
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
			UNiagaraComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(((FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams*)__Parameters)->PSystem);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401370D RID: 79629
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401370E RID: 79630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature";

		// Token: 0x0401370F RID: 79631
		private static int RegisterId;

		// Token: 0x02003677 RID: 13943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnNiagaraSystemFinished_DelegateParams
		{
			// Token: 0x0401774E RID: 96078
			[FieldOffset(0)]
			public IntPtr PSystem;
		}

		// Token: 0x02003678 RID: 13944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401774F RID: 96079
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
