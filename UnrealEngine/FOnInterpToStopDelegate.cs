using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F13 RID: 3859
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInterpToStopDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0AE RID: 53422 RVA: 0x00130EE2 File Offset: 0x0012F0E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInterpToStopDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x00130EEE File Offset: 0x0012F0EE
		private static IntPtr StaticFunctionPtr()
		{
			if (UInterpToMovementComponent.__OnInterpToStopDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInterpToMovementComponent.__OnInterpToStopDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature");
			}
			return UInterpToMovementComponent.__OnInterpToStopDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x00130F11 File Offset: 0x0012F111
		public FOnInterpToStopDelegate()
		{
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x00130F19 File Offset: 0x0012F119
		[NullableContext(2)]
		public FOnInterpToStopDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x00130F23 File Offset: 0x0012F123
		public FOnInterpToStopDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x00130F2E File Offset: 0x0012F12E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, float>) ?? ((Action<FHitResult, float>)Delegate.CreateDelegate(typeof(Action<FHitResult, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x00130F60 File Offset: 0x0012F160
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, float> Callback)
		{
			if (FOnInterpToStopDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInterpToStopDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInterpToStopDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInterpToStopDelegate.OnScriptCallback));
				}
				FOnInterpToStopDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInterpToStopDelegate.RegisterId);
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x00130F9A File Offset: 0x0012F19A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x00130FA4 File Offset: 0x0012F1A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, float Time)
		{
			FOnInterpToStopDelegate.__FOnInterpToStopDelegate_DelegateParams* ptr = stackalloc FOnInterpToStopDelegate.__FOnInterpToStopDelegate_DelegateParams[(UIntPtr)167] + 15L / (long)sizeof(FOnInterpToStopDelegate.__FOnInterpToStopDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInterpToStopDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->Time = Time;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x00131008 File Offset: 0x0012F208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FHitResult, float> action = target as Action<FHitResult, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FHitResult arg = new FHitResult(&((FOnInterpToStopDelegate.__FOnInterpToStopDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnInterpToStopDelegate.__FOnInterpToStopDelegate_DelegateParams*)__Parameters)->Time);
		}

		// Token: 0x0400704C RID: 28748
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpToMovementComponent:OnInterpToStopDelegate__DelegateSignature";

		// Token: 0x0400704D RID: 28749
		private static int RegisterId;

		// Token: 0x02002D75 RID: 11637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __FOnInterpToStopDelegate_DelegateParams
		{
			// Token: 0x04016793 RID: 92051
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x04016794 RID: 92052
			[FieldOffset(148)]
			public float Time;
		}

		// Token: 0x02002D76 RID: 11638
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016795 RID: 92053
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
