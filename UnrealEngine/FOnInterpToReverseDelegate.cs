using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F12 RID: 3858
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInterpToReverseDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0A4 RID: 53412 RVA: 0x00130D62 File Offset: 0x0012EF62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInterpToReverseDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x00130D6E File Offset: 0x0012EF6E
		private static IntPtr StaticFunctionPtr()
		{
			if (UInterpToMovementComponent.__OnInterpToReverseDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UInterpToMovementComponent.__OnInterpToReverseDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature");
			}
			return UInterpToMovementComponent.__OnInterpToReverseDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x00130D91 File Offset: 0x0012EF91
		public FOnInterpToReverseDelegate()
		{
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x00130D99 File Offset: 0x0012EF99
		[NullableContext(2)]
		public FOnInterpToReverseDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x00130DA3 File Offset: 0x0012EFA3
		public FOnInterpToReverseDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x00130DAE File Offset: 0x0012EFAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FHitResult, float>) ?? ((Action<FHitResult, float>)Delegate.CreateDelegate(typeof(Action<FHitResult, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x00130DE0 File Offset: 0x0012EFE0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FHitResult, float> Callback)
		{
			if (FOnInterpToReverseDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInterpToReverseDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInterpToReverseDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInterpToReverseDelegate.OnScriptCallback));
				}
				FOnInterpToReverseDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInterpToReverseDelegate.RegisterId);
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x00130E1A File Offset: 0x0012F01A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FHitResult, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x00130E24 File Offset: 0x0012F024
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FHitResult ImpactResult, float Time)
		{
			FOnInterpToReverseDelegate.__FOnInterpToReverseDelegate_DelegateParams* ptr = stackalloc FOnInterpToReverseDelegate.__FOnInterpToReverseDelegate_DelegateParams[(UIntPtr)167] + 15L / (long)sizeof(FOnInterpToReverseDelegate.__FOnInterpToReverseDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInterpToReverseDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (ImpactResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->ImpactResult, ImpactResult.NativePtr, 1, false);
			}
			ptr->Time = Time;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0AD RID: 53421 RVA: 0x00130E88 File Offset: 0x0012F088
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
			FHitResult arg = new FHitResult(&((FOnInterpToReverseDelegate.__FOnInterpToReverseDelegate_DelegateParams*)__Parameters)->ImpactResult, true, true);
			action(arg, ((FOnInterpToReverseDelegate.__FOnInterpToReverseDelegate_DelegateParams*)__Parameters)->Time);
		}

		// Token: 0x0400704A RID: 28746
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpToMovementComponent:OnInterpToReverseDelegate__DelegateSignature";

		// Token: 0x0400704B RID: 28747
		private static int RegisterId;

		// Token: 0x02002D73 RID: 11635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __FOnInterpToReverseDelegate_DelegateParams
		{
			// Token: 0x04016790 RID: 92048
			[FieldOffset(0)]
			public byte ImpactResult;

			// Token: 0x04016791 RID: 92049
			[FieldOffset(148)]
			public float Time;
		}

		// Token: 0x02002D74 RID: 11636
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016792 RID: 92050
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
