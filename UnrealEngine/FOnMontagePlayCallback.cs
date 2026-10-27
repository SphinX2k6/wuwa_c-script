using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001971 RID: 6513
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontagePlayCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018340 RID: 99136 RVA: 0x0023AF2A File Offset: 0x0023912A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontagePlayCallback.StaticFunctionPtr();
		}

		// Token: 0x06018341 RID: 99137 RVA: 0x0023AF36 File Offset: 0x00239136
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontagePlayCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnMontagePlayCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnMontagePlayCallback__DelegateSignature");
			}
			return FOnMontagePlayCallback._FunctionPtr;
		}

		// Token: 0x06018342 RID: 99138 RVA: 0x0023AF59 File Offset: 0x00239159
		public FOnMontagePlayCallback()
		{
		}

		// Token: 0x06018343 RID: 99139 RVA: 0x0023AF61 File Offset: 0x00239161
		[NullableContext(2)]
		public FOnMontagePlayCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018344 RID: 99140 RVA: 0x0023AF6B File Offset: 0x0023916B
		public FOnMontagePlayCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018345 RID: 99141 RVA: 0x0023AF76 File Offset: 0x00239176
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018346 RID: 99142 RVA: 0x0023AFA8 File Offset: 0x002391A8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnMontagePlayCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontagePlayCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontagePlayCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontagePlayCallback.OnScriptCallback));
				}
				FOnMontagePlayCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontagePlayCallback.RegisterId);
		}

		// Token: 0x06018347 RID: 99143 RVA: 0x0023AFE2 File Offset: 0x002391E2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018348 RID: 99144 RVA: 0x0023AFEC File Offset: 0x002391EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bInterrupted)
		{
			FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams* ptr = stackalloc FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontagePlayCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018349 RID: 99145 RVA: 0x0023B028 File Offset: 0x00239228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams*)__Parameters)->bInterrupted);
		}

		// Token: 0x0400D1C9 RID: 53705
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1CA RID: 53706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnMontagePlayCallback__DelegateSignature";

		// Token: 0x0400D1CB RID: 53707
		private static int RegisterId;

		// Token: 0x02003064 RID: 12388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnMontagePlayCallback_DelegateParams
		{
			// Token: 0x04016D32 RID: 93490
			[FieldOffset(0)]
			public bool bInterrupted;
		}

		// Token: 0x02003065 RID: 12389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D33 RID: 93491
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
