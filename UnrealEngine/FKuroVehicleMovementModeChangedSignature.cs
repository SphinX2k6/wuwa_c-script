using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000630 RID: 1584
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroVehicleMovementModeChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008B11 RID: 35601 RVA: 0x000D1251 File Offset: 0x000CF451
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroVehicleMovementModeChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x000D125D File Offset: 0x000CF45D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroVehicleMovementModeChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroVehicleMovementModeChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroVehicle.KuroVehicleMovementModeChangedSignature__DelegateSignature");
			}
			return FKuroVehicleMovementModeChangedSignature._FunctionPtr;
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x000D1280 File Offset: 0x000CF480
		public FKuroVehicleMovementModeChangedSignature()
		{
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x000D1288 File Offset: 0x000CF488
		[NullableContext(2)]
		public FKuroVehicleMovementModeChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x000D1292 File Offset: 0x000CF492
		public FKuroVehicleMovementModeChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x000D129D File Offset: 0x000CF49D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>) ?? ((Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>)Delegate.CreateDelegate(typeof(Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x000D12CF File Offset: 0x000CF4CF
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte> Callback)
		{
			if (FKuroVehicleMovementModeChangedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroVehicleMovementModeChangedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroVehicleMovementModeChangedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroVehicleMovementModeChangedSignature.OnScriptCallback));
				}
				FKuroVehicleMovementModeChangedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroVehicleMovementModeChangedSignature.RegisterId);
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x000D1309 File Offset: 0x000CF509
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x000D1314 File Offset: 0x000CF514
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AKuroBaseVehicle Vehicle, EKuroVehicleMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams* ptr = stackalloc FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroVehicleMovementModeChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Vehicle = ((Vehicle != null) ? Vehicle.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x000D1374 File Offset: 0x000CF574
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte> action = target as Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AKuroBaseVehicle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroBaseVehicle>(((FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams*)__Parameters)->Vehicle);
			action(orCreateUObjectByNativePointer, ((FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams*)__Parameters)->PrevMovementMode, ((FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams*)__Parameters)->PreviousCustomMode);
		}

		// Token: 0x04003C5A RID: 15450
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003C5B RID: 15451
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementModeChangedSignature__DelegateSignature";

		// Token: 0x04003C5C RID: 15452
		private static int RegisterId;

		// Token: 0x02000E52 RID: 3666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FKuroVehicleMovementModeChangedSignature_DelegateParams
		{
			// Token: 0x040061F0 RID: 25072
			[FieldOffset(0)]
			public IntPtr Vehicle;

			// Token: 0x040061F1 RID: 25073
			[FieldOffset(8)]
			public TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode;

			// Token: 0x040061F2 RID: 25074
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x02000E53 RID: 3667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061F3 RID: 25075
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
