using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F25 RID: 3877
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnProjectileBounceDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D153 RID: 53587 RVA: 0x0013254D File Offset: 0x0013074D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProjectileBounceDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D154 RID: 53588 RVA: 0x00132559 File Offset: 0x00130759
		private static IntPtr StaticFunctionPtr()
		{
			if (UProjectileMovementComponent.__OnProjectileBounceDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UProjectileMovementComponent.__OnProjectileBounceDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature");
			}
			return UProjectileMovementComponent.__OnProjectileBounceDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D155 RID: 53589 RVA: 0x0013257C File Offset: 0x0013077C
		public FOnProjectileBounceDelegate()
		{
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x00132584 File Offset: 0x00130784
		[NullableContext(2)]
		public FOnProjectileBounceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x0013258E File Offset: 0x0013078E
		public FOnProjectileBounceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x00132599 File Offset: 0x00130799
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, FVector>) ?? ((Action<FHitResult, FVector>)Delegate.CreateDelegate(typeof(Action<FHitResult, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x001325CB File Offset: 0x001307CB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, FVector> Callback)
		{
			if (FOnProjectileBounceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProjectileBounceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProjectileBounceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProjectileBounceDelegate.OnScriptCallback));
				}
				FOnProjectileBounceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnProjectileBounceDelegate.RegisterId);
		}

		// Token: 0x0600D15A RID: 53594 RVA: 0x00132605 File Offset: 0x00130805
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D15B RID: 53595 RVA: 0x00132610 File Offset: 0x00130810
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, in FVector ImpactVelocity)
		{
			FOnProjectileBounceDelegate.__FOnProjectileBounceDelegate_DelegateParams* ptr = stackalloc FOnProjectileBounceDelegate.__FOnProjectileBounceDelegate_DelegateParams[(UIntPtr)175] + 15L / (long)sizeof(FOnProjectileBounceDelegate.__FOnProjectileBounceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProjectileBounceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->ImpactVelocity = ImpactVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x00132678 File Offset: 0x00130878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FHitResult, FVector> action = target as Action<FHitResult, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FHitResult arg = new FHitResult(&((FOnProjectileBounceDelegate.__FOnProjectileBounceDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnProjectileBounceDelegate.__FOnProjectileBounceDelegate_DelegateParams*)__Parameters)->ImpactVelocity);
		}

		// Token: 0x0400707D RID: 28797
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature";

		// Token: 0x0400707E RID: 28798
		private static int RegisterId;

		// Token: 0x02002D94 RID: 11668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __FOnProjectileBounceDelegate_DelegateParams
		{
			// Token: 0x040167B5 RID: 92085
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x040167B6 RID: 92086
			[FieldOffset(148)]
			public FVector ImpactVelocity;
		}

		// Token: 0x02002D95 RID: 11669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167B7 RID: 92087
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
