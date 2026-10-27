using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F11 RID: 3857
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInterpToResetDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D09A RID: 53402 RVA: 0x00130BE0 File Offset: 0x0012EDE0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInterpToResetDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x00130BEC File Offset: 0x0012EDEC
		private static IntPtr StaticFunctionPtr()
		{
			if (UInterpToMovementComponent.__OnInterpToResetDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInterpToMovementComponent.__OnInterpToResetDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature");
			}
			return UInterpToMovementComponent.__OnInterpToResetDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D09C RID: 53404 RVA: 0x00130C0F File Offset: 0x0012EE0F
		public FOnInterpToResetDelegate()
		{
		}

		// Token: 0x0600D09D RID: 53405 RVA: 0x00130C17 File Offset: 0x0012EE17
		[NullableContext(2)]
		public FOnInterpToResetDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D09E RID: 53406 RVA: 0x00130C21 File Offset: 0x0012EE21
		public FOnInterpToResetDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x00130C2C File Offset: 0x0012EE2C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, float>) ?? ((Action<FHitResult, float>)Delegate.CreateDelegate(typeof(Action<FHitResult, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0A0 RID: 53408 RVA: 0x00130C5E File Offset: 0x0012EE5E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, float> Callback)
		{
			if (FOnInterpToResetDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInterpToResetDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInterpToResetDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInterpToResetDelegate.OnScriptCallback));
				}
				FOnInterpToResetDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInterpToResetDelegate.RegisterId);
		}

		// Token: 0x0600D0A1 RID: 53409 RVA: 0x00130C98 File Offset: 0x0012EE98
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0A2 RID: 53410 RVA: 0x00130CA4 File Offset: 0x0012EEA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, float Time)
		{
			FOnInterpToResetDelegate.__FOnInterpToResetDelegate_DelegateParams* ptr = stackalloc FOnInterpToResetDelegate.__FOnInterpToResetDelegate_DelegateParams[(UIntPtr)167] + 15L / (long)sizeof(FOnInterpToResetDelegate.__FOnInterpToResetDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInterpToResetDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->Time = Time;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x00130D08 File Offset: 0x0012EF08
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
			FHitResult arg = new FHitResult(&((FOnInterpToResetDelegate.__FOnInterpToResetDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnInterpToResetDelegate.__FOnInterpToResetDelegate_DelegateParams*)__Parameters)->Time);
		}

		// Token: 0x04007048 RID: 28744
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpToMovementComponent:OnInterpToResetDelegate__DelegateSignature";

		// Token: 0x04007049 RID: 28745
		private static int RegisterId;

		// Token: 0x02002D71 RID: 11633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __FOnInterpToResetDelegate_DelegateParams
		{
			// Token: 0x0401678D RID: 92045
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x0401678E RID: 92046
			[FieldOffset(148)]
			public float Time;
		}

		// Token: 0x02002D72 RID: 11634
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401678F RID: 92047
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
