using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200227C RID: 8828
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBoostStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021916 RID: 137494 RVA: 0x0031A7D5 File Offset: 0x003189D5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBoostStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06021917 RID: 137495 RVA: 0x0031A7E1 File Offset: 0x003189E1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBoostStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnBoostStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnBoostStateChanged__DelegateSignature");
			}
			return FOnBoostStateChanged._FunctionPtr;
		}

		// Token: 0x06021918 RID: 137496 RVA: 0x0031A804 File Offset: 0x00318A04
		public FOnBoostStateChanged()
		{
		}

		// Token: 0x06021919 RID: 137497 RVA: 0x0031A80C File Offset: 0x00318A0C
		[NullableContext(2)]
		public FOnBoostStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602191A RID: 137498 RVA: 0x0031A816 File Offset: 0x00318A16
		public FOnBoostStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602191B RID: 137499 RVA: 0x0031A821 File Offset: 0x00318A21
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FMagtBoostState>) ?? ((Action<bool, FMagtBoostState>)Delegate.CreateDelegate(typeof(Action<bool, FMagtBoostState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602191C RID: 137500 RVA: 0x0031A853 File Offset: 0x00318A53
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, FMagtBoostState> Callback)
		{
			if (FOnBoostStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBoostStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBoostStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBoostStateChanged.OnScriptCallback));
				}
				FOnBoostStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBoostStateChanged.RegisterId);
		}

		// Token: 0x0602191D RID: 137501 RVA: 0x0031A88D File Offset: 0x00318A8D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, FMagtBoostState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602191E RID: 137502 RVA: 0x0031A898 File Offset: 0x00318A98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsCPU, in FMagtBoostState NewState)
		{
			FOnBoostStateChanged.__FOnBoostStateChanged_DelegateParams* ptr = stackalloc FOnBoostStateChanged.__FOnBoostStateChanged_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FOnBoostStateChanged.__FOnBoostStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBoostStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsCPU = bIsCPU;
			if (NewState != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtBoostState.StaticStruct(), &ptr->NewState, NewState.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602191F RID: 137503 RVA: 0x0031A8F8 File Offset: 0x00318AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, FMagtBoostState> action = target as Action<bool, FMagtBoostState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FMagtBoostState arg = new FMagtBoostState(&((FOnBoostStateChanged.__FOnBoostStateChanged_DelegateParams*)__Parameters)->NewState, true, true);
			action(((FOnBoostStateChanged.__FOnBoostStateChanged_DelegateParams*)__Parameters)->bIsCPU, arg);
		}

		// Token: 0x04011EDB RID: 73435
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EDC RID: 73436
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnBoostStateChanged__DelegateSignature";

		// Token: 0x04011EDD RID: 73437
		private static int RegisterId;

		// Token: 0x02003602 RID: 13826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FOnBoostStateChanged_DelegateParams
		{
			// Token: 0x04017689 RID: 95881
			[FieldOffset(0)]
			public bool bIsCPU;

			// Token: 0x0401768A RID: 95882
			[FieldOffset(4)]
			public byte NewState;
		}

		// Token: 0x02003603 RID: 13827
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401768B RID: 95883
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
