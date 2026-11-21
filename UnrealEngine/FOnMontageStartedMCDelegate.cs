using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000258 RID: 600
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageStartedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003327 RID: 13095 RVA: 0x000494F3 File Offset: 0x000476F3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageStartedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x000494FF File Offset: 0x000476FF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageStartedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageStartedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature");
			}
			return FOnMontageStartedMCDelegate._FunctionPtr;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00049522 File Offset: 0x00047722
		public FOnMontageStartedMCDelegate()
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x0004952A File Offset: 0x0004772A
		[NullableContext(2)]
		public FOnMontageStartedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00049534 File Offset: 0x00047734
		public FOnMontageStartedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0004953F File Offset: 0x0004773F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage>) ?? ((Action<UAnimMontage>)Delegate.CreateDelegate(typeof(Action<UAnimMontage>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00049571 File Offset: 0x00047771
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

		// Token: 0x0600332E RID: 13102 RVA: 0x000495AB File Offset: 0x000477AB
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000495B4 File Offset: 0x000477B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UAnimMontage Montage)
		{
			FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnMontageStartedMCDelegate.__FOnMontageStartedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageStartedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00049600 File Offset: 0x00047800
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040011D4 RID: 4564
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011D5 RID: 4565
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature";

		// Token: 0x040011D6 RID: 4566
		private static int RegisterId;

		// Token: 0x020009DB RID: 2523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnMontageStartedMCDelegate_DelegateParams
		{
			// Token: 0x0400596C RID: 22892
			[FieldOffset(0)]
			public IntPtr Montage;
		}

		// Token: 0x020009DC RID: 2524
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400596D RID: 22893
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
