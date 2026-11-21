using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AB RID: 1963
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNiagaraSystemFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AAB7 RID: 43703 RVA: 0x000FBBFA File Offset: 0x000F9DFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNiagaraSystemFinished.StaticFunctionPtr();
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x000FBC06 File Offset: 0x000F9E06
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNiagaraSystemFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnNiagaraSystemFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature");
			}
			return FOnNiagaraSystemFinished._FunctionPtr;
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x000FBC29 File Offset: 0x000F9E29
		public FOnNiagaraSystemFinished()
		{
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x000FBC31 File Offset: 0x000F9E31
		[NullableContext(2)]
		public FOnNiagaraSystemFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AABB RID: 43707 RVA: 0x000FBC3B File Offset: 0x000F9E3B
		public FOnNiagaraSystemFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AABC RID: 43708 RVA: 0x000FBC46 File Offset: 0x000F9E46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UNiagaraComponent>) ?? ((Action<UNiagaraComponent>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x000FBC78 File Offset: 0x000F9E78
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

		// Token: 0x0600AABE RID: 43710 RVA: 0x000FBCB2 File Offset: 0x000F9EB2
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AABF RID: 43711 RVA: 0x000FBCBC File Offset: 0x000F9EBC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UNiagaraComponent PSystem)
		{
			FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams* ptr = stackalloc FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnNiagaraSystemFinished.__FOnNiagaraSystemFinished_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNiagaraSystemFinished.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PSystem = ((PSystem != null) ? PSystem.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AAC0 RID: 43712 RVA: 0x000FBD08 File Offset: 0x000F9F08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400491C RID: 18716
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400491D RID: 18717
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.OnNiagaraSystemFinished__DelegateSignature";

		// Token: 0x0400491E RID: 18718
		private static int RegisterId;

		// Token: 0x02000F60 RID: 3936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnNiagaraSystemFinished_DelegateParams
		{
			// Token: 0x04006336 RID: 25398
			[FieldOffset(0)]
			public IntPtr PSystem;
		}

		// Token: 0x02000F61 RID: 3937
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006337 RID: 25399
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
