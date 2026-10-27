using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F2A RID: 7978
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroVehicleMovementUpdatedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E544 RID: 124228 RVA: 0x002D0F8D File Offset: 0x002CF18D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroVehicleMovementUpdatedSignature.StaticFunctionPtr();
		}

		// Token: 0x0601E545 RID: 124229 RVA: 0x002D0F99 File Offset: 0x002CF199
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroVehicleMovementUpdatedSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroVehicleMovementUpdatedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroVehicle.KuroVehicleMovementUpdatedSignature__DelegateSignature");
			}
			return FKuroVehicleMovementUpdatedSignature._FunctionPtr;
		}

		// Token: 0x0601E546 RID: 124230 RVA: 0x002D0FBC File Offset: 0x002CF1BC
		public FKuroVehicleMovementUpdatedSignature()
		{
		}

		// Token: 0x0601E547 RID: 124231 RVA: 0x002D0FC4 File Offset: 0x002CF1C4
		[NullableContext(2)]
		public FKuroVehicleMovementUpdatedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E548 RID: 124232 RVA: 0x002D0FCE File Offset: 0x002CF1CE
		public FKuroVehicleMovementUpdatedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E549 RID: 124233 RVA: 0x002D0FD9 File Offset: 0x002CF1D9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, FVector, FVector>) ?? ((Action<float, FVector, FVector>)Delegate.CreateDelegate(typeof(Action<float, FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E54A RID: 124234 RVA: 0x002D100B File Offset: 0x002CF20B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float, FVector, FVector> Callback)
		{
			if (FKuroVehicleMovementUpdatedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroVehicleMovementUpdatedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroVehicleMovementUpdatedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroVehicleMovementUpdatedSignature.OnScriptCallback));
				}
				FKuroVehicleMovementUpdatedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroVehicleMovementUpdatedSignature.RegisterId);
		}

		// Token: 0x0601E54B RID: 124235 RVA: 0x002D1045 File Offset: 0x002CF245
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E54C RID: 124236 RVA: 0x002D1050 File Offset: 0x002CF250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams* ptr = stackalloc FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams[(UIntPtr)43] + 15L / (long)sizeof(FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroVehicleMovementUpdatedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->OldLocation = OldLocation;
			ptr->OldVelocity = OldVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E54D RID: 124237 RVA: 0x002D109C File Offset: 0x002CF29C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FVector, FVector> action = target as Action<float, FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->DeltaSeconds, ((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->OldLocation, ((FKuroVehicleMovementUpdatedSignature.__FKuroVehicleMovementUpdatedSignature_DelegateParams*)__Parameters)->OldVelocity);
		}

		// Token: 0x040105B9 RID: 67001
		internal static IntPtr _FunctionPtr;

		// Token: 0x040105BA RID: 67002
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementUpdatedSignature__DelegateSignature";

		// Token: 0x040105BB RID: 67003
		private static int RegisterId;

		// Token: 0x02003407 RID: 13319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __FKuroVehicleMovementUpdatedSignature_DelegateParams
		{
			// Token: 0x040173C7 RID: 95175
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040173C8 RID: 95176
			[FieldOffset(4)]
			public FVector OldLocation;

			// Token: 0x040173C9 RID: 95177
			[FieldOffset(16)]
			public FVector OldVelocity;
		}

		// Token: 0x02003408 RID: 13320
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173CA RID: 95178
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
