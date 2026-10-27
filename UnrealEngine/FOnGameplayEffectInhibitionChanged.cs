using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196D RID: 6509
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayEffectInhibitionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018318 RID: 99096 RVA: 0x0023A8E2 File Offset: 0x00238AE2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayEffectInhibitionChanged.StaticFunctionPtr();
		}

		// Token: 0x06018319 RID: 99097 RVA: 0x0023A8EE File Offset: 0x00238AEE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayEffectInhibitionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayEffectInhibitionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayEffectInhibitionChanged__DelegateSignature");
			}
			return FOnGameplayEffectInhibitionChanged._FunctionPtr;
		}

		// Token: 0x0601831A RID: 99098 RVA: 0x0023A911 File Offset: 0x00238B11
		public FOnGameplayEffectInhibitionChanged()
		{
		}

		// Token: 0x0601831B RID: 99099 RVA: 0x0023A919 File Offset: 0x00238B19
		[NullableContext(2)]
		public FOnGameplayEffectInhibitionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601831C RID: 99100 RVA: 0x0023A923 File Offset: 0x00238B23
		public FOnGameplayEffectInhibitionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601831D RID: 99101 RVA: 0x0023A92E File Offset: 0x00238B2E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle, bool>) ?? ((Action<FActiveGameplayEffectHandle, bool>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601831E RID: 99102 RVA: 0x0023A960 File Offset: 0x00238B60
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle, bool> Callback)
		{
			if (FOnGameplayEffectInhibitionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameplayEffectInhibitionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameplayEffectInhibitionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameplayEffectInhibitionChanged.OnScriptCallback));
				}
				FOnGameplayEffectInhibitionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameplayEffectInhibitionChanged.RegisterId);
		}

		// Token: 0x0601831F RID: 99103 RVA: 0x0023A99A File Offset: 0x00238B9A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018320 RID: 99104 RVA: 0x0023A9A4 File Offset: 0x00238BA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle Handle, bool bInhibited)
		{
			FOnGameplayEffectInhibitionChanged.__FOnGameplayEffectInhibitionChanged_DelegateParams* ptr = stackalloc FOnGameplayEffectInhibitionChanged.__FOnGameplayEffectInhibitionChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnGameplayEffectInhibitionChanged.__FOnGameplayEffectInhibitionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayEffectInhibitionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->bInhibited = bInhibited;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018321 RID: 99105 RVA: 0x0023AA04 File Offset: 0x00238C04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle, bool> action = target as Action<FActiveGameplayEffectHandle, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle arg = new FActiveGameplayEffectHandle(&((FOnGameplayEffectInhibitionChanged.__FOnGameplayEffectInhibitionChanged_DelegateParams*)__Parameters)->Handle, true, true);
			action(arg, ((FOnGameplayEffectInhibitionChanged.__FOnGameplayEffectInhibitionChanged_DelegateParams*)__Parameters)->bInhibited);
		}

		// Token: 0x0400D1BD RID: 53693
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1BE RID: 53694
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayEffectInhibitionChanged__DelegateSignature";

		// Token: 0x0400D1BF RID: 53695
		private static int RegisterId;

		// Token: 0x0200305C RID: 12380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnGameplayEffectInhibitionChanged_DelegateParams
		{
			// Token: 0x04016D24 RID: 93476
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016D25 RID: 93477
			[FieldOffset(8)]
			public bool bInhibited;
		}

		// Token: 0x0200305D RID: 12381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D26 RID: 93478
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
