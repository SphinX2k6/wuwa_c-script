using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F14 RID: 3860
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInterpToWaitBeginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0B8 RID: 53432 RVA: 0x00131062 File Offset: 0x0012F262
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInterpToWaitBeginDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x0013106E File Offset: 0x0012F26E
		private static IntPtr StaticFunctionPtr()
		{
			if (UInterpToMovementComponent.__OnInterpToWaitBeginDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInterpToMovementComponent.__OnInterpToWaitBeginDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature");
			}
			return UInterpToMovementComponent.__OnInterpToWaitBeginDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x00131091 File Offset: 0x0012F291
		public FOnInterpToWaitBeginDelegate()
		{
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x00131099 File Offset: 0x0012F299
		[NullableContext(2)]
		public FOnInterpToWaitBeginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x001310A3 File Offset: 0x0012F2A3
		public FOnInterpToWaitBeginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x001310AE File Offset: 0x0012F2AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, float>) ?? ((Action<FHitResult, float>)Delegate.CreateDelegate(typeof(Action<FHitResult, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x001310E0 File Offset: 0x0012F2E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, float> Callback)
		{
			if (FOnInterpToWaitBeginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInterpToWaitBeginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInterpToWaitBeginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInterpToWaitBeginDelegate.OnScriptCallback));
				}
				FOnInterpToWaitBeginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInterpToWaitBeginDelegate.RegisterId);
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x0013111A File Offset: 0x0012F31A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x00131124 File Offset: 0x0012F324
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, float Time)
		{
			FOnInterpToWaitBeginDelegate.__FOnInterpToWaitBeginDelegate_DelegateParams* ptr = stackalloc FOnInterpToWaitBeginDelegate.__FOnInterpToWaitBeginDelegate_DelegateParams[(UIntPtr)167] + 15L / (long)sizeof(FOnInterpToWaitBeginDelegate.__FOnInterpToWaitBeginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInterpToWaitBeginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->Time = Time;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x00131188 File Offset: 0x0012F388
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
			FHitResult arg = new FHitResult(&((FOnInterpToWaitBeginDelegate.__FOnInterpToWaitBeginDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnInterpToWaitBeginDelegate.__FOnInterpToWaitBeginDelegate_DelegateParams*)__Parameters)->Time);
		}

		// Token: 0x0400704E RID: 28750
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpToMovementComponent:OnInterpToWaitBeginDelegate__DelegateSignature";

		// Token: 0x0400704F RID: 28751
		private static int RegisterId;

		// Token: 0x02002D77 RID: 11639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __FOnInterpToWaitBeginDelegate_DelegateParams
		{
			// Token: 0x04016796 RID: 92054
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x04016797 RID: 92055
			[FieldOffset(148)]
			public float Time;
		}

		// Token: 0x02002D78 RID: 11640
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016798 RID: 92056
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
