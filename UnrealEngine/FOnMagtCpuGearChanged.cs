using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200227D RID: 8829
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMagtCpuGearChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021920 RID: 137504 RVA: 0x0031A952 File Offset: 0x00318B52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMagtCpuGearChanged.StaticFunctionPtr();
		}

		// Token: 0x06021921 RID: 137505 RVA: 0x0031A95E File Offset: 0x00318B5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMagtCpuGearChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnMagtCpuGearChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnMagtCpuGearChanged__DelegateSignature");
			}
			return FOnMagtCpuGearChanged._FunctionPtr;
		}

		// Token: 0x06021922 RID: 137506 RVA: 0x0031A981 File Offset: 0x00318B81
		public FOnMagtCpuGearChanged()
		{
		}

		// Token: 0x06021923 RID: 137507 RVA: 0x0031A989 File Offset: 0x00318B89
		[NullableContext(2)]
		public FOnMagtCpuGearChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021924 RID: 137508 RVA: 0x0031A993 File Offset: 0x00318B93
		public FOnMagtCpuGearChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021925 RID: 137509 RVA: 0x0031A99E File Offset: 0x00318B9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FMagtCpuGearState, FMagtCpuGearState>) ?? ((Action<FMagtCpuGearState, FMagtCpuGearState>)Delegate.CreateDelegate(typeof(Action<FMagtCpuGearState, FMagtCpuGearState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021926 RID: 137510 RVA: 0x0031A9D0 File Offset: 0x00318BD0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FMagtCpuGearState, FMagtCpuGearState> Callback)
		{
			if (FOnMagtCpuGearChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMagtCpuGearChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMagtCpuGearChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMagtCpuGearChanged.OnScriptCallback));
				}
				FOnMagtCpuGearChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMagtCpuGearChanged.RegisterId);
		}

		// Token: 0x06021927 RID: 137511 RVA: 0x0031AA0A File Offset: 0x00318C0A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FMagtCpuGearState, FMagtCpuGearState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021928 RID: 137512 RVA: 0x0031AA14 File Offset: 0x00318C14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FMagtCpuGearState CurrentState, in FMagtCpuGearState PreviousState)
		{
			FOnMagtCpuGearChanged.__FOnMagtCpuGearChanged_DelegateParams* ptr = stackalloc FOnMagtCpuGearChanged.__FOnMagtCpuGearChanged_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnMagtCpuGearChanged.__FOnMagtCpuGearChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMagtCpuGearChanged.StaticFunctionPtr(), (void*)ptr, 1);
			if (CurrentState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtCpuGearState.StaticStruct(), &ptr->CurrentState, CurrentState.NativePtr, 1, false);
			}
			if (PreviousState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtCpuGearState.StaticStruct(), &ptr->PreviousState, PreviousState.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021929 RID: 137513 RVA: 0x0031AA94 File Offset: 0x00318C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FMagtCpuGearState, FMagtCpuGearState> action = target as Action<FMagtCpuGearState, FMagtCpuGearState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FMagtCpuGearState arg = new FMagtCpuGearState(&((FOnMagtCpuGearChanged.__FOnMagtCpuGearChanged_DelegateParams*)__Parameters)->CurrentState, true, true);
			FMagtCpuGearState arg2 = new FMagtCpuGearState(&((FOnMagtCpuGearChanged.__FOnMagtCpuGearChanged_DelegateParams*)__Parameters)->PreviousState, true, true);
			action(arg, arg2);
		}

		// Token: 0x04011EDE RID: 73438
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EDF RID: 73439
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnMagtCpuGearChanged__DelegateSignature";

		// Token: 0x04011EE0 RID: 73440
		private static int RegisterId;

		// Token: 0x02003604 RID: 13828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnMagtCpuGearChanged_DelegateParams
		{
			// Token: 0x0401768C RID: 95884
			[FieldOffset(0)]
			public byte CurrentState;

			// Token: 0x0401768D RID: 95885
			[FieldOffset(12)]
			public byte PreviousState;
		}

		// Token: 0x02003605 RID: 13829
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401768E RID: 95886
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
