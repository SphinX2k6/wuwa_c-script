using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F26 RID: 3878
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnProjectileStopDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D15D RID: 53597 RVA: 0x001326D2 File Offset: 0x001308D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProjectileStopDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D15E RID: 53598 RVA: 0x001326DE File Offset: 0x001308DE
		private static IntPtr StaticFunctionPtr()
		{
			if (UProjectileMovementComponent.__OnProjectileStopDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UProjectileMovementComponent.__OnProjectileStopDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature");
			}
			return UProjectileMovementComponent.__OnProjectileStopDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x00132701 File Offset: 0x00130901
		public FOnProjectileStopDelegate()
		{
		}

		// Token: 0x0600D160 RID: 53600 RVA: 0x00132709 File Offset: 0x00130909
		[NullableContext(2)]
		public FOnProjectileStopDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D161 RID: 53601 RVA: 0x00132713 File Offset: 0x00130913
		public FOnProjectileStopDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x0013271E File Offset: 0x0013091E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult>) ?? ((Action<FHitResult>)Delegate.CreateDelegate(typeof(Action<FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D163 RID: 53603 RVA: 0x00132750 File Offset: 0x00130950
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult> Callback)
		{
			if (FOnProjectileStopDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProjectileStopDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProjectileStopDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProjectileStopDelegate.OnScriptCallback));
				}
				FOnProjectileStopDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnProjectileStopDelegate.RegisterId);
		}

		// Token: 0x0600D164 RID: 53604 RVA: 0x0013278A File Offset: 0x0013098A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x00132794 File Offset: 0x00130994
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult)
		{
			FOnProjectileStopDelegate.__FOnProjectileStopDelegate_DelegateParams* ptr = stackalloc FOnProjectileStopDelegate.__FOnProjectileStopDelegate_DelegateParams[(UIntPtr)163] + 15L / (long)sizeof(FOnProjectileStopDelegate.__FOnProjectileStopDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProjectileStopDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D166 RID: 53606 RVA: 0x001327F0 File Offset: 0x001309F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FHitResult> action = target as Action<FHitResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FHitResult obj = new FHitResult(&((FOnProjectileStopDelegate.__FOnProjectileStopDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(obj);
		}

		// Token: 0x0400707F RID: 28799
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature";

		// Token: 0x04007080 RID: 28800
		private static int RegisterId;

		// Token: 0x02002D96 RID: 11670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 148)]
		protected ref struct __FOnProjectileStopDelegate_DelegateParams
		{
			// Token: 0x040167B8 RID: 92088
			[FieldOffset(0)]
			public byte ImpactResult;
		}

		// Token: 0x02002D97 RID: 11671
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167B9 RID: 92089
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
