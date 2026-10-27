using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F29 RID: 7977
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroVehicleMovementModeChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E53A RID: 124218 RVA: 0x002D0E0D File Offset: 0x002CF00D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroVehicleMovementModeChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x0601E53B RID: 124219 RVA: 0x002D0E19 File Offset: 0x002CF019
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroVehicleMovementModeChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroVehicleMovementModeChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroVehicle.KuroVehicleMovementModeChangedSignature__DelegateSignature");
			}
			return FKuroVehicleMovementModeChangedSignature._FunctionPtr;
		}

		// Token: 0x0601E53C RID: 124220 RVA: 0x002D0E3C File Offset: 0x002CF03C
		public FKuroVehicleMovementModeChangedSignature()
		{
		}

		// Token: 0x0601E53D RID: 124221 RVA: 0x002D0E44 File Offset: 0x002CF044
		[NullableContext(2)]
		public FKuroVehicleMovementModeChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E53E RID: 124222 RVA: 0x002D0E4E File Offset: 0x002CF04E
		public FKuroVehicleMovementModeChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E53F RID: 124223 RVA: 0x002D0E59 File Offset: 0x002CF059
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>) ?? ((Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>)Delegate.CreateDelegate(typeof(Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E540 RID: 124224 RVA: 0x002D0E8B File Offset: 0x002CF08B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E541 RID: 124225 RVA: 0x002D0EC5 File Offset: 0x002CF0C5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AKuroBaseVehicle, TEnumAsByte<EKuroVehicleMovementMode>, byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E542 RID: 124226 RVA: 0x002D0ED0 File Offset: 0x002CF0D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AKuroBaseVehicle Vehicle, EKuroVehicleMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams* ptr = stackalloc FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FKuroVehicleMovementModeChangedSignature.__FKuroVehicleMovementModeChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroVehicleMovementModeChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Vehicle = ((Vehicle != null) ? Vehicle.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E543 RID: 124227 RVA: 0x002D0F30 File Offset: 0x002CF130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040105B6 RID: 66998
		internal static IntPtr _FunctionPtr;

		// Token: 0x040105B7 RID: 66999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.KuroVehicleMovementModeChangedSignature__DelegateSignature";

		// Token: 0x040105B8 RID: 67000
		private static int RegisterId;

		// Token: 0x02003405 RID: 13317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FKuroVehicleMovementModeChangedSignature_DelegateParams
		{
			// Token: 0x040173C3 RID: 95171
			[FieldOffset(0)]
			public IntPtr Vehicle;

			// Token: 0x040173C4 RID: 95172
			[FieldOffset(8)]
			public TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode;

			// Token: 0x040173C5 RID: 95173
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x02003406 RID: 13318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173C6 RID: 95174
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
