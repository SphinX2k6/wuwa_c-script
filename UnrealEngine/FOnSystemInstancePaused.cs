using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AC RID: 1964
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSystemInstancePaused : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AAC1 RID: 43713 RVA: 0x000FBD59 File Offset: 0x000F9F59
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemInstancePaused.StaticFunctionPtr();
		}

		// Token: 0x0600AAC2 RID: 43714 RVA: 0x000FBD65 File Offset: 0x000F9F65
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemInstancePaused._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemInstancePaused._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Niagara.OnSystemInstancePaused__DelegateSignature");
			}
			return FOnSystemInstancePaused._FunctionPtr;
		}

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x000FBD88 File Offset: 0x000F9F88
		public FOnSystemInstancePaused()
		{
		}

		// Token: 0x0600AAC4 RID: 43716 RVA: 0x000FBD90 File Offset: 0x000F9F90
		[NullableContext(2)]
		public FOnSystemInstancePaused(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AAC5 RID: 43717 RVA: 0x000FBD9A File Offset: 0x000F9F9A
		public FOnSystemInstancePaused(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AAC6 RID: 43718 RVA: 0x000FBDA5 File Offset: 0x000F9FA5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UNiagaraComponent, bool>) ?? ((Action<UNiagaraComponent, bool>)Delegate.CreateDelegate(typeof(Action<UNiagaraComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x000FBDD7 File Offset: 0x000F9FD7
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

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x000FBE11 File Offset: 0x000FA011
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UNiagaraComponent, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x000FBE1C File Offset: 0x000FA01C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UNiagaraComponent PSystem, bool IsPaused)
		{
			FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams* ptr = stackalloc FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSystemInstancePaused.__FOnSystemInstancePaused_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemInstancePaused.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PSystem = ((PSystem != null) ? PSystem.NativePtr : IntPtr.Zero);
			ptr->IsPaused = IsPaused;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x000FBE70 File Offset: 0x000FA070
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400491F RID: 18719
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004920 RID: 18720
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.OnSystemInstancePaused__DelegateSignature";

		// Token: 0x04004921 RID: 18721
		private static int RegisterId;

		// Token: 0x02000F62 RID: 3938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnSystemInstancePaused_DelegateParams
		{
			// Token: 0x04006338 RID: 25400
			[FieldOffset(0)]
			public IntPtr PSystem;

			// Token: 0x04006339 RID: 25401
			[FieldOffset(8)]
			public bool IsPaused;
		}

		// Token: 0x02000F63 RID: 3939
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400633A RID: 25402
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
