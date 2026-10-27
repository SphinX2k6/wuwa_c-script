using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002281 RID: 8833
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMagtThrottleStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021948 RID: 137544 RVA: 0x0031AE6E File Offset: 0x0031906E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMagtThrottleStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06021949 RID: 137545 RVA: 0x0031AE7A File Offset: 0x0031907A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMagtThrottleStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnMagtThrottleStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnMagtThrottleStateChanged__DelegateSignature");
			}
			return FOnMagtThrottleStateChanged._FunctionPtr;
		}

		// Token: 0x0602194A RID: 137546 RVA: 0x0031AE9D File Offset: 0x0031909D
		public FOnMagtThrottleStateChanged()
		{
		}

		// Token: 0x0602194B RID: 137547 RVA: 0x0031AEA5 File Offset: 0x003190A5
		[NullableContext(2)]
		public FOnMagtThrottleStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602194C RID: 137548 RVA: 0x0031AEAF File Offset: 0x003190AF
		public FOnMagtThrottleStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602194D RID: 137549 RVA: 0x0031AEBA File Offset: 0x003190BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, FMagtPerfReport>) ?? ((Action<int, int, FMagtPerfReport>)Delegate.CreateDelegate(typeof(Action<int, int, FMagtPerfReport>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602194E RID: 137550 RVA: 0x0031AEEC File Offset: 0x003190EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int, FMagtPerfReport> Callback)
		{
			if (FOnMagtThrottleStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMagtThrottleStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMagtThrottleStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMagtThrottleStateChanged.OnScriptCallback));
				}
				FOnMagtThrottleStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMagtThrottleStateChanged.RegisterId);
		}

		// Token: 0x0602194F RID: 137551 RVA: 0x0031AF26 File Offset: 0x00319126
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int, FMagtPerfReport> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021950 RID: 137552 RVA: 0x0031AF30 File Offset: 0x00319130
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int CurrentStatus, int PreviousStatus, in FMagtPerfReport PerfReport)
		{
			FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams* ptr = stackalloc FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMagtThrottleStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentStatus = CurrentStatus;
			ptr->PreviousStatus = PreviousStatus;
			if (PerfReport != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtPerfReport.StaticStruct(), &ptr->PerfReport, PerfReport.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021951 RID: 137553 RVA: 0x0031AF98 File Offset: 0x00319198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, FMagtPerfReport> action = target as Action<int, int, FMagtPerfReport>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FMagtPerfReport arg = new FMagtPerfReport(&((FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams*)__Parameters)->PerfReport, true, true);
			action(((FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams*)__Parameters)->CurrentStatus, ((FOnMagtThrottleStateChanged.__FOnMagtThrottleStateChanged_DelegateParams*)__Parameters)->PreviousStatus, arg);
		}

		// Token: 0x04011EEA RID: 73450
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EEB RID: 73451
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnMagtThrottleStateChanged__DelegateSignature";

		// Token: 0x04011EEC RID: 73452
		private static int RegisterId;

		// Token: 0x0200360A RID: 13834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FOnMagtThrottleStateChanged_DelegateParams
		{
			// Token: 0x04017694 RID: 95892
			[FieldOffset(0)]
			public int CurrentStatus;

			// Token: 0x04017695 RID: 95893
			[FieldOffset(4)]
			public int PreviousStatus;

			// Token: 0x04017696 RID: 95894
			[FieldOffset(8)]
			public byte PerfReport;
		}

		// Token: 0x0200360B RID: 13835
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017697 RID: 95895
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
