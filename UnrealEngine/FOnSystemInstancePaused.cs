using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200260C RID: 9740
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSystemInstancePaused : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060243BE RID: 148414 RVA: 0x0035A541 File Offset: 0x00358741
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemInstancePaused.StaticFunctionPtr();
		}

		// Token: 0x060243BF RID: 148415 RVA: 0x0035A54D File Offset: 0x0035874D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemInstancePaused._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemInstancePaused._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Niagara.OnSystemInstancePaused__DelegateSignature");
			}
			return FOnSystemInstancePaused._FunctionPtr;
		}

		// Token: 0x060243C0 RID: 148416 RVA: 0x0035A570 File Offset: 0x00358770
		public FOnSystemInstancePaused()
		{
		}

		// Token: 0x060243C1 RID: 148417 RVA: 0x0035A578 File Offset: 0x00358778
		[NullableContext(2)]
		public FOnSystemInstancePaused(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243C2 RID: 148418 RVA: 0x0035A582 File Offset: 0x00358782
		public FOnSystemInstancePaused(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243C3 RID: 148419 RVA: 0x0035A58D File Offset: 0x0035878D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UNiagaraComponent, bool>) ?? ((Action<UNiagaraComponent, bool>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060243C4 RID: 148420 RVA: 0x0035A5BF File Offset: 0x003587BF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent, bool> Callback)
		{
			if (FOnSystemInstancePaused.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSystemInstancePaused.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSystemInstancePaused.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSystemInstancePaused.OnScriptCallback));
				}
				FOnSystemInstancePaused.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSystemInstancePaused.RegisterId);
		}

		// Token: 0x060243C5 RID: 148421 RVA: 0x0035A5F9 File Offset: 0x003587F9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060243C6 RID: 148422 RVA: 0x0035A604 File Offset: 0x00358804
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UNiagaraComponent PSystem, bool IsPaused)
		{
			FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams* ptr = stackalloc FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemInstancePaused.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PSystem = ((PSystem != null) ? PSystem.NativePtr : IntPtr.Zero);
			ptr->IsPaused = IsPaused;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060243C7 RID: 148423 RVA: 0x0035A658 File Offset: 0x00358858
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
			UNiagaraComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(((FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams*)__Parameters)->PSystem);
			action(orCreateUObjectByNativePointer, ((FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams*)__Parameters)->IsPaused);
		}

		// Token: 0x04013710 RID: 79632
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013711 RID: 79633
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.OnSystemInstancePaused__DelegateSignature";

		// Token: 0x04013712 RID: 79634
		private static int RegisterId;

		// Token: 0x02003679 RID: 13945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSystemInstancePaused_DelegateParams
		{
			// Token: 0x04017750 RID: 96080
			[FieldOffset(0)]
			public IntPtr PSystem;

			// Token: 0x04017751 RID: 96081
			[FieldOffset(8)]
			public bool IsPaused;
		}

		// Token: 0x0200367A RID: 13946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017752 RID: 96082
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
