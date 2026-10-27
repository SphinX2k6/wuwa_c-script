using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F15 RID: 3861
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInterpToWaitEndDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0C2 RID: 53442 RVA: 0x001311E2 File Offset: 0x0012F3E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInterpToWaitEndDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x001311EE File Offset: 0x0012F3EE
		private static IntPtr StaticFunctionPtr()
		{
			if (UInterpToMovementComponent.__OnInterpToWaitEndDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInterpToMovementComponent.__OnInterpToWaitEndDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature");
			}
			return UInterpToMovementComponent.__OnInterpToWaitEndDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x00131211 File Offset: 0x0012F411
		public FOnInterpToWaitEndDelegate()
		{
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x00131219 File Offset: 0x0012F419
		[NullableContext(2)]
		public FOnInterpToWaitEndDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0C6 RID: 53446 RVA: 0x00131223 File Offset: 0x0012F423
		public FOnInterpToWaitEndDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x0013122E File Offset: 0x0012F42E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, float>) ?? ((Action<FHitResult, float>)Delegate.CreateDelegate(typeof(Action<FHitResult, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x00131260 File Offset: 0x0012F460
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, float> Callback)
		{
			if (FOnInterpToWaitEndDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInterpToWaitEndDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInterpToWaitEndDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInterpToWaitEndDelegate.OnScriptCallback));
				}
				FOnInterpToWaitEndDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInterpToWaitEndDelegate.RegisterId);
		}

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x0013129A File Offset: 0x0012F49A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x001312A4 File Offset: 0x0012F4A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, float Time)
		{
			FOnInterpToWaitEndDelegate.__FOnInterpToWaitEndDelegate_DelegateParams* ptr = stackalloc FOnInterpToWaitEndDelegate.__FOnInterpToWaitEndDelegate_DelegateParams[(UIntPtr)167] + 15L / (long)sizeof(FOnInterpToWaitEndDelegate.__FOnInterpToWaitEndDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInterpToWaitEndDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->Time = Time;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x00131308 File Offset: 0x0012F508
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
			FHitResult arg = new FHitResult(&((FOnInterpToWaitEndDelegate.__FOnInterpToWaitEndDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnInterpToWaitEndDelegate.__FOnInterpToWaitEndDelegate_DelegateParams*)__Parameters)->Time);
		}

		// Token: 0x04007050 RID: 28752
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpToMovementComponent:OnInterpToWaitEndDelegate__DelegateSignature";

		// Token: 0x04007051 RID: 28753
		private static int RegisterId;

		// Token: 0x02002D79 RID: 11641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __FOnInterpToWaitEndDelegate_DelegateParams
		{
			// Token: 0x04016799 RID: 92057
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x0401679A RID: 92058
			[FieldOffset(148)]
			public float Time;
		}

		// Token: 0x02002D7A RID: 11642
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401679B RID: 92059
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
